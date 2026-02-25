using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace SynqPlataform {
    public partial class UC_DetalhesEquipe : UserControl {

        public event EventHandler BotaoVoltarClicado;
        public event Action<int> OnProjetoClicado;
        public event Action<UC_CardMembro> OnMembroClicado;


        int _IdEquipe;
        string _NomeEquipe;

        public UC_DetalhesEquipe(int Id, string NomeEquipe) {

            InitializeComponent();
            _IdEquipe = Id;
            _NomeEquipe = NomeEquipe;
            lblTitulo.Text = "Equipe: " + _NomeEquipe;
            CarregarMembros();
            CarregarProjetosEquipe();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
        }



        private void CarregarProjetosEquipe(string termoBusca = "") {

            try {

                flowPanelEquipeProjeto.Controls.Clear();
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = @"
                SELECT 
                    P.Id, P.NomeProjeto, P.Status, P.CodigoProjeto, P.EquipeResponsavel,
                    ISNULL(SUM(R.QtHoras), 0) AS TotalHoras
                FROM Projeto P
                LEFT JOIN RegistroHoras R ON P.Id = R.ProjetoId
                WHERE P.EquipeResponsavel = @NomeDaEquipe 
                  AND (P.NomeProjeto LIKE @Busca OR P.CodigoProjeto LIKE @Busca)
                GROUP BY P.Id, P.NomeProjeto, P.Status, P.CodigoProjeto, P.EquipeResponsavel
                ORDER BY TotalHoras DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {

                        cmd.Parameters.AddWithValue("@NomeDaEquipe", _NomeEquipe);
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

                                card.OnCardProjetoClicado += (id) => OnProjetoClicado?.Invoke(id);

                                flowPanelEquipeProjeto.Controls.Add(card);
                            }
                        }
                    }
                }
                if (flowPanelEquipeProjeto.Controls.Count == 0) {
                    Label lblVazio = new Label {
                        Text = termoBusca == "" ? "Esta equipe ainda não tem projetos." : "Nenhum projeto encontrado na busca.",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Width = flowPanelEquipeProjeto.Width - 5,
                        Height = 100,
                        Font = new Font("Poppins", 10),
                        Margin = new Padding(0, 0, 0, 0)
                    };
                    flowPanelEquipeProjeto.Controls.Add(lblVazio);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro projetos: " + ex.Message); }
        }

        private void CarregarMembros() {
            try {
                flowPanelEquipe.Controls.Clear();
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = "SELECT * FROM Usuarios WHERE NomeEquipe = @NomeEquipe AND Ativo = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@NomeEquipe", _NomeEquipe);

                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                                UC_CardMembro cardMembro = new UC_CardMembro();
                                int idCapturado = Convert.ToInt32(leitor["Id"]);
                                cardMembro.IdMembro = idCapturado;

                                cardMembro.IdMembro = Convert.ToInt32(leitor["Id"]);
                                cardMembro.NomeCompleto = leitor["NomeCompleto"].ToString();
                                cardMembro.Nome = leitor["NomeCompleto"].ToString();
                                cardMembro.LoginUsuario = leitor["LoginUser"].ToString();
                                cardMembro.Cargo = leitor["Cargo"].ToString();
                                cardMembro.Email = leitor["Email"] != DBNull.Value ? leitor["Email"].ToString() : "";
                                cardMembro.Telefone = leitor["Telefone"] != DBNull.Value ? leitor["Telefone"].ToString() : "";
                                cardMembro.TelefoneEmergencia = leitor["TelefoneEmergencia"] != DBNull.Value ? leitor["TelefoneEmergencia"].ToString() : "";


                                cardMembro.Width = flowPanelEquipe.Width - 25;
                                cardMembro.Margin = new Padding(5);


                                cardMembro.OnMembroClicado += MostrarDetalhesDoMembro;

                                cardMembro.OnEditarClicado += (s, e) => EditarMembro(idCapturado);

                                cardMembro.OnExcluirClicado += (s, e) => DesativarMembro(cardMembro.IdMembro);

                                flowPanelEquipe.Controls.Add(cardMembro);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar membros (Usuarios): " + ex.Message); }
        }

        private void MostrarDetalhesDoMembro(UC_CardMembro dados) {

            UC_DetalheMembro Detalhes = new UC_DetalheMembro();


            Detalhes.CarregarDados(dados);

            Form janelaPopup = new Form();

            janelaPopup.Size = new Size(Detalhes.Width + 20, Detalhes.Height + 40);
            janelaPopup.StartPosition = FormStartPosition.CenterScreen;
            janelaPopup.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            janelaPopup.Text = "Detalhes do Colaborador";

            Detalhes.Dock = DockStyle.Fill;
            janelaPopup.Controls.Add(Detalhes);

            janelaPopup.ShowDialog();

        }

        private void EditarMembro(int idMembro) {

            UC_CadastroEquipe telaEdicao = new UC_CadastroEquipe(_NomeEquipe, true, idMembro);

            telaEdicao.Dock = DockStyle.Fill;

            if (this.Parent != null) {
                this.Parent.Controls.Add(telaEdicao);

                telaEdicao.BringToFront();

                telaEdicao.BotaoVoltarClicado += (s, e) => {
                    this.Parent.Controls.Remove(telaEdicao);
                    CarregarMembros();
                };
            }
            else {
                MessageBox.Show("Erro: Não foi possível achar a janela principal.");
            }
        }



        private void DesativarMembro(int id) {
            if (MessageBox.Show("Tem certeza que deseja remover este usuário?",
                "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try {
                    using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                        con.Open();

                        string sql = "UPDATE Usuarios SET Ativo = 0 WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(sql, con)) {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    CarregarMembros();
                }
                catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
            }
        }

        private void tbBuscarProjeto_TextChanged(object sender, EventArgs e) {
            CarregarProjetosEquipe(tbBuscarProjeto.Text.Trim());
        }
    }

}
