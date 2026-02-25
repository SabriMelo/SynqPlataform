namespace SynqPlataform {
    partial class UC_DetalhesEquipe {
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
            Button btnVoltarEquipe;
            flowPanelEquipe = new FlowLayoutPanel();
            lblTitulo = new Label();
            flowPanelEquipeProjeto = new FlowLayoutPanel();
            label1 = new Label();
            tbBuscarProjeto = new TextBox();
            btnVoltarEquipe = new Button();
            SuspendLayout();
            // 
            // btnVoltarEquipe
            // 
            btnVoltarEquipe.BackColor = Color.FromArgb(159, 188, 199);
            btnVoltarEquipe.Cursor = Cursors.Hand;
            btnVoltarEquipe.FlatAppearance.BorderSize = 0;
            btnVoltarEquipe.FlatStyle = FlatStyle.Flat;
            btnVoltarEquipe.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarEquipe.ForeColor = Color.FromArgb(64, 64, 64);
            btnVoltarEquipe.Location = new Point(51, 835);
            btnVoltarEquipe.Name = "btnVoltarEquipe";
            btnVoltarEquipe.Size = new Size(195, 34);
            btnVoltarEquipe.TabIndex = 42;
            btnVoltarEquipe.Text = "Voltar";
            btnVoltarEquipe.UseVisualStyleBackColor = false;
            btnVoltarEquipe.Click += btnVoltar_Click;
            // 
            // flowPanelEquipe
            // 
            flowPanelEquipe.BackColor = Color.FromArgb(230, 239, 242);
            flowPanelEquipe.Location = new Point(0, 100);
            flowPanelEquipe.Name = "flowPanelEquipe";
            flowPanelEquipe.Size = new Size(300, 729);
            flowPanelEquipe.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(0, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowPanelEquipeProjeto
            // 
            flowPanelEquipeProjeto.AutoScroll = true;
            flowPanelEquipeProjeto.BackColor = Color.FromArgb(230, 239, 242);
            flowPanelEquipeProjeto.Location = new Point(306, 100);
            flowPanelEquipeProjeto.Name = "flowPanelEquipeProjeto";
            flowPanelEquipeProjeto.Size = new Size(994, 729);
            flowPanelEquipeProjeto.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(306, 13);
            label1.Name = "label1";
            label1.Size = new Size(994, 39);
            label1.TabIndex = 43;
            label1.Text = "Projeto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbBuscarProjeto
            // 
            tbBuscarProjeto.Location = new Point(946, 21);
            tbBuscarProjeto.Name = "tbBuscarProjeto";
            tbBuscarProjeto.PlaceholderText = "Pesquisar Projeto";
            tbBuscarProjeto.Size = new Size(351, 31);
            tbBuscarProjeto.TabIndex = 44;
            tbBuscarProjeto.TextChanged += tbBuscarProjeto_TextChanged;
            // 
            // UC_DetalhesEquipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(tbBuscarProjeto);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(flowPanelEquipeProjeto);
            Controls.Add(btnVoltarEquipe);
            Controls.Add(flowPanelEquipe);
            Name = "UC_DetalhesEquipe";
            Size = new Size(1300, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanelEquipe;
        private FlowLayoutPanel flowPanelEquipeProjeto;
        private Label lblTitulo;
        private Label label1;
        private TextBox tbBuscarProjeto;
    }
}
