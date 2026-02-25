using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.SqlClient;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SynqPlataform {
    public partial class UC_JanelaDetalheProjeto : UserControl {

        private readonly SKTypeface _poppinsSemiBold =
    SKTypeface.FromFile(
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        "Fonts", "Poppins-SemiBold.ttf"));

        public event EventHandler BotaoVoltarClicado;

        private int _idProjetoAtual;

        public UC_JanelaDetalheProjeto(int idProjeto) {
            _idProjetoAtual = idProjeto;
            InitializeComponent();
        }

        private void UC_JanelaDetalheProjeto_Load(object sender, EventArgs e) {
            
            if (_idProjetoAtual > 0) {
                CarregarDadosGerais();        
                CarregarGraficoMensal();
                CarregarRacingBars();
                CarregarRelatoriosObra();
            }

        }

        private void CarregarDadosGerais() {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = @"
                    SELECT P.*, C.Nome AS NomeDoCliente 
                    FROM Projeto P
                    LEFT JOIN Cliente C ON P.ClienteId = C.Id
                    WHERE P.Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _idProjetoAtual);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            if (leitor.Read()) {

                                if (lblNomeProjeto != null) lblNomeProjeto.Text = leitor["NomeProjeto"].ToString();
                                if (lblCodigo != null) lblCodigo.Text = "#" + leitor["CodigoProjeto"].ToString();
                                if (lblStatus != null) lblStatus.Text = leitor["Status"].ToString();
                                if (lblEquipeResp != null) lblEquipeResp.Text = leitor["EquipeResponsavel"].ToString();
                                if (lblDescricao != null) lblDescricao.Text = leitor["Descricao"].ToString();
                                if (lblData != null) {                                    
                                    if (leitor["DataInicio"] != DBNull.Value) {                                       
                                        DateTime data = Convert.ToDateTime(leitor["DataInicio"]);
                                        lblData.Text = data.ToString("dd/MM/yyyy");
                                    }
                                    else {
                                        lblData.Text = "---"; 
                                    }
                                }
                                if (lblCliente != null) {
                                    if (leitor["NomeDoCliente"] != DBNull.Value) {
                                        lblCliente.Text = leitor["NomeDoCliente"].ToString();
                                    }
                                    else {
                                        lblCliente.Text = "---";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro dados gerais: " + ex.Message); }
        }

        private void CarregarGraficoMensal() {

            try {
                if (chartMensal == null) return;

                var valores = new List<double>();
                var meses = new List<string>();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    
                    string sql = @"SELECT FORMAT(DataRegistro, 'MM/yyyy') as Mes, SUM(QtHoras) as Total 
                           FROM RegistroHoras WHERE ProjetoId = @Id 
                           GROUP BY FORMAT(DataRegistro, 'MM/yyyy'), YEAR(DataRegistro), MONTH(DataRegistro)
                           ORDER BY YEAR(DataRegistro), MONTH(DataRegistro)";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _idProjetoAtual);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                                meses.Add(leitor["Mes"].ToString()); 
                                valores.Add(Convert.ToDouble(leitor["Total"]));
                            }
                        }
                    }
                }
                chartMensal.Series = new ISeries[]
                {
            new ColumnSeries<double>
            {
                Name = "Horas",
                Values = valores.ToArray(),
                Fill = new SolidColorPaint(SKColors.CornflowerBlue), 

                DataLabelsPaint = new SolidColorPaint(SKColors.Black), 
                               
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                 
                DataLabelsFormatter = point => $"{point.PrimaryValue:N1}h"
            }
                };


                chartMensal.XAxes = new Axis[]
                {
            new Axis
            {
                Labels = meses, 
                LabelsRotation = 0, 
                TextSize = 12
            }
                };

                
                chartMensal.YAxes = new Axis[]
                {
            new Axis {
                MinLimit = 0,
                Labeler = value => value.ToString("N0") + "h" }
                };
            }
            catch (Exception ex) { MessageBox.Show("Erro Gráfico Mensal: " + ex.Message); }
        }

        private void CarregarRacingBars() {
            try {
                if (chartRacing == null) return;

                var seriesLista = new List<ISeries>();
                var valores = new List<double>();
                
                var labelsY = new List<String>();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    
                    string sql = @"SELECT Categoria, SUM(QtHoras) as Total 
                           FROM RegistroHoras WHERE ProjetoId = @Id 
                           GROUP BY Categoria ORDER BY Total ASC";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@Id", _idProjetoAtual);
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                               var categoria = leitor["Categoria"].ToString().ToUpper();
                                var totalHoras = Convert.ToDouble(leitor["Total"]);

                                valores.Add(totalHoras);
                                labelsY.Add($"{categoria}: {totalHoras:N1}h");

                                                      
                            }
                        }
                    }
                }


                chartRacing.Series = new ISeries[] {
                    new RowSeries<double> {
                        Values = valores.ToArray(),
                        MaxBarWidth = double.PositiveInfinity,
                        Padding = 5,

                        DataLabelsPaint = new SolidColorPaint(SKColors.White),
                        DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Middle,
                        DataLabelsFormatter = point =>
                            $"{point.PrimaryValue:N1}h"
                    }
                };

                chartRacing.XAxes = new Axis[] {
                    new Axis {
                    IsVisible = false,
                    }
                };

                chartRacing.YAxes = new Axis[] {
                    new Axis {
                        Labels = labelsY,
                        TextSize = 10,
                        ForceStepToMin = true,
                        MinStep = 1,
                         LabelsPaint = new SolidColorPaint(SKColors.Black)
                        {
                            SKTypeface = _poppinsSemiBold
                        }

                    }
                };

            }
            catch (Exception ex) { MessageBox.Show("Erro Ranking: " + ex.Message); }
        }




        private void CarregarRelatoriosObra() {
            try {
                flowRegistroObra.Controls.Clear(); 

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();


                    string sql = @"
                SELECT R.Id, R.DataVisita, R.TituloObra, U.NomeCompleto as UsuarioId
                FROM RelatorioObra R
                LEFT JOIN Usuarios U ON R.UsuarioId = U.Id
                WHERE R.ProjetoId = @ProjetoId
                ORDER BY R.DataVisita DESC"; 

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.AddWithValue("@ProjetoId", _idProjetoAtual);

                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {
                               
                                UC_CardRelatorio item = new UC_CardRelatorio();

                                int id = Convert.ToInt32(leitor["Id"]);
                                DateTime data = Convert.ToDateTime(leitor["DataVisita"]);
                                string titulo = leitor["TituloObra"].ToString();
                                string usuario = leitor["UsuarioId"] != DBNull.Value ? leitor["UsuarioId"].ToString() : "Desconhecido";

                                item.DefinirDados(id, data, titulo, usuario);

                                item.Width = flowRegistroObra.Width - 25;
                                item.Margin = new Padding(0, 0, 0, 5); 

                                item.OnAbrirRelatorio += (idRelatorio) => AbrirLeituraRelatorio(idRelatorio);

                                flowRegistroObra.Controls.Add(item);
                            }
                        }
                    }
                }

                if (flowRegistroObra.Controls.Count == 0) {
                    Label lbl = new Label { Text = "Nenhum registro de obra encontrado.", AutoSize = true, ForeColor = Color.Gray };
                    flowRegistroObra.Controls.Add(lbl);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar relatórios: " + ex.Message);
            }
        
        }

        private void AbrirLeituraRelatorio(int idRelatorio) {
           
            Form popup = new Form();
            UC_DetalheRelatorio ver = new UC_DetalheRelatorio(idRelatorio);
            ver.Dock = DockStyle.Fill;

            popup.Size = new Size(900, 600);
            popup.Controls.Add(ver);
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            BotaoVoltarClicado?.Invoke(this, EventArgs.Empty);
        }


    }
}
