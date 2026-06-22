using ProjetoOrcamento.Forms;
using ProjetoOrcamento.Services;

namespace ProjetoOrcamento
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();

                var usuarioService = new UsuarioService();

                if (usuarioService.GarantirAdminPadrao())
                {
                    MessageBox.Show(
                        "Primeiro acesso detectado.\n\nUsuário: admin\nSenha: 1234\n\nAltere a senha ou crie novos usuários em Gerenciar Usuários.",
                        "Bem-vindo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                using var login = new FrmLogin();

                if (login.ShowDialog() == DialogResult.OK && login.UsuarioLogado != null)
                    Application.Run(new Form1(login.UsuarioLogado));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao iniciar o sistema.\n\nDetalhes: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
