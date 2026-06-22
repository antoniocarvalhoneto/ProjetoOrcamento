using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoOrcamento.Repositories
{
    internal sealed class SqliteOrcamentoRepository : IOrcamentoRepository
    {
        public IReadOnlyList<Orcamento> ObterTodos()
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT Id, ClienteId, ClienteNome, ClienteContato, ClienteCpf, ClienteCep, ClienteEndereco,
                       ClienteObservacoes, Status, NumeroPedido, MotivoRejeicao, DataCriacao
                FROM Orcamentos
                ORDER BY DataCriacao DESC;
                """;

            using var reader = command.ExecuteReader();
            var orcamentos = new List<Orcamento>();

            while (reader.Read())
                orcamentos.Add(MapearOrcamento(reader));

            foreach (var orcamento in orcamentos)
                CarregarItens(orcamento);

            return orcamentos;
        }

        public Orcamento? ObterPorId(Guid id)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT Id, ClienteId, ClienteNome, ClienteContato, ClienteCpf, ClienteCep, ClienteEndereco,
                       ClienteObservacoes, Status, NumeroPedido, MotivoRejeicao, DataCriacao
                FROM Orcamentos
                WHERE Id = $id;
                """;
            SqliteDatabase.AddParameter(command, "$id", id.ToString());

            using var reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            var orcamento = MapearOrcamento(reader);
            CarregarItens(orcamento);
            return orcamento;
        }

        public void Adicionar(Orcamento orcamento)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var transaction = connection.BeginTransaction();

            InserirOrcamento(connection, transaction, orcamento);
            transaction.Commit();
        }

        public void Atualizar(Orcamento orcamento)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var transaction = connection.BeginTransaction();
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                UPDATE Orcamentos
                SET ClienteId = $clienteId,
                    ClienteNome = $clienteNome,
                    ClienteContato = $clienteContato,
                    ClienteCpf = $clienteCpf,
                    ClienteCep = $clienteCep,
                    ClienteEndereco = $clienteEndereco,
                    ClienteObservacoes = $clienteObservacoes,
                    Status = $status,
                    NumeroPedido = $numeroPedido,
                    MotivoRejeicao = $motivoRejeicao,
                    DataCriacao = $dataCriacao
                WHERE Id = $id;
                """;
            SqliteDatabase.PreencherParametrosOrcamento(command, orcamento);
            var affectedRows = command.ExecuteNonQuery();

            if (affectedRows == 0)
            {
                InserirOrcamento(connection, transaction, orcamento);
                transaction.Commit();
                return;
            }

            using var deleteItemsCommand = connection.CreateCommand();
            deleteItemsCommand.Transaction = transaction;
            deleteItemsCommand.CommandText = "DELETE FROM ItensOrcamento WHERE OrcamentoId = $orcamentoId;";
            SqliteDatabase.AddParameter(deleteItemsCommand, "$orcamentoId", orcamento.Id.ToString());
            deleteItemsCommand.ExecuteNonQuery();

            foreach (var item in orcamento.Itens)
                SqliteDatabase.InserirItemOrcamento(connection, transaction, orcamento.Id, item);

            transaction.Commit();
        }

        public void Remover(Guid id)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Orcamentos WHERE Id = $id;";
            SqliteDatabase.AddParameter(command, "$id", id.ToString());
            command.ExecuteNonQuery();
        }

        public int ObterProximoNumeroPedido()
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Valor FROM Configuracoes WHERE Chave = 'ProximoNumeroPedido';";
            var valor = command.ExecuteScalar()?.ToString();

            if (int.TryParse(valor, NumberStyles.Integer, CultureInfo.InvariantCulture, out var proximo) && proximo > 0)
                return proximo;

            return 1;
        }

        public void AtualizarProximoNumeroPedido(int proximoNumeroPedido)
        {
            using var connection = SqliteDatabase.CreateConnection();
            SqliteDatabase.AtualizarConfiguracao(
                connection,
                null,
                "ProximoNumeroPedido",
                proximoNumeroPedido.ToString(CultureInfo.InvariantCulture));
        }

        private static void InserirOrcamento(
            Microsoft.Data.Sqlite.SqliteConnection connection,
            Microsoft.Data.Sqlite.SqliteTransaction transaction,
            Orcamento orcamento)
        {
            using var command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = """
                INSERT INTO Orcamentos (
                    Id, ClienteId, ClienteNome, ClienteContato, ClienteCpf, ClienteCep, ClienteEndereco, ClienteObservacoes,
                    Status, NumeroPedido, MotivoRejeicao, DataCriacao)
                VALUES (
                    $id, $clienteId, $clienteNome, $clienteContato, $clienteCpf, $clienteCep, $clienteEndereco, $clienteObservacoes,
                    $status, $numeroPedido, $motivoRejeicao, $dataCriacao);
                """;
            SqliteDatabase.PreencherParametrosOrcamento(command, orcamento);
            command.ExecuteNonQuery();

            foreach (var item in orcamento.Itens)
                SqliteDatabase.InserirItemOrcamento(connection, transaction, orcamento.Id, item);
        }

        private static Orcamento MapearOrcamento(Microsoft.Data.Sqlite.SqliteDataReader reader)
        {
            var dataCriacaoTexto = reader.GetString(11);

            if (!DateTime.TryParse(dataCriacaoTexto, null, DateTimeStyles.RoundtripKind, out var dataCriacao))
                dataCriacao = DateTime.Now;

            return new Orcamento
            {
                Id = Guid.Parse(reader.GetString(0)),
                Cliente = new Cliente
                {
                    Id = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    Nome = reader.GetString(2),
                    Contato = reader.GetString(3),
                    Cpf = reader.GetString(4),
                    Cep = reader.GetString(5),
                    Endereco = reader.GetString(6),
                    Observacoes = reader.GetString(7)
                },
                Status = (StatusOrcamento)reader.GetInt32(8),
                NumeroPedido = reader.GetInt32(9),
                MotivoRejeicao = reader.GetString(10),
                DataCriacao = dataCriacao
            };
        }

        private static void CarregarItens(Orcamento orcamento)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT ServicoId, ServicoNome, PrecoUnitario, Quantidade
                FROM ItensOrcamento
                WHERE OrcamentoId = $orcamentoId
                ORDER BY Id;
                """;
            SqliteDatabase.AddParameter(command, "$orcamentoId", orcamento.Id.ToString());

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                orcamento.Itens.Add(new ItemOrcamento
                {
                    Servico = new Servico
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        PrecoUnitario = reader.GetDecimal(2)
                    },
                    Quantidade = reader.GetInt32(3)
                });
            }
        }
    }
}
