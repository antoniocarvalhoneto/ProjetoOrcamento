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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                Width = 200
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Contato",
                HeaderText = "Contato",
                Width = 250
            });

            var colEditar = new DataGridViewButtonColumn();
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Name = "btnEditar";
            dgvClientes.Columns.Add(colEditar);

            var colDeletar = new DataGridViewButtonColumn();
            colDeletar.Text = "Deletar";
            colDeletar.UseColumnTextForButtonValue = true;
            colDeletar.Name = "btnDeletar";
            dgvClientes.Columns.Add(colDeletar);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            dgvClientes.DataSource = new BindingSource(Dados.Clientes, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCliente();
        }

        private void CadastrarCliente()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Nome do cliente é obrigatório!", "Validação");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContato.Text))
                {
                    MessageBox.Show("Contato do cliente é obrigatório!", "Validação");
                    return;
                }

                var cliente = new Cliente(txtNome.Text.Trim(), txtContato.Text.Trim());
                Dados.AdicionarCliente(cliente);

                MessageBox.Show($"Cliente '{cliente.Nome}' cadastrado com sucesso!", "Sucesso");

                txtNome.Clear();
                txtContato.Clear();
                txtNome.Focus();

                CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}", "Erro");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvClientes.Columns["btnDeletar"].Index)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar este cliente?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Dados.RemoverCliente(e.RowIndex);
                    CarregarClientes();
                    MessageBox.Show("Cliente deletado com sucesso!", "Sucesso");
                }
            }
            else if (e.ColumnIndex == dgvClientes.Columns["btnEditar"].Index)
            {
                var cliente = Dados.Clientes[e.RowIndex];
                txtNome.Text = cliente.Nome;
                txtContato.Text = cliente.Contato;

                Dados.RemoverCliente(e.RowIndex);
                CarregarClientes();
            }
        }
    }
}
