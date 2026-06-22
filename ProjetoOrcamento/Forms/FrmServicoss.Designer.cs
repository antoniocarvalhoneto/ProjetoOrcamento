using System.Drawing;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    partial class FrmServicoss
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            headerLayout = new TableLayoutPanel();
            lblIconeTela = new Label();
            pnlTituloHeader = new Panel();
            lblTituloTela = new Label();
            lblNomeSistema = new Label();
            pnlUsuario = new Panel();
            lblUsuario = new Label();
            lblDataHora = new Label();
            pnlConteudo = new Panel();
            layoutConteudo = new TableLayoutPanel();
            cardDados = new ModernPanel();
            layoutDados = new TableLayoutPanel();
            lblDadosTitulo = new Label();
            gridDados = new TableLayoutPanel();
            lblNomeServico = new Label();
            txtNomeServico = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            cardOperacoes = new ModernPanel();
            layoutOperacoes = new TableLayoutPanel();
            lblOperacoesTitulo = new Label();
            fluxoBotoes = new FlowLayoutPanel();
            btnCadastrarServico = new ModernButton();
            btnEditar = new ModernButton();
            btnLimpar = new ModernButton();
            btnExcluir = new ModernButton();
            btnCancelar = new ModernButton();
            cardLista = new ModernPanel();
            layoutLista = new TableLayoutPanel();
            pnlListaTopo = new Panel();
            lblListaTitulo = new Label();
            txtPesquisa = new TextBox();
            prgCarregando = new ProgressBar();
            dgvServicos = new DataGridView();
            cardResumo = new ModernPanel();
            layoutResumo = new TableLayoutPanel();
            lblQuantidadeRegistros = new Label();
            lblValorTotal = new Label();
            lblStatus = new Label();
            toolTip = new ToolTip(components);
            errorProvider = new ErrorProvider(components);
            tmrRelogio = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            headerLayout.SuspendLayout();
            pnlTituloHeader.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlConteudo.SuspendLayout();
            layoutConteudo.SuspendLayout();
            cardDados.SuspendLayout();
            layoutDados.SuspendLayout();
            gridDados.SuspendLayout();
            cardOperacoes.SuspendLayout();
            layoutOperacoes.SuspendLayout();
            fluxoBotoes.SuspendLayout();
            cardLista.SuspendLayout();
            layoutLista.SuspendLayout();
            pnlListaTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            cardResumo.SuspendLayout();
            layoutResumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = ColorTranslator.FromHtml("#1E3A8A");
            pnlHeader.Controls.Add(headerLayout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 10, 24, 10);
            pnlHeader.Size = new Size(1184, 74);
            pnlHeader.TabIndex = 0;
            // 
            // headerLayout
            // 
            headerLayout.ColumnCount = 3;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            headerLayout.Controls.Add(lblIconeTela, 0, 0);
            headerLayout.Controls.Add(pnlTituloHeader, 1, 0);
            headerLayout.Controls.Add(pnlUsuario, 2, 0);
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.Location = new Point(24, 10);
            headerLayout.Name = "headerLayout";
            headerLayout.RowCount = 1;
            headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerLayout.Size = new Size(1136, 54);
            headerLayout.TabIndex = 0;
            // 
            // lblIconeTela
            // 
            lblIconeTela.BackColor = ColorTranslator.FromHtml("#2563EB");
            lblIconeTela.Dock = DockStyle.Fill;
            lblIconeTela.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblIconeTela.ForeColor = Color.White;
            lblIconeTela.Location = new Point(0, 0);
            lblIconeTela.Margin = new Padding(0, 0, 12, 0);
            lblIconeTela.Name = "lblIconeTela";
            lblIconeTela.Size = new Size(42, 54);
            lblIconeTela.TabIndex = 0;
            lblIconeTela.Text = "🧾";
            lblIconeTela.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTituloHeader
            // 
            pnlTituloHeader.Controls.Add(lblTituloTela);
            pnlTituloHeader.Controls.Add(lblNomeSistema);
            pnlTituloHeader.Dock = DockStyle.Fill;
            pnlTituloHeader.Location = new Point(54, 0);
            pnlTituloHeader.Margin = new Padding(0);
            pnlTituloHeader.Name = "pnlTituloHeader";
            pnlTituloHeader.Size = new Size(782, 54);
            pnlTituloHeader.TabIndex = 1;
            // 
            // lblTituloTela
            // 
            lblTituloTela.Dock = DockStyle.Top;
            lblTituloTela.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloTela.ForeColor = Color.White;
            lblTituloTela.Location = new Point(0, 0);
            lblTituloTela.Name = "lblTituloTela";
            lblTituloTela.Size = new Size(782, 30);
            lblTituloTela.TabIndex = 0;
            lblTituloTela.Text = "Serviços";
            lblTituloTela.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNomeSistema
            // 
            lblNomeSistema.Dock = DockStyle.Top;
            lblNomeSistema.Font = new Font("Segoe UI", 9.5F);
            lblNomeSistema.ForeColor = ColorTranslator.FromHtml("#DBEAFE");
            lblNomeSistema.Location = new Point(0, 30);
            lblNomeSistema.Name = "lblNomeSistema";
            lblNomeSistema.Size = new Size(782, 22);
            lblNomeSistema.TabIndex = 1;
            lblNomeSistema.Text = "Projeto Orçamento";
            lblNomeSistema.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(lblUsuario);
            pnlUsuario.Controls.Add(lblDataHora);
            pnlUsuario.Dock = DockStyle.Fill;
            pnlUsuario.Location = new Point(836, 0);
            pnlUsuario.Margin = new Padding(0);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(300, 54);
            pnlUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(0, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(300, 27);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário: -";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDataHora
            // 
            lblDataHora.Dock = DockStyle.Top;
            lblDataHora.Font = new Font("Segoe UI", 9.5F);
            lblDataHora.ForeColor = ColorTranslator.FromHtml("#DBEAFE");
            lblDataHora.Location = new Point(0, 27);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(300, 24);
            lblDataHora.TabIndex = 1;
            lblDataHora.Text = "--/--/---- --:--";
            lblDataHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlConteudo
            // 
            pnlConteudo.AutoScroll = true;
            pnlConteudo.BackColor = ColorTranslator.FromHtml("#F5F5F5");
            pnlConteudo.Controls.Add(layoutConteudo);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 74);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Padding = new Padding(22);
            pnlConteudo.Size = new Size(1184, 687);
            pnlConteudo.TabIndex = 1;
            // 
            // layoutConteudo
            // 
            layoutConteudo.AutoSize = true;
            layoutConteudo.ColumnCount = 1;
            layoutConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutConteudo.Controls.Add(cardDados, 0, 0);
            layoutConteudo.Controls.Add(cardOperacoes, 0, 1);
            layoutConteudo.Controls.Add(cardLista, 0, 2);
            layoutConteudo.Controls.Add(cardResumo, 0, 3);
            layoutConteudo.Dock = DockStyle.Top;
            layoutConteudo.Location = new Point(22, 22);
            layoutConteudo.Name = "layoutConteudo";
            layoutConteudo.RowCount = 4;
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 390F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            layoutConteudo.Size = new Size(1140, 726);
            layoutConteudo.TabIndex = 0;
            // 
            // cardDados
            // 
            cardDados.Controls.Add(layoutDados);
            cardDados.Dock = DockStyle.Fill;
            cardDados.Location = new Point(0, 0);
            cardDados.Margin = new Padding(0, 0, 0, 16);
            cardDados.Name = "cardDados";
            cardDados.Padding = new Padding(20);
            cardDados.Size = new Size(1140, 134);
            cardDados.TabIndex = 0;
            // 
            // layoutDados
            // 
            layoutDados.BackColor = Color.White;
            layoutDados.ColumnCount = 1;
            layoutDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutDados.Controls.Add(lblDadosTitulo, 0, 0);
            layoutDados.Controls.Add(gridDados, 0, 1);
            layoutDados.Dock = DockStyle.Fill;
            layoutDados.Location = new Point(20, 20);
            layoutDados.Name = "layoutDados";
            layoutDados.RowCount = 2;
            layoutDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            layoutDados.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutDados.Size = new Size(1100, 94);
            layoutDados.TabIndex = 0;
            // 
            // lblDadosTitulo
            // 
            lblDadosTitulo.Dock = DockStyle.Fill;
            lblDadosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDadosTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblDadosTitulo.Location = new Point(0, 0);
            lblDadosTitulo.Margin = new Padding(0);
            lblDadosTitulo.Name = "lblDadosTitulo";
            lblDadosTitulo.Size = new Size(1100, 34);
            lblDadosTitulo.TabIndex = 0;
            lblDadosTitulo.Text = "Dados do serviço";
            lblDadosTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gridDados
            // 
            gridDados.ColumnCount = 2;
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            gridDados.Controls.Add(lblNomeServico, 0, 0);
            gridDados.Controls.Add(txtNomeServico, 0, 1);
            gridDados.Controls.Add(lblPreco, 1, 0);
            gridDados.Controls.Add(txtPreco, 1, 1);
            gridDados.Dock = DockStyle.Fill;
            gridDados.Location = new Point(0, 34);
            gridDados.Margin = new Padding(0);
            gridDados.Name = "gridDados";
            gridDados.RowCount = 2;
            gridDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            gridDados.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridDados.Size = new Size(1100, 60);
            gridDados.TabIndex = 1;
            // 
            // lblNomeServico
            // 
            lblNomeServico.Dock = DockStyle.Fill;
            lblNomeServico.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNomeServico.ForeColor = ColorTranslator.FromHtml("#374151");
            lblNomeServico.Location = new Point(0, 0);
            lblNomeServico.Margin = new Padding(0, 0, 10, 0);
            lblNomeServico.Name = "lblNomeServico";
            lblNomeServico.Size = new Size(705, 24);
            lblNomeServico.TabIndex = 0;
            lblNomeServico.Text = "Serviço *";
            lblNomeServico.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeServico
            // 
            txtNomeServico.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNomeServico.BorderStyle = BorderStyle.FixedSingle;
            txtNomeServico.Font = new Font("Segoe UI", 10.5F);
            txtNomeServico.Location = new Point(0, 27);
            txtNomeServico.Margin = new Padding(0, 0, 10, 0);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.PlaceholderText = "Digite o nome do serviço...";
            txtNomeServico.Size = new Size(705, 31);
            txtNomeServico.TabIndex = 0;
            txtNomeServico.TextChanged += Campo_TextChanged;
            // 
            // lblPreco
            // 
            lblPreco.Dock = DockStyle.Fill;
            lblPreco.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPreco.ForeColor = ColorTranslator.FromHtml("#374151");
            lblPreco.Location = new Point(725, 0);
            lblPreco.Margin = new Padding(10, 0, 0, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(375, 24);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço *";
            lblPreco.TextAlign = ContentAlignment.BottomLeft;
            lblPreco.Click += lblPreco_Click;
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPreco.BorderStyle = BorderStyle.FixedSingle;
            txtPreco.Font = new Font("Segoe UI", 10.5F);
            txtPreco.Location = new Point(725, 27);
            txtPreco.Margin = new Padding(10, 0, 0, 0);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Digite o valor...";
            txtPreco.Size = new Size(375, 31);
            txtPreco.TabIndex = 1;
            txtPreco.TextChanged += Campo_TextChanged;
            // 
            // cardOperacoes
            // 
            cardOperacoes.Controls.Add(layoutOperacoes);
            cardOperacoes.Dock = DockStyle.Fill;
            cardOperacoes.Location = new Point(0, 150);
            cardOperacoes.Margin = new Padding(0, 0, 0, 16);
            cardOperacoes.Name = "cardOperacoes";
            cardOperacoes.Padding = new Padding(20, 14, 20, 14);
            cardOperacoes.Size = new Size(1140, 84);
            cardOperacoes.TabIndex = 1;
            // 
            // layoutOperacoes
            // 
            layoutOperacoes.BackColor = Color.White;
            layoutOperacoes.ColumnCount = 2;
            layoutOperacoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            layoutOperacoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutOperacoes.Controls.Add(lblOperacoesTitulo, 0, 0);
            layoutOperacoes.Controls.Add(fluxoBotoes, 1, 0);
            layoutOperacoes.Dock = DockStyle.Fill;
            layoutOperacoes.Location = new Point(20, 14);
            layoutOperacoes.Name = "layoutOperacoes";
            layoutOperacoes.RowCount = 1;
            layoutOperacoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutOperacoes.Size = new Size(1100, 56);
            layoutOperacoes.TabIndex = 0;
            // 
            // lblOperacoesTitulo
            // 
            lblOperacoesTitulo.Dock = DockStyle.Fill;
            lblOperacoesTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOperacoesTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblOperacoesTitulo.Location = new Point(0, 0);
            lblOperacoesTitulo.Margin = new Padding(0);
            lblOperacoesTitulo.Name = "lblOperacoesTitulo";
            lblOperacoesTitulo.Size = new Size(180, 56);
            lblOperacoesTitulo.TabIndex = 0;
            lblOperacoesTitulo.Text = "Operações";
            lblOperacoesTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fluxoBotoes
            // 
            fluxoBotoes.Controls.Add(btnCadastrarServico);
            fluxoBotoes.Controls.Add(btnEditar);
            fluxoBotoes.Controls.Add(btnLimpar);
            fluxoBotoes.Controls.Add(btnExcluir);
            fluxoBotoes.Controls.Add(btnCancelar);
            fluxoBotoes.Dock = DockStyle.Fill;
            fluxoBotoes.Location = new Point(180, 0);
            fluxoBotoes.Margin = new Padding(0);
            fluxoBotoes.Name = "fluxoBotoes";
            fluxoBotoes.Size = new Size(920, 56);
            fluxoBotoes.TabIndex = 1;
            fluxoBotoes.WrapContents = false;
            // 
            // btnCadastrarServico
            // 
            btnCadastrarServico.HoverBackColor = ColorTranslator.FromHtml("#15803D");
            btnCadastrarServico.Location = new Point(0, 8);
            btnCadastrarServico.Margin = new Padding(0, 8, 10, 8);
            btnCadastrarServico.Name = "btnCadastrarServico";
            btnCadastrarServico.NormalBackColor = ColorTranslator.FromHtml("#16A34A");
            btnCadastrarServico.PressedBackColor = ColorTranslator.FromHtml("#166534");
            btnCadastrarServico.Size = new Size(132, 40);
            btnCadastrarServico.TabIndex = 2;
            btnCadastrarServico.Text = "💾 Salvar";
            btnCadastrarServico.Click += btnCadastrarServico_Click;
            // 
            // btnEditar
            // 
            btnEditar.HoverBackColor = ColorTranslator.FromHtml("#1D4ED8");
            btnEditar.Location = new Point(142, 8);
            btnEditar.Margin = new Padding(0, 8, 10, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.NormalBackColor = ColorTranslator.FromHtml("#2563EB");
            btnEditar.PressedBackColor = ColorTranslator.FromHtml("#1E40AF");
            btnEditar.Size = new Size(132, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "✏️ Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = ColorTranslator.FromHtml("#111827");
            btnLimpar.HoverBackColor = ColorTranslator.FromHtml("#D1D5DB");
            btnLimpar.Location = new Point(284, 8);
            btnLimpar.Margin = new Padding(0, 8, 10, 8);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.NormalBackColor = ColorTranslator.FromHtml("#E5E7EB");
            btnLimpar.PressedBackColor = ColorTranslator.FromHtml("#CBD5E1");
            btnLimpar.Size = new Size(132, 40);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "🧹 Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.HoverBackColor = ColorTranslator.FromHtml("#B91C1C");
            btnExcluir.Location = new Point(426, 8);
            btnExcluir.Margin = new Padding(0, 8, 10, 8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NormalBackColor = ColorTranslator.FromHtml("#DC2626");
            btnExcluir.PressedBackColor = ColorTranslator.FromHtml("#991B1B");
            btnExcluir.Size = new Size(132, 40);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "🗑 Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.HoverBackColor = ColorTranslator.FromHtml("#D97706");
            btnCancelar.Location = new Point(568, 8);
            btnCancelar.Margin = new Padding(0, 8, 10, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackColor = ColorTranslator.FromHtml("#F59E0B");
            btnCancelar.PressedBackColor = ColorTranslator.FromHtml("#B45309");
            btnCancelar.Size = new Size(132, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cardLista
            // 
            cardLista.Controls.Add(layoutLista);
            cardLista.Dock = DockStyle.Fill;
            cardLista.Location = new Point(0, 250);
            cardLista.Margin = new Padding(0, 0, 0, 16);
            cardLista.Name = "cardLista";
            cardLista.Padding = new Padding(20);
            cardLista.Size = new Size(1140, 374);
            cardLista.TabIndex = 2;
            // 
            // layoutLista
            // 
            layoutLista.BackColor = Color.White;
            layoutLista.ColumnCount = 1;
            layoutLista.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutLista.Controls.Add(pnlListaTopo, 0, 0);
            layoutLista.Controls.Add(prgCarregando, 0, 1);
            layoutLista.Controls.Add(dgvServicos, 0, 2);
            layoutLista.Dock = DockStyle.Fill;
            layoutLista.Location = new Point(20, 20);
            layoutLista.Name = "layoutLista";
            layoutLista.RowCount = 3;
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLista.Size = new Size(1100, 334);
            layoutLista.TabIndex = 0;
            // 
            // pnlListaTopo
            // 
            pnlListaTopo.Controls.Add(lblListaTitulo);
            pnlListaTopo.Controls.Add(txtPesquisa);
            pnlListaTopo.Dock = DockStyle.Fill;
            pnlListaTopo.Location = new Point(0, 0);
            pnlListaTopo.Margin = new Padding(0);
            pnlListaTopo.Name = "pnlListaTopo";
            pnlListaTopo.Size = new Size(1100, 48);
            pnlListaTopo.TabIndex = 0;
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblListaTitulo.Location = new Point(0, 8);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(220, 30);
            lblListaTitulo.TabIndex = 0;
            lblListaTitulo.Text = "Lista de registros";
            lblListaTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisa.Font = new Font("Segoe UI", 10.5F);
            txtPesquisa.Location = new Point(735, 8);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por serviço ou valor...";
            txtPesquisa.Size = new Size(365, 31);
            txtPesquisa.TabIndex = 7;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // prgCarregando
            // 
            prgCarregando.Dock = DockStyle.Fill;
            prgCarregando.Location = new Point(0, 48);
            prgCarregando.Margin = new Padding(0, 0, 0, 4);
            prgCarregando.MarqueeAnimationSpeed = 24;
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(1100, 2);
            prgCarregando.Style = ProgressBarStyle.Marquee;
            prgCarregando.TabIndex = 1;
            prgCarregando.Visible = false;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.AllowUserToDeleteRows = false;
            dgvServicos.AllowUserToResizeColumns = false;
            dgvServicos.AllowUserToResizeRows = false;
            dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicos.BackgroundColor = Color.White;
            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServicos.ColumnHeadersHeight = 42;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvServicos.Dock = DockStyle.Fill;
            dgvServicos.EnableHeadersVisualStyles = false;
            dgvServicos.GridColor = ColorTranslator.FromHtml("#E5E7EB");
            dgvServicos.Location = new Point(0, 54);
            dgvServicos.Margin = new Padding(0);
            dgvServicos.MultiSelect = false;
            dgvServicos.Name = "dgvServicos";
            dgvServicos.ReadOnly = true;
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.RowHeadersWidth = 51;
            dgvServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicos.Size = new Size(1100, 280);
            dgvServicos.TabIndex = 8;
            dgvServicos.CellContentClick += dataGridView1_CellContentClick;
            dgvServicos.CellDoubleClick += dgvServicos_CellDoubleClick;
            // 
            // cardResumo
            // 
            cardResumo.Controls.Add(layoutResumo);
            cardResumo.Dock = DockStyle.Fill;
            cardResumo.Location = new Point(0, 640);
            cardResumo.Margin = new Padding(0);
            cardResumo.Name = "cardResumo";
            cardResumo.Padding = new Padding(20, 12, 20, 12);
            cardResumo.Size = new Size(1140, 86);
            cardResumo.TabIndex = 3;
            // 
            // layoutResumo
            // 
            layoutResumo.BackColor = Color.White;
            layoutResumo.ColumnCount = 3;
            layoutResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            layoutResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            layoutResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            layoutResumo.Controls.Add(lblQuantidadeRegistros, 0, 0);
            layoutResumo.Controls.Add(lblValorTotal, 1, 0);
            layoutResumo.Controls.Add(lblStatus, 2, 0);
            layoutResumo.Dock = DockStyle.Fill;
            layoutResumo.Location = new Point(20, 12);
            layoutResumo.Name = "layoutResumo";
            layoutResumo.RowCount = 1;
            layoutResumo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutResumo.Size = new Size(1100, 62);
            layoutResumo.TabIndex = 0;
            // 
            // lblQuantidadeRegistros
            // 
            lblQuantidadeRegistros.Dock = DockStyle.Fill;
            lblQuantidadeRegistros.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblQuantidadeRegistros.ForeColor = ColorTranslator.FromHtml("#111827");
            lblQuantidadeRegistros.Location = new Point(0, 0);
            lblQuantidadeRegistros.Margin = new Padding(0);
            lblQuantidadeRegistros.Name = "lblQuantidadeRegistros";
            lblQuantidadeRegistros.Size = new Size(363, 62);
            lblQuantidadeRegistros.TabIndex = 0;
            lblQuantidadeRegistros.Text = "Quantidade de registros: 0";
            lblQuantidadeRegistros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblValorTotal
            // 
            lblValorTotal.Dock = DockStyle.Fill;
            lblValorTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValorTotal.ForeColor = ColorTranslator.FromHtml("#111827");
            lblValorTotal.Location = new Point(363, 0);
            lblValorTotal.Margin = new Padding(0);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(363, 62);
            lblValorTotal.TabIndex = 1;
            lblValorTotal.Text = "Valor total: R$ 0,00";
            lblValorTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10.5F);
            lblStatus.ForeColor = ColorTranslator.FromHtml("#374151");
            lblStatus.Location = new Point(726, 0);
            lblStatus.Margin = new Padding(0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(374, 62);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Pronto.";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmServicoss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ColorTranslator.FromHtml("#F5F5F5");
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1000, 680);
            Name = "FrmServicoss";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerenciamento de Serviços";
            Load += FrmServicoss_Load;
            pnlHeader.ResumeLayout(false);
            headerLayout.ResumeLayout(false);
            pnlTituloHeader.ResumeLayout(false);
            pnlUsuario.ResumeLayout(false);
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            layoutConteudo.ResumeLayout(false);
            cardDados.ResumeLayout(false);
            layoutDados.ResumeLayout(false);
            gridDados.ResumeLayout(false);
            gridDados.PerformLayout();
            cardOperacoes.ResumeLayout(false);
            layoutOperacoes.ResumeLayout(false);
            fluxoBotoes.ResumeLayout(false);
            cardLista.ResumeLayout(false);
            layoutLista.ResumeLayout(false);
            pnlListaTopo.ResumeLayout(false);
            pnlListaTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            cardResumo.ResumeLayout(false);
            layoutResumo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader = null!;
        private TableLayoutPanel headerLayout = null!;
        private Label lblIconeTela = null!;
        private Panel pnlTituloHeader = null!;
        private Label lblTituloTela = null!;
        private Label lblNomeSistema = null!;
        private Panel pnlUsuario = null!;
        private Label lblUsuario = null!;
        private Label lblDataHora = null!;
        private Panel pnlConteudo = null!;
        private TableLayoutPanel layoutConteudo = null!;
        private ModernPanel cardDados = null!;
        private TableLayoutPanel layoutDados = null!;
        private Label lblDadosTitulo = null!;
        private TableLayoutPanel gridDados = null!;
        private Label lblNomeServico = null!;
        private TextBox txtNomeServico = null!;
        private Label lblPreco = null!;
        private TextBox txtPreco = null!;
        private ModernPanel cardOperacoes = null!;
        private TableLayoutPanel layoutOperacoes = null!;
        private Label lblOperacoesTitulo = null!;
        private FlowLayoutPanel fluxoBotoes = null!;
        private ModernButton btnCadastrarServico = null!;
        private ModernButton btnEditar = null!;
        private ModernButton btnLimpar = null!;
        private ModernButton btnExcluir = null!;
        private ModernButton btnCancelar = null!;
        private ModernPanel cardLista = null!;
        private TableLayoutPanel layoutLista = null!;
        private Panel pnlListaTopo = null!;
        private Label lblListaTitulo = null!;
        private TextBox txtPesquisa = null!;
        private ProgressBar prgCarregando = null!;
        private DataGridView dgvServicos = null!;
        private ModernPanel cardResumo = null!;
        private TableLayoutPanel layoutResumo = null!;
        private Label lblQuantidadeRegistros = null!;
        private Label lblValorTotal = null!;
        private Label lblStatus = null!;
        private ToolTip toolTip = null!;
        private ErrorProvider errorProvider = null!;
        private System.Windows.Forms.Timer tmrRelogio = null!;
    }
}
