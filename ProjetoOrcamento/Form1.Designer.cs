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
            btnClientes = new Button();
            btnServicos = new Button();
            btnOrcamentos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(164, 404);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(100, 42);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += this.button1_Click;
            // 
            // btnServicos
            // 
            btnServicos.Location = new Point(444, 406);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(119, 40);
            btnServicos.TabIndex = 1;
            btnServicos.Text = "Serviços";
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += this.button1_Click_1;
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.Location = new Point(734, 406);
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.Size = new Size(114, 40);
            btnOrcamentos.TabIndex = 2;
            btnOrcamentos.Text = "Orçamentos";
            btnOrcamentos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 92);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 3;
            label1.Text = "EMISSOR DE ORÇAMENTOS";
            label1.Click += this.label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 586);
            Controls.Add(label1);
            Controls.Add(btnOrcamentos);
            Controls.Add(btnServicos);
            Controls.Add(btnClientes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnServicos;
        private Button btnOrcamentos;
        private Label label1;


    }
}
