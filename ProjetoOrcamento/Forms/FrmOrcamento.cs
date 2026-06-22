using ProjetoOrcamento.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmOrcamento : Form
    {
        private readonly Color _azulPrincipal = ColorTranslator.FromHtml("#1E3A8A");
        private readonly Color _cinzaTexto = ColorTranslator.FromHtml("#374151");
        private readonly Color _erroCampo = ColorTranslator.FromHtml("#FEF2F2");
        private readonly Color _sucesso = ColorTranslator.FromHtml("#16A34A");
        private readonly ClienteService _clienteService = new();
        private readonly ServicoService _servicoService = new();
        private readonly OrcamentoService _orcamentoService = new();
        private readonly Usuario _usuarioLogado;

        private Orcamento _orcamentoAtual;

        public FrmOrcamento(Usuario usuarioLogado)
        {
            _usuarioLogado = usuarioLogado;
            InitializeComponent();
            _orcamentoAtual = new Orcamento();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            ConfigurarToolTips();
            AplicarPermissoes();
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
            dgvItens.AutoGenerateColumns = false;
            dgvItens.Columns.Clear();

            dgvItens.ColumnHeadersDefaultCellStyle.BackColor = _azulPrincipal;
            dgvItens.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvItens.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvItens.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvItens.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvItens.DefaultCellStyle.BackColor = Color.White;
            dgvItens.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111827");
            dgvItens.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            dgvItens.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#111827");
            dgvItens.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F4F6");
            dgvItens.RowTemplate.Height = 38;

            dgvItens.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ItemOrcamentoExibicao.Servico),
                HeaderText = "Serviço",
                Name = "colServico",
                FillWeight = 190
            });

            dgvItens.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ItemOrcamentoExibicao.Quantidade),
                HeaderText = "Quantidade",
                Name = "colQuantidade",
                FillWeight = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvItens.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ItemOrcamentoExibicao.PrecoUnitario),
                HeaderText = "Valor unitário",
                Name = "colPreco",
                FillWeight = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvItens.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ItemOrcamentoExibicao.Subtotal),
                HeaderText = "Subtotal",
                Name = "colSubtotal",
                FillWeight = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvItens.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnRemoverGrid",
                Text = "🗑",
                ToolTipText = "Remover item",
                UseColumnTextForButtonValue = true,
                FillWeight = 35,
                FlatStyle = FlatStyle.Flat
            });

            dgvItens.Columns["btnRemoverGrid"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AplicarPermissoes()
        {
            var podeAlterar = _usuarioLogado.PodeAlterarDados;

            cmbCliente.Enabled = podeAlterar;
            cmbServico.Enabled = podeAlterar;
            nudQuantidade.Enabled = podeAlterar;
            btnAdicionarItem.Enabled = podeAlterar;
            btnRemoverItem.Enabled = podeAlterar;
            btnCriarOrcamento.Enabled = podeAlterar;
            btnLimpar.Enabled = podeAlterar;
            btnCancelar.Enabled = podeAlterar;

            if (dgvItens.Columns.Contains("btnRemoverGrid"))
                dgvItens.Columns["btnRemoverGrid"]!.Visible = podeAlterar;

            if (!podeAlterar)
                DefinirStatus("Perfil Visualizador: criação de orçamentos bloqueada.", _cinzaTexto);
        }

        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(cmbCliente, "Selecione o cliente do orçamento.");
            toolTip.SetToolTip(cmbServico, "Selecione o serviço que será adicionado.");
            toolTip.SetToolTip(nudQuantidade, "Informe a quantidade do serviço.");
            toolTip.SetToolTip(btnAdicionarItem, "Adicionar serviço ao orçamento.");
            toolTip.SetToolTip(btnRemoverItem, "Remover o item selecionado. Atalho: Del no grid.");
            toolTip.SetToolTip(btnCriarOrcamento, "Criar orçamento. Atalho: Ctrl + S.");
            toolTip.SetToolTip(btnLimpar, "Limpar orçamento atual. Atalho: Ctrl + N.");
            toolTip.SetToolTip(btnCancelar, "Cancelar orçamento atual. Atalho: Esc.");
        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarServicos();
            AtualizarListaItens();
            cmbCliente.Focus();
        }

        private void CarregarClientes()
        {
            var clientes = _clienteService.ObterTodos().ToList();
            cmbCliente.DataSource = new BindingSource { DataSource = clientes };
            cmbCliente.DisplayMember = nameof(Cliente.Nome);
            cmbCliente.SelectedIndex = -1;
        }

        private void CarregarServicos()
        {
            var servicos = _servicoService.ObterTodos().ToList();
            cmbServico.DataSource = new BindingSource { DataSource = servicos };
            cmbServico.DisplayMember = nameof(Servico.Nome);
            cmbServico.SelectedIndex = -1;
        }

        private void AtualizarListaItens()
        {
            dgvItens.DataSource = new BindingSource
            {
                DataSource = _orcamentoAtual.Itens
                    .Select((item, index) => new ItemOrcamentoExibicao
                    {
                        Index = index,
                        Servico = item.Servico.Nome,
                        Quantidade = item.Quantidade,
                        PrecoUnitario = item.Servico.PrecoUnitario.ToString("C2"),
                        Subtotal = item.Subtotal.ToString("C2")
                    })
                    .ToList()
            };

            lblQuantidadeItens.Text = $"Itens: {_orcamentoAtual.Itens.Count}";
            lblTotalOrcamento.Text = $"Total: {_orcamentoAtual.CalcularTotal():C2}";
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (!ValidarPermissaoAlteracao("adicionar itens ao orçamento"))
                return;

            try
            {
                if (!ValidarCamposItem())
                    return;

                _orcamentoAtual.Cliente = (Cliente)cmbCliente.SelectedItem!;

                var item = new ItemOrcamento
                {
                    Servico = (Servico)cmbServico.SelectedItem!,
                    Quantidade = (int)nudQuantidade.Value
                };

                _orcamentoAtual.Itens.Add(item);
                AtualizarListaItens();

                nudQuantidade.Value = 1;
                cmbServico.SelectedIndex = -1;
                DefinirStatus($"Item adicionado. Total: {_orcamentoAtual.CalcularTotal():C2}", _sucesso);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao adicionar item. Tente novamente.", ex);
            }
        }

        private bool ValidarCamposItem()
        {
            errorProvider.Clear();
            var valido = true;

            if (cmbCliente.SelectedItem == null)
            {
                errorProvider.SetError(cmbCliente, "Selecione um cliente.");
                cmbCliente.BackColor = _erroCampo;
                valido = false;
            }
            else
            {
                cmbCliente.BackColor = Color.White;
            }

            if (cmbServico.SelectedItem == null)
            {
                errorProvider.SetError(cmbServico, "Selecione um serviço.");
                cmbServico.BackColor = _erroCampo;
                valido = false;
            }
            else
            {
                cmbServico.BackColor = Color.White;
            }

            if (nudQuantidade.Value <= 0)
            {
                errorProvider.SetError(nudQuantidade, "Quantidade deve ser maior que zero.");
                valido = false;
            }

            if (!valido)
            {
                MessageBox.Show("Preencha os campos obrigatórios do item.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus("Preencha os campos obrigatórios do item.", ColorTranslator.FromHtml("#DC2626"));
            }

            return valido;
        }

        private void btnCriarOrcamento_Click(object sender, EventArgs e)
        {
            if (!ValidarPermissaoAlteracao("criar orçamentos"))
                return;

            try
            {
                if (cmbCliente.SelectedItem is Cliente cliente)
                    _orcamentoAtual.Cliente = cliente;

                _orcamentoService.Criar(_orcamentoAtual, _usuarioLogado);

                MessageBox.Show(
                    $"Orçamento criado com sucesso!\nID: {_orcamentoAtual.Id}\nTotal: {_orcamentoAtual.CalcularTotal():C2}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DefinirStatus("Orçamento criado com sucesso.", _sucesso);
                ReiniciarOrcamento();
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
                ExibirErro("Erro ao criar orçamento. Tente novamente.", ex);
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverItemSelecionado();
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvItens.Columns[e.ColumnIndex].Name == "btnRemoverGrid")
                RemoverItemSelecionado();
        }

        private void RemoverItemSelecionado()
        {
            if (!ValidarPermissaoAlteracao("remover itens do orçamento"))
                return;

            if (dgvItens.CurrentRow?.DataBoundItem is not ItemOrcamentoExibicao item)
            {
                MessageBox.Show("Selecione um item para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (item.Index < 0 || item.Index >= _orcamentoAtual.Itens.Count)
                return;

            _orcamentoAtual.Itens.RemoveAt(item.Index);
            AtualizarListaItens();
            DefinirStatus("Item removido do orçamento.", _cinzaTexto);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ReiniciarOrcamento();
            DefinirStatus("Orçamento limpo.", _cinzaTexto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarOrcamento();
            DefinirStatus("Operação cancelada.", _cinzaTexto);
        }

        private void ReiniciarOrcamento()
        {
            if (!_usuarioLogado.PodeAlterarDados)
                return;

            _orcamentoAtual = new Orcamento();
            errorProvider.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;
            nudQuantidade.Value = 1;
            cmbCliente.BackColor = Color.White;
            cmbServico.BackColor = Color.White;
            AtualizarListaItens();
            cmbCliente.Focus();
        }

        private void CampoOrcamento_Changed(object? sender, EventArgs e)
        {
            errorProvider.SetError(cmbCliente, string.Empty);
            errorProvider.SetError(cmbServico, string.Empty);
            cmbCliente.BackColor = Color.White;
            cmbServico.BackColor = Color.White;
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
        }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DefinirStatus(string mensagem, Color cor)
        {
            lblStatus.ForeColor = cor;
            lblStatus.Text = mensagem;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnCriarOrcamento_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                ReiniciarOrcamento();
                DefinirStatus("Novo orçamento iniciado.", _cinzaTexto);
                return true;
            }

            if (keyData == Keys.Delete && dgvItens.ContainsFocus)
            {
                RemoverItemSelecionado();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                ReiniciarOrcamento();
                DefinirStatus("Operação cancelada.", _cinzaTexto);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private sealed class ItemOrcamentoExibicao
        {
            public int Index { get; set; }
            public string Servico { get; set; } = string.Empty;
            public int Quantidade { get; set; }
            public string PrecoUnitario { get; set; } = string.Empty;
            public string Subtotal { get; set; } = string.Empty;
        }
    }
}
