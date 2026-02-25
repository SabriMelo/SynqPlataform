using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_RegistroObra : UserControl {

        public class ItemProjeto {
            public int Id { get; set; }
            public string Nome { get; set; }
            public override string ToString() {
                return Nome;
            }

        }

        public UC_RegistroObra() {
            InitializeComponent();
            CarregarProjetosNoCombo();
        }

        private void CarregarProjetosNoCombo() {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT Id, NomeProjeto, CodigoProjeto FROM Projeto ORDER BY NomeProjeto";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            cboProjetos.Items.Clear();
                            while (leitor.Read()) {
                                ItemProjeto item = new ItemProjeto();
                                item.Id = Convert.ToInt32(leitor["Id"]);

                                string codigo = leitor["CodigoProjeto"] != DBNull.Value ? leitor["CodigoProjeto"].ToString() : "";
                                item.Nome = $"{leitor["NomeProjeto"]}  (#{codigo})";

                                cboProjetos.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar projetos: " + ex.Message);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e) {
            
            if (cboProjetos.SelectedItem == null) {
                MessageBox.Show("Por favor, selecione um projeto.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtObservacao.Text)) {
                MessageBox.Show("Escreva alguma observação sobre a visita.");
                return;
            }          
            ItemProjeto projetoSelecionado = (ItemProjeto)cboProjetos.SelectedItem;
            int idProjeto = projetoSelecionado.Id;

            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sqlRelatorio = @"INSERT INTO RelatorioObra (ProjetoId, DataVisita, Observacoes, HorasGastas, TituloObra) 
                                            VALUES (@Proj, @Data, @Obs, @Horas, @TituloObra)";

                    using (SqlCommand cmd = new SqlCommand(sqlRelatorio, con)) {
                        cmd.Parameters.AddWithValue("@Proj", idProjeto);
                        cmd.Parameters.AddWithValue("@Data", dtpData.Value);
                        cmd.Parameters.AddWithValue("@Obs", txtObservacao.Text);
                        cmd.Parameters.AddWithValue("@Horas", numHoras.Value);
                        cmd.Parameters.AddWithValue("@TituloObra", tbTitulo.Text);
                        cmd.ExecuteNonQuery();
                    }

                    
                    if (numHoras.Value > 0) {
                        string sqlHoras = @"INSERT INTO RegistroHoras (ProjetoId, Categoria, QtHoras, DataRegistro, TituloObra)
                                            VALUES (@Proj, 'Obra', @Horas, @Data, @TituloObra)";

                        using (SqlCommand cmd = new SqlCommand(sqlHoras, con)) {
                            cmd.Parameters.AddWithValue("@Proj", idProjeto);
                            cmd.Parameters.AddWithValue("@Horas", numHoras.Value);
                            cmd.Parameters.AddWithValue("@Data", dtpData.Value);
                            cmd.Parameters.AddWithValue("@TituloObra", tbTitulo.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Visita registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void LimparCampos() {
            txtObservacao.Clear();
            numHoras.Value = 0;
            dtpData.Value = DateTime.Now;
            cboProjetos.SelectedIndex = -1;
        }

      
    }
}
