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
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Servico";
            // 
            // txtNomeServico
            // 
            txtNomeServico.Location = new Point(81, 59);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.Size = new Size(100, 23);
            txtNomeServico.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(81, 124);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 106);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Preco";
            // 
            // btnCadastrarServico
            // 
            btnCadastrarServico.Location = new Point(81, 171);
            btnCadastrarServico.Name = "btnCadastrarServico";
            btnCadastrarServico.Size = new Size(129, 26);
            btnCadastrarServico.TabIndex = 4;
            btnCadastrarServico.Text = "Cadastrar Servico";
            btnCadastrarServico.UseVisualStyleBackColor = true;
            // 
            // dgvServicos
            // 
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Location = new Point(81, 223);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.Size = new Size(383, 172);
            dgvServicos.TabIndex = 5;
            dgvServicos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmServicoss
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvServicos);
            Controls.Add(btnCadastrarServico);
            Controls.Add(label2);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeServico);
            Controls.Add(label1);
            Name = "FrmServicoss";
            Text = "FrmServicos";
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