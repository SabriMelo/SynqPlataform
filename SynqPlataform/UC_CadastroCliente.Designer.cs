namespace SynqPlataform {
    partial class UC_CadastroCliente {
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
            Button btnCadastrarCliente;
            Button btnVoltarCliente;
            dateTimePicker1 = new DateTimePicker();
            tbNomeCompleto = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbDocumento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            tbTelefone = new TextBox();
            tbEndereco = new TextBox();
            tbCep = new TextBox();
            label7 = new Label();
            label9 = new Label();
            cmbTipoPessoa = new ComboBox();
            btnCadastrarCliente = new Button();
            btnVoltarCliente = new Button();
            SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.FromArgb(159, 188, 199);
            btnCadastrarCliente.Cursor = Cursors.Hand;
            btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnCadastrarCliente.Location = new Point(1075, 834);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(186, 42);
            btnCadastrarCliente.TabIndex = 31;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadatrarCliente_click;
            // 
            // btnVoltarCliente
            // 
            btnVoltarCliente.BackColor = Color.FromArgb(159, 188, 199);
            btnVoltarCliente.Cursor = Cursors.Hand;
            btnVoltarCliente.FlatAppearance.BorderSize = 0;
            btnVoltarCliente.FlatStyle = FlatStyle.Flat;
            btnVoltarCliente.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnVoltarCliente.Location = new Point(22, 834);
            btnVoltarCliente.Name = "btnVoltarCliente";
            btnVoltarCliente.Size = new Size(186, 42);
            btnVoltarCliente.TabIndex = 35;
            btnVoltarCliente.Text = "Voltar";
            btnVoltarCliente.UseVisualStyleBackColor = false;
            btnVoltarCliente.Click += btnVoltarCliente_click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(979, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // tbNomeCompleto
            // 
            tbNomeCompleto.Cursor = Cursors.IBeam;
            tbNomeCompleto.Location = new Point(22, 119);
            tbNomeCompleto.Name = "tbNomeCompleto";
            tbNomeCompleto.Size = new Size(823, 31);
            tbNomeCompleto.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(22, 16);
            label8.Name = "label8";
            label8.Size = new Size(265, 50);
            label8.TabIndex = 15;
            label8.Text = "Cadastro Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 163);
            label6.Name = "label6";
            label6.Size = new Size(120, 31);
            label6.TabIndex = 14;
            label6.Text = "Tipo Pessoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(165, 31);
            label1.TabIndex = 13;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(979, 85);
            label2.Name = "label2";
            label2.Size = new Size(173, 31);
            label2.TabIndex = 18;
            label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(979, 163);
            label3.Name = "label3";
            label3.Size = new Size(103, 31);
            label3.TabIndex = 19;
            label3.Text = "CPF/CNPJ";
            // 
            // tbDocumento
            // 
            tbDocumento.Cursor = Cursors.IBeam;
            tbDocumento.Location = new Point(979, 197);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(282, 31);
            tbDocumento.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 244);
            label4.Name = "label4";
            label4.Size = new Size(72, 31);
            label4.TabIndex = 21;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(979, 244);
            label5.Name = "label5";
            label5.Size = new Size(91, 31);
            label5.TabIndex = 22;
            label5.Text = "Telefone";
            // 
            // tbEmail
            // 
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Location = new Point(22, 278);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(823, 31);
            tbEmail.TabIndex = 23;
            // 
            // tbTelefone
            // 
            tbTelefone.Cursor = Cursors.IBeam;
            tbTelefone.Location = new Point(979, 278);
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(282, 31);
            tbTelefone.TabIndex = 24;
            // 
            // tbEndereco
            // 
            tbEndereco.Cursor = Cursors.IBeam;
            tbEndereco.Location = new Point(979, 363);
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(282, 31);
            tbEndereco.TabIndex = 28;
            // 
            // tbCep
            // 
            tbCep.Cursor = Cursors.IBeam;
            tbCep.Location = new Point(22, 363);
            tbCep.Name = "tbCep";
            tbCep.Size = new Size(823, 31);
            tbCep.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(979, 329);
            label7.Name = "label7";
            label7.Size = new Size(99, 31);
            label7.TabIndex = 26;
            label7.Text = "Endereço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 329);
            label9.Name = "label9";
            label9.Size = new Size(47, 31);
            label9.TabIndex = 25;
            label9.Text = "CEP";
            // 
            // cmbTipoPessoa
            // 
            cmbTipoPessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPessoa.FormattingEnabled = true;
            cmbTipoPessoa.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            cmbTipoPessoa.Location = new Point(22, 197);
            cmbTipoPessoa.Name = "cmbTipoPessoa";
            cmbTipoPessoa.Size = new Size(823, 33);
            cmbTipoPessoa.TabIndex = 32;
            // 
            // UC_CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(btnVoltarCliente);
            Controls.Add(cmbTipoPessoa);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(tbEndereco);
            Controls.Add(tbCep);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(tbTelefone);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbDocumento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbNomeCompleto);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "UC_CadastroCliente";
            Size = new Size(1300, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox tbNomeCompleto;
        private Label label8;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbDocumento;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
        private TextBox tbTelefone;
        private TextBox tbEndereco;
        private TextBox tbCep;
        private Label label7;
        private Label label9;
        private ComboBox cmbTipoPessoa;
    }
}
