using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoOrcamento.Deita;

namespace ProjetoOrcamento.Forms
{
    public partial class FrmListaOrcamentos : Form
    {
        private List<Orcamento> _orcamentosOriginais;

        public FrmListaOrcamentos()
        {
            InitializeComponent();
            _orcamentosOriginais = new List<Orcamento>();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvOrcamentos.AutoGenerateColumns = false;
            dgvOrcamentos.Columns.Clear();
            dgvOrcamentos.AllowUserToAddRows = false;

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 200,
                Visible = false
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClienteNome",
                HeaderText = "Cliente",
                Width = 150
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Width = 100
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroPedido",
                HeaderText = "Nº Pedido",
                Width = 80
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MotivoRejeicao",
                HeaderText = "Motivo Rejeição",
                Width = 200
            });

            dgvOrcamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCriacao",
                HeaderText = "Data Criação",
                Width = 120
            });
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregarOrcamentos();
        }

        private void CarregarOrcamentos()
        {
            _orcamentosOriginais = new List<Orcamento>(Dados.Orcamentos);
            dgvOrcamentos.DataSource = null;

            var dados = new List<OrcamentoExibicao>();

            foreach (var orcamento in _orcamentosOriginais)
            {
                dados.Add(new OrcamentoExibicao
                {
                    Id = orcamento.Id,
                    ClienteNome = orcamento.Cliente?.Nome ?? "N/A",
                    Total = $"R$ {orcamento.CalcularTotal():F2}",
                    Status = orcamento.Status.ToString(),
                    NumeroPedido = orcamento.NumeroPedido?.ToString() ?? "-",
                    MotivoRejeicao = orcamento.MotivoRejeicao ?? "-",
                    DataCriacao = orcamento.DataCriacao.ToString("dd/MM/yyyy HH:mm")
                });
            }

            dgvOrcamentos.DataSource = dados;
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrcamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um orçamento para aprovar.", "Validação");
                    return;
                }

                var row = dgvOrcamentos.SelectedRows[0];
                var itemExibicao = (OrcamentoExibicao)row.DataBoundItem;

                if (itemExibicao == null)
                {
                    MessageBox.Show("Erro ao obter orçamento selecionado.", "Erro");
                    return;
                }

                var orcamento = Dados.ObterOrcamento(itemExibicao.Id);

                if (orcamento == null)
                {
                    MessageBox.Show("Orçamento não encontrado.", "Erro");
                    return;
                }

                if (orcamento.Status != StatusOrcamento.Pendente)
                {
                    MessageBox.Show($"Orçamento já foi {orcamento.Status.ToString().ToLower()}.", "Validação");
                    return;
                }

                orcamento.Aprovar();
                Dados.AtualizarOrcamento(orcamento);

                MessageBox.Show(
                    $"Orçamento aprovado com sucesso!\nNº do Pedido: {orcamento.NumeroPedido}",
                    "Sucesso"
                );

                CarregarOrcamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aprovar orçamento: {ex.Message}", "Erro");
            }
        }

        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrcamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um orçamento para rejeitar.", "Validação");
                    return;
                }

                var row = dgvOrcamentos.SelectedRows[0];
                var itemExibicao = (OrcamentoExibicao)row.DataBoundItem;

                if (itemExibicao == null)
                {
                    MessageBox.Show("Erro ao obter orçamento selecionado.", "Erro");
                    return;
                }

                var orcamento = Dados.ObterOrcamento(itemExibicao.Id);

                if (orcamento == null)
                {
                    MessageBox.Show("Orçamento não encontrado.", "Erro");
                    return;
                }

                if (orcamento.Status != StatusOrcamento.Pendente)
                {
                    MessageBox.Show($"Orçamento já foi {orcamento.Status.ToString().ToLower()}.", "Validação");
                    return;
                }

                var motivo = PromptMotivo();
                if (motivo == null)
                    return;

                orcamento.Rejeitar(motivo);
                Dados.AtualizarOrcamento(orcamento);

                MessageBox.Show("Orçamento rejeitado com sucesso!", "Sucesso");
                CarregarOrcamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao rejeitar orçamento: {ex.Message}", "Erro");
            }
        }

        private string PromptMotivo()
        {
            var form = new Form
            {
                Text = "Motivo da Rejeição",
                Width = 400,
                Height = 180,
                StartPosition = FormStartPosition.CenterParent
            };

            var label = new Label { Left = 20, Top = 20, Text = "Motivo:", Width = 300 };
            var textBox = new TextBox { Left = 20, Top = 50, Width = 340, Height = 50, Multiline = true };
            var okButton = new Button { Text = "OK", Left = 220, Width = 80, Top = 110, DialogResult = DialogResult.OK };
            var cancelButton = new Button { Text = "Cancelar", Left = 310, Width = 80, Top = 110, DialogResult = DialogResult.Cancel };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(okButton);
            form.Controls.Add(cancelButton);

            form.AcceptButton = okButton;
            form.CancelButton = cancelButton;

            if (form.ShowDialog() == DialogResult.OK)
                return textBox.Text;

            return null;
        }

        private class OrcamentoExibicao
        {
            public Guid Id { get; set; }
            public string? ClienteNome { get; set; }
            public string? Total { get; set; }
            public string? Status { get; set; }
            public string? NumeroPedido { get; set; }
            public string? MotivoRejeicao { get; set; }
            public string? DataCriacao { get; set; }
        }
    }
}
