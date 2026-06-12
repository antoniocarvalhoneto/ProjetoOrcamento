namespace ProjetoOrcamento.Forms
{
    partial class FrmListaOrcamentos
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
            dgvOrcamentos = new DataGridView();
            btnAprovar = new Button();
            btnRejeitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvOrcamentos
            // 
            dgvOrcamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrcamentos.Location = new Point(95, 55);
            dgvOrcamentos.Margin = new Padding(3, 4, 3, 4);
            dgvOrcamentos.Name = "dgvOrcamentos";
            dgvOrcamentos.RowHeadersWidth = 51;
            dgvOrcamentos.Size = new Size(647, 200);
            dgvOrcamentos.TabIndex = 0;
            // 
            // btnAprovar
            // 
            btnAprovar.Location = new Point(330, 294);
            btnAprovar.Margin = new Padding(3, 4, 3, 4);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(175, 47);
            btnAprovar.TabIndex = 1;
            btnAprovar.Text = "Aprovar";
            btnAprovar.UseVisualStyleBackColor = true;
            btnAprovar.Click += btnAprovar_Click;
            // 
            // btnRejeitar
            // 
            btnRejeitar.Location = new Point(330, 367);
            btnRejeitar.Margin = new Padding(3, 4, 3, 4);
            btnRejeitar.Name = "btnRejeitar";
            btnRejeitar.Size = new Size(175, 49);
            btnRejeitar.TabIndex = 2;
            btnRejeitar.Text = "Rejeitar";
            btnRejeitar.UseVisualStyleBackColor = true;
            btnRejeitar.Click += btnRejeitar_Click;
            // 
            // FrmListaOrcamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 488);
            Controls.Add(btnRejeitar);
            Controls.Add(btnAprovar);
            Controls.Add(dgvOrcamentos);
            Name = "FrmListaOrcamentos";
            Text = "FrmListaOrcamentos";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrcamentos;
        private Button btnAprovar;
        private Button btnRejeitar;
    }
}