using ProjetoOrcamento.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmServicoss : Form
    {
        private readonly Color _azulPrincipal = ColorTranslator.FromHtml("#1E3A8A");
        private readonly Color _cinzaTexto = ColorTranslator.FromHtml("#374151");
        private readonly Color _erroCampo = ColorTranslator.FromHtml("#FEF2F2");
        private readonly Color _sucesso = ColorTranslator.FromHtml("#16A34A");
        private readonly ServicoService _servicoService = new();

        private int _servicoEmEdicaoIndex = -1;

        public FrmServicoss()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            ConfigurarToolTips();
            DefinirModoEdicao(false);
        }

        private void ConfigurarFormulario()
        {
            lblUsuario.Text = $"Usuário: {Environment.UserName}";
            AtualizarRelogio();

            tmrRelogio.Interval = 1000;
            tmrRelogio.Tick += (_, _) => AtualizarRelogio();
            tmrRelogio.Start();
        }

        private void ConfigurarDataGridView()
        {
            dgvServicos.AutoGenerateColumns = false;
            dgvServicos.Columns.Clear();

            dgvServicos.ColumnHeadersDefaultCellStyle.BackColor = _azulPrincipal;
            dgvServicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvServicos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvServicos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvServicos.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvServicos.DefaultCellStyle.BackColor = Color.White;
            dgvServicos.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111827");
            dgvServicos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            dgvServicos.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#111827");
            dgvServicos.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F4F6");
            dgvServicos.RowTemplate.Height = 38;

            dgvServicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Servico.Nome),
                HeaderText = "Serviço",
                Name = "colNome",
                FillWeight = 190
            });

            dgvServicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Servico.PrecoUnitario),
                HeaderText = "Preço",
                Name = "colPreco",
                FillWeight = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvServicos.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnEditarGrid",
                Text = "✏️",
                ToolTipText = "Editar serviço",
                UseColumnTextForButtonValue = true,
                FillWeight = 35,
                FlatStyle = FlatStyle.Flat
            });

            dgvServicos.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnDeletar",
                Text = "🗑",
                ToolTipText = "Excluir serviço",
                UseColumnTextForButtonValue = true,
                FillWeight = 35,
                FlatStyle = FlatStyle.Flat
            });

            dgvServicos.Columns["btnEditarGrid"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicos.Columns["btnDeletar"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(txtNomeServico, "Informe o nome do serviço.");
            toolTip.SetToolTip(txtPreco, "Informe o preço do serviço.");
            toolTip.SetToolTip(txtPesquisa, "Pesquise instantaneamente por serviço ou valor.");
            toolTip.SetToolTip(btnCadastrarServico, "Salvar serviço. Atalho: Ctrl + S.");
            toolTip.SetToolTip(btnEditar, "Editar o serviço selecionado.");
            toolTip.SetToolTip(btnLimpar, "Limpar o formulário. Atalho: Ctrl + N.");
            toolTip.SetToolTip(btnExcluir, "Excluir o serviço selecionado. Atalho: Del no grid.");
            toolTip.SetToolTip(btnCancelar, "Cancelar a edição atual. Atalho: Esc.");
            toolTip.SetToolTip(dgvServicos, "Clique duas vezes para editar ou use os botões da linha.");
        }

        private void FrmServicoss_Load(object sender, EventArgs e)
        {
            CarregarServicos();
            txtNomeServico.Focus();
        }

        private void CarregarServicos()
        {
            try
            {
                MostrarCarregamento(true);

                var servicos = _servicoService.Pesquisar(txtPesquisa.Text.Trim()).ToList();
                dgvServicos.DataSource = new BindingSource { DataSource = servicos };
                AtualizarResumo(servicos.Count);
                DefinirStatus("Lista de serviços atualizada.", _cinzaTexto);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao carregar serviços. Tente novamente.", ex);
            }
            finally
            {
                MostrarCarregamento(false);
            }
        }

        private void SalvarRegistro()
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var servico = MontarObjeto();
                _servicoService.Salvar(servico, _servicoEmEdicaoIndex);

                var mensagem = _servicoEmEdicaoIndex >= 0
                    ? "Registro atualizado com sucesso."
                    : "Registro salvo com sucesso.";

                DefinirStatus(mensagem, _sucesso);
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarServicos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(ex.Message, ColorTranslator.FromHtml("#DC2626"));
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao salvar. Tente novamente.", ex);
            }
        }

        private Servico MontarObjeto()
        {
            return new Servico(txtNomeServico.Text.Trim(), ObterPreco());
        }

        private bool ValidarCampos(bool exibirMensagem = true)
        {
            var mensagens = new List<string>();
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNomeServico.Text))
            {
                txtNomeServico.BackColor = _erroCampo;
                errorProvider.SetError(txtNomeServico, "Informe o nome do serviço.");
                mensagens.Add("Informe o nome do serviço.");
            }
            else
            {
                txtNomeServico.BackColor = Color.White;
            }

            if (!TentarObterPreco(out var preco) || preco <= 0)
            {
                txtPreco.BackColor = _erroCampo;
                errorProvider.SetError(txtPreco, "Informe um preço maior que zero.");
                mensagens.Add("Informe um preço maior que zero.");
            }
            else
            {
                txtPreco.BackColor = Color.White;
            }

            var valido = mensagens.Count == 0;

            if (!valido && exibirMensagem)
            {
                MessageBox.Show(mensagens[0], "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(mensagens[0], ColorTranslator.FromHtml("#DC2626"));
            }

            return valido;
        }

        private decimal ObterPreco()
        {
            TentarObterPreco(out var preco);
            return preco;
        }

        private bool TentarObterPreco(out decimal preco)
        {
            var texto = txtPreco.Text.Trim();

            return decimal.TryParse(texto, NumberStyles.Currency, CultureInfo.CurrentCulture, out preco)
                || decimal.TryParse(texto, NumberStyles.Currency, CultureInfo.InvariantCulture, out preco);
        }

        private void EditarServicoSelecionado()
        {
            var servico = ObterServicoSelecionado();

            if (servico == null)
            {
                MessageBox.Show("Selecione um serviço para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelecionarServicoParaEdicao(servico);
        }

        private void SelecionarServicoParaEdicao(Servico servico)
        {
            var index = _servicoService.ObterIndex(servico);

            if (index < 0)
            {
                MessageBox.Show("Não foi possível localizar o serviço selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _servicoEmEdicaoIndex = index;
            txtNomeServico.Text = servico.Nome;
            txtPreco.Text = servico.PrecoUnitario.ToString("N2");

            DefinirModoEdicao(true);
            txtNomeServico.Focus();
        }

        private void ExcluirServicoSelecionado()
        {
            var servico = ObterServicoSelecionado();

            if (servico == null)
            {
                MessageBox.Show("Selecione um serviço para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExcluirServico(servico);
        }

        private void ExcluirServico(Servico servico)
        {
            try
            {
                var confirmacao = MessageBox.Show(
                    $"Deseja realmente excluir o serviço '{servico.Nome}'?",
                    "Confirmar exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (confirmacao != DialogResult.Yes)
                    return;

                _servicoService.Remover(servico);
                LimparCampos();
                CarregarServicos();

                DefinirStatus("Registro excluído com sucesso.", _sucesso);
                MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao excluir. Tente novamente.", ex);
            }
        }

        private Servico? ObterServicoSelecionado()
        {
            return dgvServicos.CurrentRow?.DataBoundItem as Servico;
        }

        private void LimparCampos()
        {
            _servicoEmEdicaoIndex = -1;
            txtNomeServico.Clear();
            txtPreco.Clear();
            errorProvider.Clear();
            txtNomeServico.BackColor = Color.White;
            txtPreco.BackColor = Color.White;
            DefinirModoEdicao(false);
            txtNomeServico.Focus();
        }

        private void CancelarEdicao()
        {
            LimparCampos();
            DefinirStatus("Operação cancelada.", _cinzaTexto);
        }

        private void DefinirModoEdicao(bool editando)
        {
            btnCadastrarServico.Text = editando ? "💾 Atualizar" : "💾 Salvar";
            btnCancelar.Enabled = editando;
            lblStatus.Text = editando ? "Editando registro selecionado." : "Pronto.";
        }

        private void AtualizarResumo(int quantidadeFiltrada)
        {
            var servicos = _servicoService.ObterTodos();
            var total = servicos.Sum(servico => servico.PrecoUnitario);

            lblQuantidadeRegistros.Text = quantidadeFiltrada == servicos.Count
                ? $"Quantidade de registros: {servicos.Count}"
                : $"Quantidade de registros: {quantidadeFiltrada} de {servicos.Count}";
            lblValorTotal.Text = $"Valor total: {total:C2}";
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

        private void Campo_TextChanged(object? sender, EventArgs e)
        {
            ValidarCampos(false);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarServicos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarServicoSelecionado();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DefinirStatus("Campos limpos.", _cinzaTexto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirServicoSelecionado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarEdicao();
        }

        private void dgvServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvServicos.Rows[e.RowIndex].DataBoundItem is Servico servico)
                SelecionarServicoParaEdicao(servico);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvServicos.Rows[e.RowIndex].DataBoundItem is not Servico servico)
                return;

            if (dgvServicos.Columns[e.ColumnIndex].Name == "btnDeletar")
            {
                ExcluirServico(servico);
                return;
            }

            if (dgvServicos.Columns[e.ColumnIndex].Name == "btnEditarGrid")
                SelecionarServicoParaEdicao(servico);
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
        }

        private void lblPreco_Click(object sender, EventArgs e)
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

            if (keyData == Keys.Delete && dgvServicos.ContainsFocus)
            {
                ExcluirServicoSelecionado();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
