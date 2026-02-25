using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;

namespace SynqPlataform {
    public partial class FormLogin : Form {

        public FormLogin() {
            InitializeComponent();
            tbSenha.PasswordChar = '*';
            ConfigurarInicializacaoComWindows();
        }

        private void ConfigurarInicializacaoComWindows() {
            try {

                string nomeApp = "SynqPlataform";

                string caminhoExe = Application.ExecutablePath;

                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                if (rk.GetValue(nomeApp) == null) {
                    rk.SetValue(nomeApp, caminhoExe);
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Erro ao configurar inicialização: " + ex.Message);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbUsuario.Text) || string.IsNullOrWhiteSpace(tbSenha.Text)) {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = @"
                        SELECT U.*, CE.Id AS IdDaEquipe 
                        FROM Usuarios U
                        LEFT JOIN CadastroEquipe CE ON U.NomeEquipe = CE.NomeEquipe
                        WHERE U.LoginUser = @Login AND U.Senha = @Senha AND U.Ativo = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Login", tbUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Senha", tbSenha.Text.Trim());

                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {

                                SessaoSistema.UsuarioId = Convert.ToInt32(leitor["Id"]);
                                SessaoSistema.NomeUsuario = leitor["LoginUser"].ToString();
                                SessaoSistema.Cargo = leitor["Cargo"].ToString();


                                SessaoSistema.Equipe = leitor["NomeEquipe"] != DBNull.Value ? leitor["NomeEquipe"].ToString() : "";

                                if (leitor["IdDaEquipe"] != DBNull.Value)
                                    SessaoSistema.EquipeId = Convert.ToInt32(leitor["IdDaEquipe"]);
                                else
                                    SessaoSistema.EquipeId = 0;
                                try {
                                    if (chkLembrar.Checked) {
                                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\SynqApp", "LembrarUsuario", tbUsuario.Text);
                                    }
                                    else {

                                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\SynqApp", "LembrarUsuario", "");
                                    }
                                }

                                catch { }

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        
                            else {
                                MessageBox.Show("Usuário ou senha incorretos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro de conexão: " + ex.Message);
            }
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e) {

            if (chkMostrarSenha.Checked) {

                tbSenha.PasswordChar = '\0'; 
            }
            else {

                tbSenha.PasswordChar = '*'; 
            }
        }
        private void FormLogin_Load(object sender, EventArgs e) {
            try {
                string usuarioSalvo = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\SynqApp", "LembrarUsuario", "");

                if (!string.IsNullOrEmpty(usuarioSalvo)) {
                    tbUsuario.Text = usuarioSalvo;
                    chkLembrar.Checked = true;
                    tbSenha.Focus(); 
                }
            }
            catch { } 
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
