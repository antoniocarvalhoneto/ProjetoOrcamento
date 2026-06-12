namespace ProjetoOrcamento.Forms
{
    partial class FrmServicoss
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
            txtNomeServico = new TextBox();
            txtPreco = new TextBox();
            label2 = new Label();
            btnCadastrarServico = new Button();
            dgvServicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 43);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Servico";
            // 
            // txtNomeServico
            // 
            txtNomeServico.Location = new Point(329, 67);
            txtNomeServico.Margin = new Padding(3, 4, 3, 4);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.Size = new Size(114, 27);
            txtNomeServico.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(329, 134);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(114, 27);
            txtPreco.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 110);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Preco";
            // 
            // btnCadastrarServico
            // 
            btnCadastrarServico.Location = new Point(313, 183);
            btnCadastrarServico.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarServico.Name = "btnCadastrarServico";
            btnCadastrarServico.Size = new Size(147, 35);
            btnCadastrarServico.TabIndex = 4;
            btnCadastrarServico.Text = "Cadastrar Servico";
            btnCadastrarServico.UseVisualStyleBackColor = true;
            btnCadastrarServico.Click += btnCadastrarServico_Click;
            // 
            // dgvServicos
            // 
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Location = new Point(143, 251);
            dgvServicos.Margin = new Padding(3, 4, 3, 4);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.RowHeadersWidth = 51;
            dgvServicos.Size = new Size(579, 256);
            dgvServicos.TabIndex = 5;
            dgvServicos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmServicoss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvServicos);
            Controls.Add(btnCadastrarServico);
            Controls.Add(label2);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeServico);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmServicoss";
            Text = "Gerenciamento de Serviços";
            Load += FrmServicoss_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeServico;
        private TextBox txtPreco;
        private Label label2;
        private Button btnCadastrarServico;
        private DataGridView dgvServicos;
    }
}