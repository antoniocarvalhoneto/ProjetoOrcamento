using ProjetoOrcamento.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOrcamento.Services
{
    internal sealed class UsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService()
            : this(new SqliteUsuarioRepository())
        {
        }

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public bool GarantirAdminPadrao()
        {
            if (_repository.ExisteAlgumUsuario())
                return false;

            var admin = new Usuario
            {
                Nome = "Administrador",
                Login = "admin",
                SenhaHash = PasswordHasher.Hash("1234"),
                Papel = new Papel { Id = Papel.AdminId, Nome = "Admin" }
            };

            _repository.Adicionar(admin);
            return true;
        }

        public Usuario? Autenticar(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                return null;

            var usuario = _repository.ObterPorLogin(login.Trim());

            if (usuario == null)
                return null;

            return PasswordHasher.Verify(senha, usuario.SenhaHash) ? usuario : null;
        }

        public IReadOnlyList<Usuario> Listar(Usuario solicitante)
        {
            AutorizacaoService.ExigirAdmin(solicitante, "listar usuários");
            return _repository.ObterTodos();
        }

        public IReadOnlyList<Papel> ListarPapeis(Usuario solicitante)
        {
            AutorizacaoService.ExigirAdmin(solicitante, "listar papéis");
            return _repository.ObterPapeis();
        }

        public void Salvar(Usuario usuario, string senha, Usuario solicitante)
        {
            AutorizacaoService.ExigirAdmin(solicitante, "salvar usuários");
            Validar(usuario, senha);

            var novoUsuario = usuario.Id <= 0;

            if (_repository.LoginExiste(usuario.Login, novoUsuario ? null : usuario.Id))
                throw new InvalidOperationException("Já existe um usuário com este login.");

            if (novoUsuario)
            {
                usuario.SenhaHash = PasswordHasher.Hash(senha);
                _repository.Adicionar(usuario);
                return;
            }

            if (!string.IsNullOrWhiteSpace(senha))
                usuario.SenhaHash = PasswordHasher.Hash(senha);

            GarantirQueNaoRemoveUltimoAdmin(usuario);
            _repository.Atualizar(usuario, !string.IsNullOrWhiteSpace(senha));
        }

        public void Remover(Usuario usuario, Usuario solicitante)
        {
            AutorizacaoService.ExigirAdmin(solicitante, "excluir usuários");

            if (usuario.Id == solicitante.Id)
                throw new InvalidOperationException("Você não pode excluir o próprio usuário logado.");

            if (usuario.Login.Equals("admin", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("O usuário admin padrão não pode ser excluído.");

            if (usuario.EhAdmin && _repository.ContarAdmins() <= 1)
                throw new InvalidOperationException("Mantenha pelo menos um administrador ativo.");

            _repository.Remover(usuario.Id);
        }

        private static void Validar(Usuario usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new InvalidOperationException("Informe o nome do usuário.");

            if (string.IsNullOrWhiteSpace(usuario.Login))
                throw new InvalidOperationException("Informe o login do usuário.");

            if (usuario.Papel.Id <= 0)
                throw new InvalidOperationException("Selecione um papel para o usuário.");

            if (usuario.Id <= 0 && string.IsNullOrWhiteSpace(senha))
                throw new InvalidOperationException("Informe a senha inicial do usuário.");

            if (!string.IsNullOrWhiteSpace(senha) && senha.Length < 4)
                throw new InvalidOperationException("A senha deve ter pelo menos 4 caracteres.");
        }

        private void GarantirQueNaoRemoveUltimoAdmin(Usuario usuario)
        {
            if (usuario.EhAdmin)
                return;

            var usuarioAtual = _repository
                .ObterTodos()
                .FirstOrDefault(item => item.Id == usuario.Id);

            if (usuarioAtual?.EhAdmin == true && _repository.ContarAdmins() <= 1)
                throw new InvalidOperationException("Mantenha pelo menos um administrador ativo.");
        }
    }
}
