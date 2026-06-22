using System.Collections.Generic;

namespace ProjetoOrcamento.Repositories
{
    internal interface IUsuarioRepository
    {
        bool ExisteAlgumUsuario();
        bool LoginExiste(string login, int? usuarioIdIgnorado = null);
        int ContarAdmins();
        Usuario? ObterPorLogin(string login);
        IReadOnlyList<Usuario> ObterTodos();
        IReadOnlyList<Papel> ObterPapeis();
        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario, bool atualizarSenha);
        void Remover(int id);
    }
}
