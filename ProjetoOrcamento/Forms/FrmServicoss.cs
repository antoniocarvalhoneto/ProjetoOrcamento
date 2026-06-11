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
    public partial class FrmServicoss : Form
    {
        public FrmServicoss()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvServicos.AutoGenerateColumns = false;
            dgvServicos.Columns.Clear();

            dgvServicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                Width = 200
            });

            dgvServicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecoUnitario",
                HeaderText = "Preço",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            var colEditar = new DataGridViewButtonColumn();
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Name = "btnEditar";
            dgvServicos.Columns.Add(colEditar);

            var colDeletar = new DataGridViewButtonColumn();
            colDeletar.Text = "Deletar";
            colDeletar.UseColumnTextForButtonValue = true;
            colDeletar.Name = "btnDeletar";
            dgvServicos.Columns.Add(colDeletar);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmServicoss_Load(object sender, EventArgs e)
        {
            CarregarServicos();
        }

        private void CarregarServicos()
        {
            dgvServicos.DataSource = new BindingSource(Dados.Servicos, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvServicos.Columns["btnDeletar"].Index)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar este serviço?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Dados.RemoverServico(e.RowIndex);
                    CarregarServicos();
                    MessageBox.Show("Serviço deletado com sucesso!", "Sucesso");
                }
            }
            else if (e.ColumnIndex == dgvServicos.Columns["btnEditar"].Index)
            {
                var servico = Dados.Servicos[e.RowIndex];
                txtNomeServico.Text = servico.Nome;
                txtPreco.Text = servico.PrecoUnitario.ToString("F2");

                Dados.RemoverServico(e.RowIndex);
                CarregarServicos();
            }
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            CadastrarServico();
        }

        private void CadastrarServico()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeServico.Text))
                {
                    MessageBox.Show("Nome do serviço é obrigatório!", "Validação");
                    return;
                }

                if (!decimal.TryParse(txtPreco.Text, out var preco))
                {
                    MessageBox.Show("Preço inválido! Use formato numérico (ex: 100,00 ou 100.00)", "Validação");
                    return;
                }

                if (preco <= 0)
                {
                    MessageBox.Show("Preço deve ser maior que zero!", "Validação");
                    return;
                }

                var servico = new Servico(txtNomeServico.Text.Trim(), preco);
                Dados.AdicionarServico(servico);

                MessageBox.Show($"Serviço '{servico.Nome}' cadastrado com sucesso!", "Sucesso");

                txtNomeServico.Clear();
                txtPreco.Clear();
                txtNomeServico.Focus();

                CarregarServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar serviço: {ex.Message}", "Erro");
            }
        }
    }
}
