using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynqPlataform {
    public partial class UC_CardRelatorio : UserControl {


        public event Action<int> OnAbrirRelatorio;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdRelatorio { get; set; }


        public UC_CardRelatorio() {
            InitializeComponent();

            this.Click += DispararClique;
            lblDataRelatorio.Click += DispararClique;
            lblTituloRelatorio.Click += DispararClique;
            lblUsuario.Click += DispararClique;
        }

        public void DefinirDados(int id, DateTime data, string titulo, string autor) {
            this.IdRelatorio = id;
            lblDataRelatorio.Text = data.ToString("dd/MM/yyyy");
            lblTituloRelatorio.Text = titulo;
            lblUsuario.Text = autor;
        }

        private void DispararClique(object sender, EventArgs e) {
            OnAbrirRelatorio?.Invoke(this.IdRelatorio);
        }


    }
}
