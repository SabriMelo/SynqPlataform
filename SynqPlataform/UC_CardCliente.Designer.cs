namespace SynqPlataform {
    partial class UC_CardCliente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CardCliente));
            lblNome = new Label();
            lblTipo = new Label();
            pbEdit = new PictureBox();
            pbExcluir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExcluir).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(64, 64, 64);
            lblNome.Location = new Point(0, 18);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(300, 31);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            lblNome.Click += CardCliente_Click;
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTipo.Location = new Point(0, 85);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(300, 31);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            lblTipo.Click += CardCliente_Click;
            // 
            // pbEdit
            // 
            pbEdit.Image = (Image)resources.GetObject("pbEdit.Image");
            pbEdit.Location = new Point(270, 3);
            pbEdit.Name = "pbEdit";
            pbEdit.Size = new Size(25, 25);
            pbEdit.SizeMode = PictureBoxSizeMode.Zoom;
            pbEdit.TabIndex = 7;
            pbEdit.TabStop = false;
            pbEdit.Click += pbEdit_Click;
            // 
            // pbExcluir
            // 
            pbExcluir.Image = (Image)resources.GetObject("pbExcluir.Image");
            pbExcluir.Location = new Point(270, 119);
            pbExcluir.Name = "pbExcluir";
            pbExcluir.Size = new Size(25, 25);
            pbExcluir.SizeMode = PictureBoxSizeMode.Zoom;
            pbExcluir.TabIndex = 8;
            pbExcluir.TabStop = false;
            pbExcluir.Click += pbExcluir_Click;
            // 
            // UC_CardCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 188, 199);
            Controls.Add(pbExcluir);
            Controls.Add(pbEdit);
            Controls.Add(lblTipo);
            Controls.Add(lblNome);
            Name = "UC_CardCliente";
            Size = new Size(300, 150);
            Click += CardCliente_Click;
            ((System.ComponentModel.ISupportInitialize)pbEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExcluir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblTipo;
        private PictureBox pbEdit;
        private PictureBox pbExcluir;
    }
}
