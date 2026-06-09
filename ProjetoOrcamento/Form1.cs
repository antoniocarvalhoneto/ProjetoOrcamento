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
            FrmServicos tela = new FrmServicos();
            tela.ShowDialog();
        }
        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            FrmOrcamentos tela = new FrmOrcamentos();
            tela.ShowDialog();
        }
    }
}
