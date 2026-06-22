using ProjetoOrcamento.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmUsuarios : Form
    {
        private readonly Usuario _usuarioLogado;
        private readonly UsuarioService _usuarioService = new();
        private readonly Color _azulPrincipal = ColorTranslator.FromHtml("#1E3A8A");
        private readonly Color _cinzaTexto = ColorTranslator.FromHtml("#374151");
        private readonly Color _erro = ColorTranslator.FromHtml("#DC2626");
        private readonly Color _sucesso = ColorTranslator.FromHtml("#16A34A");

        private DataGridView dgvUsuarios = null!;
        private TextBox txtNome = null!;
        private TextBox txtLogin = null!;
        private TextBox txtSenha = null!;
        private ComboBox cmbPapel = null!;
        private Label lblStatus = null!;
        private Label lblResumo = null!;
        private ModernButton btnSalvar = null!;
        private ModernButton btnLimpar = null!;
        private ModernButton btnExcluir = null!;
        private ModernButton btnFechar = null!;

        private IReadOnlyList<Papel> _papeis = Array.Empty<Papel>();
        private int _usuarioEmEdicaoId;

        public FrmUsuarios(Usuario usuarioLogado)
        {
            _usuarioLogado = usuarioLogado;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            Text = "Gerenciar Usuários";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(940, 620);
            ClientSize = new Size(1040, 660);
            BackColor = ColorTranslator.FromHtml("#F5F5F5");
            Font = new Font("Segoe UI", 10F);

            var pnlHeader = CriarHeader();

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(22),
                ColumnCount = 1,
                RowCount = 3
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));

            layout.Controls.Add(CriarCardFormulario(), 0, 0);
            layout.Controls.Add(CriarCardLista(), 0, 1);
            layout.Controls.Add(CriarRodape(), 0, 2);

            Controls.Add(layout);
            Controls.Add(pnlHeader);

            Load += FrmUsuarios_Load;
            ResumeLayout(false);
        }

        private Panel CriarHeader()
        {
            var pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 74,
                BackColor = _azulPrincipal,
                Padding = new Padding(24, 10, 24, 10)
            };

            var lblTitulo = new Label
            {
                Dock = DockStyle.Top,
                Height = 30,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "Gerenciamento de usuários",
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblSubtitulo = new Label
            {
                Dock = DockStyle.Top,
                Height = 24,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = ColorTranslator.FromHtml("#DBEAFE"),
                Text = $"Administrador: {_usuarioLogado.Nome} ({_usuarioLogado.Papel.Nome})",
                TextAlign = ContentAlignment.MiddleLeft
            };

            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            return pnlHeader;
        }

        private Control CriarCardFormulario()
        {
            var card = new ModernPanel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 16),
                Padding = new Padding(20)
            };

            var grid = new TableLayoutPanel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 4
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var lblTitulo = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#111827"),
                Text = "Dados do usuário",
                TextAlign = ContentAlignment.MiddleLeft
            };
            grid.Controls.Add(lblTitulo, 0, 0);
            grid.SetColumnSpan(lblTitulo, 4);

            txtNome = CriarTextBox("Nome completo...");
            txtLogin = CriarTextBox("Login...");
            txtSenha = CriarTextBox("Senha...");
            txtSenha.UseSystemPasswordChar = true;
            cmbPapel = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10.5F),
                Margin = new Padding(0, 0, 12, 14)
            };

            grid.Controls.Add(CriarCampo("Nome", txtNome), 0, 1);
            grid.Controls.Add(CriarCampo("Login", txtLogin), 1, 1);
            grid.Controls.Add(CriarCampo("Senha", txtSenha), 2, 1);
            grid.Controls.Add(CriarCampo("Papel", cmbPapel), 3, 1);

            btnSalvar = CriarBotao("Salvar", "#16A34A", "#15803D", "#166534");
            btnLimpar = CriarBotao("Limpar", "#6B7280", "#4B5563", "#374151");
            btnExcluir = CriarBotao("Excluir", "#DC2626", "#B91C1C", "#991B1B");
            btnFechar = CriarBotao("Fechar", "#F59E0B", "#D97706", "#B45309");

            btnSalvar.Click += btnSalvar_Click;
            btnLimpar.Click += (_, _) => LimparCampos();
            btnExcluir.Click += btnExcluir_Click;
            btnFechar.Click += (_, _) => Close();

            var botoes = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Margin = new Padding(0),
                WrapContents = false
            };
            botoes.Controls.Add(btnFechar);
            botoes.Controls.Add(btnExcluir);
            botoes.Controls.Add(btnLimpar);
            botoes.Controls.Add(btnSalvar);

            grid.Controls.Add(botoes, 0, 2);
            grid.SetColumnSpan(botoes, 4);

            card.Controls.Add(grid);
            return card;
        }

        private Control CriarCardLista()
        {
            var card = new ModernPanel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 16),
                Padding = new Padding(20)
            };

            dgvUsuarios = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                MultiSelect = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = _azulPrincipal;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#111827");
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F4F6");
            dgvUsuarios.RowTemplate.Height = 38;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Usuario.Nome),
                HeaderText = "Nome",
                FillWeight = 180
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Usuario.Login),
                HeaderText = "Login",
                FillWeight = 110
            });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Usuario.Papel),
                HeaderText = "Papel",
                FillWeight = 110
            });

            card.Controls.Add(dgvUsuarios);
            return card;
        }

        private Control CriarRodape()
        {
            var painel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(18, 0, 18, 0)
            };

            lblResumo = new Label
            {
                Dock = DockStyle.Left,
                Width = 360,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#111827"),
                TextAlign = ContentAlignment.MiddleLeft
            };

            lblStatus = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10.5F),
                ForeColor = _cinzaTexto,
                Text = "Pronto.",
                TextAlign = ContentAlignment.MiddleRight
            };

            painel.Controls.Add(lblStatus);
            painel.Controls.Add(lblResumo);
            return painel;
        }

        private TextBox CriarTextBox(string placeholder)
        {
            return new TextBox
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10.5F),
                PlaceholderText = placeholder,
                Margin = new Padding(0, 0, 12, 14)
            };
        }

        private Control CriarCampo(string label, Control controle)
        {
            var painel = new Panel { Dock = DockStyle.Fill, Margin = new Padding(0) };

            var lbl = new Label
            {
                Dock = DockStyle.Top,
                Height = 24,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#111827"),
                Text = label,
                TextAlign = ContentAlignment.BottomLeft
            };

            controle.Dock = DockStyle.Bottom;
            controle.Height = 32;

            painel.Controls.Add(controle);
            painel.Controls.Add(lbl);
            return painel;
        }

        private ModernButton CriarBotao(string texto, string normal, string hover, string pressed)
        {
            return new ModernButton
            {
                Text = texto,
                Width = 124,
                Height = 40,
                Margin = new Padding(10, 8, 0, 8),
                NormalBackColor = ColorTranslator.FromHtml(normal),
                HoverBackColor = ColorTranslator.FromHtml(hover),
                PressedBackColor = ColorTranslator.FromHtml(pressed)
            };
        }

        private void FrmUsuarios_Load(object? sender, EventArgs e)
        {
            try
            {
                _papeis = _usuarioService.ListarPapeis(_usuarioLogado);
                cmbPapel.DataSource = new BindingSource { DataSource = _papeis.ToList() };
                cmbPapel.DisplayMember = nameof(Papel.Nome);
                cmbPapel.SelectedIndex = -1;
                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao abrir usuários.", ex);
            }
        }

        private void CarregarUsuarios()
        {
            var usuarios = _usuarioService.Listar(_usuarioLogado).ToList();
            dgvUsuarios.DataSource = new BindingSource { DataSource = usuarios };
            lblResumo.Text = $"Usuários: {usuarios.Count}";
            DefinirStatus("Lista de usuários atualizada.", _cinzaTexto);
        }

        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cmbPapel.SelectedItem is not Papel papel)
                    throw new InvalidOperationException("Selecione um papel para o usuário.");

                var usuario = new Usuario
                {
                    Id = _usuarioEmEdicaoId,
                    Nome = txtNome.Text.Trim(),
                    Login = txtLogin.Text.Trim(),
                    Papel = papel
                };

                _usuarioService.Salvar(usuario, txtSenha.Text, _usuarioLogado);
                LimparCampos();
                CarregarUsuarios();
                DefinirStatus("Usuário salvo com sucesso.", _sucesso);
                MessageBox.Show("Usuário salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                DefinirStatus(ex.Message, _erro);
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException ex)
            {
                DefinirStatus(ex.Message, _erro);
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao salvar usuário.", ex);
            }
        }

        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.CurrentRow?.DataBoundItem is not Usuario usuario)
                {
                    MessageBox.Show("Selecione um usuário para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmacao = MessageBox.Show(
                    $"Deseja realmente excluir o usuário '{usuario.Login}'?",
                    "Confirmar exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (confirmacao != DialogResult.Yes)
                    return;

                _usuarioService.Remover(usuario, _usuarioLogado);
                LimparCampos();
                CarregarUsuarios();
                DefinirStatus("Usuário excluído com sucesso.", _sucesso);
            }
            catch (InvalidOperationException ex)
            {
                DefinirStatus(ex.Message, _erro);
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException ex)
            {
                DefinirStatus(ex.Message, _erro);
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao excluir usuário.", ex);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvUsuarios.Rows[e.RowIndex].DataBoundItem is not Usuario usuario)
                return;

            _usuarioEmEdicaoId = usuario.Id;
            txtNome.Text = usuario.Nome;
            txtLogin.Text = usuario.Login;
            txtSenha.Clear();
            cmbPapel.SelectedItem = _papeis.FirstOrDefault(papel => papel.Id == usuario.Papel.Id);
            btnSalvar.Text = "Atualizar";
            DefinirStatus("Editando usuário selecionado. Deixe a senha em branco para manter a atual.", _cinzaTexto);
        }

        private void LimparCampos()
        {
            _usuarioEmEdicaoId = 0;
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            cmbPapel.SelectedIndex = -1;
            btnSalvar.Text = "Salvar";
            txtNome.Focus();
            DefinirStatus("Pronto.", _cinzaTexto);
        }

        private void DefinirStatus(string mensagem, Color cor)
        {
            lblStatus.ForeColor = cor;
            lblStatus.Text = mensagem;
        }

        private void ExibirErro(string mensagemAmigavel, Exception ex)
        {
            DefinirStatus(mensagemAmigavel, _erro);
            MessageBox.Show($"{mensagemAmigavel}\n\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSalvar_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                LimparCampos();
                return true;
            }

            if (keyData == Keys.Delete && dgvUsuarios.ContainsFocus)
            {
                btnExcluir_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
