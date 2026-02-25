namespace SynqPlataform {
    partial class UC_Equipe {
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
            Button btnCadastroEquipe;
            nomeCabecalho = new Label();
            flowPanelEquipe = new FlowLayoutPanel();
            btnCadastroEquipe = new Button();
            SuspendLayout();
            // 
            // btnCadastroEquipe
            // 
            btnCadastroEquipe.BackColor = Color.FromArgb(159, 188, 199);
            btnCadastroEquipe.Cursor = Cursors.Hand;
            btnCadastroEquipe.FlatAppearance.BorderSize = 0;
            btnCadastroEquipe.FlatStyle = FlatStyle.Flat;
            btnCadastroEquipe.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroEquipe.ForeColor = Color.FromArgb(64, 64, 64);
            btnCadastroEquipe.Location = new Point(1074, 831);
            btnCadastroEquipe.Name = "btnCadastroEquipe";
            btnCadastroEquipe.Size = new Size(186, 34);
            btnCadastroEquipe.TabIndex = 33;
            btnCadastroEquipe.Text = "Cadastro Equipe";
            btnCadastroEquipe.UseVisualStyleBackColor = false;
            btnCadastroEquipe.Click += btnCadastroEquipe_Click;
            // 
            // nomeCabecalho
            // 
            nomeCabecalho.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomeCabecalho.ForeColor = Color.FromArgb(64, 64, 64);
            nomeCabecalho.Location = new Point(0, 25);
            nomeCabecalho.Name = "nomeCabecalho";
            nomeCabecalho.Size = new Size(1300, 50);
            nomeCabecalho.TabIndex = 2;
            nomeCabecalho.Text = "EQUIPES";
            nomeCabecalho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowPanelEquipe
            // 
            flowPanelEquipe.Location = new Point(24, 114);
            flowPanelEquipe.Name = "flowPanelEquipe";
            flowPanelEquipe.Size = new Size(1250, 673);
            flowPanelEquipe.TabIndex = 3;
            // 
            // UC_Equipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(btnCadastroEquipe);
            Controls.Add(flowPanelEquipe);
            Controls.Add(nomeCabecalho);
            Name = "UC_Equipe";
            Size = new Size(1300, 900);
            ResumeLayout(false);
        }

        #endregion

        private Label nomeCabecalho;
        private FlowLayoutPanel flowPanelEquipe;
    }
}
