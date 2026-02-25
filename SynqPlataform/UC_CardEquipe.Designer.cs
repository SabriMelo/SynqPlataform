namespace SynqPlataform {
    partial class UC_CardEquipe {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CardEquipe));
            lblNomeEquipe = new Label();
            label1 = new Label();
            pbExcluir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbExcluir).BeginInit();
            SuspendLayout();
            // 
            // lblNomeEquipe
            // 
            lblNomeEquipe.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            lblNomeEquipe.ForeColor = Color.FromArgb(64, 64, 64);
            lblNomeEquipe.Location = new Point(0, 84);
            lblNomeEquipe.Name = "lblNomeEquipe";
            lblNomeEquipe.Size = new Size(297, 36);
            lblNomeEquipe.TabIndex = 0;
            lblNomeEquipe.Text = "Nome Equipe";
            lblNomeEquipe.TextAlign = ContentAlignment.MiddleCenter;
            lblNomeEquipe.Click += UC_CardEquipe_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(0, 25);
            label1.Margin = new Padding(3, 10, 10, 10);
            label1.Name = "label1";
            label1.Size = new Size(300, 39);
            label1.TabIndex = 1;
            label1.Text = "EQUIPE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += UC_CardEquipe_Click;
            // 
            // pbExcluir
            // 
            pbExcluir.Image = (Image)resources.GetObject("pbExcluir.Image");
            pbExcluir.Location = new Point(272, 122);
            pbExcluir.Name = "pbExcluir";
            pbExcluir.Size = new Size(25, 25);
            pbExcluir.SizeMode = PictureBoxSizeMode.Zoom;
            pbExcluir.TabIndex = 9;
            pbExcluir.TabStop = false;
            pbExcluir.Click += pbExcluir_Click;
            // 
            // UC_CardEquipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 188, 199);
            Controls.Add(pbExcluir);
            Controls.Add(label1);
            Controls.Add(lblNomeEquipe);
            Cursor = Cursors.Hand;
            Margin = new Padding(20);
            Name = "UC_CardEquipe";
            Size = new Size(300, 150);
            Click += UC_CardEquipe_Click;
            ((System.ComponentModel.ISupportInitialize)pbExcluir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeEquipe;
        private Label label1;
        private PictureBox pbExcluir;
    }
}
