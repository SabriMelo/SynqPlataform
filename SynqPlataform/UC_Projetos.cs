using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_Projetos : UserControl {

        public event EventHandler BotaoNovoProjetoClicado;
        public event Action<int> OnDetalheProjetoClicado;

        public UC_Projetos() {
            InitializeComponent();
            CarregarProjetos();
        }

        public void CarregarProjetos(string termoBusca = "") {
            try {
                flowPanelProjetos.Controls.Clear();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = @"
                SELECT 
                    P.Id, P.NomeProjeto, P.Status, P.CodigoProjeto, P.EquipeResponsavel,
                    ISNULL(SUM(R.QtHoras), 0) AS TotalHoras
                FROM Projeto P
                LEFT JOIN RegistroHoras R ON P.Id = R.ProjetoId
                WHERE P.NomeProjeto LIKE @Busca OR P.CodigoProjeto LIKE @Busca
                GROUP BY P.Id, P.NomeProjeto, P.Status, P.CodigoProjeto, P.EquipeResponsavel
                ORDER BY TotalHoras DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {

                        cmd.Parameters.AddWithValue("@Busca", "%" + termoBusca + "%");

                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                                UC_CardProjeto card = new UC_CardProjeto();

                                int id = Convert.ToInt32(leitor["Id"]);
                                string nome = leitor["NomeProjeto"].ToString();
                                string status = leitor["Status"] != DBNull.Value ? leitor["Status"].ToString() : "Em Andamento";
                                string codigo = leitor["CodigoProjeto"] != DBNull.Value ? leitor["CodigoProjeto"].ToString() : "---";
                                string NomeEquipe = leitor["EquipeResponsavel"].ToString();

                                card.DefinirProjeto(id, nome, status, codigo, NomeEquipe);

                                card.IdProjeto = Convert.ToInt32(leitor["Id"]);

                                card.Margin = new Padding(10);


                                card.OnEditarClicado += (sender, e) => {
                                    EditarProjeto(card.IdProjeto);
                                };

                                card.OnExcluirClicado += (sender, e) => {
                                    ExcluirProjeto(card.IdProjeto);
                                };
                                card.OnCardProjetoClicado += (idClicado) => {
                                    OnDetalheProjetoClicado.Invoke(idClicado);
                                };

                                flowPanelProjetos.Controls.Add(card);


                            }
                        }
                    }
                    if (flowPanelProjetos.Controls.Count == 0) {
                        Label lblVazio = new Label {
                            Text = "Nenhum projeto encontrado.",
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Width = flowPanelProjetos.Width - 20,
                            Height = 100,
                            Font = new Font("Poppins", 10),
                            Margin = new Padding(0, 50, 0, 0)
                        };
                        flowPanelProjetos.Controls.Add(lblVazio);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar lista: " + ex.Message);
            }
        }

        private void ExcluirProjeto(int id) {
            if (MessageBox.Show("Tem certeza que deseja excluir este projeto e TODOS os seus registros?",
        "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                try {
                    using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                        con.Open();
                        string sqlLimparHoras = "DELETE FROM RegistroHoras WHERE ProjetoId = @Id";
                        using (SqlCommand cmd = new SqlCommand(sqlLimparHoras, con)) {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }

                        string sqlLimpaRelatorios = "DELETE FROM RelatorioObra WHERE ProjetoId = @Id";
                        using (SqlCommand cmd = new SqlCommand(sqlLimpaRelatorios, con)) {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }

                        string sqlProjeto = "DELETE FROM Projeto WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(sqlProjeto, con)) {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    CarregarProjetos();
                    MessageBox.Show("Projeto excluído com sucesso!");
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void EditarProjeto(int id) {
            UC_CadastroProjeto ucEdicao = new UC_CadastroProjeto(id, true);

            ucEdicao.Dock = DockStyle.Fill;

            ucEdicao.BotaoVoltarClicado += (s, e) => {
                this.Parent.Controls.Remove(ucEdicao);

                this.Show();

                CarregarProjetos();
            };

            if (this.Parent != null) {

                this.Parent.Controls.Add(ucEdicao);
                ucEdicao.BringToFront();

            }
            else {
                MessageBox.Show("Erro: Não encontrei o painel pai para trocar de tela.");
            }
        }


        private void btnNovoProjeto_Click(object sender, EventArgs e) {

            BotaoNovoProjetoClicado?.Invoke(this, EventArgs.Empty);
        }

        private void tbBuscarProjeto_TextChanged(object sender, EventArgs e) {
            CarregarProjetos(tbBuscarProjeto.Text.Trim());
        }
    }
}
