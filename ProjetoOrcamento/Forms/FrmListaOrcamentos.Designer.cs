using System.Drawing;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    partial class FrmListaOrcamentos
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
            cardFiltros = new ModernPanel();
            layoutFiltros = new TableLayoutPanel();
            lblFiltrosTitulo = new Label();
            gridFiltros = new TableLayoutPanel();
            lblPesquisa = new Label();
            txtPesquisa = new TextBox();
            lblStatusFiltro = new Label();
            cmbStatusFiltro = new ComboBox();
            cardOperacoes = new ModernPanel();
            layoutOperacoes = new TableLayoutPanel();
            lblOperacoesTitulo = new Label();
            fluxoBotoes = new FlowLayoutPanel();
            btnAprovar = new ModernButton();
            btnRejeitar = new ModernButton();
            btnAtualizar = new ModernButton();
            btnFechar = new ModernButton();
            cardLista = new ModernPanel();
            layoutLista = new TableLayoutPanel();
            lblListaTitulo = new Label();
            prgCarregando = new ProgressBar();
            dgvOrcamentos = new DataGridView();
            cardResumo = new ModernPanel();
            layoutResumo = new TableLayoutPanel();
            lblQuantidadeRegistros = new Label();
            lblValorTotal = new Label();
            lblStatus = new Label();
            toolTip = new ToolTip(components);
            tmrRelogio = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            headerLayout.SuspendLayout();
            pnlTituloHeader.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlConteudo.SuspendLayout();
            layoutConteudo.SuspendLayout();
            cardFiltros.SuspendLayout();
            layoutFiltros.SuspendLayout();
            gridFiltros.SuspendLayout();
            cardOperacoes.SuspendLayout();
            layoutOperacoes.SuspendLayout();
            fluxoBotoes.SuspendLayout();
            cardLista.SuspendLayout();
            layoutLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).BeginInit();
            cardResumo.SuspendLayout();
            layoutResumo.SuspendLayout();
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
            lblIconeTela.Text = "📋";
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
            lblTituloTela.Text = "Orçamentos";
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
            layoutConteudo.Controls.Add(cardFiltros, 0, 0);
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
            // cardFiltros
            // 
            cardFiltros.Controls.Add(layoutFiltros);
            cardFiltros.Dock = DockStyle.Fill;
            cardFiltros.Location = new Point(0, 0);
            cardFiltros.Margin = new Padding(0, 0, 0, 16);
            cardFiltros.Name = "cardFiltros";
            cardFiltros.Padding = new Padding(20);
            cardFiltros.Size = new Size(1140, 134);
            cardFiltros.TabIndex = 0;
            // 
            // layoutFiltros
            // 
            layoutFiltros.BackColor = Color.White;
            layoutFiltros.ColumnCount = 1;
            layoutFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutFiltros.Controls.Add(lblFiltrosTitulo, 0, 0);
            layoutFiltros.Controls.Add(gridFiltros, 0, 1);
            layoutFiltros.Dock = DockStyle.Fill;
            layoutFiltros.Location = new Point(20, 20);
            layoutFiltros.Name = "layoutFiltros";
            layoutFiltros.RowCount = 2;
            layoutFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            layoutFiltros.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutFiltros.Size = new Size(1100, 94);
            layoutFiltros.TabIndex = 0;
            // 
            // lblFiltrosTitulo
            // 
            lblFiltrosTitulo.Dock = DockStyle.Fill;
            lblFiltrosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFiltrosTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblFiltrosTitulo.Location = new Point(0, 0);
            lblFiltrosTitulo.Margin = new Padding(0);
            lblFiltrosTitulo.Name = "lblFiltrosTitulo";
            lblFiltrosTitulo.Size = new Size(1100, 34);
            lblFiltrosTitulo.TabIndex = 0;
            lblFiltrosTitulo.Text = "Filtros";
            lblFiltrosTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gridFiltros
            // 
            gridFiltros.ColumnCount = 2;
            gridFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            gridFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            gridFiltros.Controls.Add(lblPesquisa, 0, 0);
            gridFiltros.Controls.Add(txtPesquisa, 0, 1);
            gridFiltros.Controls.Add(lblStatusFiltro, 1, 0);
            gridFiltros.Controls.Add(cmbStatusFiltro, 1, 1);
            gridFiltros.Dock = DockStyle.Fill;
            gridFiltros.Location = new Point(0, 34);
            gridFiltros.Margin = new Padding(0);
            gridFiltros.Name = "gridFiltros";
            gridFiltros.RowCount = 2;
            gridFiltros.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            gridFiltros.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridFiltros.Size = new Size(1100, 60);
            gridFiltros.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            lblPesquisa.Dock = DockStyle.Fill;
            lblPesquisa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPesquisa.ForeColor = ColorTranslator.FromHtml("#374151");
            lblPesquisa.Location = new Point(0, 0);
            lblPesquisa.Margin = new Padding(0, 0, 10, 0);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(760, 24);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Pesquisa";
            lblPesquisa.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisa.Font = new Font("Segoe UI", 10.5F);
            txtPesquisa.Location = new Point(0, 27);
            txtPesquisa.Margin = new Padding(0, 0, 10, 0);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por cliente, status, pedido ou motivo...";
            txtPesquisa.Size = new Size(760, 31);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += Filtros_Changed;
            // 
            // lblStatusFiltro
            // 
            lblStatusFiltro.Dock = DockStyle.Fill;
            lblStatusFiltro.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatusFiltro.ForeColor = ColorTranslator.FromHtml("#374151");
            lblStatusFiltro.Location = new Point(780, 0);
            lblStatusFiltro.Margin = new Padding(10, 0, 0, 0);
            lblStatusFiltro.Name = "lblStatusFiltro";
            lblStatusFiltro.Size = new Size(320, 24);
            lblStatusFiltro.TabIndex = 2;
            lblStatusFiltro.Text = "Status";
            lblStatusFiltro.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbStatusFiltro
            // 
            cmbStatusFiltro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbStatusFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFiltro.Font = new Font("Segoe UI", 10.5F);
            cmbStatusFiltro.FormattingEnabled = true;
            cmbStatusFiltro.Location = new Point(780, 26);
            cmbStatusFiltro.Margin = new Padding(10, 0, 0, 0);
            cmbStatusFiltro.Name = "cmbStatusFiltro";
            cmbStatusFiltro.Size = new Size(320, 31);
            cmbStatusFiltro.TabIndex = 1;
            cmbStatusFiltro.SelectedIndexChanged += Filtros_Changed;
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
            fluxoBotoes.Controls.Add(btnAprovar);
            fluxoBotoes.Controls.Add(btnRejeitar);
            fluxoBotoes.Controls.Add(btnAtualizar);
            fluxoBotoes.Controls.Add(btnFechar);
            fluxoBotoes.Dock = DockStyle.Fill;
            fluxoBotoes.Location = new Point(180, 0);
            fluxoBotoes.Margin = new Padding(0);
            fluxoBotoes.Name = "fluxoBotoes";
            fluxoBotoes.Size = new Size(920, 56);
            fluxoBotoes.TabIndex = 1;
            fluxoBotoes.WrapContents = false;
            // 
            // btnAprovar
            // 
            btnAprovar.HoverBackColor = ColorTranslator.FromHtml("#15803D");
            btnAprovar.Location = new Point(0, 8);
            btnAprovar.Margin = new Padding(0, 8, 10, 8);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.NormalBackColor = ColorTranslator.FromHtml("#16A34A");
            btnAprovar.PressedBackColor = ColorTranslator.FromHtml("#166534");
            btnAprovar.Size = new Size(132, 40);
            btnAprovar.TabIndex = 2;
            btnAprovar.Text = "✔ Aprovar";
            btnAprovar.Click += btnAprovar_Click;
            // 
            // btnRejeitar
            // 
            btnRejeitar.HoverBackColor = ColorTranslator.FromHtml("#B91C1C");
            btnRejeitar.Location = new Point(142, 8);
            btnRejeitar.Margin = new Padding(0, 8, 10, 8);
            btnRejeitar.Name = "btnRejeitar";
            btnRejeitar.NormalBackColor = ColorTranslator.FromHtml("#DC2626");
            btnRejeitar.PressedBackColor = ColorTranslator.FromHtml("#991B1B");
            btnRejeitar.Size = new Size(132, 40);
            btnRejeitar.TabIndex = 3;
            btnRejeitar.Text = "✖ Rejeitar";
            btnRejeitar.Click += btnRejeitar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.ForeColor = ColorTranslator.FromHtml("#111827");
            btnAtualizar.HoverBackColor = ColorTranslator.FromHtml("#D1D5DB");
            btnAtualizar.Location = new Point(284, 8);
            btnAtualizar.Margin = new Padding(0, 8, 10, 8);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.NormalBackColor = ColorTranslator.FromHtml("#E5E7EB");
            btnAtualizar.PressedBackColor = ColorTranslator.FromHtml("#CBD5E1");
            btnAtualizar.Size = new Size(132, 40);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "↻ Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.HoverBackColor = ColorTranslator.FromHtml("#D97706");
            btnFechar.Location = new Point(426, 8);
            btnFechar.Margin = new Padding(0, 8, 10, 8);
            btnFechar.Name = "btnFechar";
            btnFechar.NormalBackColor = ColorTranslator.FromHtml("#F59E0B");
            btnFechar.PressedBackColor = ColorTranslator.FromHtml("#B45309");
            btnFechar.Size = new Size(132, 40);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "❌ Fechar";
            btnFechar.Click += btnFechar_Click;
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
            layoutLista.Controls.Add(lblListaTitulo, 0, 0);
            layoutLista.Controls.Add(prgCarregando, 0, 1);
            layoutLista.Controls.Add(dgvOrcamentos, 0, 2);
            layoutLista.Dock = DockStyle.Fill;
            layoutLista.Location = new Point(20, 20);
            layoutLista.Name = "layoutLista";
            layoutLista.RowCount = 3;
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLista.Size = new Size(1100, 334);
            layoutLista.TabIndex = 0;
            // 
            // lblListaTitulo
            // 
            lblListaTitulo.Dock = DockStyle.Fill;
            lblListaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblListaTitulo.Location = new Point(0, 0);
            lblListaTitulo.Margin = new Padding(0);
            lblListaTitulo.Name = "lblListaTitulo";
            lblListaTitulo.Size = new Size(1100, 42);
            lblListaTitulo.TabIndex = 0;
            lblListaTitulo.Text = "Lista de registros";
            lblListaTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // prgCarregando
            // 
            prgCarregando.Dock = DockStyle.Fill;
            prgCarregando.Location = new Point(0, 42);
            prgCarregando.Margin = new Padding(0, 0, 0, 4);
            prgCarregando.MarqueeAnimationSpeed = 24;
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(1100, 2);
            prgCarregando.Style = ProgressBarStyle.Marquee;
            prgCarregando.TabIndex = 1;
            prgCarregando.Visible = false;
            // 
            // dgvOrcamentos
            // 
            dgvOrcamentos.AllowUserToAddRows = false;
            dgvOrcamentos.AllowUserToDeleteRows = false;
            dgvOrcamentos.AllowUserToResizeColumns = false;
            dgvOrcamentos.AllowUserToResizeRows = false;
            dgvOrcamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrcamentos.BackgroundColor = Color.White;
            dgvOrcamentos.BorderStyle = BorderStyle.None;
            dgvOrcamentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrcamentos.ColumnHeadersHeight = 42;
            dgvOrcamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrcamentos.Dock = DockStyle.Fill;
            dgvOrcamentos.EnableHeadersVisualStyles = false;
            dgvOrcamentos.GridColor = ColorTranslator.FromHtml("#E5E7EB");
            dgvOrcamentos.Location = new Point(0, 48);
            dgvOrcamentos.Margin = new Padding(0);
            dgvOrcamentos.MultiSelect = false;
            dgvOrcamentos.Name = "dgvOrcamentos";
            dgvOrcamentos.ReadOnly = true;
            dgvOrcamentos.RowHeadersVisible = false;
            dgvOrcamentos.RowHeadersWidth = 51;
            dgvOrcamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrcamentos.Size = new Size(1100, 286);
            dgvOrcamentos.TabIndex = 6;
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
            lblValorTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValorTotal.ForeColor = ColorTranslator.FromHtml("#16A34A");
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
            // FrmListaOrcamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ColorTranslator.FromHtml("#F5F5F5");
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(1000, 680);
            Name = "FrmListaOrcamentos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Orçamentos";
            Load += Form_Load;
            pnlHeader.ResumeLayout(false);
            headerLayout.ResumeLayout(false);
            pnlTituloHeader.ResumeLayout(false);
            pnlUsuario.ResumeLayout(false);
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            layoutConteudo.ResumeLayout(false);
            cardFiltros.ResumeLayout(false);
            layoutFiltros.ResumeLayout(false);
            gridFiltros.ResumeLayout(false);
            gridFiltros.PerformLayout();
            cardOperacoes.ResumeLayout(false);
            layoutOperacoes.ResumeLayout(false);
            fluxoBotoes.ResumeLayout(false);
            cardLista.ResumeLayout(false);
            layoutLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).EndInit();
            cardResumo.ResumeLayout(false);
            layoutResumo.ResumeLayout(false);
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
        private ModernPanel cardFiltros = null!;
        private TableLayoutPanel layoutFiltros = null!;
        private Label lblFiltrosTitulo = null!;
        private TableLayoutPanel gridFiltros = null!;
        private Label lblPesquisa = null!;
        private TextBox txtPesquisa = null!;
        private Label lblStatusFiltro = null!;
        private ComboBox cmbStatusFiltro = null!;
        private ModernPanel cardOperacoes = null!;
        private TableLayoutPanel layoutOperacoes = null!;
        private Label lblOperacoesTitulo = null!;
        private FlowLayoutPanel fluxoBotoes = null!;
        private ModernButton btnAprovar = null!;
        private ModernButton btnRejeitar = null!;
        private ModernButton btnAtualizar = null!;
        private ModernButton btnFechar = null!;
        private ModernPanel cardLista = null!;
        private TableLayoutPanel layoutLista = null!;
        private Label lblListaTitulo = null!;
        private ProgressBar prgCarregando = null!;
        private DataGridView dgvOrcamentos = null!;
        private ModernPanel cardResumo = null!;
        private TableLayoutPanel layoutResumo = null!;
        private Label lblQuantidadeRegistros = null!;
        private Label lblValorTotal = null!;
        private Label lblStatus = null!;
        private ToolTip toolTip = null!;
        private System.Windows.Forms.Timer tmrRelogio = null!;
    }
}
