namespace SynqPlataform {
    partial class FormLogin {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Button btnVoltarProjeto;
            Button btnEntrar;
            Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            tbNome = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tbUsuario = new TextBox();
            label3 = new Label();
            tbSenha = new TextBox();
            label4 = new Label();
            nomeCabecalho = new Label();
            chkMostrarSenha = new CheckBox();
            chkLembrar = new CheckBox();
            btnVoltarProjeto = new Button();
            btnEntrar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVoltarProjeto
            // 
            btnVoltarProjeto.BackColor = Color.FromArgb(159, 188, 199);
            btnVoltarProjeto.Cursor = Cursors.Hand;
            btnVoltarProjeto.FlatAppearance.BorderSize = 0;
            btnVoltarProjeto.FlatStyle = FlatStyle.Flat;
            btnVoltarProjeto.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarProjeto.ForeColor = Color.FromArgb(64, 64, 64);
            btnVoltarProjeto.Location = new Point(-68, 655);
            btnVoltarProjeto.Name = "btnVoltarProjeto";
            btnVoltarProjeto.Size = new Size(186, 34);
            btnVoltarProjeto.TabIndex = 42;
            btnVoltarProjeto.Text = "Voltar";
            btnVoltarProjeto.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(159, 188, 199);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(64, 64, 64);
            btnEntrar.Location = new Point(78, 472);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(283, 34);
            btnEntrar.TabIndex = 45;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 188, 199);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(78, 563);
            button1.Name = "button1";
            button1.Size = new Size(283, 34);
            button1.TabIndex = 50;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(78, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(-68, -54);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(587, 31);
            tbNome.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-68, -88);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 40;
            label1.Text = "Nome Projeto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, -155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(587, 31);
            textBox1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, -189);
            label2.Name = "label2";
            label2.Size = new Size(137, 31);
            label2.TabIndex = 43;
            label2.Text = "Nome Projeto";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(78, 288);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(283, 31);
            tbUsuario.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 254);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 46;
            label3.Text = "Usuário";
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(78, 382);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(283, 31);
            tbSenha.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 348);
            label4.Name = "label4";
            label4.Size = new Size(72, 31);
            label4.TabIndex = 48;
            label4.Text = "Senha";
            // 
            // nomeCabecalho
            // 
            nomeCabecalho.Font = new Font("Poppins SemiBold", 15F, FontStyle.Bold);
            nomeCabecalho.ForeColor = Color.FromArgb(64, 64, 64);
            nomeCabecalho.Location = new Point(2, 141);
            nomeCabecalho.Name = "nomeCabecalho";
            nomeCabecalho.Size = new Size(447, 70);
            nomeCabecalho.TabIndex = 51;
            nomeCabecalho.Text = "Login";
            nomeCabecalho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Location = new Point(367, 382);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(63, 29);
            chkMostrarSenha.TabIndex = 52;
            chkMostrarSenha.Text = "👁️";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // chkLembrar
            // 
            chkLembrar.AutoSize = true;
            chkLembrar.Location = new Point(140, 419);
            chkLembrar.Name = "chkLembrar";
            chkLembrar.Size = new Size(163, 29);
            chkLembrar.TabIndex = 53;
            chkLembrar.Text = "Lembra de mim";
            chkLembrar.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 188, 199);
            ClientSize = new Size(450, 600);
            Controls.Add(chkLembrar);
            Controls.Add(chkMostrarSenha);
            Controls.Add(nomeCabecalho);
            Controls.Add(button1);
            Controls.Add(tbSenha);
            Controls.Add(label4);
            Controls.Add(tbUsuario);
            Controls.Add(label3);
            Controls.Add(btnEntrar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnVoltarProjeto);
            Controls.Add(tbNome);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbNome;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox tbUsuario;
        private Label label3;
        private TextBox tbSenha;
        private Label label4;
        private Label nomeCabecalho;
        private CheckBox chkMostrarSenha;
        private CheckBox chkLembrar;
    }
}