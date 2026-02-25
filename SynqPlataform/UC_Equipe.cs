using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_Equipe : UserControl {


        public event EventHandler BotaoNovoClicado;
        public event Action<int, string> OnEquipeSelecionado;

        public UC_Equipe() {
            InitializeComponent();
            CarregarEquipes();
        }

        private void btnCadastroEquipe_Click(object sender, EventArgs e) {
            
            BotaoNovoClicado?.Invoke(this, EventArgs.Empty);
        }

        public void CarregarEquipes() {
            try {
                flowPanelEquipe.Controls.Clear();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT Id, NomeEquipe FROM CadastroEquipe WHERE NomeEquipe IS NOT NULL AND NomeEquipe <> ''";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {

                                int IdEquipe = Convert.ToInt32(leitor["Id"]);
                                string NomeEquipe = leitor["NomeEquipe"].ToString();

                                UC_CardEquipe cardEquipe = new UC_CardEquipe();

                                cardEquipe.NomeEquipe = leitor["NomeEquipe"].ToString();
                                cardEquipe.OnEquipeSelecionado += (NomeEquipe) => {
                                    OnEquipeSelecionado?.Invoke(IdEquipe, NomeEquipe);

                                    cardEquipe.OnExcluirClicado += (s, e) => ExcluirEquipe(cardEquipe.IdEquipe);

                                };

                                

                                flowPanelEquipe.Controls.Add(cardEquipe);
                            }
                        }
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar equipes: " + ex.Message);


            }
        }

        private void ExcluirEquipe(int id) {
            if (MessageBox.Show("Excluir esta equipe?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM Projeto WHERE EquipeResponsavel = (SELECT NomeEquipe FROM CadastroEquipe WHERE Id = @Id)";

                    SqlCommand cmdVerifica = new SqlCommand(sqlCheck, con);
                    cmdVerifica.Parameters.AddWithValue("@Id", id);
                    int deps = (int)cmdVerifica.ExecuteScalar();

                    if (deps > 0) {
                        MessageBox.Show("Esta equipe está responsável por projetos ativos. Não é possível excluir.");
                        return;
                    }

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM CadastroEquipe WHERE Id = @Id", con);
                    cmdDelete.Parameters.AddWithValue("@Id", id);
                    cmdDelete.ExecuteNonQuery();
                }
                CarregarEquipes();
            }
        }

    }
}
