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
            btnClientes.Location = new Point(187, 539);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(114, 56);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnServicos
            // 
            btnServicos.Location = new Point(507, 541);
            btnServicos.Margin = new Padding(3, 4, 3, 4);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(136, 53);
            btnServicos.TabIndex = 1;
            btnServicos.Text = "Serviços";
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.Location = new Point(839, 541);
            btnOrcamentos.Margin = new Padding(3, 4, 3, 4);
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.Size = new Size(130, 53);
            btnOrcamentos.TabIndex = 2;
            btnOrcamentos.Text = "Orçamentos";
            btnOrcamentos.UseVisualStyleBackColor = true;
            btnOrcamentos.Click += btnOrcamentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 123);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 3;
            label1.Text = "EMISSOR DE ORÇAMENTOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 677);
            Controls.Add(label1);
            Controls.Add(btnOrcamentos);
            Controls.Add(btnServicos);
            Controls.Add(btnClientes);
            Margin = new Padding(3, 4, 3, 4);
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
