using System.Drawing;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    partial class FrmOrcamento
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
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblServico = new Label();
            cmbServico = new ComboBox();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            cardOperacoes = new ModernPanel();
            layoutOperacoes = new TableLayoutPanel();
            lblOperacoesTitulo = new Label();
            fluxoBotoes = new FlowLayoutPanel();
            btnAdicionarItem = new ModernButton();
            btnRemoverItem = new ModernButton();
            btnCriarOrcamento = new ModernButton();
            btnLimpar = new ModernButton();
            btnCancelar = new ModernButton();
            cardItens = new ModernPanel();
            layoutItens = new TableLayoutPanel();
            lblItensTitulo = new Label();
            dgvItens = new DataGridView();
            cardResumo = new ModernPanel();
            layoutResumo = new TableLayoutPanel();
            lblQuantidadeItens = new Label();
            lblTotalOrcamento = new Label();
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
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            cardOperacoes.SuspendLayout();
            layoutOperacoes.SuspendLayout();
            fluxoBotoes.SuspendLayout();
            cardItens.SuspendLayout();
            layoutItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
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
            lblIconeTela.BackColor = ColorTranslator.FromHtml("#16A34A");
            lblIconeTela.Dock = DockStyle.Fill;
            lblIconeTela.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblIconeTela.ForeColor = Color.White;
            lblIconeTela.Location = new Point(0, 0);
            lblIconeTela.Margin = new Padding(0, 0, 12, 0);
            lblIconeTela.Name = "lblIconeTela";
            lblIconeTela.Size = new Size(42, 54);
            lblIconeTela.TabIndex = 0;
            lblIconeTela.Text = "➕";
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
            lblTituloTela.Text = "Criar Orçamento";
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
            layoutConteudo.Controls.Add(cardItens, 0, 2);
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
            lblDadosTitulo.Text = "Dados do orçamento";
            lblDadosTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gridDados
            // 
            gridDados.ColumnCount = 3;
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            gridDados.Controls.Add(lblCliente, 0, 0);
            gridDados.Controls.Add(cmbCliente, 0, 1);
            gridDados.Controls.Add(lblServico, 1, 0);
            gridDados.Controls.Add(cmbServico, 1, 1);
            gridDados.Controls.Add(lblQuantidade, 2, 0);
            gridDados.Controls.Add(nudQuantidade, 2, 1);
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
            // lblCliente
            // 
            lblCliente.Dock = DockStyle.Fill;
            lblCliente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCliente.ForeColor = ColorTranslator.FromHtml("#374151");
            lblCliente.Location = new Point(0, 0);
            lblCliente.Margin = new Padding(0, 0, 10, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(452, 24);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente *";
            lblCliente.TextAlign = ContentAlignment.BottomLeft;
            lblCliente.Click += lblCliente_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 10.5F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(0, 26);
            cmbCliente.Margin = new Padding(0, 0, 10, 0);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(452, 31);
            cmbCliente.TabIndex = 0;
            cmbCliente.SelectedIndexChanged += CampoOrcamento_Changed;
            // 
            // lblServico
            // 
            lblServico.Dock = DockStyle.Fill;
            lblServico.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblServico.ForeColor = ColorTranslator.FromHtml("#374151");
            lblServico.Location = new Point(472, 0);
            lblServico.Margin = new Padding(10, 0, 10, 0);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(442, 24);
            lblServico.TabIndex = 2;
            lblServico.Text = "Serviço *";
            lblServico.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbServico
            // 
            cmbServico.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbServico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServico.Font = new Font("Segoe UI", 10.5F);
            cmbServico.FormattingEnabled = true;
            cmbServico.Location = new Point(472, 26);
            cmbServico.Margin = new Padding(10, 0, 10, 0);
            cmbServico.Name = "cmbServico";
            cmbServico.Size = new Size(442, 31);
            cmbServico.TabIndex = 1;
            cmbServico.SelectedIndexChanged += CampoOrcamento_Changed;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Dock = DockStyle.Fill;
            lblQuantidade.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQuantidade.ForeColor = ColorTranslator.FromHtml("#374151");
            lblQuantidade.Location = new Point(934, 0);
            lblQuantidade.Margin = new Padding(10, 0, 0, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(166, 24);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Quantidade *";
            lblQuantidade.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudQuantidade.Font = new Font("Segoe UI", 10.5F);
            nudQuantidade.Location = new Point(934, 27);
            nudQuantidade.Margin = new Padding(10, 0, 0, 0);
            nudQuantidade.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(166, 31);
            nudQuantidade.TabIndex = 2;
            nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.ValueChanged += CampoOrcamento_Changed;
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
            fluxoBotoes.Controls.Add(btnAdicionarItem);
            fluxoBotoes.Controls.Add(btnRemoverItem);
            fluxoBotoes.Controls.Add(btnCriarOrcamento);
            fluxoBotoes.Controls.Add(btnLimpar);
            fluxoBotoes.Controls.Add(btnCancelar);
            fluxoBotoes.Dock = DockStyle.Fill;
            fluxoBotoes.Location = new Point(180, 0);
            fluxoBotoes.Margin = new Padding(0);
            fluxoBotoes.Name = "fluxoBotoes";
            fluxoBotoes.Size = new Size(920, 56);
            fluxoBotoes.TabIndex = 1;
            fluxoBotoes.WrapContents = false;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.HoverBackColor = ColorTranslator.FromHtml("#1D4ED8");
            btnAdicionarItem.Location = new Point(0, 8);
            btnAdicionarItem.Margin = new Padding(0, 8, 10, 8);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.NormalBackColor = ColorTranslator.FromHtml("#2563EB");
            btnAdicionarItem.PressedBackColor = ColorTranslator.FromHtml("#1E40AF");
            btnAdicionarItem.Size = new Size(150, 40);
            btnAdicionarItem.TabIndex = 3;
            btnAdicionarItem.Text = "➕ Adicionar";
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.HoverBackColor = ColorTranslator.FromHtml("#B91C1C");
            btnRemoverItem.Location = new Point(160, 8);
            btnRemoverItem.Margin = new Padding(0, 8, 10, 8);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.NormalBackColor = ColorTranslator.FromHtml("#DC2626");
            btnRemoverItem.PressedBackColor = ColorTranslator.FromHtml("#991B1B");
            btnRemoverItem.Size = new Size(140, 40);
            btnRemoverItem.TabIndex = 4;
            btnRemoverItem.Text = "🗑 Remover";
            btnRemoverItem.Click += btnRemoverItem_Click;
            // 
            // btnCriarOrcamento
            // 
            btnCriarOrcamento.HoverBackColor = ColorTranslator.FromHtml("#15803D");
            btnCriarOrcamento.Location = new Point(310, 8);
            btnCriarOrcamento.Margin = new Padding(0, 8, 10, 8);
            btnCriarOrcamento.Name = "btnCriarOrcamento";
            btnCriarOrcamento.NormalBackColor = ColorTranslator.FromHtml("#16A34A");
            btnCriarOrcamento.PressedBackColor = ColorTranslator.FromHtml("#166534");
            btnCriarOrcamento.Size = new Size(160, 40);
            btnCriarOrcamento.TabIndex = 5;
            btnCriarOrcamento.Text = "💾 Criar";
            btnCriarOrcamento.Click += btnCriarOrcamento_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = ColorTranslator.FromHtml("#111827");
            btnLimpar.HoverBackColor = ColorTranslator.FromHtml("#D1D5DB");
            btnLimpar.Location = new Point(480, 8);
            btnLimpar.Margin = new Padding(0, 8, 10, 8);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.NormalBackColor = ColorTranslator.FromHtml("#E5E7EB");
            btnLimpar.PressedBackColor = ColorTranslator.FromHtml("#CBD5E1");
            btnLimpar.Size = new Size(132, 40);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "🧹 Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.HoverBackColor = ColorTranslator.FromHtml("#D97706");
            btnCancelar.Location = new Point(622, 8);
            btnCancelar.Margin = new Padding(0, 8, 10, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackColor = ColorTranslator.FromHtml("#F59E0B");
            btnCancelar.PressedBackColor = ColorTranslator.FromHtml("#B45309");
            btnCancelar.Size = new Size(132, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cardItens
            // 
            cardItens.Controls.Add(layoutItens);
            cardItens.Dock = DockStyle.Fill;
            cardItens.Location = new Point(0, 250);
            cardItens.Margin = new Padding(0, 0, 0, 16);
            cardItens.Name = "cardItens";
            cardItens.Padding = new Padding(20);
            cardItens.Size = new Size(1140, 374);
            cardItens.TabIndex = 2;
            // 
            // layoutItens
            // 
            layoutItens.BackColor = Color.White;
            layoutItens.ColumnCount = 1;
            layoutItens.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutItens.Controls.Add(lblItensTitulo, 0, 0);
            layoutItens.Controls.Add(dgvItens, 0, 1);
            layoutItens.Dock = DockStyle.Fill;
            layoutItens.Location = new Point(20, 20);
            layoutItens.Name = "layoutItens";
            layoutItens.RowCount = 2;
            layoutItens.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutItens.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutItens.Size = new Size(1100, 334);
            layoutItens.TabIndex = 0;
            // 
            // lblItensTitulo
            // 
            lblItensTitulo.Dock = DockStyle.Fill;
            lblItensTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblItensTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblItensTitulo.Location = new Point(0, 0);
            lblItensTitulo.Margin = new Padding(0);
            lblItensTitulo.Name = "lblItensTitulo";
            lblItensTitulo.Size = new Size(1100, 42);
            lblItensTitulo.TabIndex = 0;
            lblItensTitulo.Text = "Itens do orçamento";
            lblItensTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AllowUserToResizeColumns = false;
            dgvItens.AllowUserToResizeRows = false;
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.BackgroundColor = Color.White;
            dgvItens.BorderStyle = BorderStyle.None;
            dgvItens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItens.ColumnHeadersHeight = 42;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItens.Dock = DockStyle.Fill;
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.GridColor = ColorTranslator.FromHtml("#E5E7EB");
            dgvItens.Location = new Point(0, 42);
            dgvItens.Margin = new Padding(0);
            dgvItens.MultiSelect = false;
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.RowHeadersWidth = 51;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(1100, 292);
            dgvItens.TabIndex = 8;
            dgvItens.CellContentClick += dgvItens_CellContentClick;
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
            layoutResumo.Controls.Add(lblQuantidadeItens, 0, 0);
            layoutResumo.Controls.Add(lblTotalOrcamento, 1, 0);
            layoutResumo.Controls.Add(lblStatus, 2, 0);
            layoutResumo.Dock = DockStyle.Fill;
            layoutResumo.Location = new Point(20, 12);
            layoutResumo.Name = "layoutResumo";
            layoutResumo.RowCount = 1;
            layoutResumo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutResumo.Size = new Size(1100, 62);
            layoutResumo.TabIndex = 0;
            // 
            // lblQuantidadeItens
            // 
            lblQuantidadeItens.Dock = DockStyle.Fill;
            lblQuantidadeItens.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblQuantidadeItens.ForeColor = ColorTranslator.FromHtml("#111827");
            lblQuantidadeItens.Location = new Point(0, 0);
            lblQuantidadeItens.Margin = new Padding(0);
            lblQuantidadeItens.Name = "lblQuantidadeItens";
            lblQuantidadeItens.Size = new Size(363, 62);
            lblQuantidadeItens.TabIndex = 0;
            lblQuantidadeItens.Text = "Itens: 0";
            lblQuantidadeItens.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalOrcamento
            // 
            lblTotalOrcamento.Dock = DockStyle.Fill;
            lblTotalOrcamento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalOrcamento.ForeColor = ColorTranslator.FromHtml("#16A34A");
            lblTotalOrcamento.Location = new Point(363, 0);
            lblTotalOrcamento.Margin = new Padding(0);
            lblTotalOrcamento.Name = "lblTotalOrcamento";
            lblTotalOrcamento.Size = new Size(363, 62);
            lblTotalOrcamento.TabIndex = 1;
            lblTotalOrcamento.Text = "Total: R$ 0,00";
            lblTotalOrcamento.TextAlign = ContentAlignment.MiddleCenter;
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
            // FrmOrcamento
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
            Name = "FrmOrcamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Criar Orçamento";
            Load += FrmServicos_Load;
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
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            cardOperacoes.ResumeLayout(false);
            layoutOperacoes.ResumeLayout(false);
            fluxoBotoes.ResumeLayout(false);
            cardItens.ResumeLayout(false);
            layoutItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
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
        private Label lblCliente = null!;
        private ComboBox cmbCliente = null!;
        private Label lblServico = null!;
        private ComboBox cmbServico = null!;
        private Label lblQuantidade = null!;
        private NumericUpDown nudQuantidade = null!;
        private ModernPanel cardOperacoes = null!;
        private TableLayoutPanel layoutOperacoes = null!;
        private Label lblOperacoesTitulo = null!;
        private FlowLayoutPanel fluxoBotoes = null!;
        private ModernButton btnAdicionarItem = null!;
        private ModernButton btnRemoverItem = null!;
        private ModernButton btnCriarOrcamento = null!;
        private ModernButton btnLimpar = null!;
        private ModernButton btnCancelar = null!;
        private ModernPanel cardItens = null!;
        private TableLayoutPanel layoutItens = null!;
        private Label lblItensTitulo = null!;
        private DataGridView dgvItens = null!;
        private ModernPanel cardResumo = null!;
        private TableLayoutPanel layoutResumo = null!;
        private Label lblQuantidadeItens = null!;
        private Label lblTotalOrcamento = null!;
        private Label lblStatus = null!;
        private ToolTip toolTip = null!;
        private ErrorProvider errorProvider = null!;
        private System.Windows.Forms.Timer tmrRelogio = null!;
    }
}
