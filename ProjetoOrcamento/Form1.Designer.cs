namespace ProjetoOrcamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnClientes = new Button();
            btnServicos = new Button();
            btnOrcamentos = new Button();
            btnListarOrcamentos = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(445, 316);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(216, 56);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnServicos
            // 
            btnServicos.Location = new Point(445, 398);
            btnServicos.Margin = new Padding(3, 4, 3, 4);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(216, 53);
            btnServicos.TabIndex = 1;
            btnServicos.Text = "Serviços";
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.Location = new Point(668, 579);
            btnOrcamentos.Margin = new Padding(3, 4, 3, 4);
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.Size = new Size(130, 53);
            btnOrcamentos.TabIndex = 2;
            btnOrcamentos.Text = "Criar Orçamento";
            btnOrcamentos.UseVisualStyleBackColor = true;
            btnOrcamentos.Click += btnOrcamentos_Click;
            // 
            // btnListarOrcamentos
            // 
            btnListarOrcamentos.Location = new Point(859, 579);
            btnListarOrcamentos.Margin = new Padding(3, 4, 3, 4);
            btnListarOrcamentos.Name = "btnListarOrcamentos";
            btnListarOrcamentos.Size = new Size(130, 53);
            btnListarOrcamentos.TabIndex = 3;
            btnListarOrcamentos.Text = "Listar Orçamentos";
            btnListarOrcamentos.UseVisualStyleBackColor = true;
            btnListarOrcamentos.Click += btnListarOrcamentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 123);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 4;
            label1.Text = "EMISSOR DE ORÇAMENTOS";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(310, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_12_de_jun__de_2026__10_26_21;
            pictureBox2.Location = new Point(12, 548);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 677);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnListarOrcamentos);
            Controls.Add(btnOrcamentos);
            Controls.Add(btnServicos);
            Controls.Add(btnClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sistema de Orçamentos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnClientes;
        private Button btnServicos;
        private Button btnOrcamentos;
        private Button btnListarOrcamentos;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
