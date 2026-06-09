using ProjetoOrcamento.Forms;
using System;
using System.Windows.Forms;

namespace ProjetoOrcamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir cadastro de serviços", "Serviços", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir cadastro de orçamentos", "Orçamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
