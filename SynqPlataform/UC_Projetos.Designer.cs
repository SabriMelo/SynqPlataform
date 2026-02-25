namespace SynqPlataform {
    partial class UC_Projetos {
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
            Button btnNovoProjeto;
            flowPanelProjetos = new FlowLayoutPanel();
            label1 = new Label();
            tbBuscarProjeto = new TextBox();
            btnNovoProjeto = new Button();
            SuspendLayout();
            // 
            // btnNovoProjeto
            // 
            btnNovoProjeto.BackColor = Color.FromArgb(159, 188, 199);
            btnNovoProjeto.Cursor = Cursors.Hand;
            btnNovoProjeto.FlatAppearance.BorderSize = 0;
            btnNovoProjeto.FlatStyle = FlatStyle.Flat;
            btnNovoProjeto.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoProjeto.ForeColor = Color.FromArgb(64, 64, 64);
            btnNovoProjeto.Location = new Point(1064, 830);
            btnNovoProjeto.Name = "btnNovoProjeto";
            btnNovoProjeto.Size = new Size(186, 34);
            btnNovoProjeto.TabIndex = 33;
            btnNovoProjeto.Text = "Novo Projeto";
            btnNovoProjeto.UseVisualStyleBackColor = false;
            btnNovoProjeto.Click += btnNovoProjeto_Click;
            // 
            // flowPanelProjetos
            // 
            flowPanelProjetos.Location = new Point(0, 97);
            flowPanelProjetos.Name = "flowPanelProjetos";
            flowPanelProjetos.Size = new Size(1300, 727);
            flowPanelProjetos.TabIndex = 34;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(0, 14);
            label1.Name = "label1";
            label1.Size = new Size(1300, 70);
            label1.TabIndex = 35;
            label1.Text = "PROJETOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbBuscarProjeto
            // 
            tbBuscarProjeto.Location = new Point(946, 60);
            tbBuscarProjeto.Name = "tbBuscarProjeto";
            tbBuscarProjeto.PlaceholderText = "Pesquisar Projeto";
            tbBuscarProjeto.Size = new Size(351, 31);
            tbBuscarProjeto.TabIndex = 0;
            tbBuscarProjeto.TextChanged += tbBuscarProjeto_TextChanged;
            // 
            // UC_Projetos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(tbBuscarProjeto);
            Controls.Add(label1);
            Controls.Add(flowPanelProjetos);
            Controls.Add(btnNovoProjeto);
            Name = "UC_Projetos";
            Size = new Size(1300, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanelProjetos;
        private Label label1;
        private TextBox tbBuscarProjeto;
    }
}
