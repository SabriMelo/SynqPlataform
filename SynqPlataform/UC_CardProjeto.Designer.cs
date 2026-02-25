namespace SynqPlataform {
    partial class UC_CardProjeto {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CardProjeto));
            lblStatus = new Label();
            lblNomeProjeto = new Label();
            lblEquipe = new Label();
            lblCodigo = new Label();
            pbEdit = new PictureBox();
            pbExcluir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExcluir).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatus.Location = new Point(0, 80);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 35);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += UC_CardProjeto_Click;
            // 
            // lblNomeProjeto
            // 
            lblNomeProjeto.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            lblNomeProjeto.ForeColor = Color.FromArgb(64, 64, 64);
            lblNomeProjeto.Location = new Point(0, 10);
            lblNomeProjeto.Name = "lblNomeProjeto";
            lblNomeProjeto.Size = new Size(300, 35);
            lblNomeProjeto.TabIndex = 2;
            lblNomeProjeto.Text = "Nome";
            lblNomeProjeto.TextAlign = ContentAlignment.MiddleCenter;
            lblNomeProjeto.Click += UC_CardProjeto_Click;
            // 
            // lblEquipe
            // 
            lblEquipe.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            lblEquipe.ForeColor = Color.FromArgb(64, 64, 64);
            lblEquipe.Location = new Point(0, 45);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(300, 35);
            lblEquipe.TabIndex = 4;
            lblEquipe.Text = "Equipe";
            lblEquipe.TextAlign = ContentAlignment.MiddleCenter;
            lblEquipe.Click += UC_CardProjeto_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodigo.Location = new Point(0, 115);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(300, 35);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Codigo";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            lblCodigo.Click += UC_CardProjeto_Click;
            // 
            // pbEdit
            // 
            pbEdit.Image = (Image)resources.GetObject("pbEdit.Image");
            pbEdit.Location = new Point(272, 3);
            pbEdit.Name = "pbEdit";
            pbEdit.Size = new Size(25, 25);
            pbEdit.SizeMode = PictureBoxSizeMode.Zoom;
            pbEdit.TabIndex = 6;
            pbEdit.TabStop = false;
            pbEdit.Click += pbEdit_Click;
            // 
            // pbExcluir
            // 
            pbExcluir.Image = (Image)resources.GetObject("pbExcluir.Image");
            pbExcluir.Location = new Point(272, 122);
            pbExcluir.Name = "pbExcluir";
            pbExcluir.Size = new Size(25, 25);
            pbExcluir.SizeMode = PictureBoxSizeMode.Zoom;
            pbExcluir.TabIndex = 7;
            pbExcluir.TabStop = false;
            pbExcluir.Click += pbExcluir_Click;
            // 
            // UC_CardProjeto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 188, 199);
            Controls.Add(pbExcluir);
            Controls.Add(pbEdit);
            Controls.Add(lblCodigo);
            Controls.Add(lblEquipe);
            Controls.Add(lblStatus);
            Controls.Add(lblNomeProjeto);
            Cursor = Cursors.Hand;
            Margin = new Padding(5);
            Name = "UC_CardProjeto";
            Size = new Size(300, 150);
            Click += UC_CardProjeto_Click;
            ((System.ComponentModel.ISupportInitialize)pbEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExcluir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStatus;
        private Label lblNomeProjeto;
        private Label lblEquipe;
        private Label lblCodigo;
        private PictureBox pbEdit;
        private PictureBox pbExcluir;
    }
}
