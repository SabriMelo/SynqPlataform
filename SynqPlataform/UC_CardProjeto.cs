using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynqPlataform {
    public partial class UC_CardProjeto : UserControl {


        public event EventHandler OnEditarClicado;
        public event EventHandler OnExcluirClicado;
        public event Action<int> OnCardProjetoClicado;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Codigo { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdProjeto { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeProjeto {
            get { return lblNomeProjeto.Text; }
            set { lblNomeProjeto.Text = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StatusProjeto {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeEquipe {
            get { return lblEquipe.Text; }
            set { lblEquipe.Text = value; }
        }

        
        public void DefinirProjeto(int id, string nome, string status, string codigo, string equipe) {

            this.IdProjeto = id;
            this.Codigo = codigo;

            lblNomeProjeto.Text = nome;
            lblStatus.Text = status;
            lblCodigo.Text ="#" + codigo;
            lblEquipe.Text = equipe;

        }


        public UC_CardProjeto() {
            InitializeComponent();
            this.Click += UC_CardProjeto_Click;
            lblNomeProjeto.Click += UC_CardProjeto_Click;
            lblStatus.Click += UC_CardProjeto_Click;
            lblEquipe.Click += UC_CardProjeto_Click;
            lblCodigo.Click += UC_CardProjeto_Click;
        }

        private void pbEdit_Click(object sender, EventArgs e) {
            OnEditarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pbExcluir_Click(object sender, EventArgs e) {
            OnExcluirClicado?.Invoke(this, EventArgs.Empty);
        }

        private void UC_CardProjeto_Click(object sender, EventArgs e) {
            OnCardProjetoClicado?.Invoke(this.IdProjeto);

        }
    }
}
