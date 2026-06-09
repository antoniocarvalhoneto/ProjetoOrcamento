namespace ProjetoOrcamento.Forms
{
    partial class FrmOrcamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            cmbServico = new ComboBox();
            label3 = new Label();
            nudQuantidade = new NumericUpDown();
            btnAdicionarItem = new Button();
            toolStrip1 = new ToolStrip();
            lstItens = new ListBox();
            btnCriarOrcamento = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente :";
            label1.Click += label1_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(82, 58);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 28);
            cmbCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Serviço :";
            // 
            // cmbServico
            // 
            cmbServico.FormattingEnabled = true;
            cmbServico.Location = new Point(82, 123);
            cmbServico.Name = "cmbServico";
            cmbServico.Size = new Size(151, 28);
            cmbServico.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 154);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantidade :";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(83, 177);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(150, 27);
            nudQuantidade.TabIndex = 5;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(83, 223);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(150, 29);
            btnAdicionarItem.TabIndex = 6;
            btnAdicionarItem.Text = "Adicionar Item";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(874, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.Location = new Point(83, 273);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(248, 104);
            lstItens.TabIndex = 8;
            // 
            // btnCriarOrcamento
            // 
            btnCriarOrcamento.Location = new Point(83, 383);
            btnCriarOrcamento.Name = "btnCriarOrcamento";
            btnCriarOrcamento.Size = new Size(130, 29);
            btnCriarOrcamento.TabIndex = 9;
            btnCriarOrcamento.Text = "Criar Orçamento";
            btnCriarOrcamento.UseVisualStyleBackColor = true;
            // 
            // FrmOrcamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 516);
            Controls.Add(btnCriarOrcamento);
            Controls.Add(lstItens);
            Controls.Add(toolStrip1);
            Controls.Add(btnAdicionarItem);
            Controls.Add(nudQuantidade);
            Controls.Add(label3);
            Controls.Add(cmbServico);
            Controls.Add(label2);
            Controls.Add(cmbCliente);
            Controls.Add(label1);
            Name = "FrmOrcamentos";
            Text = "FrmOrcamentos";
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCliente;
        private Label label2;
        private ComboBox cmbServico;
        private Label label3;
        private NumericUpDown nudQuantidade;
        private Button btnAdicionarItem;
        private ToolStrip toolStrip1;
        private ListBox lstItens;
        private Button btnCriarOrcamento;
    }
}