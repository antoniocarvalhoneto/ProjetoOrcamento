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
    public partial class FrmOrcamento : Form
    {
        private Orcamento _orcamentoAtual;

        public FrmOrcamento()
        {
            InitializeComponent();
            _orcamentoAtual = new Orcamento();
        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarServicos();
            AtualizarListaItens();
        }

        private void CarregarClientes()
        {
            cmbCliente.DataSource = new BindingSource(Dados.Clientes, null);
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.SelectedIndex = -1;
        }

        private void CarregarServicos()
        {
            cmbServico.DataSource = new BindingSource(Dados.Servicos, null);
            cmbServico.DisplayMember = "Nome";
            cmbServico.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AtualizarListaItens()
        {
            lstItens.Items.Clear();
            foreach (var item in _orcamentoAtual.Itens)
            {
                lstItens.Items.Add($"{item.Servico.Nome} - Qty: {item.Quantidade} - Subtotal: R$ {item.Subtotal:F2}");
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um cliente.", "Validação");
                    return;
                }

                if (cmbServico.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um serviço.", "Validação");
                    return;
                }

                if (nudQuantidade.Value <= 0)
                {
                    MessageBox.Show("Quantidade deve ser maior que zero.", "Validação");
                    return;
                }

                _orcamentoAtual.Cliente = (Cliente)cmbCliente.SelectedItem;

                var item = new ItemOrcamento
                {
                    Servico = (Servico)cmbServico.SelectedItem,
                    Quantidade = (int)nudQuantidade.Value
                };

                _orcamentoAtual.Itens.Add(item);
                AtualizarListaItens();

                nudQuantidade.Value = 1;
                cmbServico.SelectedIndex = -1;

                MessageBox.Show($"Item adicionado! Total: R$ {_orcamentoAtual.CalcularTotal():F2}", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar item: {ex.Message}", "Erro");
            }
        }

        private void btnCriarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (_orcamentoAtual.Cliente == null)
                {
                    MessageBox.Show("Selecione um cliente.", "Validação");
                    return;
                }

                if (_orcamentoAtual.Itens.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um item ao orçamento.", "Validação");
                    return;
                }

                Dados.AdicionarOrcamento(_orcamentoAtual);

                MessageBox.Show(
                    $"Orçamento criado com sucesso!\nID: {_orcamentoAtual.Id}\nTotal: R$ {_orcamentoAtual.CalcularTotal():F2}",
                    "Sucesso"
                );

                // Limpar formulário
                _orcamentoAtual = new Orcamento();
                AtualizarListaItens();
                cmbCliente.SelectedIndex = -1;
                cmbServico.SelectedIndex = -1;
                nudQuantidade.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar orçamento: {ex.Message}", "Erro");
            }
        }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
