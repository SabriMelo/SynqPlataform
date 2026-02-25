namespace SynqPlataform
{
    partial class FormPrincipal
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            btnEquipe = new Button();
            btnCliente = new Button();
            btnObra = new Button();
            btnProjeto = new Button();
            btnHome = new Button();
            pnlConteudo = new Panel();
            timerMonitor = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 188, 199);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnEquipe);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(btnObra);
            panel1.Controls.Add(btnProjeto);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 900);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.FromArgb(64, 64, 64);
            btnSair.Location = new Point(0, 837);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(191, 34);
            btnSair.TabIndex = 6;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEquipe
            // 
            btnEquipe.FlatAppearance.BorderSize = 0;
            btnEquipe.FlatStyle = FlatStyle.Flat;
            btnEquipe.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipe.ForeColor = Color.FromArgb(64, 64, 64);
            btnEquipe.Location = new Point(0, 394);
            btnEquipe.Name = "btnEquipe";
            btnEquipe.Size = new Size(188, 34);
            btnEquipe.TabIndex = 4;
            btnEquipe.Text = "EQUIPE";
            btnEquipe.UseVisualStyleBackColor = true;
            btnEquipe.Click += btnEquipe_Click;
            // 
            // btnCliente
            // 
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnCliente.Location = new Point(-3, 333);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(188, 34);
            btnCliente.TabIndex = 3;
            btnCliente.Text = "CLIENTE";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnClientes_Click;
            // 
            // btnObra
            // 
            btnObra.FlatAppearance.BorderSize = 0;
            btnObra.FlatStyle = FlatStyle.Flat;
            btnObra.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObra.ForeColor = Color.FromArgb(64, 64, 64);
            btnObra.Location = new Point(0, 271);
            btnObra.Name = "btnObra";
            btnObra.Size = new Size(188, 34);
            btnObra.TabIndex = 2;
            btnObra.Text = "REGISTRO OBRA";
            btnObra.UseVisualStyleBackColor = true;
            btnObra.Click += btnObras_Click;
            // 
            // btnProjeto
            // 
            btnProjeto.FlatAppearance.BorderSize = 0;
            btnProjeto.FlatStyle = FlatStyle.Flat;
            btnProjeto.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProjeto.ForeColor = Color.FromArgb(64, 64, 64);
            btnProjeto.Location = new Point(0, 209);
            btnProjeto.Name = "btnProjeto";
            btnProjeto.Size = new Size(188, 34);
            btnProjeto.TabIndex = 1;
            btnProjeto.Text = "PROJETO";
            btnProjeto.UseVisualStyleBackColor = true;
            btnProjeto.Click += btnProjetos_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(64, 64, 64);
            btnHome.Location = new Point(0, 148);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 34);
            btnHome.TabIndex = 0;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(230, 239, 242);
            pnlConteudo.Location = new Point(191, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1309, 900);
            pnlConteudo.TabIndex = 1;
            // 
            // timerMonitor
            // 
            timerMonitor.Enabled = true;
            timerMonitor.Interval = 60000;
            timerMonitor.Tick += timerMonitor_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1500, 900);
            Controls.Add(pnlConteudo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SynqApliccation";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlConteudo;
        private Button btnProjeto;
        private Button btnHome;
        private Button btnEquipe;
        private Button btnCliente;
        private Button btnObra;
        private PictureBox pictureBox1;
        private Button btnSair;
        private System.Windows.Forms.Timer timerMonitor;
    }
}
