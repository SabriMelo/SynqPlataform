using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynqPlataform {
    public partial class UC_DetalheMembro : UserControl {
        public UC_DetalheMembro() {
            InitializeComponent();
        }

        public void CarregarDados(UC_CardMembro dados) {

            lblNomeCompleto.Text = dados.NomeCompleto;
            lblCargo.Text = dados.Cargo;
            lblEmail.Text = dados.Email;
            lblTelefone.Text = dados.Telefone;
            lblEmergencia.Text = dados.TelefoneEmergencia;
            lblNomeUsuario.Text = dados.LoginUsuario;
        }

        
    }
}

