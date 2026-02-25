namespace SynqPlataform {
    partial class UC_Clientes {
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
            Button btnNovoCliente;
            flowPanelClientes = new FlowLayoutPanel();
            label1 = new Label();
            btnNovoCliente = new Button();
            SuspendLayout();
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.BackColor = Color.FromArgb(159, 188, 199);
            btnNovoCliente.Cursor = Cursors.Hand;
            btnNovoCliente.FlatAppearance.BorderSize = 0;
            btnNovoCliente.FlatStyle = FlatStyle.Flat;
            btnNovoCliente.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoCliente.ForeColor = Color.FromArgb(64, 64, 64);
            btnNovoCliente.Location = new Point(1064, 831);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(186, 34);
            btnNovoCliente.TabIndex = 32;
            btnNovoCliente.Text = "Novo Cliente";
            btnNovoCliente.UseVisualStyleBackColor = false;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // flowPanelClientes
            // 
            flowPanelClientes.AutoScroll = true;
            flowPanelClientes.Location = new Point(3, 95);
            flowPanelClientes.Name = "flowPanelClientes";
            flowPanelClientes.Size = new Size(1294, 700);
            flowPanelClientes.TabIndex = 33;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(1300, 70);
            label1.TabIndex = 34;
            label1.Text = "CLIENTES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 242);
            Controls.Add(label1);
            Controls.Add(flowPanelClientes);
            Controls.Add(btnNovoCliente);
            Name = "UC_Clientes";
            Size = new Size(1300, 900);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanelClientes;
        private Label label1;
    }
}
