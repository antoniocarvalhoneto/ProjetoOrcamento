using ProjetoOrcamento.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmClientes : Form
    {
        private readonly Color _azulPrincipal = ColorTranslator.FromHtml("#1E3A8A");
        private readonly Color _azulSecundario = ColorTranslator.FromHtml("#2563EB");
        private readonly Color _cinzaTexto = ColorTranslator.FromHtml("#374151");
        private readonly Color _erroCampo = ColorTranslator.FromHtml("#FEF2F2");
        private readonly Color _sucesso = ColorTranslator.FromHtml("#16A34A");
        private readonly ClienteService _clienteService = new();
        private readonly Usuario _usuarioLogado;

        private int _clienteEmEdicaoIndex = -1;

        public FrmClientes(Usuario usuarioLogado)
        {
            _usuarioLogado = usuarioLogado;
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            ConfigurarToolTips();
            AplicarPermissoes();
            DefinirModoEdicao(false);
        }

        private void ConfigurarFormulario()
        {
            lblUsuario.Text = $"Usuário: {_usuarioLogado.Nome} ({_usuarioLogado.Papel.Nome})";
            AtualizarRelogio();

            tmrRelogio.Interval = 1000;
            tmrRelogio.Tick += (_, _) => AtualizarRelogio();
            tmrRelogio.Start();
        }

        private void ConfigurarDataGridView()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = _azulPrincipal;
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvClientes.DefaultCellStyle.BackColor = Color.White;
            dgvClientes.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111827");
            dgvClientes.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            dgvClientes.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#111827");
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F4F6");
            dgvClientes.RowTemplate.Height = 38;

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Cliente.Nome),
                HeaderText = "Nome",
                Name = "colNome",
                FillWeight = 180
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Cliente.Contato),
                HeaderText = "Telefone",
                Name = "colTelefone",
                FillWeight = 120
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Cliente.Cpf),
                HeaderText = "CPF",
                Name = "colCpf",
                FillWeight = 115
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Cliente.Cep),
                HeaderText = "CEP",
                Name = "colCep",
                FillWeight = 90
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Cliente.Endereco),
                HeaderText = "Endereço",
                Name = "colEndereco",
                FillWeight = 190
            });

            dgvClientes.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnEditarGrid",
                Text = "✏️",
                ToolTipText = "Editar cliente",
                UseColumnTextForButtonValue = true,
                FillWeight = 42,
                FlatStyle = FlatStyle.Flat
            });

            dgvClientes.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnDeletar",
                Text = "🗑",
                ToolTipText = "Excluir cliente",
                UseColumnTextForButtonValue = true,
                FillWeight = 42,
                FlatStyle = FlatStyle.Flat
            });

            dgvClientes.Columns["btnEditarGrid"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["btnDeletar"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AplicarPermissoes()
        {
            var podeAlterar = _usuarioLogado.PodeAlterarDados;

            btnSalvar.Enabled = podeAlterar;
            btnEditar.Enabled = podeAlterar;
            btnExcluir.Enabled = podeAlterar;
            btnLimpar.Enabled = podeAlterar;
            btnCancelar.Enabled = false;
            txtNome.Enabled = podeAlterar;
            txtTelefone.Enabled = podeAlterar;
            txtCpf.Enabled = podeAlterar;
            txtCep.Enabled = podeAlterar;
            txtEndereco.Enabled = podeAlterar;
            txtObservacoes.Enabled = podeAlterar;

            if (dgvClientes.Columns.Contains("btnEditarGrid"))
                dgvClientes.Columns["btnEditarGrid"]!.Visible = podeAlterar;

            if (dgvClientes.Columns.Contains("btnDeletar"))
                dgvClientes.Columns["btnDeletar"]!.Visible = podeAlterar;

            if (!podeAlterar)
                DefinirStatus("Perfil Visualizador: consulta liberada, alterações bloqueadas.", _cinzaTexto);
        }

        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(txtNome, "Informe o nome do cliente.");
            toolTip.SetToolTip(txtTelefone, "Informe o telefone no formato (99) 99999-9999.");
            toolTip.SetToolTip(txtCpf, "Informe o CPF no formato 999.999.999-99.");
            toolTip.SetToolTip(txtCep, "Informe o CEP no formato 99999-999.");
            toolTip.SetToolTip(txtEndereco, "Informe o endereço do cliente.");
            toolTip.SetToolTip(txtObservacoes, "Inclua informações adicionais do cliente.");
            toolTip.SetToolTip(txtPesquisa, "Pesquise instantaneamente por nome, telefone, CPF, CEP ou endereço.");
            toolTip.SetToolTip(btnSalvar, "Salvar cliente. Atalho: Ctrl + S.");
            toolTip.SetToolTip(btnEditar, "Editar o cliente selecionado.");
            toolTip.SetToolTip(btnLimpar, "Limpar o formulário. Atalho: Ctrl + N.");
            toolTip.SetToolTip(btnExcluir, "Excluir o cliente selecionado. Atalho: Del no grid.");
            toolTip.SetToolTip(btnCancelar, "Cancelar a edição atual. Atalho: Esc.");
            toolTip.SetToolTip(dgvClientes, "Clique duas vezes para editar ou use os botões da linha.");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            txtNome.Focus();
        }

        private void CarregarClientes()
        {
            try
            {
                MostrarCarregamento(true);

                var clientes = ObterClientesFiltrados();
                dgvClientes.DataSource = new BindingSource { DataSource = clientes };
                AtualizarResumo(clientes.Count);
                DefinirStatus("Lista de clientes atualizada.", _cinzaTexto);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao carregar clientes. Tente novamente.", ex);
            }
            finally
            {
                MostrarCarregamento(false);
            }
        }

        private List<Cliente> ObterClientesFiltrados()
        {
            var termo = txtPesquisa.Text.Trim();

            if (string.IsNullOrWhiteSpace(termo))
                return _clienteService.ObterTodos().ToList();

            return _clienteService.Pesquisar(termo).ToList();
        }

        private static bool Contem(string? texto, string termo)
        {
            return !string.IsNullOrWhiteSpace(texto)
                && texto.Contains(termo, StringComparison.OrdinalIgnoreCase);
        }

        private void SalvarRegistro()
        {
            if (!ValidarPermissaoAlteracao("salvar clientes"))
                return;

            try
            {
                if (!ValidarCampos())
                    return;

                var cliente = MontarObjeto();

                if (_clienteEmEdicaoIndex >= 0)
                {
                    _clienteService.Salvar(cliente, _clienteEmEdicaoIndex, _usuarioLogado);
                    DefinirStatus("Registro atualizado com sucesso.", _sucesso);
                    MessageBox.Show("Registro atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _clienteService.Salvar(cliente, _clienteEmEdicaoIndex, _usuarioLogado);
                    DefinirStatus("Registro salvo com sucesso.", _sucesso);
                    MessageBox.Show("Registro salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                CarregarClientes();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(ex.Message, ColorTranslator.FromHtml("#DC2626"));
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(ex.Message, ColorTranslator.FromHtml("#DC2626"));
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao salvar. Tente novamente.", ex);
            }
        }

        private Cliente MontarObjeto()
        {
            return new Cliente(
                txtNome.Text.Trim(),
                txtTelefone.Text.Trim(),
                ObterTextoMascaraOpcional(txtCpf),
                ObterTextoMascaraOpcional(txtCep),
                txtEndereco.Text.Trim(),
                txtObservacoes.Text.Trim());
        }

        private static string ObterTextoMascaraOpcional(MaskedTextBox controle)
        {
            return MascaraVazia(controle) ? string.Empty : controle.Text.Trim();
        }

        private bool ValidarCampos(bool exibirMensagem = true)
        {
            var mensagens = new List<string>();
            errorProvider.Clear();

            ValidarTextoObrigatorio(txtNome, "Informe o nome do cliente.", mensagens);
            ValidarMascaraObrigatoria(txtTelefone, "Informe o telefone do cliente.", mensagens);
            ValidarMascaraOpcional(txtCpf, "CPF incompleto.", mensagens);
            ValidarMascaraOpcional(txtCep, "CEP incompleto.", mensagens);

            var valido = mensagens.Count == 0;

            if (!valido && exibirMensagem)
            {
                MessageBox.Show(mensagens[0], "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(mensagens[0], ColorTranslator.FromHtml("#DC2626"));
            }

            return valido;
        }

        private void ValidarTextoObrigatorio(TextBox controle, string mensagem, ICollection<string> mensagens)
        {
            if (string.IsNullOrWhiteSpace(controle.Text))
            {
                controle.BackColor = _erroCampo;
                errorProvider.SetError(controle, mensagem);
                mensagens.Add(mensagem);
                return;
            }

            controle.BackColor = Color.White;
            errorProvider.SetError(controle, string.Empty);
        }

        private void ValidarMascaraObrigatoria(MaskedTextBox controle, string mensagem, ICollection<string> mensagens)
        {
            if (!controle.MaskCompleted)
            {
                controle.BackColor = _erroCampo;
                errorProvider.SetError(controle, mensagem);
                mensagens.Add(mensagem);
                return;
            }

            controle.BackColor = Color.White;
            errorProvider.SetError(controle, string.Empty);
        }

        private void ValidarMascaraOpcional(MaskedTextBox controle, string mensagem, ICollection<string> mensagens)
        {
            if (MascaraVazia(controle))
            {
                controle.BackColor = Color.White;
                errorProvider.SetError(controle, string.Empty);
                return;
            }

            if (!controle.MaskCompleted)
            {
                controle.BackColor = _erroCampo;
                errorProvider.SetError(controle, mensagem);
                mensagens.Add(mensagem);
                return;
            }

            controle.BackColor = Color.White;
            errorProvider.SetError(controle, string.Empty);
        }

        private static bool MascaraVazia(MaskedTextBox controle)
        {
            return !controle.Text.Any(char.IsDigit);
        }

        private void EditarClienteSelecionado()
        {
            if (!ValidarPermissaoAlteracao("editar clientes"))
                return;

            var cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelecionarClienteParaEdicao(cliente);
        }

        private void SelecionarClienteParaEdicao(Cliente cliente)
        {
            if (!ValidarPermissaoAlteracao("editar clientes"))
                return;

            var index = _clienteService.ObterIndex(cliente);

            if (index < 0)
            {
                MessageBox.Show("Não foi possível localizar o cliente selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _clienteEmEdicaoIndex = index;
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Contato;
            txtCpf.Text = cliente.Cpf;
            txtCep.Text = cliente.Cep;
            txtEndereco.Text = cliente.Endereco;
            txtObservacoes.Text = cliente.Observacoes;

            DefinirModoEdicao(true);
            txtNome.Focus();
        }

        private void ExcluirClienteSelecionado()
        {
            if (!ValidarPermissaoAlteracao("excluir clientes"))
                return;

            var cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExcluirCliente(cliente);
        }

        private void ExcluirCliente(Cliente cliente)
        {
            if (!ValidarPermissaoAlteracao("excluir clientes"))
                return;

            try
            {
                var index = _clienteService.ObterIndex(cliente);

                if (index < 0)
                {
                    MessageBox.Show("Não foi possível localizar o cliente selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacao = MessageBox.Show(
                    $"Deseja realmente excluir o cliente '{cliente.Nome}'?",
                    "Confirmar exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (confirmacao != DialogResult.Yes)
                    return;

                _clienteService.Remover(cliente, _usuarioLogado);

                if (_clienteEmEdicaoIndex == index)
                    LimparCampos();

                CarregarClientes();
                DefinirStatus("Registro excluído com sucesso.", _sucesso);
                MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao excluir. Tente novamente.", ex);
            }
        }

        private Cliente? ObterClienteSelecionado()
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente cliente)
                return cliente;

            return null;
        }

        private void LimparCampos()
        {
            if (!_usuarioLogado.PodeAlterarDados)
                return;

            _clienteEmEdicaoIndex = -1;

            txtNome.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtObservacoes.Clear();

            errorProvider.Clear();
            RestaurarCoresDosCampos();
            DefinirModoEdicao(false);
            txtNome.Focus();
        }

        private void CancelarEdicao()
        {
            LimparCampos();
            DefinirStatus("Operação cancelada.", _cinzaTexto);
        }

        private void DefinirModoEdicao(bool editando)
        {
            if (!_usuarioLogado.PodeAlterarDados)
            {
                btnSalvar.Text = "💾 Salvar";
                btnCancelar.Enabled = false;
                return;
            }

            btnSalvar.Text = editando ? "💾 Atualizar" : "💾 Salvar";
            btnCancelar.Enabled = editando;
            lblStatus.Text = editando ? "Editando registro selecionado." : "Pronto.";
        }

        private void RestaurarCoresDosCampos()
        {
            txtNome.BackColor = Color.White;
            txtTelefone.BackColor = Color.White;
            txtCpf.BackColor = Color.White;
            txtCep.BackColor = Color.White;
            txtEndereco.BackColor = Color.White;
            txtObservacoes.BackColor = Color.White;
        }

        private void AtualizarResumo(int quantidadeFiltrada)
        {
            var total = _clienteService.ObterTodos().Count;
            lblQuantidadeRegistros.Text = quantidadeFiltrada == total
                ? $"Quantidade de registros: {total}"
                : $"Quantidade de registros: {quantidadeFiltrada} de {total}";

            lblValorTotal.Text = "Valor total: R$ 0,00";
        }

        private void DefinirStatus(string mensagem, Color cor)
        {
            lblStatus.ForeColor = cor;
            lblStatus.Text = mensagem;
        }

        private void MostrarCarregamento(bool exibir)
        {
            prgCarregando.Visible = exibir;
            Cursor = exibir ? Cursors.WaitCursor : Cursors.Default;
        }

        private void AtualizarRelogio()
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ExibirErro(string mensagemAmigavel, Exception ex)
        {
            DefinirStatus(mensagemAmigavel, ColorTranslator.FromHtml("#DC2626"));
            MessageBox.Show($"{mensagemAmigavel}\n\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarPermissaoAlteracao(string acao)
        {
            if (_usuarioLogado.PodeAlterarDados)
                return true;

            var mensagem = $"Seu perfil não permite {acao}.";
            DefinirStatus(mensagem, ColorTranslator.FromHtml("#DC2626"));
            MessageBox.Show(mensagem, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void Campo_TextChanged(object? sender, EventArgs e)
        {
            ValidarCampos(false);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarClienteSelecionado();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DefinirStatus("Campos limpos.", _cinzaTexto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirClienteSelecionado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarEdicao();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvClientes.Rows[e.RowIndex].DataBoundItem is Cliente cliente)
                SelecionarClienteParaEdicao(cliente);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvClientes.Rows[e.RowIndex].DataBoundItem is not Cliente cliente)
                return;

            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnDeletar")
            {
                ExcluirCliente(cliente);
                return;
            }

            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditarGrid")
                SelecionarClienteParaEdicao(cliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            Campo_TextChanged(sender, e);
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SalvarRegistro();
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                LimparCampos();
                DefinirStatus("Novo cadastro iniciado.", _cinzaTexto);
                return true;
            }

            if (keyData == Keys.Escape)
            {
                CancelarEdicao();
                return true;
            }

            if (keyData == Keys.Delete && dgvClientes.ContainsFocus)
            {
                ExcluirClienteSelecionado();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
