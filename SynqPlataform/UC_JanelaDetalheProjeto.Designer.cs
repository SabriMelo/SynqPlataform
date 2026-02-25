namespace SynqPlataform {
    partial class UC_JanelaDetalheProjeto {
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
            Button btnVoltar;
            tabControl1 = new TabControl();
            tpGeral = new TabPage();
            label5 = new Label();
            lblDescricao = new Label();
            label3 = new Label();
            lblData = new Label();
            label6 = new Label();
            lblCliente = new Label();
            label4 = new Label();
            lblEquipeResp = new Label();
            label1 = new Label();
            lblStatus = new Label();
            label2 = new Label();
            lblCodigo = new Label();
            lblNomeProjeto = new Label();
            tpGestHoras = new TabPage();
            label8 = new Label();
            label7 = new Label();
            chartRacing = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            chartMensal = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tpRegistroObra = new TabPage();
            flowRegistroObra = new FlowLayoutPanel();
            label9 = new Label();
            btnVoltar = new Button();
            tabControl1.SuspendLayout();
            tpGeral.SuspendLayout();
            tpGestHoras.SuspendLayout();
            tpRegistroObra.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(159, 188, 199);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(64, 64, 64);
            btnVoltar.Location = new Point(23, 796);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(195, 34);
            btnVoltar.TabIndex = 43;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpGeral);
            tabControl1.Controls.Add(tpGestHoras);
            tabControl1.Controls.Add(tpRegistroObra);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1300, 900);
            tabControl1.TabIndex = 0;
            // 
            // tpGeral
            // 
            tpGeral.Controls.Add(label5);
            tpGeral.Controls.Add(lblDescricao);
            tpGeral.Controls.Add(label3);
            tpGeral.Controls.Add(lblData);
            tpGeral.Controls.Add(btnVoltar);
            tpGeral.Controls.Add(label6);
            tpGeral.Controls.Add(lblCliente);
            tpGeral.Controls.Add(label4);
            tpGeral.Controls.Add(lblEquipeResp);
            tpGeral.Controls.Add(label1);
            tpGeral.Controls.Add(lblStatus);
            tpGeral.Controls.Add(label2);
            tpGeral.Controls.Add(lblCodigo);
            tpGeral.Controls.Add(lblNomeProjeto);
            tpGeral.ForeColor = Color.FromArgb(64, 64, 64);
            tpGeral.Location = new Point(4, 40);
            tpGeral.Name = "tpGeral";
            tpGeral.Padding = new Padding(3);
            tpGeral.Size = new Size(1292, 856);
            tpGeral.TabIndex = 0;
            tpGeral.Text = "Geral";
            tpGeral.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(23, 445);
            label5.Name = "label5";
            label5.Size = new Size(117, 36);
            label5.TabIndex = 47;
            label5.Text = "Descrição";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Poppins", 9F);
            lblDescricao.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescricao.Location = new Point(23, 481);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(148, 31);
            lblDescricao.TabIndex = 46;
            lblDescricao.Text = "Código Projeto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(384, 282);
            label3.Name = "label3";
            label3.Size = new Size(126, 36);
            label3.TabIndex = 45;
            label3.Text = "Data Inicio";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Poppins", 9F);
            lblData.ForeColor = Color.FromArgb(64, 64, 64);
            lblData.Location = new Point(384, 318);
            lblData.Name = "lblData";
            lblData.Size = new Size(148, 31);
            lblData.TabIndex = 44;
            lblData.Text = "Código Projeto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(23, 282);
            label6.Name = "label6";
            label6.Size = new Size(153, 36);
            label6.TabIndex = 8;
            label6.Text = "Nome Cliente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Poppins", 9F);
            lblCliente.ForeColor = Color.FromArgb(64, 64, 64);
            lblCliente.Location = new Point(23, 318);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(148, 31);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Código Projeto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(770, 122);
            label4.Name = "label4";
            label4.Size = new Size(221, 36);
            label4.TabIndex = 6;
            label4.Text = "Equipe Responsável";
            // 
            // lblEquipeResp
            // 
            lblEquipeResp.AutoSize = true;
            lblEquipeResp.Font = new Font("Poppins", 9F);
            lblEquipeResp.ForeColor = Color.FromArgb(64, 64, 64);
            lblEquipeResp.Location = new Point(770, 158);
            lblEquipeResp.Name = "lblEquipeResp";
            lblEquipeResp.Size = new Size(148, 31);
            lblEquipeResp.TabIndex = 5;
            lblEquipeResp.Text = "Código Projeto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(384, 122);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 4;
            label1.Text = "Status Projeto";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Poppins", 9F);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatus.Location = new Point(384, 158);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(148, 31);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Código Projeto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(167, 36);
            label2.TabIndex = 2;
            label2.Text = "Código Projeto";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Poppins", 9F);
            lblCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodigo.Location = new Point(23, 158);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(148, 31);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código Projeto";
            // 
            // lblNomeProjeto
            // 
            lblNomeProjeto.AutoSize = true;
            lblNomeProjeto.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeProjeto.ForeColor = Color.FromArgb(64, 64, 64);
            lblNomeProjeto.Location = new Point(23, 22);
            lblNomeProjeto.Name = "lblNomeProjeto";
            lblNomeProjeto.Size = new Size(214, 50);
            lblNomeProjeto.TabIndex = 0;
            lblNomeProjeto.Text = "Nome Projeto";
            // 
            // tpGestHoras
            // 
            tpGestHoras.Controls.Add(label8);
            tpGestHoras.Controls.Add(label7);
            tpGestHoras.Controls.Add(chartRacing);
            tpGestHoras.Controls.Add(chartMensal);
            tpGestHoras.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpGestHoras.ForeColor = Color.FromArgb(64, 64, 64);
            tpGestHoras.Location = new Point(4, 40);
            tpGestHoras.Name = "tpGestHoras";
            tpGestHoras.Padding = new Padding(3);
            tpGestHoras.Size = new Size(1292, 856);
            tpGestHoras.TabIndex = 1;
            tpGestHoras.Text = "Gestão Horas";
            tpGestHoras.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(33, 517);
            label8.Name = "label8";
            label8.Size = new Size(245, 36);
            label8.TabIndex = 4;
            label8.Text = "Gráfico Horas Mensais";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(33, 12);
            label7.Name = "label7";
            label7.Size = new Size(224, 36);
            label7.TabIndex = 3;
            label7.Text = "Horas por Categoria";
            // 
            // chartRacing
            // 
            chartRacing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartRacing.Location = new Point(3, 62);
            chartRacing.Name = "chartRacing";
            chartRacing.Size = new Size(917, 436);
            chartRacing.TabIndex = 1;
            // 
            // chartMensal
            // 
            chartMensal.Location = new Point(3, 556);
            chartMensal.Name = "chartMensal";
            chartMensal.Size = new Size(1286, 300);
            chartMensal.TabIndex = 0;
            // 
            // tpRegistroObra
            // 
            tpRegistroObra.Controls.Add(flowRegistroObra);
            tpRegistroObra.Controls.Add(label9);
            tpRegistroObra.Location = new Point(4, 40);
            tpRegistroObra.Name = "tpRegistroObra";
            tpRegistroObra.Size = new Size(1292, 856);
            tpRegistroObra.TabIndex = 2;
            tpRegistroObra.Text = "Registros de Obra";
            tpRegistroObra.UseVisualStyleBackColor = true;
            // 
            // flowRegistroObra
            // 
            flowRegistroObra.Location = new Point(-4, 103);
            flowRegistroObra.Name = "flowRegistroObra";
            flowRegistroObra.Padding = new Padding(10);
            flowRegistroObra.Size = new Size(1293, 754);
            flowRegistroObra.TabIndex = 2;
            // 
            // label9
            // 
            label9.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(-4, 29);
            label9.Name = "label9";
            label9.Size = new Size(1296, 50);
            label9.TabIndex = 1;
            label9.Text = "Registros de Obra";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_JanelaDetalheProjeto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(tabControl1);
            Name = "UC_JanelaDetalheProjeto";
            Size = new Size(1300, 900);
            Load += UC_JanelaDetalheProjeto_Load;
            tabControl1.ResumeLayout(false);
            tpGeral.ResumeLayout(false);
            tpGeral.PerformLayout();
            tpGestHoras.ResumeLayout(false);
            tpGestHoras.PerformLayout();
            tpRegistroObra.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpGeral;
        private TabPage tpGestHoras;
        private Label label6;
        private Label lblCliente;
        private Label label4;
        private Label lblEquipeResp;
        private Label label1;
        private Label lblStatus;
        private Label label2;
        private Label lblCodigo;
        private Label lblNomeProjeto;
        private Label label5;
        private Label lblDescricao;
        private Label label3;
        private Label lblData;
        private TabPage tpRegistroObra;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartMensal;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartRacing;
        private Label label8;
        private Label label7;
        private FlowLayoutPanel flowRegistroObra;
        private Label label9;
    }
}
