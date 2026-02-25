namespace SynqPlataform {
    partial class UC_CardRelatorio {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblTituloRelatorio = new Label();
            lblDataRelatorio = new Label();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // lblTituloRelatorio
            // 
            lblTituloRelatorio.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            lblTituloRelatorio.ForeColor = Color.FromArgb(64, 64, 64);
            lblTituloRelatorio.Location = new Point(0, 11);
            lblTituloRelatorio.Name = "lblTituloRelatorio";
            lblTituloRelatorio.Size = new Size(250, 36);
            lblTituloRelatorio.TabIndex = 1;
            lblTituloRelatorio.Text = "Nome Equipe";
            lblTituloRelatorio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDataRelatorio
            // 
            lblDataRelatorio.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            lblDataRelatorio.ForeColor = Color.FromArgb(64, 64, 64);
            lblDataRelatorio.Location = new Point(0, 56);
            lblDataRelatorio.Name = "lblDataRelatorio";
            lblDataRelatorio.Size = new Size(250, 36);
            lblDataRelatorio.TabIndex = 2;
            lblDataRelatorio.Text = "Nome Equipe";
            lblDataRelatorio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsuario.Location = new Point(0, 101);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(250, 36);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Nome Equipe";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_CardRelatorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 188, 199);
            Controls.Add(lblUsuario);
            Controls.Add(lblDataRelatorio);
            Controls.Add(lblTituloRelatorio);
            Name = "UC_CardRelatorio";
            Size = new Size(250, 150);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloRelatorio;
        private Label lblDataRelatorio;
        private Label lblUsuario;
    }
}
