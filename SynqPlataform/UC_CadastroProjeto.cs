using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_CadastroProjeto : UserControl {

        public event EventHandler BotaoVoltarClicado;

        int _ClienteIdPreSelecionado = 0;
        private int _idProjeto = 0;
        private bool _modoEdicao = false;
        public UC_CadastroProjeto() {
            InitializeComponent();
            ConfigurarTelaInicial();
            _idProjeto = 0;
        }

        public UC_CadastroProjeto(int ClienteID) {

            InitializeComponent();
            _ClienteIdPreSelecionado = ClienteID;
            ConfigurarTelaInicial();

            cmbCliente.SelectedValue = _ClienteIdPreSelecionado;
            cmbCliente.Enabled = false;
            _idProjeto = 0;
        }

        public UC_CadastroProjeto(int idProjetoParaEditar, bool isEdicao) {
            InitializeComponent();
            ConfigurarTelaInicial();

            _idProjeto = idProjetoParaEditar;
            _modoEdicao = true;

            CarregarDadosEdicao();
        }

        private void UC_CadastroProjeto_Load(object sender, EventArgs e) {

            if (_modoEdicao) {
                btnCadastrarProjeto.Text = "Salvar Alterações";
            }
            else {
                btnCadastrarProjeto.Text = "Cadastrar Projeto";
            }

        }


        private void ConfigurarTelaInicial() {
            CarregarListaEquipes();
            CarregarClienteBox();
        }

        private void btnVoltarProjeto_click(object sender, EventArgs e) {

            BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void CarregarDadosEdicao() {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT * FROM Projeto WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _idProjeto);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {
                                tbNome.Text = leitor["NomeProjeto"].ToString();

                                if (leitor["Status"] != DBNull.Value)
                                    cmbStatus.Text = leitor["Status"].ToString();

                                if (leitor["ClienteID"] != DBNull.Value)
                                    cmbCliente.SelectedValue = Convert.ToInt32(leitor["ClienteID"]);

                                if (leitor["EquipeResponsavel"] != DBNull.Value)
                                    cmbEquipe.Text = leitor["EquipeResponsavel"].ToString();

                                if (leitor["EnderecoObra"] != DBNull.Value)
                                    tbEndereco.Text = leitor["EnderecoObra"].ToString();

                                if (leitor["Metragem"] != DBNull.Value)
                                    tbMetragem.Text = leitor["Metragem"].ToString();

                                if (leitor["ValorContrato"] != DBNull.Value)
                                    tbValor.Text = leitor["ValorContrato"].ToString();

                                if (leitor["Descricao"] != DBNull.Value)
                                    tbDescricao.Text = leitor["Descricao"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar dados para edição: " + ex.Message);
            }
        }


        private void CarregarClienteBox() {
            try {
                cmbCliente.DataSource = null;

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT Id, Nome FROM Cliente ORDER BY Nome ASC";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0) {

                        string NomeColunaId = dt.Columns[0].ColumnName;
                        string NomeColunaNome = dt.Columns[1].ColumnName;

                        cmbCliente.DisplayMember = NomeColunaNome;
                        cmbCliente.ValueMember = NomeColunaId;
                        cmbCliente.DataSource = dt;

                        cmbCliente.SelectedIndex = -1;

                        if (_ClienteIdPreSelecionado > 0)
                            cmbCliente.SelectedValue = _ClienteIdPreSelecionado;

                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void CarregarListaEquipes() {

            cmbEquipe.Items.Clear();

            try {
                cmbEquipe.Items.Clear();


                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = "SELECT DISTINCT NomeEquipe FROM CadastroEquipe ORDER BY NomeEquipe ASC";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                                if (leitor["NomeEquipe"] != DBNull.Value) {
                                    string nomeDaEquipe = leitor["NomeEquipe"].ToString();
                                    cmbEquipe.Items.Add(nomeDaEquipe);
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar equipes: " + ex.Message);

            }
        }
        private void btnCadastrarProjeto_Click(object sender, EventArgs e) {

            string equipeResponsavel = cmbEquipe.Text;
            if (string.IsNullOrWhiteSpace(tbNome.Text) || cmbCliente.SelectedIndex == -1 || cmbEquipe.SelectedIndex == -1) {
                MessageBox.Show("Preencha Nome, Cliente e Equipe.");
                return;
            }

            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "";
                    if (_idProjeto == 0) {

                        sql = @"INSERT INTO Projeto 
                               (NomeProjeto, Status, ClienteID, EnderecoObra, Metragem, ValorContrato, EquipeResponsavel, Descricao) 
                               VALUES 
                               (@Nome, @Status, @ClienteID, @EnderecoObra, @Metragem, @ValorContrato, @EquipeResponsavel, @Descricao)";
                    }
                    else {

                        sql = @"UPDATE Projeto SET 
                                NomeProjeto = @Nome, 
                                Status = @Status, 
                                ClienteID = @ClienteID, 
                                EnderecoObra = @EnderecoObra, 
                                Metragem = @Metragem, 
                                ValorContrato = @ValorContrato, 
                                EquipeResponsavel = @EquipeResponsavel, 
                                Descricao = @Descricao 
                                WHERE Id = @Id";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {

                        cmd.Parameters.AddWithValue("@Nome", tbNome.Text);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@ClienteID", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@EnderecoObra", tbEndereco.Text);

                        decimal metragem = string.IsNullOrWhiteSpace(tbMetragem.Text) ? 0 : decimal.Parse(tbMetragem.Text);
                        decimal valorContrato = string.IsNullOrWhiteSpace(tbValor.Text) ? 0 : decimal.Parse(tbValor.Text);

                        cmd.Parameters.AddWithValue("@Metragem", metragem);
                        cmd.Parameters.AddWithValue("@ValorContrato", valorContrato);
                        cmd.Parameters.AddWithValue("@EquipeResponsavel", equipeResponsavel);
                        cmd.Parameters.AddWithValue("@Descricao", tbDescricao.Text);

                        if (_idProjeto > 0) {
                            cmd.Parameters.AddWithValue("@Id", _idProjeto);
                        }


                        cmd.ExecuteNonQuery();
                    }
                }
                string mensagem = _idProjeto == 0 ? "Projeto cadastrado!" : "Projeto atualizado com sucesso!";
                MessageBox.Show(mensagem);

                BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
            }

            catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar projeto: " + ex.Message);
            }

        }

        
    }
}
