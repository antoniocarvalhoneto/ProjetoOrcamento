using ProjetoOrcamento.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoOrcamento
{
    partial class Form1
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
            lblTituloSistema = new Label();
            lblSubtitulo = new Label();
            pnlUsuario = new Panel();
            lblUsuario = new Label();
            lblDataHora = new Label();
            pnlConteudo = new Panel();
            layoutConteudo = new TableLayoutPanel();
            cardApresentacao = new ModernPanel();
            layoutApresentacao = new TableLayoutPanel();
            picLogoPrincipal = new PictureBox();
            pnlIntro = new Panel();
            lblIntroTitulo = new Label();
            lblIntroTexto = new Label();
            cardIndicadores = new ModernPanel();
            layoutIndicadores = new TableLayoutPanel();
            lblClientesResumo = new Label();
            lblServicosResumo = new Label();
            lblOrcamentosResumo = new Label();
            lblTotalResumo = new Label();
            cardModulos = new ModernPanel();
            layoutModulos = new TableLayoutPanel();
            lblModulosTitulo = new Label();
            fluxoModulos = new FlowLayoutPanel();
            btnClientes = new ModernButton();
            btnServicos = new ModernButton();
            btnOrcamentos = new ModernButton();
            btnListarOrcamentos = new ModernButton();
            btnUsuarios = new ModernButton();
            picLogoRodape = new PictureBox();
            tmrRelogio = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            headerLayout.SuspendLayout();
            pnlTituloHeader.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlConteudo.SuspendLayout();
            layoutConteudo.SuspendLayout();
            cardApresentacao.SuspendLayout();
            layoutApresentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoPrincipal).BeginInit();
            pnlIntro.SuspendLayout();
            cardIndicadores.SuspendLayout();
            layoutIndicadores.SuspendLayout();
            cardModulos.SuspendLayout();
            layoutModulos.SuspendLayout();
            fluxoModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoRodape).BeginInit();
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
            lblIconeTela.Text = "▣";
            lblIconeTela.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTituloHeader
            // 
            pnlTituloHeader.Controls.Add(lblTituloSistema);
            pnlTituloHeader.Controls.Add(lblSubtitulo);
            pnlTituloHeader.Dock = DockStyle.Fill;
            pnlTituloHeader.Location = new Point(54, 0);
            pnlTituloHeader.Margin = new Padding(0);
            pnlTituloHeader.Name = "pnlTituloHeader";
            pnlTituloHeader.Size = new Size(782, 54);
            pnlTituloHeader.TabIndex = 1;
            // 
            // lblTituloSistema
            // 
            lblTituloSistema.Dock = DockStyle.Top;
            lblTituloSistema.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloSistema.ForeColor = Color.White;
            lblTituloSistema.Location = new Point(0, 0);
            lblTituloSistema.Name = "lblTituloSistema";
            lblTituloSistema.Size = new Size(782, 30);
            lblTituloSistema.TabIndex = 0;
            lblTituloSistema.Text = "Sistema de Orçamentos";
            lblTituloSistema.TextAlign = ContentAlignment.MiddleLeft;
            lblTituloSistema.Click += lblTituloSistema_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Dock = DockStyle.Top;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = ColorTranslator.FromHtml("#DBEAFE");
            lblSubtitulo.Location = new Point(0, 30);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(782, 22);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Clientes, serviços e propostas comerciais em um fluxo único";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
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
            layoutConteudo.Controls.Add(cardApresentacao, 0, 0);
            layoutConteudo.Controls.Add(cardIndicadores, 0, 1);
            layoutConteudo.Controls.Add(cardModulos, 0, 2);
            layoutConteudo.Dock = DockStyle.Top;
            layoutConteudo.Location = new Point(22, 22);
            layoutConteudo.Name = "layoutConteudo";
            layoutConteudo.RowCount = 3;
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            layoutConteudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            layoutConteudo.Size = new Size(1140, 530);
            layoutConteudo.TabIndex = 0;
            // 
            // cardApresentacao
            // 
            cardApresentacao.Controls.Add(layoutApresentacao);
            cardApresentacao.Dock = DockStyle.Fill;
            cardApresentacao.Location = new Point(0, 0);
            cardApresentacao.Margin = new Padding(0, 0, 0, 16);
            cardApresentacao.Name = "cardApresentacao";
            cardApresentacao.Padding = new Padding(20);
            cardApresentacao.Size = new Size(1140, 174);
            cardApresentacao.TabIndex = 0;
            // 
            // layoutApresentacao
            // 
            layoutApresentacao.BackColor = Color.White;
            layoutApresentacao.ColumnCount = 2;
            layoutApresentacao.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            layoutApresentacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutApresentacao.Controls.Add(picLogoPrincipal, 0, 0);
            layoutApresentacao.Controls.Add(pnlIntro, 1, 0);
            layoutApresentacao.Dock = DockStyle.Fill;
            layoutApresentacao.Location = new Point(20, 20);
            layoutApresentacao.Name = "layoutApresentacao";
            layoutApresentacao.RowCount = 1;
            layoutApresentacao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutApresentacao.Size = new Size(1100, 134);
            layoutApresentacao.TabIndex = 0;
            // 
            // picLogoPrincipal
            // 
            picLogoPrincipal.Dock = DockStyle.Fill;
            picLogoPrincipal.Image = Properties.Resources.ChatGPT_Image_12_de_jun__de_2026__10_12_39;
            picLogoPrincipal.Location = new Point(0, 0);
            picLogoPrincipal.Margin = new Padding(0, 0, 18, 0);
            picLogoPrincipal.Name = "picLogoPrincipal";
            picLogoPrincipal.Size = new Size(172, 134);
            picLogoPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoPrincipal.TabIndex = 0;
            picLogoPrincipal.TabStop = false;
            picLogoPrincipal.Click += picLogoPrincipal_Click;
            // 
            // pnlIntro
            // 
            pnlIntro.Controls.Add(lblIntroTitulo);
            pnlIntro.Controls.Add(lblIntroTexto);
            pnlIntro.Dock = DockStyle.Fill;
            pnlIntro.Location = new Point(190, 0);
            pnlIntro.Margin = new Padding(0);
            pnlIntro.Name = "pnlIntro";
            pnlIntro.Size = new Size(910, 134);
            pnlIntro.TabIndex = 1;
            // 
            // lblIntroTitulo
            // 
            lblIntroTitulo.Dock = DockStyle.Top;
            lblIntroTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblIntroTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblIntroTitulo.Location = new Point(0, 0);
            lblIntroTitulo.Name = "lblIntroTitulo";
            lblIntroTitulo.Size = new Size(910, 44);
            lblIntroTitulo.TabIndex = 0;
            lblIntroTitulo.Text = "Painel de controle";
            lblIntroTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIntroTexto
            // 
            lblIntroTexto.Dock = DockStyle.Top;
            lblIntroTexto.Font = new Font("Segoe UI", 10.5F);
            lblIntroTexto.ForeColor = ColorTranslator.FromHtml("#374151");
            lblIntroTexto.Location = new Point(0, 44);
            lblIntroTexto.Name = "lblIntroTexto";
            lblIntroTexto.Size = new Size(910, 58);
            lblIntroTexto.TabIndex = 1;
            lblIntroTexto.Text = "Acesse os cadastros e acompanhe os orçamentos pelo resumo abaixo.";
            lblIntroTexto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cardIndicadores
            // 
            cardIndicadores.Controls.Add(layoutIndicadores);
            cardIndicadores.Dock = DockStyle.Fill;
            cardIndicadores.Location = new Point(0, 190);
            cardIndicadores.Margin = new Padding(0, 0, 0, 16);
            cardIndicadores.Name = "cardIndicadores";
            cardIndicadores.Padding = new Padding(20);
            cardIndicadores.Size = new Size(1140, 104);
            cardIndicadores.TabIndex = 1;
            // 
            // layoutIndicadores
            // 
            layoutIndicadores.BackColor = Color.White;
            layoutIndicadores.ColumnCount = 4;
            layoutIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            layoutIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            layoutIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            layoutIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            layoutIndicadores.Controls.Add(lblClientesResumo, 0, 0);
            layoutIndicadores.Controls.Add(lblServicosResumo, 1, 0);
            layoutIndicadores.Controls.Add(lblOrcamentosResumo, 2, 0);
            layoutIndicadores.Controls.Add(lblTotalResumo, 3, 0);
            layoutIndicadores.Dock = DockStyle.Fill;
            layoutIndicadores.Location = new Point(20, 20);
            layoutIndicadores.Name = "layoutIndicadores";
            layoutIndicadores.RowCount = 1;
            layoutIndicadores.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutIndicadores.Size = new Size(1100, 64);
            layoutIndicadores.TabIndex = 0;
            // 
            // lblClientesResumo
            // 
            lblClientesResumo.Dock = DockStyle.Fill;
            lblClientesResumo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblClientesResumo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblClientesResumo.Location = new Point(0, 0);
            lblClientesResumo.Margin = new Padding(0);
            lblClientesResumo.Name = "lblClientesResumo";
            lblClientesResumo.Size = new Size(275, 64);
            lblClientesResumo.TabIndex = 0;
            lblClientesResumo.Text = "Clientes: 0";
            lblClientesResumo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblServicosResumo
            // 
            lblServicosResumo.Dock = DockStyle.Fill;
            lblServicosResumo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblServicosResumo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblServicosResumo.Location = new Point(275, 0);
            lblServicosResumo.Margin = new Padding(0);
            lblServicosResumo.Name = "lblServicosResumo";
            lblServicosResumo.Size = new Size(275, 64);
            lblServicosResumo.TabIndex = 1;
            lblServicosResumo.Text = "Serviços: 0";
            lblServicosResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrcamentosResumo
            // 
            lblOrcamentosResumo.Dock = DockStyle.Fill;
            lblOrcamentosResumo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOrcamentosResumo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblOrcamentosResumo.Location = new Point(550, 0);
            lblOrcamentosResumo.Margin = new Padding(0);
            lblOrcamentosResumo.Name = "lblOrcamentosResumo";
            lblOrcamentosResumo.Size = new Size(275, 64);
            lblOrcamentosResumo.TabIndex = 2;
            lblOrcamentosResumo.Text = "Orçamentos: 0";
            lblOrcamentosResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalResumo
            // 
            lblTotalResumo.Dock = DockStyle.Fill;
            lblTotalResumo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalResumo.ForeColor = ColorTranslator.FromHtml("#16A34A");
            lblTotalResumo.Location = new Point(825, 0);
            lblTotalResumo.Margin = new Padding(0);
            lblTotalResumo.Name = "lblTotalResumo";
            lblTotalResumo.Size = new Size(275, 64);
            lblTotalResumo.TabIndex = 3;
            lblTotalResumo.Text = "Total: R$ 0,00";
            lblTotalResumo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cardModulos
            // 
            cardModulos.Controls.Add(layoutModulos);
            cardModulos.Dock = DockStyle.Fill;
            cardModulos.Location = new Point(0, 310);
            cardModulos.Margin = new Padding(0);
            cardModulos.Name = "cardModulos";
            cardModulos.Padding = new Padding(20);
            cardModulos.Size = new Size(1140, 220);
            cardModulos.TabIndex = 2;
            // 
            // layoutModulos
            // 
            layoutModulos.BackColor = Color.White;
            layoutModulos.ColumnCount = 1;
            layoutModulos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutModulos.Controls.Add(lblModulosTitulo, 0, 0);
            layoutModulos.Controls.Add(fluxoModulos, 0, 1);
            layoutModulos.Dock = DockStyle.Fill;
            layoutModulos.Location = new Point(20, 20);
            layoutModulos.Name = "layoutModulos";
            layoutModulos.RowCount = 2;
            layoutModulos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            layoutModulos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutModulos.Size = new Size(1100, 180);
            layoutModulos.TabIndex = 0;
            // 
            // lblModulosTitulo
            // 
            lblModulosTitulo.Dock = DockStyle.Fill;
            lblModulosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblModulosTitulo.ForeColor = ColorTranslator.FromHtml("#111827");
            lblModulosTitulo.Location = new Point(0, 0);
            lblModulosTitulo.Margin = new Padding(0);
            lblModulosTitulo.Name = "lblModulosTitulo";
            lblModulosTitulo.Size = new Size(1100, 38);
            lblModulosTitulo.TabIndex = 0;
            lblModulosTitulo.Text = "Módulos";
            lblModulosTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fluxoModulos
            // 
            fluxoModulos.Controls.Add(btnClientes);
            fluxoModulos.Controls.Add(btnServicos);
            fluxoModulos.Controls.Add(btnOrcamentos);
            fluxoModulos.Controls.Add(btnListarOrcamentos);
            fluxoModulos.Controls.Add(btnUsuarios);
            fluxoModulos.Controls.Add(picLogoRodape);
            fluxoModulos.Dock = DockStyle.Fill;
            fluxoModulos.Location = new Point(0, 38);
            fluxoModulos.Margin = new Padding(0);
            fluxoModulos.Name = "fluxoModulos";
            fluxoModulos.Size = new Size(1100, 142);
            fluxoModulos.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.HoverBackColor = ColorTranslator.FromHtml("#1D4ED8");
            btnClientes.Location = new Point(0, 12);
            btnClientes.Margin = new Padding(0, 12, 14, 12);
            btnClientes.Name = "btnClientes";
            btnClientes.NormalBackColor = ColorTranslator.FromHtml("#2563EB");
            btnClientes.PressedBackColor = ColorTranslator.FromHtml("#1E40AF");
            btnClientes.Size = new Size(200, 74);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "👤 Clientes";
            btnClientes.Click += btnClientes_Click;
            // 
            // btnServicos
            // 
            btnServicos.HoverBackColor = ColorTranslator.FromHtml("#1D4ED8");
            btnServicos.Location = new Point(214, 12);
            btnServicos.Margin = new Padding(0, 12, 14, 12);
            btnServicos.Name = "btnServicos";
            btnServicos.NormalBackColor = ColorTranslator.FromHtml("#2563EB");
            btnServicos.PressedBackColor = ColorTranslator.FromHtml("#1E40AF");
            btnServicos.Size = new Size(200, 74);
            btnServicos.TabIndex = 1;
            btnServicos.Text = "🧾 Serviços";
            btnServicos.Click += btnServicos_Click;
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.HoverBackColor = ColorTranslator.FromHtml("#15803D");
            btnOrcamentos.Location = new Point(428, 12);
            btnOrcamentos.Margin = new Padding(0, 12, 14, 12);
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.NormalBackColor = ColorTranslator.FromHtml("#16A34A");
            btnOrcamentos.PressedBackColor = ColorTranslator.FromHtml("#166534");
            btnOrcamentos.Size = new Size(200, 74);
            btnOrcamentos.TabIndex = 2;
            btnOrcamentos.Text = "➕ Criar orçamento";
            btnOrcamentos.Click += btnOrcamentos_Click;
            // 
            // btnListarOrcamentos
            // 
            btnListarOrcamentos.HoverBackColor = ColorTranslator.FromHtml("#1D4ED8");
            btnListarOrcamentos.Location = new Point(642, 12);
            btnListarOrcamentos.Margin = new Padding(0, 12, 14, 12);
            btnListarOrcamentos.Name = "btnListarOrcamentos";
            btnListarOrcamentos.NormalBackColor = ColorTranslator.FromHtml("#1E3A8A");
            btnListarOrcamentos.PressedBackColor = ColorTranslator.FromHtml("#1E40AF");
            btnListarOrcamentos.Size = new Size(200, 74);
            btnListarOrcamentos.TabIndex = 3;
            btnListarOrcamentos.Text = "📋 Orçamentos";
            btnListarOrcamentos.Click += btnListarOrcamentos_Click;
            //
            // btnUsuarios
            //
            btnUsuarios.HoverBackColor = ColorTranslator.FromHtml("#7C3AED");
            btnUsuarios.Location = new Point(856, 12);
            btnUsuarios.Margin = new Padding(0, 12, 14, 12);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NormalBackColor = ColorTranslator.FromHtml("#6D28D9");
            btnUsuarios.PressedBackColor = ColorTranslator.FromHtml("#5B21B6");
            btnUsuarios.Size = new Size(200, 74);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "🔐 Usuários";
            btnUsuarios.Visible = false;
            btnUsuarios.Click += btnUsuarios_Click;
            //
            // picLogoRodape
            // 
            picLogoRodape.Image = Properties.Resources.ChatGPT_Image_12_de_jun__de_2026__10_26_21;
            picLogoRodape.Location = new Point(856, 12);
            picLogoRodape.Margin = new Padding(0, 12, 0, 12);
            picLogoRodape.Name = "picLogoRodape";
            picLogoRodape.Size = new Size(134, 74);
            picLogoRodape.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoRodape.TabIndex = 5;
            picLogoRodape.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = ColorTranslator.FromHtml("#F5F5F5");
            ClientSize = new Size(1184, 761);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1040, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Orçamentos";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            headerLayout.ResumeLayout(false);
            pnlTituloHeader.ResumeLayout(false);
            pnlUsuario.ResumeLayout(false);
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            layoutConteudo.ResumeLayout(false);
            cardApresentacao.ResumeLayout(false);
            layoutApresentacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoPrincipal).EndInit();
            pnlIntro.ResumeLayout(false);
            cardIndicadores.ResumeLayout(false);
            layoutIndicadores.ResumeLayout(false);
            cardModulos.ResumeLayout(false);
            layoutModulos.ResumeLayout(false);
            fluxoModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoRodape).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader = null!;
        private TableLayoutPanel headerLayout = null!;
        private Label lblIconeTela = null!;
        private Panel pnlTituloHeader = null!;
        private Label lblTituloSistema = null!;
        private Label lblSubtitulo = null!;
        private Panel pnlUsuario = null!;
        private Label lblUsuario = null!;
        private Label lblDataHora = null!;
        private Panel pnlConteudo = null!;
        private TableLayoutPanel layoutConteudo = null!;
        private ModernPanel cardApresentacao = null!;
        private TableLayoutPanel layoutApresentacao = null!;
        private PictureBox picLogoPrincipal = null!;
        private Panel pnlIntro = null!;
        private Label lblIntroTitulo = null!;
        private Label lblIntroTexto = null!;
        private ModernPanel cardIndicadores = null!;
        private TableLayoutPanel layoutIndicadores = null!;
        private Label lblClientesResumo = null!;
        private Label lblServicosResumo = null!;
        private Label lblOrcamentosResumo = null!;
        private Label lblTotalResumo = null!;
        private ModernPanel cardModulos = null!;
        private TableLayoutPanel layoutModulos = null!;
        private Label lblModulosTitulo = null!;
        private FlowLayoutPanel fluxoModulos = null!;
        private ModernButton btnClientes = null!;
        private ModernButton btnServicos = null!;
        private ModernButton btnOrcamentos = null!;
        private ModernButton btnListarOrcamentos = null!;
        private ModernButton btnUsuarios = null!;
        private PictureBox picLogoRodape = null!;
        private System.Windows.Forms.Timer tmrRelogio = null!;
    }
}
