using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ProjetoOrcamento.Repositories
{
    internal sealed class SqliteServicoRepository : IServicoRepository
    {
        public IReadOnlyList<Servico> ObterTodos()
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT Id, Nome, PrecoUnitario
                FROM Servicos
                ORDER BY Nome;
                """;

            using var reader = command.ExecuteReader();
            var servicos = new List<Servico>();

            while (reader.Read())
            {
                servicos.Add(new Servico
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    PrecoUnitario = reader.GetDecimal(2)
                });
            }

            return servicos;
        }

        public void Adicionar(Servico servico)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO Servicos (Nome, PrecoUnitario)
                VALUES ($nome, $precoUnitario);
                SELECT last_insert_rowid();
                """;
            PreencherParametros(command, servico);
            servico.Id = int.Parse(command.ExecuteScalar()?.ToString() ?? "0", CultureInfo.InvariantCulture);
        }

        public void Atualizar(int index, Servico servico)
        {
            var atual = ObterTodos().ElementAtOrDefault(index);

            if (atual == null)
                return;

            servico.Id = servico.Id > 0 ? servico.Id : atual.Id;

            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                UPDATE Servicos
                SET Nome = $nome,
                    PrecoUnitario = $precoUnitario
                WHERE Id = $id;
                """;
            SqliteDatabase.AddParameter(command, "$id", servico.Id);
            PreencherParametros(command, servico);
            command.ExecuteNonQuery();
        }

        public void Remover(int index)
        {
            var servico = ObterTodos().ElementAtOrDefault(index);

            if (servico == null)
                return;

            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Servicos WHERE Id = $id;";
            SqliteDatabase.AddParameter(command, "$id", servico.Id);
            command.ExecuteNonQuery();
        }

        public int ObterIndex(Servico servico)
        {
            var servicos = ObterTodos();
            return servicos.ToList().FindIndex(item => item.Id == servico.Id);
        }

        private static void PreencherParametros(Microsoft.Data.Sqlite.SqliteCommand command, Servico servico)
        {
            SqliteDatabase.AddParameter(command, "$nome", servico.Nome);
            SqliteDatabase.AddParameter(command, "$precoUnitario", servico.PrecoUnitario);
        }
    }
}
