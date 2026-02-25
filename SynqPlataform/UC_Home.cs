using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Microsoft.Data.SqlClient;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SynqPlataform {
    public partial class UC_Home : UserControl {

        private bool _vendoMeses = false;
        private List<string> _anosCache = new List<string>();

        public UC_Home() {
            InitializeComponent();
            CarregarDashboard();
            chartEvolucao.DataPointerDown += ChartEvolucao_DataPointerDown;
            CarregarEvolucaoAnual();
            CarregarGraficoProjetos();
        }

        public void CarregarDashboard() {
            CarregarCards();
            CarregarGraficoStatus();
            CarregarGraficoProjetos();

        }

        private void CarregarCards() {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sqlTotal = "SELECT COUNT(*) FROM Projeto";
                    SqlCommand cmdTotal = new SqlCommand(sqlTotal, con);
                    int total = (int)cmdTotal.ExecuteScalar();

                    string sqlAtivos = "SELECT COUNT(*) FROM Projeto WHERE Status NOT IN ('Cancelado', 'Finalizado', 'Entregue')";
                    SqlCommand cmdAtivos = new SqlCommand(sqlAtivos, con);
                    int ativos = (int)cmdAtivos.ExecuteScalar();

                    if (lblTotalProjetos != null) lblTotalProjetos.Text = total.ToString();
                    if (lblProjetosAtivos != null) lblProjetosAtivos.Text = ativos.ToString();
                }
            }
            catch { }
        }


        private void CarregarEvolucaoAnual() {
            try {
                _vendoMeses = false;

                if (btnVoltarEvolucao.InvokeRequired) {
                    btnVoltarEvolucao.Invoke(new MethodInvoker(() => btnVoltarEvolucao.Visible = false));
                }
                else {
                    btnVoltarEvolucao.Visible = false;
                }

                var valores = new List<double>();
                _anosCache.Clear();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = @"SELECT YEAR(DataRegistro) as Ano, SUM(QtHoras) as Total 
                           FROM RegistroHoras 
                           GROUP BY YEAR(DataRegistro) 
                           ORDER BY Ano ASC";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader leitor = cmd.ExecuteReader()) {
                        while (leitor.Read()) {
                            string ano = leitor["Ano"].ToString();
                            _anosCache.Add(ano); 
                            valores.Add(Convert.ToDouble(leitor["Total"]));
                        }
                    }
                }

                var colunaSerie = new ColumnSeries<double> {
                    Name = "Total Anual",
                    Values = valores.ToArray(),
                    Fill = new SolidColorPaint(SKColors.CornflowerBlue),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                    DataLabelsFormatter = p => $"{p.PrimaryValue:N0}h"
                };

                chartEvolucao.Series = new ISeries[] { colunaSerie };

                chartEvolucao.XAxes = new Axis[] { new Axis { Labels = _anosCache, TextSize = 12 } };
                chartEvolucao.YAxes = new Axis[] { new Axis { MinLimit = 0 } };
            }
            catch (Exception ex) { MessageBox.Show("Erro Anual: " + ex.Message); }
        }


        private void ChartEvolucao_DataPointerDown(IChartView chart, IEnumerable<ChartPoint> points) {

            if (_vendoMeses) return;

            var pontoClicado = points.FirstOrDefault();

            if (pontoClicado != null) {

                int index = pontoClicado.Index;

                if (index >= 0 && index < _anosCache.Count) {
                    string anoSelecionado = _anosCache[index];

                    int ano = int.Parse(anoSelecionado);

                    this.Invoke(new MethodInvoker(() => CarregarEvolucaoMensal(ano)));
                }
            }
        }

        private void CarregarEvolucaoMensal(int ano) {
            _vendoMeses = true;

            this.Invoke((MethodInvoker)delegate {
                btnVoltarEvolucao.Visible = true;
                btnVoltarEvolucao.Text = $"⬅ Voltar ({ano})";
            });

            var valores = new List<double>();
            var meses = new List<string>();

            using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                con.Open();
                string sql = @"SELECT FORMAT(DataRegistro, 'MMM') as Mes, MONTH(DataRegistro) as NumMes, SUM(QtHoras) as Total 
                       FROM RegistroHoras 
                       WHERE YEAR(DataRegistro) = @Ano
                       GROUP BY FORMAT(DataRegistro, 'MMM'), MONTH(DataRegistro)
                       ORDER BY NumMes ASC";

                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("@Ano", ano);
                    using (SqlDataReader leitor = cmd.ExecuteReader()) {
                        while (leitor.Read()) {
                            meses.Add(leitor["Mes"].ToString());
                            valores.Add(Convert.ToDouble(leitor["Total"]));
                        }
                    }
                }
            }

            chartEvolucao.Series = new ISeries[]
            {
                new ColumnSeries<double> 
                {
                    Name = "Horas Mensais",
                    Values = valores.ToArray(),
            
                    Fill = new SolidColorPaint(SKColors.CornflowerBlue), 
                    MaxBarWidth = 50, 
            
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                    DataLabelsFormatter = p => $"{p.PrimaryValue:N0}h"
                    }
                };

                chartEvolucao.XAxes = new Axis[] {
                    new Axis {
                        Labels = meses,
                        TextSize = 12
                    }
                };

                chartEvolucao.YAxes = new Axis[] { new Axis { MinLimit = 0 } };
        }

        private void CarregarGraficoProjetos() {
            try {
                if (chartProjetos == null) return;

                var valores = new List<double>();
                var labelsY = new List<string>();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();

                    string sql = @"SELECT TOP 5 P.NomeProjeto, SUM(R.QtHoras) as Total 
                           FROM RegistroHoras R
                           INNER JOIN Projeto P ON R.ProjetoId = P.Id
                           WHERE P.Status NOT IN ('Finalizado', 'Entregue', 'Cancelado')
                           GROUP BY P.NomeProjeto
                           ORDER BY Total DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader leitor = cmd.ExecuteReader()) {
                        if (!leitor.HasRows) {
                            MessageBox.Show("Nenhum projeto encontrado.");
                            return;
                        }

                        while (leitor.Read()) {
                            double total = leitor["Total"] != DBNull.Value
                                ? Convert.ToDouble(leitor["Total"])
                                : 0;

                            if (total <= 0) continue;

                            valores.Add(total);
                            labelsY.Add(leitor["NomeProjeto"].ToString());
                        }
                    }
                }

                if (valores.Count == 0) return;

                valores.Reverse();
                labelsY.Reverse();

                chartProjetos.Series = new ISeries[]
                {
            new RowSeries<double>
            {
                Values = valores.ToArray(),

                MaxBarWidth = double.PositiveInfinity,
                Padding = 4,

                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.End,
                DataLabelsFormatter = p => $"{p.PrimaryValue:N0}h"
            }
                };

                chartProjetos.YAxes = new Axis[]
                {
            new Axis
            {
                Labels = labelsY,
                MinStep = 1,
                ForceStepToMin = true,
                TextSize = 11
            }
                };

                chartProjetos.XAxes = new Axis[]
                {
            new Axis { IsVisible = false }
                };

                chartProjetos.DrawMargin = new LiveChartsCore.Measure.Margin(
                    left: 160, top: 10, right: 10, bottom: 10);

                chartProjetos.DrawMarginFrame = null;
            }
            catch (Exception ex) {
                MessageBox.Show("Erro Crítico: " + ex.Message);
            }
        }


        private void CarregarGraficoStatus() {

            try {
                if (chartStatus == null) return;
                chartStatus.Series = null;

                var seriesLista = new List<ISeries>();

                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    string sql = "SELECT ISNULL(Status, 'Estudo Preliminar') as StatusDesc, COUNT(*) as Qtd FROM Projeto GROUP BY Status";
                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        using (SqlDataReader leitor = cmd.ExecuteReader()) {
                            while (leitor.Read()) {

                                string status = leitor["StatusDesc"].ToString();

                                double qtd = Convert.ToDouble(leitor["Qtd"]);

                                if (qtd > 0) {
                                    seriesLista.Add(new PieSeries<double> {
                                        Name = status,
                                        Values = new double[] { qtd },

                                        InnerRadius = 50,
                                        Pushout = 3,
                                        HoverPushout = 6,

                                        DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                                        DataLabelsFormatter = point => $"{point.Context.Series.Name}: {point.PrimaryValue}",
                                        DataLabelsSize = 12
                                    });
                                }
                            }
                        }
                    }
                }

                chartStatus.Series = seriesLista;
                chartStatus.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;

            }
            catch (Exception ex) { MessageBox.Show("Erro Status: " + ex.Message); }

        }


    }

        
    
}
