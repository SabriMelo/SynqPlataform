namespace SynqPlataform {
    partial class UC_CardMembro {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CardMembro));
            lblNome = new Label();
            lblCargo = new Label();
            pbExcluir = new PictureBox();
            pbEdit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbExcluir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEdit).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(64, 64, 64);
            lblNome.Location = new Point(0, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(273, 36);
            lblNome.TabIndex = 0;
            lblNome.Text = "label1";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            lblNome.Click += UC_CardMembro_Click;
            // 
            // lblCargo
            // 
            lblCargo.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCargo.Location = new Point(0, 78);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(273, 36);
            lblCargo.TabIndex = 1;
            lblCargo.Text = "label1";
            lblCargo.TextAlign = ContentAlignment.MiddleCenter;
            lblCargo.Click += UC_CardMembro_Click;
            // 
            // pbExcluir
            // 
            pbExcluir.Image = (Image)resources.GetObject("pbExcluir.Image");
            pbExcluir.Location = new Point(248, 117);
            pbExcluir.Name = "pbExcluir";
            pbExcluir.Size = new Size(25, 25);
            pbExcluir.SizeMode = PictureBoxSizeMode.Zoom;
            pbExcluir.TabIndex = 8;
            pbExcluir.TabStop = false;
            pbExcluir.Click += pbExcluir_Click;
            // 
            // pbEdit
            // 
            pbEdit.Image = (Image)resources.GetObject("pbEdit.Image");
            pbEdit.Location = new Point(248, 3);
            pbEdit.Name = "pbEdit";
            pbEdit.Size = new Size(25, 25);
            pbEdit.SizeMode = PictureBoxSizeMode.Zoom;
            pbEdit.TabIndex = 9;
            pbEdit.TabStop = false;
            pbEdit.Click += pbEdit_Click;
            // 
            // UC_CardMembro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 188, 199);
            Controls.Add(pbEdit);
            Controls.Add(pbExcluir);
            Controls.Add(lblCargo);
            Controls.Add(lblNome);
            Cursor = Cursors.Hand;
            Margin = new Padding(20);
            Name = "UC_CardMembro";
            Size = new Size(286, 150);
            Click += UC_CardMembro_Click;
            ((System.ComponentModel.ISupportInitialize)pbExcluir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblCargo;
        private PictureBox pbExcluir;
        private PictureBox pbEdit;
    }
}
