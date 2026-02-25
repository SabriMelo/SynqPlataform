using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SynqPlataform {
    public partial class UC_CadastroCliente : UserControl {

        public event EventHandler BotaoVoltarClicado;
        private int _idCliente = 0;

        public UC_CadastroCliente() {
            InitializeComponent();
            _idCliente = 0;
        }


        public UC_CadastroCliente(int id, bool isEdicao) {
            InitializeComponent();
            _idCliente = id;

            CarregarDadosEdicao();
        }

        private void CarregarDadosEdicao() {

            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT * FROM Cliente WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _idCliente);

                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {
                            
                                tbNomeCompleto.Text = leitor["Nome"].ToString();

                                if (leitor["Email"] != DBNull.Value)
                                    tbEmail.Text = leitor["Email"].ToString();

                                if (leitor["Telefone"] != DBNull.Value)
                                    tbTelefone.Text = leitor["Telefone"].ToString();

                                if (leitor["Documento"] != DBNull.Value)
                                    tbDocumento.Text = leitor["Documento"].ToString();

                                if (leitor["Telefone"] != DBNull.Value)
                                    tbTelefone.Text = leitor["Telefone"].ToString();

                                if (leitor["Cep"] != DBNull.Value)
                                    tbCep.Text = leitor["Cep"].ToString();

                                if (leitor["Endereco"] != DBNull.Value)
                                    tbEndereco.Text = leitor["Endereco"].ToString();

                                if (leitor["DataNascimento"] != DBNull.Value)
                                    dateTimePicker1.Text = leitor["DataNascimento"].ToString();



                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar cliente: " + ex.Message);
            }
        }

        private void btnVoltarCliente_click(object sender, EventArgs e) {

            BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnCadatrarCliente_click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(tbNomeCompleto.Text)) {
                MessageBox.Show("O campo Nome é obrigatório!");
                return;
            }
            if (string.IsNullOrEmpty(cmbTipoPessoa.Text)) {
                MessageBox.Show("Selecione se é Pessoa Física ou Jurídica!");
                return;
            }
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = "";

                    if(_idCliente == 0) {
                        sql = "INSERT INTO Cliente(Nome, Email, Telefone, TipoPessoa, Documento, CEP, Endereco, DataNascimento) VALUES (@Nome, @Email, @Telefone, @TipoPessoa, @Doc, @CEP, @End, @DataNascimento)";
                    }
                    else {
                        sql = "UPDATE Cliente SET Nome = @Nome, Email = @Email, Telefone = @Telefone, TipoPessoa = @TipoPessoa, " +
                      "Documento = @Doc, CEP = @CEP, Endereco = @End, DataNascimento = @DataNascimento WHERE Id = @Id";
                    }
                        using (SqlCommand cmd = new SqlCommand(sql, con)) {
                            cmd.Parameters.AddWithValue("@Nome", tbNomeCompleto.Text);
                            cmd.Parameters.AddWithValue("@TipoPessoa", cmbTipoPessoa.Text);
                            cmd.Parameters.AddWithValue("@Doc", tbDocumento.Text);
                            cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                            cmd.Parameters.AddWithValue("@Telefone", tbTelefone.Text);
                            cmd.Parameters.AddWithValue("@End", tbEndereco.Text);
                            cmd.Parameters.AddWithValue("@CEP", tbCep.Text);
                            cmd.Parameters.AddWithValue("@DataNascimento", dateTimePicker1.Value.Date);

                        if (_idCliente > 0) {
                            cmd.Parameters.AddWithValue("@Id", _idCliente);
                        }

                            cmd.ExecuteNonQuery();

                        }
                }

                MessageBox.Show(_idCliente == 0 ? "Cliente cadastrado com Sucesso!" : "Cliente atualizado!");

                BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
            }
        }


        private void LimparCampos() {

            tbNomeCompleto.Clear();
            cmbTipoPessoa.SelectedIndex = -1;
            tbDocumento.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
            tbEndereco.Clear();
            tbCep.Clear();
            tbNomeCompleto.Focus();

        }
    }
}
