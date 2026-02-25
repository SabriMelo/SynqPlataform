using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SynqPlataform {
    public partial class UC_DetalheRelatorio : UserControl {

        public event EventHandler BotaoFecharClicado;

        public UC_DetalheRelatorio() {
            InitializeComponent();
        }
        public UC_DetalheRelatorio(int idRelatorio) {
            InitializeComponent();
            CarregarDetalhes(idRelatorio);
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            BotaoFecharClicado?.Invoke(this, EventArgs.Empty);
        }

        public void CarregarDetalhes(int idRelatorio) {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = @"
                    SELECT R.*, U.NomeCompleto as UsuarioId
                    FROM RelatorioObra R
                    LEFT JOIN Usuarios U ON R.UsuarioId = U.Id
                    WHERE R.Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", idRelatorio);

                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {

                                lblTitulo.Text = leitor["TituloObra"].ToString();
                                lblRelatorio.Text = leitor["Observacoes"].ToString();

                                string dataFormatada = Convert.ToDateTime(leitor["DataVisita"]).ToString("dd/MM/yyyy");
                                lblData.Text = dataFormatada;

                                string nomeAutor = leitor["UsuarioId"] != DBNull.Value ? leitor["UsuarioId"].ToString() : "Desconhecido";

                                if (lblUsuario != null) lblUsuario.Text = "Registrado por: " + nomeAutor;

                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao abrir relatório: " + ex.Message);
            }
        }


    }
}
