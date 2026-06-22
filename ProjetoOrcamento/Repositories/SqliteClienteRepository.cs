using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ProjetoOrcamento.Repositories
{
    internal sealed class SqliteClienteRepository : IClienteRepository
    {
        public IReadOnlyList<Cliente> ObterTodos()
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT Id, Nome, Contato, Cpf, Cep, Endereco, Observacoes
                FROM Clientes
                ORDER BY Nome;
                """;

            using var reader = command.ExecuteReader();
            var clientes = new List<Cliente>();

            while (reader.Read())
            {
                clientes.Add(new Cliente
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Contato = reader.GetString(2),
                    Cpf = reader.GetString(3),
                    Cep = reader.GetString(4),
                    Endereco = reader.GetString(5),
                    Observacoes = reader.GetString(6)
                });
            }

            return clientes;
        }

        public void Adicionar(Cliente cliente)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO Clientes (Nome, Contato, Cpf, Cep, Endereco, Observacoes)
                VALUES ($nome, $contato, $cpf, $cep, $endereco, $observacoes);
                SELECT last_insert_rowid();
                """;
            PreencherParametros(command, cliente);
            cliente.Id = int.Parse(command.ExecuteScalar()?.ToString() ?? "0", CultureInfo.InvariantCulture);
        }

        public void Atualizar(int index, Cliente cliente)
        {
            var atual = ObterTodos().ElementAtOrDefault(index);

            if (atual == null)
                return;

            cliente.Id = cliente.Id > 0 ? cliente.Id : atual.Id;

            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                UPDATE Clientes
                SET Nome = $nome,
                    Contato = $contato,
                    Cpf = $cpf,
                    Cep = $cep,
                    Endereco = $endereco,
                    Observacoes = $observacoes
                WHERE Id = $id;
                """;
            SqliteDatabase.AddParameter(command, "$id", cliente.Id);
            PreencherParametros(command, cliente);
            command.ExecuteNonQuery();
        }

        public void Remover(int index)
        {
            var cliente = ObterTodos().ElementAtOrDefault(index);

            if (cliente == null)
                return;

            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Clientes WHERE Id = $id;";
            SqliteDatabase.AddParameter(command, "$id", cliente.Id);
            command.ExecuteNonQuery();
        }

        public int ObterIndex(Cliente cliente)
        {
            var clientes = ObterTodos();
            return clientes.ToList().FindIndex(item => item.Id == cliente.Id);
        }

        private static void PreencherParametros(Microsoft.Data.Sqlite.SqliteCommand command, Cliente cliente)
        {
            SqliteDatabase.AddParameter(command, "$nome", cliente.Nome);
            SqliteDatabase.AddParameter(command, "$contato", cliente.Contato);
            SqliteDatabase.AddParameter(command, "$cpf", cliente.Cpf);
            SqliteDatabase.AddParameter(command, "$cep", cliente.Cep);
            SqliteDatabase.AddParameter(command, "$endereco", cliente.Endereco);
            SqliteDatabase.AddParameter(command, "$observacoes", cliente.Observacoes);
        }
    }
}
