using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_JanelaDetalheCliente : UserControl {

        public event EventHandler BotaoVoltarClicado;       
        public event Action<int> OnNovoProjetoClicado;
        public event Action<int> OnClienteSelecionado;
        public event Action<int> OnProjetoClicado;

        int _ClienteId;
        public UC_JanelaDetalheCliente(int ClienteId) {
            InitializeComponent();
            _ClienteId = ClienteId;

            CarregarInfoCliente();
            CarregarProjetosCliente();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnNovoProjeto_Click(object sender, EventArgs e) {
            OnNovoProjetoClicado?.Invoke(_ClienteId);
        }

        private void CarregarInfoCliente() {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT * FROM Cliente WHERE Id = @Id";
                    //string telefone = reader["Telefone"] != DBNull.Value ? reader["Telefone"].ToString() : "";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _ClienteId);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {
                                lblNome.Text = leitor["Nome"].ToString();
                                lblTipoPessoa.Text = leitor["TipoPessoa"].ToString();
                                lblEmail.Text = leitor["Email"].ToString();
                                lblTelefone.Text = leitor["Telefone"].ToString();
                                if (leitor["DataNascimento"] != DBNull.Value) {
                                    lblDataNascimento.Text = Convert.ToDateTime(leitor["DataNascimento"]).ToString("dd/MM/yyyy");
                                }
                                else {
                                    lblDataNascimento.Text = "-";
                                }
                                lblDoc.Text = leitor["Documento"].ToString();
                                lblCEP.Text = leitor["CEP"].ToString();
                                lblEndereco.Text = leitor["Endereco"].ToString();
                                lblDataCadastro.Text = Convert.ToDateTime(leitor["DataCadastro"]).ToString("dd/MM/yyyy");

                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarProjetosCliente() {
            try {
                flowProjetos.Controls.Clear();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT Id, NomeProjeto, Status, CodigoProjeto, EquipeResponsavel FROM Projeto WHERE ClienteId = @Id";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _ClienteId);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {

                                UC_CardProjeto card = new UC_CardProjeto();
                                int id = Convert.ToInt32(leitor["Id"]);
                                string nome = leitor["NomeProjeto"].ToString();
                                string status = leitor["Status"] != DBNull.Value ? leitor["Status"].ToString() : "Em Andamento";
                                string codigo = leitor["CodigoProjeto"] != DBNull.Value ? leitor["CodigoProjeto"].ToString() : "---";
                                string NomeEquipe = leitor["EquipeResponsavel"].ToString();

                                card.DefinirProjeto(id, nome, status, codigo, NomeEquipe);

                                card.OnCardProjetoClicado += (id) => OnProjetoClicado?.Invoke(id);

                                flowProjetos.Controls.Add(card);
                            }
                        }
                    }
                }
                if (flowProjetos.Controls.Count == 0) {
                    Label lblVazio = new Label();
                    lblVazio.Text = "Este cliente ainda não tem projetos.";
                    lblVazio.AutoSize = true;
                    lblVazio.ForeColor = Color.Black;
                    lblVazio.Font = new Font("Poppins", 10);
                    lblVazio.TextAlign = ContentAlignment.MiddleCenter;
                    lblVazio.Margin = new Padding(0,50,0,0);
                    lblVazio.Height = 100;
                    lblVazio.Width = flowProjetos.Width - 20;
                    lblVazio.AutoSize = false;


                    flowProjetos.Controls.Add(lblVazio);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar projetos: " + ex.Message);

            }

        }
    }
}
