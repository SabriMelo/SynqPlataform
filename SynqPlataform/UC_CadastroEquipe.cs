using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace SynqPlataform {
    public partial class UC_CadastroEquipe : UserControl {

        public event EventHandler BotaoVoltarClicado;
        private string _nomeEquipeFoco = ""; 
        private int _idMembroFoco = 0;       
        private bool _isEdicao = false;


        public UC_CadastroEquipe() {
            InitializeComponent();
            CarregarEquipeNoCombo();
            _idMembroFoco = 0;
            _isEdicao = false;
        }

        public UC_CadastroEquipe(string nomeEquipe, bool isEdicao, int idMembro = 0) {
            InitializeComponent();

            _nomeEquipeFoco = nomeEquipe;
            _isEdicao = isEdicao;
            _idMembroFoco = idMembro;

            CarregarEquipeNoCombo();
         
            if (!string.IsNullOrEmpty(_nomeEquipeFoco)) {
                cbEquipe.SelectedItem = _nomeEquipeFoco;
                
            }

            if (_isEdicao && _idMembroFoco > 0) {
                
                CarregarDadosMembro(_idMembroFoco);
            }
        }


        private void btnVoltarEquipe_Click(object sender, EventArgs e) {
            BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnCadastrarEquipe_Click(object sender, EventArgs e) {
            

            if (string.IsNullOrWhiteSpace(tbNomeEquipe.Text))return ;

            try {
                using (SqlConnection conexaoBanco = new SqlConnection(BancoConfig.StringConexao)) {
                    conexaoBanco.Open();
                    string inserirEquipeQuery = "INSERT INTO CadastroEquipe (NomeEquipe) VALUES (@NomeEquipe)";
                    using (SqlCommand cmd = new SqlCommand(inserirEquipeQuery, conexaoBanco)) {
                        cmd.Parameters.AddWithValue("@NomeEquipe", tbNomeEquipe.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Equipe cadastrada com sucesso!");
                tbNomeEquipe.Clear();
                CarregarEquipeNoCombo();
            }

            catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar equipe: " + ex.Message);
            }

        }

        private void btnCadastrarMembro_Click(object sender, EventArgs e) {

            int nivelEscolhido = 1;

            if (string.IsNullOrWhiteSpace(tbNomeMembro.Text) ||
               string.IsNullOrWhiteSpace(tbUsuario.Text) ||
               string.IsNullOrWhiteSpace(tbSenha.Text) ||
               cbEquipe.SelectedIndex == -1 ) 
               {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            
            if(cbNivel.Text == "Administrador") {
                nivelEscolhido = 4;
            }else if (cbNivel.Text == "Sócio"){
                nivelEscolhido = 3;
            }else if(cbNivel.Text == "Arquiteto") {
                nivelEscolhido = 2;
            }
            else {
                nivelEscolhido = 1;
            }


                try {
                    using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                        con.Open();
                    string sql = "";

                    if (_idMembroFoco == 0) {
                        
                        sql = @"INSERT INTO Usuarios 
                               (NomeCompleto, Telefone, LoginUser, Email, Cargo, TelefoneEmergencia, Senha, NomeEquipe, Ativo)
                               VALUES
                               (@NomeCompleto, @Telefone, @Usuario, @Email, @Cargo, @TelefoneEmergencia, @Senha, @NomeEquipe, 1)";
                    }
                    else {
                        
                        sql = @"UPDATE Usuarios SET 
                                NomeCompleto = @NomeCompleto, 
                                Telefone = @Telefone, 
                                LoginUser = @Usuario, 
                                Email = @Email, 
                                Cargo = @Cargo, 
                                TelefoneEmergencia = @TelefoneEmergencia, 
                                Senha = @Senha, 
                                NomeEquipe = @NomeEquipe
                                WHERE Id = @Id";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {

                            cmd.Parameters.AddWithValue("@NomeCompleto", tbNomeMembro.Text);
                            cmd.Parameters.AddWithValue("@Telefone", tbTelefone.Text);
                            cmd.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                            cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                            cmd.Parameters.AddWithValue("@Cargo", cbCargo.Text);
                            cmd.Parameters.AddWithValue("@TelefoneEmergencia", tbTelefoneEmergencia.Text);
                            cmd.Parameters.AddWithValue("@Senha", tbSenha.Text);
                            cmd.Parameters.AddWithValue("@NomeEquipe", cbEquipe.Text);
                            cmd.Parameters.AddWithValue("@Nivel", nivelEscolhido);

                        if (_idMembroFoco > 0) {
                            cmd.Parameters.AddWithValue("@Id", _idMembroFoco);
                        }
                        cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Membro cadastrado com sucesso!");

                }
                catch (Exception ex) {
                    MessageBox.Show("Erro ao cadastrar membro: " + ex.Message);
                }
        }

        private void CarregarDadosMembro(int id) {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    
                    string sql = "SELECT * FROM Usuarios WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {
                                tbNomeMembro.Text = leitor["NomeCompleto"].ToString();
                                tbUsuario.Text = leitor["LoginUser"].ToString();
                                tbSenha.Text = leitor["Senha"].ToString();

                                if (leitor["Email"] != DBNull.Value) tbEmail.Text = leitor["Email"].ToString();
                                if (leitor["Telefone"] != DBNull.Value) tbTelefone.Text = leitor["Telefone"].ToString();
                                if (leitor["TelefoneEmergencia"] != DBNull.Value) tbTelefoneEmergencia.Text = leitor["TelefoneEmergencia"].ToString();
                                if (leitor["Cargo"] != DBNull.Value) cbCargo.Text = leitor["Cargo"].ToString();
                                if (leitor["NomeEquipe"] != DBNull.Value) cbEquipe.Text = leitor["NomeEquipe"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar membro: " + ex.Message); }
        }

        private void CarregarEquipeNoCombo() {
            try {
                cbEquipe.Items.Clear(); 
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT DISTINCT NomeEquipe FROM CadastroEquipe ORDER BY NomeEquipe ASC";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                                if (leitor["NomeEquipe"] != DBNull.Value) {
                                    cbEquipe.Items.Add(leitor["NomeEquipe"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void LimparCampoMembro() {
            tbNomeMembro.Clear();
            tbTelefone.Clear();
            tbUsuario.Clear(); 
            tbEmail.Clear();
            cbCargo.SelectedIndex = -1;
            tbTelefoneEmergencia.Clear();
            tbSenha.Clear();
            cbEquipe.SelectedIndex = -1;

        }


    }
}
