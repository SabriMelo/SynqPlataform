namespace SynqPlataform {
    partial class UC_Home {
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
            chartStatus = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            chartEvolucao = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1 = new Panel();
            panel3 = new Panel();
            lblTotalProjetos = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblProjetosAtivos = new Label();
            label1 = new Label();
            chartProjetos = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnVoltarEvolucao = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // chartStatus
            // 
            chartStatus.Dock = DockStyle.Fill;
            chartStatus.InitialRotation = 0D;
            chartStatus.IsClockwise = true;
            chartStatus.Location = new Point(0, 0);
            chartStatus.MaxAngle = 360D;
            chartStatus.MaxValue = null;
            chartStatus.MinValue = 0D;
            chartStatus.Name = "chartStatus";
            chartStatus.Size = new Size(572, 300);
            chartStatus.TabIndex = 0;
            chartStatus.Total = null;
            // 
            // chartEvolucao
            // 
            chartEvolucao.Dock = DockStyle.Fill;
            chartEvolucao.Location = new Point(0, 0);
            chartEvolucao.Name = "chartEvolucao";
            chartEvolucao.Size = new Size(1264, 271);
            chartEvolucao.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 159);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalProjetos);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(702, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 132);
            panel3.TabIndex = 1;
            // 
            // lblTotalProjetos
            // 
            lblTotalProjetos.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProjetos.ForeColor = Color.FromArgb(64, 64, 64);
            lblTotalProjetos.Location = new Point(0, 69);
            lblTotalProjetos.Name = "lblTotalProjetos";
            lblTotalProjetos.Size = new Size(300, 38);
            lblTotalProjetos.TabIndex = 3;
            lblTotalProjetos.Text = "Projetos Ativos";
            lblTotalProjetos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(0, 19);
            label3.Name = "label3";
            label3.Size = new Size(300, 38);
            label3.TabIndex = 2;
            label3.Text = "Projetos Total";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblProjetosAtivos);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(312, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 132);
            panel2.TabIndex = 0;
            // 
            // lblProjetosAtivos
            // 
            lblProjetosAtivos.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProjetosAtivos.ForeColor = Color.FromArgb(64, 64, 64);
            lblProjetosAtivos.Location = new Point(0, 69);
            lblProjetosAtivos.Name = "lblProjetosAtivos";
            lblProjetosAtivos.Size = new Size(300, 38);
            lblProjetosAtivos.TabIndex = 1;
            lblProjetosAtivos.Text = "Projetos Ativos";
            lblProjetosAtivos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 0;
            label1.Text = "Projetos Ativos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartProjetos
            // 
            chartProjetos.Dock = DockStyle.Fill;
            chartProjetos.Location = new Point(0, 0);
            chartProjetos.Name = "chartProjetos";
            chartProjetos.Size = new Size(602, 291);
            chartProjetos.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1297, 75);
            label2.TabIndex = 2;
            label2.Text = "Dashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(3, 585);
            label4.Name = "label4";
            label4.Size = new Size(1300, 38);
            label4.TabIndex = 3;
            label4.Text = "Horas Mensais";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(-3, 241);
            label5.Name = "label5";
            label5.Size = new Size(618, 38);
            label5.TabIndex = 4;
            label5.Text = "Horas Projeto";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(705, 241);
            label6.Name = "label6";
            label6.Size = new Size(592, 38);
            label6.TabIndex = 5;
            label6.Text = "Status";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltarEvolucao
            // 
            btnVoltarEvolucao.FlatStyle = FlatStyle.Flat;
            btnVoltarEvolucao.Location = new Point(16, 592);
            btnVoltarEvolucao.Name = "btnVoltarEvolucao";
            btnVoltarEvolucao.Size = new Size(159, 34);
            btnVoltarEvolucao.TabIndex = 6;
            btnVoltarEvolucao.Text = "Voltar para Anos";
            btnVoltarEvolucao.UseVisualStyleBackColor = true;
            btnVoltarEvolucao.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(chartProjetos);
            panel4.Location = new Point(13, 291);
            panel4.Name = "panel4";
            panel4.Size = new Size(602, 291);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(chartStatus);
            panel5.Location = new Point(705, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 300);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(chartEvolucao);
            panel6.Location = new Point(13, 629);
            panel6.Name = "panel6";
            panel6.Size = new Size(1264, 271);
            panel6.TabIndex = 8;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(panel6);
            Controls.Add(btnVoltarEvolucao);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "UC_Home";
            Size = new Size(1300, 900);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.PieChart chartStatus;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartEvolucao;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label lblTotalProjetos;
        private Label label3;
        private Label lblProjetosAtivos;
        private Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartProjetos;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnVoltarEvolucao;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
