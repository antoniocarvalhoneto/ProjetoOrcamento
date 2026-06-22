using System.Drawing;
using System.Windows.Forms;

namespace ProjetoOrcamento.Forms
{
    partial class FrmClientes
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
            lblNomeSistema = new Label();
            lblTituloTela = new Label();
            pnlUsuario = new Panel();
            lblUsuario = new Label();
            lblDataHora = new Label();
            pnlConteudo = new Panel();
            layoutConteudo = new TableLayoutPanel();
            cardDados = new ModernPanel();
            layoutDados = new TableLayoutPanel();
            lblDadosTitulo = new Label();
            gridDados = new TableLayoutPanel();
            lblNome = new Label();
            txtNome = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new MaskedTextBox();
            lblCpf = new Label();
            txtCpf = new MaskedTextBox();
            lblCep = new Label();
            txtCep = new MaskedTextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblObservacoes = new Label();
            txtObservacoes = new TextBox();
            cardOperacoes = new ModernPanel();
            layoutOperacoes = new TableLayoutPanel();
            lblOperacoesTitulo = new Label();
            fluxoBotoes = new FlowLayoutPanel();
            btnSalvar = new ModernButton();
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
            dgvClientes = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            lblIconeTela.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblIconeTela.ForeColor = Color.White;
            lblIconeTela.Location = new Point(0, 0);
            lblIconeTela.Margin = new Padding(0, 0, 12, 0);
            lblIconeTela.Name = "lblIconeTela";
            lblIconeTela.Size = new Size(42, 54);
            lblIconeTela.TabIndex = 0;
            lblIconeTela.Text = "👤";
            lblIconeTela.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTituloHeader
            // 
            pnlTituloHeader.Controls.Add(lblNomeSistema);
            pnlTituloHeader.Controls.Add(lblTituloTela);
            pnlTituloHeader.Dock = DockStyle.Fill;
            pnlTituloHeader.Location = new Point(54, 0);
            pnlTituloHeader.Margin = new Padding(0);
            pnlTituloHeader.Name = "pnlTituloHeader";
            pnlTituloHeader.Size = new Size(782, 54);
            pnlTituloHeader.TabIndex = 1;
            // 
            // lblNomeSistema
            // 
            lblNomeSistema.Dock = DockStyle.Top;
            lblNomeSistema.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblNomeSistema.ForeColor = ColorTranslator.FromHtml("#DBEAFE");
            lblNomeSistema.Location = new Point(0, 30);
            lblNomeSistema.Name = "lblNomeSistema";
            lblNomeSistema.Size = new Size(782, 22);
            lblNomeSistema.TabIndex = 1;
            lblNomeSistema.Text = "Projeto Orçamento";
            lblNomeSistema.TextAlign = ContentAlignment.MiddleLeft;
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
            lblTituloTela.Text = "Clientes";
            lblTituloTela.TextAlign = ContentAlignment.MiddleLeft;
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
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 266F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 378F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            layoutConteudo.Size = new Size(1140, 830);
            layoutConteudo.TabIndex = 0;
            // 
            // cardDados
            // 
            cardDados.BorderColor = ColorTranslator.FromHtml("#D1D5DB");
            cardDados.CornerRadius = 12;
            cardDados.Controls.Add(layoutDados);
            cardDados.Dock = DockStyle.Fill;
            cardDados.FillColor = Color.White;
            cardDados.Location = new Point(0, 0);
            cardDados.Margin = new Padding(0, 0, 0, 16);
            cardDados.Name = "cardDados";
            cardDados.Padding = new Padding(20);
            cardDados.Size = new Size(1140, 250);
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
            layoutDados.Size = new Size(1100, 210);
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
            lblDadosTitulo.Text = "Dados do cliente";
            lblDadosTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gridDados
            // 
            gridDados.ColumnCount = 2;
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gridDados.Controls.Add(lblNome, 0, 0);
            gridDados.Controls.Add(txtNome, 0, 1);
            gridDados.Controls.Add(lblTelefone, 1, 0);
            gridDados.Controls.Add(txtTelefone, 1, 1);
            gridDados.Controls.Add(lblCpf, 0, 2);
            gridDados.Controls.Add(txtCpf, 0, 3);
            gridDados.Controls.Add(lblCep, 1, 2);
            gridDados.Controls.Add(txtCep, 1, 3);
            gridDados.Controls.Add(lblEndereco, 0, 4);
            gridDados.Controls.Add(txtEndereco, 0, 5);
            gridDados.Controls.Add(lblObservacoes, 1, 4);
            gridDados.Controls.Add(txtObservacoes, 1, 5);
            gridDados.Dock = DockStyle.Fill;
            gridDados.Location = new Point(0, 34);
            gridDados.Margin = new Padding(0);
            gridDados.Name = "gridDados";
            gridDados.RowCount = 6;
            gridDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            gridDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            gridDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            gridDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            gridDados.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            gridDados.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridDados.Size = new Size(1100, 176);
            gridDados.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNome.ForeColor = ColorTranslator.FromHtml("#374151");
            lblNome.Location = new Point(0, 0);
            lblNome.Margin = new Padding(0, 0, 10, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(540, 24);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome *";
            lblNome.TextAlign = ContentAlignment.BottomLeft;
            lblNome.Click += lblNome_Click;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 10.5F);
            txtNome.Location = new Point(0, 27);
            txtNome.Margin = new Padding(0, 0, 10, 0);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o nome...";
            txtNome.Size = new Size(540, 31);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += Campo_TextChanged;
            // 
            // lblTelefone
            // 
            lblTelefone.Dock = DockStyle.Fill;
            lblTelefone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTelefone.ForeColor = ColorTranslator.FromHtml("#374151");
            lblTelefone.Location = new Point(560, 0);
            lblTelefone.Margin = new Padding(10, 0, 0, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(540, 24);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone *";
            lblTelefone.TextAlign = ContentAlignment.BottomLeft;
            lblTelefone.Click += lblTelefone_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Font = new Font("Segoe UI", 10.5F);
            txtTelefone.HidePromptOnLeave = true;
            txtTelefone.Location = new Point(560, 27);
            txtTelefone.Margin = new Padding(10, 0, 0, 0);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PromptChar = ' ';
            txtTelefone.Size = new Size(540, 31);
            txtTelefone.TabIndex = 1;
            txtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // lblCpf
            // 
            lblCpf.Dock = DockStyle.Fill;
            lblCpf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCpf.ForeColor = ColorTranslator.FromHtml("#374151");
            lblCpf.Location = new Point(0, 60);
            lblCpf.Margin = new Padding(0, 0, 10, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(540, 24);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF";
            lblCpf.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Font = new Font("Segoe UI", 10.5F);
            txtCpf.HidePromptOnLeave = true;
            txtCpf.Location = new Point(0, 87);
            txtCpf.Margin = new Padding(0, 0, 10, 0);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.PromptChar = ' ';
            txtCpf.Size = new Size(540, 31);
            txtCpf.TabIndex = 2;
            txtCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtCpf.TextChanged += Campo_TextChanged;
            // 
            // lblCep
            // 
            lblCep.Dock = DockStyle.Fill;
            lblCep.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCep.ForeColor = ColorTranslator.FromHtml("#374151");
            lblCep.Location = new Point(560, 60);
            lblCep.Margin = new Padding(10, 0, 0, 0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(540, 24);
            lblCep.TabIndex = 6;
            lblCep.Text = "CEP";
            lblCep.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Font = new Font("Segoe UI", 10.5F);
            txtCep.HidePromptOnLeave = true;
            txtCep.Location = new Point(560, 87);
            txtCep.Margin = new Padding(10, 0, 0, 0);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.PromptChar = ' ';
            txtCep.Size = new Size(540, 31);
            txtCep.TabIndex = 3;
            txtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtCep.TextChanged += Campo_TextChanged;
            // 
            // lblEndereco
            // 
            lblEndereco.Dock = DockStyle.Fill;
            lblEndereco.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEndereco.ForeColor = ColorTranslator.FromHtml("#374151");
            lblEndereco.Location = new Point(0, 120);
            lblEndereco.Margin = new Padding(0, 0, 10, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(540, 24);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "Endereço";
            lblEndereco.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Segoe UI", 10.5F);
            txtEndereco.Location = new Point(0, 147);
            txtEndereco.Margin = new Padding(0, 0, 10, 0);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Digite o endereço...";
            txtEndereco.Size = new Size(540, 29);
            txtEndereco.TabIndex = 4;
            txtEndereco.TextChanged += Campo_TextChanged;
            // 
            // lblObservacoes
            // 
            lblObservacoes.Dock = DockStyle.Fill;
            lblObservacoes.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblObservacoes.ForeColor = ColorTranslator.FromHtml("#374151");
            lblObservacoes.Location = new Point(560, 120);
            lblObservacoes.Margin = new Padding(10, 0, 0, 0);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(540, 24);
            lblObservacoes.TabIndex = 10;
            lblObservacoes.Text = "Observações";
            lblObservacoes.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.BorderStyle = BorderStyle.FixedSingle;
            txtObservacoes.Font = new Font("Segoe UI", 10.5F);
            txtObservacoes.Location = new Point(560, 144);
            txtObservacoes.Margin = new Padding(10, 0, 0, 0);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.PlaceholderText = "Digite observações...";
            txtObservacoes.ScrollBars = ScrollBars.Vertical;
            txtObservacoes.Size = new Size(540, 32);
            txtObservacoes.TabIndex = 5;
            txtObservacoes.TextChanged += Campo_TextChanged;
            // 
            // cardOperacoes
            // 
            cardOperacoes.BorderColor = ColorTranslator.FromHtml("#D1D5DB");
            cardOperacoes.CornerRadius = 12;
            cardOperacoes.Controls.Add(layoutOperacoes);
            cardOperacoes.Dock = DockStyle.Fill;
            cardOperacoes.FillColor = Color.White;
            cardOperacoes.Location = new Point(0, 266);
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
            fluxoBotoes.Controls.Add(btnSalvar);
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
            // btnSalvar
            // 
            btnSalvar.CornerRadius = 10;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.HoverBackColor = ColorTranslator.FromHtml("#15803D");
            btnSalvar.Location = new Point(0, 8);
            btnSalvar.Margin = new Padding(0, 8, 10, 8);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NormalBackColor = ColorTranslator.FromHtml("#16A34A");
            btnSalvar.PressedBackColor = ColorTranslator.FromHtml("#166534");
            btnSalvar.Size = new Size(132, 40);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "💾 Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.CornerRadius = 10;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.HoverBackColor = ColorTranslator.FromHtml("#1D4ED8");
            btnEditar.Location = new Point(142, 8);
            btnEditar.Margin = new Padding(0, 8, 10, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.NormalBackColor = ColorTranslator.FromHtml("#2563EB");
            btnEditar.PressedBackColor = ColorTranslator.FromHtml("#1E40AF");
            btnEditar.Size = new Size(132, 40);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "✏️ Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.CornerRadius = 10;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = ColorTranslator.FromHtml("#111827");
            btnLimpar.HoverBackColor = ColorTranslator.FromHtml("#D1D5DB");
            btnLimpar.Location = new Point(284, 8);
            btnLimpar.Margin = new Padding(0, 8, 10, 8);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.NormalBackColor = ColorTranslator.FromHtml("#E5E7EB");
            btnLimpar.PressedBackColor = ColorTranslator.FromHtml("#CBD5E1");
            btnLimpar.Size = new Size(132, 40);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "🧹 Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.CornerRadius = 10;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.HoverBackColor = ColorTranslator.FromHtml("#B91C1C");
            btnExcluir.Location = new Point(426, 8);
            btnExcluir.Margin = new Padding(0, 8, 10, 8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NormalBackColor = ColorTranslator.FromHtml("#DC2626");
            btnExcluir.PressedBackColor = ColorTranslator.FromHtml("#991B1B");
            btnExcluir.Size = new Size(132, 40);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "🗑 Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRadius = 10;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.HoverBackColor = ColorTranslator.FromHtml("#D97706");
            btnCancelar.Location = new Point(568, 8);
            btnCancelar.Margin = new Padding(0, 8, 10, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackColor = ColorTranslator.FromHtml("#F59E0B");
            btnCancelar.PressedBackColor = ColorTranslator.FromHtml("#B45309");
            btnCancelar.Size = new Size(132, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cardLista
            // 
            cardLista.BorderColor = ColorTranslator.FromHtml("#D1D5DB");
            cardLista.CornerRadius = 12;
            cardLista.Controls.Add(layoutLista);
            cardLista.Dock = DockStyle.Fill;
            cardLista.FillColor = Color.White;
            cardLista.Location = new Point(0, 366);
            cardLista.Margin = new Padding(0, 0, 0, 16);
            cardLista.Name = "cardLista";
            cardLista.Padding = new Padding(20);
            cardLista.Size = new Size(1140, 362);
            cardLista.TabIndex = 2;
            // 
            // layoutLista
            // 
            layoutLista.BackColor = Color.White;
            layoutLista.ColumnCount = 1;
            layoutLista.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutLista.Controls.Add(pnlListaTopo, 0, 0);
            layoutLista.Controls.Add(prgCarregando, 0, 1);
            layoutLista.Controls.Add(dgvClientes, 0, 2);
            layoutLista.Dock = DockStyle.Fill;
            layoutLista.Location = new Point(20, 20);
            layoutLista.Name = "layoutLista";
            layoutLista.RowCount = 3;
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            layoutLista.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLista.Size = new Size(1100, 322);
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
            lblListaTitulo.Anchor = AnchorStyles.Left;
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
            txtPesquisa.PlaceholderText = "Pesquisar por nome, telefone, CPF, CEP ou endereço...";
            txtPesquisa.Size = new Size(365, 31);
            txtPesquisa.TabIndex = 11;
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
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersHeight = 42;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = ColorTranslator.FromHtml("#E5E7EB");
            dgvClientes.Location = new Point(0, 54);
            dgvClientes.Margin = new Padding(0);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1100, 268);
            dgvClientes.TabIndex = 12;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // cardResumo
            // 
            cardResumo.BorderColor = ColorTranslator.FromHtml("#D1D5DB");
            cardResumo.CornerRadius = 12;
            cardResumo.Controls.Add(layoutResumo);
            cardResumo.Dock = DockStyle.Fill;
            cardResumo.FillColor = Color.White;
            cardResumo.Location = new Point(0, 744);
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ColorTranslator.FromHtml("#F5F5F5");
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(1000, 720);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerenciamento de Clientes";
            Load += Form_Load;
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
        private Label lblNomeSistema = null!;
        private Label lblTituloTela = null!;
        private Panel pnlUsuario = null!;
        private Label lblUsuario = null!;
        private Label lblDataHora = null!;
        private Panel pnlConteudo = null!;
        private TableLayoutPanel layoutConteudo = null!;
        private ModernPanel cardDados = null!;
        private TableLayoutPanel layoutDados = null!;
        private Label lblDadosTitulo = null!;
        private TableLayoutPanel gridDados = null!;
        private Label lblNome = null!;
        private TextBox txtNome = null!;
        private Label lblTelefone = null!;
        private MaskedTextBox txtTelefone = null!;
        private Label lblCpf = null!;
        private MaskedTextBox txtCpf = null!;
        private Label lblCep = null!;
        private MaskedTextBox txtCep = null!;
        private Label lblEndereco = null!;
        private TextBox txtEndereco = null!;
        private Label lblObservacoes = null!;
        private TextBox txtObservacoes = null!;
        private ModernPanel cardOperacoes = null!;
        private TableLayoutPanel layoutOperacoes = null!;
        private Label lblOperacoesTitulo = null!;
        private FlowLayoutPanel fluxoBotoes = null!;
        private ModernButton btnSalvar = null!;
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
        private DataGridView dgvClientes = null!;
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
