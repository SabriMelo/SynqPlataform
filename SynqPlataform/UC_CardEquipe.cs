using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynqPlataform {
    public partial class UC_CardEquipe : UserControl {

        public event Action<string> OnEquipeSelecionado;
        public event EventHandler OnExcluirClicado;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string NomeEquipe {
            get { return lblNomeEquipe.Text; }
            set { lblNomeEquipe.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdEquipe { get; set; }


        public UC_CardEquipe() {
            InitializeComponent();
        }

       

        private void UC_CardEquipe_Click(object sender, EventArgs e) {
            OnEquipeSelecionado?.Invoke(this.NomeEquipe);
        }

        private void pbExcluir_Click(object sender, EventArgs e) {
            OnExcluirClicado?.Invoke(this, EventArgs.Empty);
        }
    }
}
