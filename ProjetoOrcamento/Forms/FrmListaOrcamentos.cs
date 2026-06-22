using ProjetoOrcamento.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmListaOrcamentos : Form
    {
        private readonly Color _azulPrincipal = ColorTranslator.FromHtml("#1E3A8A");
        private readonly Color _cinzaTexto = ColorTranslator.FromHtml("#374151");
        private readonly Color _sucesso = ColorTranslator.FromHtml("#16A34A");
        private readonly OrcamentoService _orcamentoService = new();

        public FrmListaOrcamentos()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            ConfigurarFiltroStatus();
            ConfigurarToolTips();
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
            dgvOrcamentos.AutoGenerateColumns = false;
            dgvOrcamentos.Columns.Clear();

            dgvOrcamentos.ColumnHeadersDefaultCellStyle.BackColor = _azulPrincipal;
            dgvOrcamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrcamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrcamentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvOrcamentos.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvOrcamentos.DefaultCellStyle.BackColor = Color.White;
            dgvOrcamentos.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111827");
            dgvOrcamentos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#DBEAFE");
            dgvOrcamentos.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#111827");
            dgvOrcamentos.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F4F6");
            dgvOrcamentos.RowTemplate.Height = 38;
            dgvOrcamentos.DataBindingComplete += dgvOrcamentos_DataBindingComplete;

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.Id),
                HeaderText = "ID",
                Name = "colId",
                Visible = false
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.ClienteNome),
                HeaderText = "Cliente",
                Name = "colCliente",
                FillWeight = 160
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.Total),
                HeaderText = "Total",
                Name = "colTotal",
                FillWeight = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.Status),
                HeaderText = "Status",
                Name = "colStatus",
                FillWeight = 85
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.NumeroPedido),
                HeaderText = "Nº Pedido",
                Name = "colPedido",
                FillWeight = 85
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.MotivoRejeicao),
                HeaderText = "Motivo rejeição",
                Name = "colMotivo",
                FillWeight = 170
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(OrcamentoExibicao.DataCriacao),
                HeaderText = "Data criação",
                Name = "colData",
                FillWeight = 105
            });
        }

        private void ConfigurarFiltroStatus()
        {
            cmbStatusFiltro.DataSource = new List<StatusFiltroItem>
            {
                new("Todos", null),
                new("Pendentes", StatusOrcamento.Pendente),
                new("Aprovados", StatusOrcamento.Aprovado),
                new("Rejeitados", StatusOrcamento.Rejeitado)
            };
            cmbStatusFiltro.DisplayMember = nameof(StatusFiltroItem.Descricao);
        }

        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(txtPesquisa, "Pesquise por cliente, status, número do pedido ou motivo.");
            toolTip.SetToolTip(cmbStatusFiltro, "Filtre os orçamentos por status.");
            toolTip.SetToolTip(btnAprovar, "Aprovar o orçamento selecionado.");
            toolTip.SetToolTip(btnRejeitar, "Rejeitar o orçamento selecionado.");
            toolTip.SetToolTip(btnAtualizar, "Atualizar lista. Atalho: Ctrl + R.");
            toolTip.SetToolTip(btnFechar, "Fechar esta tela. Atalho: Esc.");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregarOrcamentos();
        }

        private void CarregarOrcamentos()
        {
            try
            {
                MostrarCarregamento(true);

                var dados = _orcamentoService
                    .Pesquisar(txtPesquisa.Text.Trim(), ObterStatusSelecionado())
                    .Select(MapearParaExibicao)
                    .ToList();

                dgvOrcamentos.DataSource = new BindingSource { DataSource = dados };
                AtualizarResumo(dados);
                DefinirStatus("Lista de orçamentos atualizada.", _cinzaTexto);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao carregar orçamentos. Tente novamente.", ex);
            }
            finally
            {
                MostrarCarregamento(false);
            }
        }

        private StatusOrcamento? ObterStatusSelecionado()
        {
            return (cmbStatusFiltro.SelectedItem as StatusFiltroItem)?.Status;
        }

        private static OrcamentoExibicao MapearParaExibicao(Orcamento orcamento)
        {
            return new OrcamentoExibicao
            {
                Id = orcamento.Id,
                ClienteNome = orcamento.Cliente?.Nome ?? "N/A",
                Total = orcamento.CalcularTotal().ToString("C2"),
                TotalValor = orcamento.CalcularTotal(),
                Status = orcamento.Status.ToString(),
                NumeroPedido = orcamento.NumeroPedido > 0 ? orcamento.NumeroPedido.ToString() : "-",
                MotivoRejeicao = string.IsNullOrWhiteSpace(orcamento.MotivoRejeicao) ? "-" : orcamento.MotivoRejeicao,
                DataCriacao = orcamento.DataCriacao.ToString("dd/MM/yyyy HH:mm")
            };
        }

        private void AtualizarResumo(IReadOnlyCollection<OrcamentoExibicao> dados)
        {
            var totalRegistros = _orcamentoService.ObterTodos().Count;
            var totalValor = dados.Sum(orcamento => orcamento.TotalValor);

            lblQuantidadeRegistros.Text = dados.Count == totalRegistros
                ? $"Quantidade de registros: {totalRegistros}"
                : $"Quantidade de registros: {dados.Count} de {totalRegistros}";
            lblValorTotal.Text = $"Valor total: {totalValor:C2}";
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            try
            {
                var orcamento = ObterOrcamentoSelecionado("aprovar");

                if (orcamento == null)
                    return;

                _orcamentoService.Aprovar(orcamento);

                MessageBox.Show(
                    $"Orçamento aprovado com sucesso!\nNº do Pedido: {orcamento.NumeroPedido}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DefinirStatus("Orçamento aprovado com sucesso.", _sucesso);
                CarregarOrcamentos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(ex.Message, ColorTranslator.FromHtml("#DC2626"));
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao aprovar orçamento. Tente novamente.", ex);
            }
        }

        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            try
            {
                var orcamento = ObterOrcamentoSelecionado("rejeitar");

                if (orcamento == null)
                    return;

                var motivo = PromptMotivo();

                if (motivo == null)
                    return;

                _orcamentoService.Rejeitar(orcamento, motivo);

                MessageBox.Show("Orçamento rejeitado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefinirStatus("Orçamento rejeitado com sucesso.", _sucesso);
                CarregarOrcamentos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefinirStatus(ex.Message, ColorTranslator.FromHtml("#DC2626"));
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao rejeitar orçamento. Tente novamente.", ex);
            }
        }

        private Orcamento? ObterOrcamentoSelecionado(string acao)
        {
            if (dgvOrcamentos.CurrentRow?.DataBoundItem is not OrcamentoExibicao itemExibicao)
            {
                MessageBox.Show($"Selecione um orçamento para {acao}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var orcamento = _orcamentoService.ObterPorId(itemExibicao.Id);

            if (orcamento != null)
                return orcamento;

            MessageBox.Show("Orçamento não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private string? PromptMotivo()
        {
            using var form = new Form
            {
                Text = "Motivo da rejeição",
                Width = 460,
                Height = 240,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = ColorTranslator.FromHtml("#F5F5F5"),
                Font = new Font("Segoe UI", 10F),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var label = new Label
            {
                Left = 22,
                Top = 18,
                Width = 400,
                Height = 26,
                Text = "Informe o motivo da rejeição:",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#111827")
            };

            var textBox = new TextBox
            {
                Left = 22,
                Top = 52,
                Width = 400,
                Height = 76,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            var okButton = new ModernButton
            {
                Text = "✔ Confirmar",
                Left = 178,
                Width = 116,
                Top = 148,
                Height = 38,
                DialogResult = DialogResult.OK,
                NormalBackColor = ColorTranslator.FromHtml("#16A34A"),
                HoverBackColor = ColorTranslator.FromHtml("#15803D"),
                PressedBackColor = ColorTranslator.FromHtml("#166534")
            };

            var cancelButton = new ModernButton
            {
                Text = "❌ Cancelar",
                Left = 306,
                Width = 116,
                Top = 148,
                Height = 38,
                DialogResult = DialogResult.Cancel,
                NormalBackColor = ColorTranslator.FromHtml("#F59E0B"),
                HoverBackColor = ColorTranslator.FromHtml("#D97706"),
                PressedBackColor = ColorTranslator.FromHtml("#B45309")
            };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(okButton);
            form.Controls.Add(cancelButton);
            form.AcceptButton = okButton;
            form.CancelButton = cancelButton;

            if (form.ShowDialog(this) != DialogResult.OK)
                return null;

            if (!string.IsNullOrWhiteSpace(textBox.Text))
                return textBox.Text.Trim();

            MessageBox.Show("Informe o motivo da rejeição.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void Filtros_Changed(object sender, EventArgs e)
        {
            if (!IsHandleCreated)
                return;

            CarregarOrcamentos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarOrcamentos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOrcamentos_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrcamentos.Rows)
            {
                if (row.DataBoundItem is not OrcamentoExibicao orcamento)
                    continue;

                row.DefaultCellStyle.ForeColor = orcamento.Status switch
                {
                    nameof(StatusOrcamento.Aprovado) => ColorTranslator.FromHtml("#166534"),
                    nameof(StatusOrcamento.Rejeitado) => ColorTranslator.FromHtml("#991B1B"),
                    _ => ColorTranslator.FromHtml("#111827")
                };
            }
        }

        private void MostrarCarregamento(bool exibir)
        {
            prgCarregando.Visible = exibir;
            Cursor = exibir ? Cursors.WaitCursor : Cursors.Default;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R) || keyData == Keys.F5)
            {
                CarregarOrcamentos();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private sealed class StatusFiltroItem
        {
            public StatusFiltroItem(string descricao, StatusOrcamento? status)
            {
                Descricao = descricao;
                Status = status;
            }

            public string Descricao { get; }
            public StatusOrcamento? Status { get; }
        }

        private sealed class OrcamentoExibicao
        {
            public Guid Id { get; set; }
            public string ClienteNome { get; set; } = string.Empty;
            public string Total { get; set; } = string.Empty;
            public decimal TotalValor { get; set; }
            public string Status { get; set; } = string.Empty;
            public string NumeroPedido { get; set; } = string.Empty;
            public string MotivoRejeicao { get; set; } = string.Empty;
            public string DataCriacao { get; set; } = string.Empty;
        }
    }
}
