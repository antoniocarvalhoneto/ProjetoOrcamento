using ProjetoOrcamento.Forms;
using ProjetoOrcamento.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOrcamento
{
    public partial class Form1 : Form
    {
        private readonly ClienteService _clienteService = new();
        private readonly ServicoService _servicoService = new();
        private readonly OrcamentoService _orcamentoService = new();

        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
            AtualizarIndicadores();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            FrmServicoss tela = new FrmServicoss();
            tela.ShowDialog();
            AtualizarIndicadores();
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            FrmOrcamento tela = new FrmOrcamento();
            tela.ShowDialog();
            AtualizarIndicadores();
        }

        private void btnListarOrcamentos_Click(object sender, EventArgs e)
        {
            FrmListaOrcamentos tela = new FrmListaOrcamentos();
            tela.ShowDialog();
            AtualizarIndicadores();
        }

        private void lblTituloSistema_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarIndicadores();
        }

        private void picLogoPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarFormulario()
        {
            lblUsuario.Text = $"Usuário: {Environment.UserName}";
            AtualizarRelogio();

            tmrRelogio.Interval = 1000;
            tmrRelogio.Tick += (_, _) => AtualizarRelogio();
            tmrRelogio.Start();
        }

        private void AtualizarRelogio()
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void AtualizarIndicadores()
        {
            var clientes = _clienteService.ObterTodos().Count;
            var servicos = _servicoService.ObterTodos().Count;
            var orcamentos = _orcamentoService.ObterTodos();
            var total = orcamentos.Sum(orcamento => orcamento.CalcularTotal());

            lblClientesResumo.Text = $"Clientes: {clientes}";
            lblServicosResumo.Text = $"Serviços: {servicos}";
            lblOrcamentosResumo.Text = $"Orçamentos: {orcamentos.Count}";
            lblTotalResumo.Text = $"Total: {total:C2}";
        }
    }
}
