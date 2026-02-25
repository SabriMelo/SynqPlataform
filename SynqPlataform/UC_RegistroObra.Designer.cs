namespace SynqPlataform {
    partial class UC_RegistroObra {
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
            Button btnSalvar;
            cboProjetos = new ComboBox();
            label14 = new Label();
            tbTitulo = new TextBox();
            label8 = new Label();
            label1 = new Label();
            dtpData = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtObservacao = new TextBox();
            numHoras = new NumericUpDown();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)numHoras).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(159, 188, 199);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.FromArgb(64, 64, 64);
            btnSalvar.Location = new Point(1071, 844);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(186, 34);
            btnSalvar.TabIndex = 42;
            btnSalvar.Text = "Salvar Registro";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboProjetos
            // 
            cboProjetos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProjetos.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProjetos.FormattingEnabled = true;
            cboProjetos.Location = new Point(674, 134);
            cboProjetos.Name = "cboProjetos";
            cboProjetos.Size = new Size(472, 44);
            cboProjetos.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(53, 207);
            label14.Name = "label14";
            label14.Size = new Size(140, 31);
            label14.TabIndex = 43;
            label14.Text = "Data da Visita";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(53, 134);
            tbTitulo.Multiline = true;
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(587, 44);
            tbTitulo.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(44, 23);
            label8.Name = "label8";
            label8.Size = new Size(291, 50);
            label8.TabIndex = 40;
            label8.Text = "Cadastro Relatório";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(674, 100);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 39;
            label1.Text = "Nome Projeto";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(56, 241);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(431, 31);
            dtpData.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(674, 207);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 46;
            label2.Text = "Horas Gastas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 100);
            label3.Name = "label3";
            label3.Size = new Size(68, 31);
            label3.TabIndex = 47;
            label3.Text = "Título ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 325);
            label4.Name = "label4";
            label4.Size = new Size(231, 31);
            label4.TabIndex = 48;
            label4.Text = "Relatório / Observações";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(56, 376);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(1090, 319);
            txtObservacao.TabIndex = 49;
            // 
            // numHoras
            // 
            numHoras.Location = new Point(674, 241);
            numHoras.Name = "numHoras";
            numHoras.Size = new Size(472, 31);
            numHoras.TabIndex = 50;
            // 
            // UC_RegistroObra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(numHoras);
            Controls.Add(txtObservacao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpData);
            Controls.Add(cboProjetos);
            Controls.Add(label14);
            Controls.Add(btnSalvar);
            Controls.Add(tbTitulo);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "UC_RegistroObra";
            Size = new Size(1300, 900);
            ((System.ComponentModel.ISupportInitialize)numHoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProjetos;
        private Label label14;
        private TextBox tbTitulo;
        private Label label8;
        private Label label1;
        private DateTimePicker dtpData;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtObservacao;
        private NumericUpDown numHoras;
    }
}
