using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynqPlataform {
    public partial class UC_CardMembro : UserControl {

        public event Action<UC_CardMembro> OnMembroClicado;
        public event EventHandler OnEditarClicado;
        public event EventHandler OnExcluirClicado;

       
        public UC_CardMembro() {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nome {
            get { return lblNome.Text; }
            set { lblNome.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Cargo {
            get { return lblCargo.Text; }
            set { lblCargo.Text = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdMembro { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeCompleto { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Telefone { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TelefoneEmergencia { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Usuario { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LoginUsuario { get; set; }


        private void UC_CardMembro_Click(object sender, EventArgs e) {
            OnMembroClicado?.Invoke(this);

        }

        private void pbEdit_Click(object sender, EventArgs e) {
            OnEditarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pbExcluir_Click(object sender, EventArgs e) {
            OnExcluirClicado?.Invoke(this, EventArgs.Empty);
        }


    }
}
