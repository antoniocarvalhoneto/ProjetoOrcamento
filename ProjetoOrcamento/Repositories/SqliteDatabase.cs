using Microsoft.Data.Sqlite;
using ProjetoOrcamento.Deita;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProjetoOrcamento.Repositories
{
    internal static class SqliteDatabase
    {
        private static readonly object SyncRoot = new();
        private static bool _initialized;

        internal static string DatabasePath { get; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ProjetoOrcamento",
            "orcamentos.db");

        internal static SqliteConnection CreateConnection()
        {
            EnsureCreated();

            var connection = new SqliteConnection($"Data Source={DatabasePath}");
            connection.Open();
            return connection;
        }

        private static void EnsureCreated()
        {
            if (_initialized)
                return;

            lock (SyncRoot)
            {
                if (_initialized)
                    return;

                var directory = Path.GetDirectoryName(DatabasePath);

                if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using var connection = new SqliteConnection($"Data Source={DatabasePath}");
                connection.Open();

                CriarTabelas(connection);
                MigrarDadosLegados(connection);

                _initialized = true;
            }
        }

        private static void CriarTabelas(SqliteConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandText = """
                PRAGMA foreign_keys = ON;

                CREATE TABLE IF NOT EXISTS Clientes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Contato TEXT NOT NULL,
                    Cpf TEXT NOT NULL DEFAULT '',
                    Cep TEXT NOT NULL DEFAULT '',
                    Endereco TEXT NOT NULL DEFAULT '',
                    Observacoes TEXT NOT NULL DEFAULT ''
                );

                CREATE TABLE IF NOT EXISTS Servicos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    PrecoUnitario NUMERIC NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Orcamentos (
                    Id TEXT PRIMARY KEY,
                    ClienteId INTEGER NULL,
                    ClienteNome TEXT NOT NULL DEFAULT '',
                    ClienteContato TEXT NOT NULL DEFAULT '',
                    ClienteCpf TEXT NOT NULL DEFAULT '',
                    ClienteCep TEXT NOT NULL DEFAULT '',
                    ClienteEndereco TEXT NOT NULL DEFAULT '',
                    ClienteObservacoes TEXT NOT NULL DEFAULT '',
                    Status INTEGER NOT NULL,
                    NumeroPedido INTEGER NOT NULL DEFAULT 0,
                    MotivoRejeicao TEXT NOT NULL DEFAULT '',
                    DataCriacao TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS ItensOrcamento (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrcamentoId TEXT NOT NULL,
                    ServicoId INTEGER NULL,
                    ServicoNome TEXT NOT NULL,
                    PrecoUnitario NUMERIC NOT NULL,
                    Quantidade INTEGER NOT NULL,
                    FOREIGN KEY (OrcamentoId) REFERENCES Orcamentos(Id) ON DELETE CASCADE
                );

                CREATE TABLE IF NOT EXISTS Configuracoes (
                    Chave TEXT PRIMARY KEY,
                    Valor TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Papeis (
                    Id INTEGER PRIMARY KEY,
                    Nome TEXT NOT NULL UNIQUE
                );

                CREATE TABLE IF NOT EXISTS Usuarios (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Login TEXT NOT NULL UNIQUE,
                    SenhaHash TEXT NOT NULL,
                    PapelId INTEGER NOT NULL,
                    FOREIGN KEY (PapelId) REFERENCES Papeis(Id)
                );

                INSERT OR IGNORE INTO Papeis (Id, Nome) VALUES (1, 'Admin');
                INSERT OR IGNORE INTO Papeis (Id, Nome) VALUES (2, 'Operador');
                INSERT OR IGNORE INTO Papeis (Id, Nome) VALUES (3, 'Visualizador');
                """;
            command.ExecuteNonQuery();
        }

        private static void MigrarDadosLegados(SqliteConnection connection)
        {
            if (!BancoEstaVazio(connection))
                return;

            using var transaction = connection.BeginTransaction();

            foreach (var cliente in Dados.Clientes)
                InserirCliente(connection, transaction, cliente);

            foreach (var servico in Dados.Servicos)
                InserirServico(connection, transaction, servico);

            foreach (var orcamento in Dados.Orcamentos)
                InserirOrcamento(connection, transaction, orcamento);

            var proximoNumeroPedido = Math.Max(
                Dados.ProximoNumeroPedido,
                Dados.Orcamentos.Select(orcamento => orcamento.NumeroPedido).DefaultIfEmpty().Max() + 1);

            AtualizarConfiguracao(connection, transaction, "ProximoNumeroPedido", proximoNumeroPedido.ToString(CultureInfo.InvariantCulture));
            transaction.Commit();
        }

        private static bool BancoEstaVazio(SqliteConnection connection)
        {
            var tabelas = new[] { "Clientes", "Servicos", "Orcamentos" };

            foreach (var tabela in tabelas)
            {
                using var command = connection.CreateCommand();
                command.CommandText = $"SELECT COUNT(1) FROM {tabela};";
                var count = Convert.ToInt32(command.ExecuteScalar(), CultureInfo.InvariantCulture);

                if (count > 0)
                    return false;
            }

            return true;
        }

        private static void InserirCliente(SqliteConnection connection, SqliteTransaction transaction, Cliente cliente)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                INSERT INTO Clientes (Nome, Contato, Cpf, Cep, Endereco, Observacoes)
                VALUES ($nome, $contato, $cpf, $cep, $endereco, $observacoes);
                """;
            AddParameter(command, "$nome", cliente.Nome);
            AddParameter(command, "$contato", cliente.Contato);
            AddParameter(command, "$cpf", cliente.Cpf);
            AddParameter(command, "$cep", cliente.Cep);
            AddParameter(command, "$endereco", cliente.Endereco);
            AddParameter(command, "$observacoes", cliente.Observacoes);
            command.ExecuteNonQuery();
        }

        private static void InserirServico(SqliteConnection connection, SqliteTransaction transaction, Servico servico)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                INSERT INTO Servicos (Nome, PrecoUnitario)
                VALUES ($nome, $precoUnitario);
                """;
            AddParameter(command, "$nome", servico.Nome);
            AddParameter(command, "$precoUnitario", servico.PrecoUnitario);
            command.ExecuteNonQuery();
        }

        private static void InserirOrcamento(SqliteConnection connection, SqliteTransaction transaction, Orcamento orcamento)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                INSERT INTO Orcamentos (
                    Id, ClienteNome, ClienteContato, ClienteCpf, ClienteCep, ClienteEndereco, ClienteObservacoes,
                    Status, NumeroPedido, MotivoRejeicao, DataCriacao)
                VALUES (
                    $id, $clienteNome, $clienteContato, $clienteCpf, $clienteCep, $clienteEndereco, $clienteObservacoes,
                    $status, $numeroPedido, $motivoRejeicao, $dataCriacao);
                """;
            PreencherParametrosOrcamento(command, orcamento);
            command.ExecuteNonQuery();

            foreach (var item in orcamento.Itens)
                InserirItemOrcamento(connection, transaction, orcamento.Id, item);
        }

        internal static void InserirItemOrcamento(
            SqliteConnection connection,
            SqliteTransaction transaction,
            Guid orcamentoId,
            ItemOrcamento item)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                INSERT INTO ItensOrcamento (OrcamentoId, ServicoId, ServicoNome, PrecoUnitario, Quantidade)
                VALUES ($orcamentoId, $servicoId, $servicoNome, $precoUnitario, $quantidade);
                """;
            AddParameter(command, "$orcamentoId", orcamentoId.ToString());
            AddParameter(command, "$servicoId", item.Servico.Id > 0 ? item.Servico.Id : DBNull.Value);
            AddParameter(command, "$servicoNome", item.Servico.Nome);
            AddParameter(command, "$precoUnitario", item.Servico.PrecoUnitario);
            AddParameter(command, "$quantidade", item.Quantidade);
            command.ExecuteNonQuery();
        }

        internal static void PreencherParametrosOrcamento(SqliteCommand command, Orcamento orcamento)
        {
            AddParameter(command, "$id", orcamento.Id.ToString());
            AddParameter(command, "$clienteId", orcamento.Cliente?.Id > 0 ? orcamento.Cliente.Id : DBNull.Value);
            AddParameter(command, "$clienteNome", orcamento.Cliente?.Nome ?? string.Empty);
            AddParameter(command, "$clienteContato", orcamento.Cliente?.Contato ?? string.Empty);
            AddParameter(command, "$clienteCpf", orcamento.Cliente?.Cpf ?? string.Empty);
            AddParameter(command, "$clienteCep", orcamento.Cliente?.Cep ?? string.Empty);
            AddParameter(command, "$clienteEndereco", orcamento.Cliente?.Endereco ?? string.Empty);
            AddParameter(command, "$clienteObservacoes", orcamento.Cliente?.Observacoes ?? string.Empty);
            AddParameter(command, "$status", (int)orcamento.Status);
            AddParameter(command, "$numeroPedido", orcamento.NumeroPedido);
            AddParameter(command, "$motivoRejeicao", orcamento.MotivoRejeicao ?? string.Empty);
            AddParameter(command, "$dataCriacao", orcamento.DataCriacao.ToString("O", CultureInfo.InvariantCulture));
        }

        internal static void AtualizarConfiguracao(
            SqliteConnection connection,
            SqliteTransaction? transaction,
            string chave,
            string valor)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                INSERT INTO Configuracoes (Chave, Valor)
                VALUES ($chave, $valor)
                ON CONFLICT(Chave) DO UPDATE SET Valor = excluded.Valor;
                """;
            AddParameter(command, "$chave", chave);
            AddParameter(command, "$valor", valor);
            command.ExecuteNonQuery();
        }

        internal static void AddParameter(SqliteCommand command, string name, object? value)
        {
            command.Parameters.AddWithValue(name, value ?? DBNull.Value);
        }
    }
}
