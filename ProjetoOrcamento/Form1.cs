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
            FrmServicoss tela = new FrmServicoss();
            tela.ShowDialog();
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            FrmOrcamento tela = new FrmOrcamento();
            tela.ShowDialog();
        }

        private void btnListarOrcamentos_Click(object sender, EventArgs e)
        {
            FrmListaOrcamentos tela = new FrmListaOrcamentos();
            tela.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
