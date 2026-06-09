namespace ProjetoOrcamento.Forms
{
    partial class FrmClientes
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
            txtContato = new TextBox();
            btnCadastro = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtContato
            // 
            txtContato.Location = new Point(348, 162);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(125, 27);
            txtContato.TabIndex = 0;
            txtContato.TextChanged += textBox1_TextChanged;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(361, 208);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(94, 29);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 139);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Contato";
            label2.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(348, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 4;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(153, 276);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(539, 188);
            dgvClientes.TabIndex = 5;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 522);
            Controls.Add(dgvClientes);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastro);
            Controls.Add(txtContato);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContato;
        private Button btnCadastro;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private DataGridView dgvClientes;
    }
}