using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_Clientes : UserControl {

        public event Action<int> OnClienteSelecionado;

        public event EventHandler BotaoNovoClienteClicado;

        public UC_Clientes() {
            InitializeComponent();
            CarregarListaClientes();
            
        }

        private void btnNovoCliente_Click(object sender, EventArgs e) {

            BotaoNovoClienteClicado?.Invoke(this, EventArgs.Empty);
        }

        public void CarregarListaClientes() {

            try {
                flowPanelClientes.Controls.Clear(); 

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT Id, Nome, TipoPessoa FROM Cliente ORDER BY Nome ASC";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                                UC_CardCliente card = new UC_CardCliente();

                                card.ClienteId = Convert.ToInt32(leitor["Id"]);
                                card.NomeCliente = leitor["Nome"].ToString();
                                card.TipoCliente = leitor["TipoPessoa"].ToString();
                                card.OnEditarClicado += (s, e) => EditarCliente(card.ClienteId);
                                card.OnExcluirClicado += (s, e) => ExcluirCliente(card.ClienteId);


                                if (card.TipoCliente == "Pessoa Jurídica") {

                                }
                                card.OnSelect += (s, e) => {


                                    OnClienteSelecionado?.Invoke(card.ClienteId);

                                    

                                };

                                flowPanelClientes.Controls.Add(card);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void EditarCliente(int id) {
          
            UC_CadastroCliente uc = new UC_CadastroCliente(id, true);

            this.Parent.Controls.Add(uc);
            uc.BringToFront();
            uc.BotaoVoltarClicado += (s, e) => { this.Parent.Controls.Remove(uc); CarregarListaClientes(); };
        }

        private void ExcluirCliente(int id) {
            if (MessageBox.Show("Deseja excluir este cliente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    SqlCommand cmdVerifica = new SqlCommand("SELECT COUNT(*) FROM Projeto WHERE ClienteId = @Id", con);
                    cmdVerifica.Parameters.AddWithValue("@Id", id);
                    int projetos = (int)cmdVerifica.ExecuteScalar();

                    if (projetos > 0) {
                        MessageBox.Show($"Este cliente tem {projetos} projetos vinculados. Exclua os projetos antes de excluir o cliente.");
                        return;
                    }

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM Cliente WHERE Id = @Id", con);
                    cmdDelete.Parameters.AddWithValue("@Id", id);
                    cmdDelete.ExecuteNonQuery();
                }
                CarregarListaClientes(); 
            }
        }

    }
}
