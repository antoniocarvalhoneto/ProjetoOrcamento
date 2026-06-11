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
            dgvOrcamentos.Location = new Point(68, 31);
            dgvOrcamentos.Name = "dgvOrcamentos";
            dgvOrcamentos.Size = new Size(240, 150);
            dgvOrcamentos.TabIndex = 0;
            // 
            // btnAprovar
            // 
            btnAprovar.Location = new Point(68, 199);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(73, 35);
            btnAprovar.TabIndex = 1;
            btnAprovar.Text = "Aprovar";
            btnAprovar.UseVisualStyleBackColor = true;
            // 
            // btnRejeitar
            // 
            btnRejeitar.Location = new Point(68, 240);
            btnRejeitar.Name = "btnRejeitar";
            btnRejeitar.Size = new Size(73, 37);
            btnRejeitar.TabIndex = 2;
            btnRejeitar.Text = "Rejeitar";
            btnRejeitar.UseVisualStyleBackColor = true;
            // 
            // FrmListaOrcamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 366);
            Controls.Add(btnRejeitar);
            Controls.Add(btnAprovar);
            Controls.Add(dgvOrcamentos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmListaOrcamentos";
            Text = "FrmListaOrcamentos";
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrcamentos;
        private Button btnAprovar;
        private Button btnRejeitar;
    }
}