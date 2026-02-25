using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace SynqPlataform {
    public partial class UC_CardCliente : UserControl {

        public event EventHandler OnSelect;
        public event EventHandler OnEditarClicado;
        public event EventHandler OnExcluirClicado;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeCliente {

            get { return lblNome.Text; }
            set { lblNome.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TipoCliente {

            get { return lblTipo.Text; }
            set { lblTipo.Text = value; }
        }
        public UC_CardCliente() {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        private void CardCliente_Click(object sender, EventArgs e) {
            OnSelect?.Invoke(this, EventArgs.Empty);
        }

        private void pbEdit_Click(object sender, EventArgs e) {
            OnEditarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pbExcluir_Click(object sender, EventArgs e) {
            OnExcluirClicado?.Invoke(this, EventArgs.Empty);
        }


    }
}
