using ProjetoOrcamento.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService = new();
        private readonly Color _azulPrincipal = ColorTranslator.FromHtml("#1E3A8A");
        private readonly Color _azulSecundario = ColorTranslator.FromHtml("#2563EB");
        private readonly Color _cinzaFundo = ColorTranslator.FromHtml("#F5F5F5");
        private readonly Color _cinzaTexto = ColorTranslator.FromHtml("#374151");
        private readonly Color _erro = ColorTranslator.FromHtml("#DC2626");

        private TextBox txtLogin = null!;
        private TextBox txtSenha = null!;
        private Label lblStatus = null!;
        private ModernButton btnEntrar = null!;
        private ModernButton btnCancelar = null!;

        public Usuario? UsuarioLogado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            Text = "Entrar - Sistema de Orçamentos";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(480, 420);
            BackColor = _cinzaFundo;
            Font = new Font("Segoe UI", 10F);

            var pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 96,
                BackColor = _azulPrincipal,
                Padding = new Padding(28, 18, 28, 14)
            };

            var lblTitulo = new Label
            {
                Dock = DockStyle.Top,
                Height = 36,
                Font = new Font("Segoe UI", 17F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "Sistema de Orçamentos",
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblSubtitulo = new Label
            {
                Dock = DockStyle.Top,
                Height = 26,
                Font = new Font("Segoe UI", 10F),
                ForeColor = ColorTranslator.FromHtml("#DBEAFE"),
                Text = "Acesse com seu usuário e senha",
                TextAlign = ContentAlignment.MiddleLeft
            };

            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);

            var card = new ModernPanel
            {
                Left = 32,
                Top = 124,
                Width = 416,
                Height = 252,
                Padding = new Padding(24)
            };

            var lblLogin = CriarLabel("Login", 24, 22);
            txtLogin = CriarTextBox(24, 50, "Digite seu login...");

            var lblSenha = CriarLabel("Senha", 24, 92);
            txtSenha = CriarTextBox(24, 120, "Digite sua senha...");
            txtSenha.UseSystemPasswordChar = true;

            lblStatus = new Label
            {
                Left = 24,
                Top = 156,
                Width = 368,
                Height = 28,
                ForeColor = _cinzaTexto,
                Text = "Informe suas credenciais.",
                TextAlign = ContentAlignment.MiddleLeft
            };

            btnEntrar = new ModernButton
            {
                Text = "Entrar",
                Left = 158,
                Top = 192,
                Width = 112,
                Height = 40,
                NormalBackColor = _azulSecundario,
                HoverBackColor = ColorTranslator.FromHtml("#1D4ED8"),
                PressedBackColor = ColorTranslator.FromHtml("#1E40AF")
            };
            btnEntrar.Click += btnEntrar_Click;

            btnCancelar = new ModernButton
            {
                Text = "Cancelar",
                Left = 280,
                Top = 192,
                Width = 112,
                Height = 40,
                NormalBackColor = ColorTranslator.FromHtml("#6B7280"),
                HoverBackColor = ColorTranslator.FromHtml("#4B5563"),
                PressedBackColor = ColorTranslator.FromHtml("#374151"),
                DialogResult = DialogResult.Cancel
            };
            btnCancelar.Click += (_, _) => Close();

            card.Controls.Add(lblLogin);
            card.Controls.Add(txtLogin);
            card.Controls.Add(lblSenha);
            card.Controls.Add(txtSenha);
            card.Controls.Add(lblStatus);
            card.Controls.Add(btnEntrar);
            card.Controls.Add(btnCancelar);

            Controls.Add(card);
            Controls.Add(pnlHeader);

            AcceptButton = btnEntrar;
            CancelButton = btnCancelar;
            Load += (_, _) => txtLogin.Focus();

            ResumeLayout(false);
        }

        private Label CriarLabel(string texto, int left, int top)
        {
            return new Label
            {
                Left = left,
                Top = top,
                Width = 368,
                Height = 24,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#111827"),
                Text = texto,
                TextAlign = ContentAlignment.BottomLeft
            };
        }

        private TextBox CriarTextBox(int left, int top, string placeholder)
        {
            return new TextBox
            {
                Left = left,
                Top = top,
                Width = 368,
                Height = 31,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10.5F),
                PlaceholderText = placeholder
            };
        }

        private void btnEntrar_Click(object? sender, EventArgs e)
        {
            try
            {
                var usuario = _usuarioService.Autenticar(txtLogin.Text, txtSenha.Text);

                if (usuario == null)
                {
                    lblStatus.ForeColor = _erro;
                    lblStatus.Text = "Usuário ou senha incorretos.";
                    txtSenha.Clear();
                    txtLogin.Focus();
                    return;
                }

                UsuarioLogado = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = _erro;
                lblStatus.Text = "Erro ao autenticar.";
                MessageBox.Show($"Erro ao autenticar.\n\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
