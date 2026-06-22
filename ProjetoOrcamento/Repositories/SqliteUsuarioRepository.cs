using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoOrcamento.Repositories
{
    internal sealed class SqliteUsuarioRepository : IUsuarioRepository
    {
        public bool ExisteAlgumUsuario()
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(1) FROM Usuarios;";
            return Convert.ToInt32(command.ExecuteScalar(), CultureInfo.InvariantCulture) > 0;
        }

        public bool LoginExiste(string login, int? usuarioIdIgnorado = null)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = usuarioIdIgnorado.HasValue
                ? "SELECT COUNT(1) FROM Usuarios WHERE Login = $login AND Id <> $id;"
                : "SELECT COUNT(1) FROM Usuarios WHERE Login = $login;";
            SqliteDatabase.AddParameter(command, "$login", login);

            if (usuarioIdIgnorado.HasValue)
                SqliteDatabase.AddParameter(command, "$id", usuarioIdIgnorado.Value);

            return Convert.ToInt32(command.ExecuteScalar(), CultureInfo.InvariantCulture) > 0;
        }

        public int ContarAdmins()
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(1) FROM Usuarios WHERE PapelId = $papelId;";
            SqliteDatabase.AddParameter(command, "$papelId", Papel.AdminId);
            return Convert.ToInt32(command.ExecuteScalar(), CultureInfo.InvariantCulture);
        }

        public Usuario? ObterPorLogin(string login)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT
                    u.Id,
                    u.Nome,
                    u.Login,
                    u.SenhaHash,
                    p.Id AS PapelId,
                    p.Nome AS PapelNome
                FROM Usuarios u
                INNER JOIN Papeis p ON p.Id = u.PapelId
                WHERE u.Login = $login;
                """;
            SqliteDatabase.AddParameter(command, "$login", login);

            using var reader = command.ExecuteReader();
            return reader.Read() ? MapearUsuario(reader) : null;
        }

        public IReadOnlyList<Usuario> ObterTodos()
        {
            var usuarios = new List<Usuario>();

            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT
                    u.Id,
                    u.Nome,
                    u.Login,
                    u.SenhaHash,
                    p.Id AS PapelId,
                    p.Nome AS PapelNome
                FROM Usuarios u
                INNER JOIN Papeis p ON p.Id = u.PapelId
                ORDER BY u.Nome;
                """;

            using var reader = command.ExecuteReader();

            while (reader.Read())
                usuarios.Add(MapearUsuario(reader));

            return usuarios;
        }

        public IReadOnlyList<Papel> ObterPapeis()
        {
            var papeis = new List<Papel>();

            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Nome FROM Papeis ORDER BY Id;";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                papeis.Add(new Papel
                {
                    Id = Convert.ToInt32(reader["Id"], CultureInfo.InvariantCulture),
                    Nome = Convert.ToString(reader["Nome"], CultureInfo.InvariantCulture) ?? string.Empty
                });
            }

            return papeis;
        }

        public void Adicionar(Usuario usuario)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO Usuarios (Nome, Login, SenhaHash, PapelId)
                VALUES ($nome, $login, $senhaHash, $papelId);
                """;
            PreencherParametros(command, usuario, incluirSenha: true);
            command.ExecuteNonQuery();
        }

        public void Atualizar(Usuario usuario, bool atualizarSenha)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = atualizarSenha
                ? """
                    UPDATE Usuarios
                    SET Nome = $nome,
                        Login = $login,
                        SenhaHash = $senhaHash,
                        PapelId = $papelId
                    WHERE Id = $id;
                    """
                : """
                    UPDATE Usuarios
                    SET Nome = $nome,
                        Login = $login,
                        PapelId = $papelId
                    WHERE Id = $id;
                    """;
            PreencherParametros(command, usuario, atualizarSenha);
            SqliteDatabase.AddParameter(command, "$id", usuario.Id);
            command.ExecuteNonQuery();
        }

        public void Remover(int id)
        {
            using var connection = SqliteDatabase.CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Usuarios WHERE Id = $id;";
            SqliteDatabase.AddParameter(command, "$id", id);
            command.ExecuteNonQuery();
        }

        private static void PreencherParametros(SqliteCommand command, Usuario usuario, bool incluirSenha)
        {
            SqliteDatabase.AddParameter(command, "$nome", usuario.Nome);
            SqliteDatabase.AddParameter(command, "$login", usuario.Login);
            SqliteDatabase.AddParameter(command, "$papelId", usuario.Papel.Id);

            if (incluirSenha)
                SqliteDatabase.AddParameter(command, "$senhaHash", usuario.SenhaHash);
        }

        private static Usuario MapearUsuario(SqliteDataReader reader)
        {
            return new Usuario
            {
                Id = Convert.ToInt32(reader["Id"], CultureInfo.InvariantCulture),
                Nome = Convert.ToString(reader["Nome"], CultureInfo.InvariantCulture) ?? string.Empty,
                Login = Convert.ToString(reader["Login"], CultureInfo.InvariantCulture) ?? string.Empty,
                SenhaHash = Convert.ToString(reader["SenhaHash"], CultureInfo.InvariantCulture) ?? string.Empty,
                Papel = new Papel
                {
                    Id = Convert.ToInt32(reader["PapelId"], CultureInfo.InvariantCulture),
                    Nome = Convert.ToString(reader["PapelNome"], CultureInfo.InvariantCulture) ?? string.Empty
                }
            };
        }
    }
}
