using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;


namespace SynqPlataform
{
    public partial class FormPrincipal : Form {


        private bool _fecharDeVerdade = false;
        private NotifyIcon _iconeBandeja;
        private ContextMenuStrip _menuBandeja;

        private UserControl _telaAtiva;
        public FormPrincipal() {
            InitializeComponent();

            Bitmap minhaImagemPng = Properties.Resources.LOGO;
            IntPtr handle = minhaImagemPng.GetHicon();
            Icon iconeConvertido = Icon.FromHandle(handle);
            this.Icon = iconeConvertido;
            ConfigurarIconeBandeja(iconeConvertido);

            _iconeBandeja = new NotifyIcon();
            _iconeBandeja.Text = "Synq Plataform - Rodando";
            _iconeBandeja.Visible = true;
            _iconeBandeja.DoubleClick += (s, e) => RestaurarTela();
            this.FormClosing += FormPrincipal_FormClosing;
            ConfigurarAcessos();
            this.Text = $"Synq - {SessaoSistema.NomeUsuario} - {SessaoSistema.Cargo}";
            if (SessaoSistema.IsAdmin || SessaoSistema.Cargo == "Sócio") {
                Navegar(new UC_Home());
                btnHome.Enabled = true;
            }
            else {
                if (SessaoSistema.EquipeId > 0) {
                    AbrirDetalheDaEquipe(SessaoSistema.EquipeId, SessaoSistema.Equipe);
                }
                else {
                    Navegar(new UC_Home());
                    MessageBox.Show("Aviso: Você não está vinculado a nenhuma equipe.");
                }
            }
           
        }

        private void ConfigurarIconeBandeja(Icon iconePronto) { 

            _menuBandeja = new ContextMenuStrip();


            _menuBandeja.Items.Add("Abrir Synq", null, (s, e) => RestaurarTela());
            _menuBandeja.Items.Add("-"); 
            _menuBandeja.Items.Add("Sair do Sistema", null, (s, e) => EncerrarSistema());


            _iconeBandeja = new NotifyIcon();

            _iconeBandeja.Icon = iconePronto;

            _iconeBandeja.Text = "Synq Plataform - Rastreador Ativo";

            _iconeBandeja.ContextMenuStrip = _menuBandeja;
            _iconeBandeja.Visible = true;

            _iconeBandeja.DoubleClick += (s, e) => RestaurarTela();
        }

        private void RestaurarTela() {
            this.Show(); 
            this.WindowState = FormWindowState.Normal; 
            this.BringToFront(); 
        }

        private void EncerrarSistema() {
            _fecharDeVerdade = true;

            if (_iconeBandeja != null) {
                _iconeBandeja.Visible = false; 
                _iconeBandeja.Dispose();
            }

            Application.Exit(); 
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e) {

            if (!_fecharDeVerdade) {

                e.Cancel = true; 
                this.Hide();

                _iconeBandeja.ShowBalloonTip(3000, "Synq", "O sistema continua rodando em segundo plano.", ToolTipIcon.Info);
            }
        }

        private void ConfigurarAcessos() {

            btnHome.Enabled = true;
            btnCliente.Enabled = true;
            btnEquipe.Enabled = true;
            btnObra.Enabled = true;
            btnProjeto.Enabled = true;  

            string cargo = SessaoSistema.Cargo;
            string equipe = SessaoSistema.Equipe;

            if (!SessaoSistema.IsAdmin) {

                btnHome.Enabled = false;
                btnCliente.Enabled = false;  
                btnProjeto.Enabled = false;
                btnEquipe.Enabled = false;
                btnObra.Enabled = true;


            }

        }

        public static class MonitorDeJanelas {
            [DllImport("user32.dll")]
            private static extern IntPtr GetForegroundWindow();

            [DllImport("user32.dll")]
            private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

            [StructLayout(LayoutKind.Sequential)]
            private struct LASTINPUTINFO {
                public uint cbSize;
                public uint dwTime;

            }

            [DllImport("user32.dll")]
            private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

            public static int ObtertempoOcioso() {
                LASTINPUTINFO lastImput = new LASTINPUTINFO();
                lastImput.cbSize = (uint)Marshal.SizeOf(lastImput);
                lastImput.dwTime = 0;

                if(GetLastInputInfo(ref lastImput)) {
                    int tempoOcioso = Environment.TickCount - (int)lastImput.dwTime;
                    return Math.Max(0, tempoOcioso / 1000);
                }
                return 0;

            }

            public static string ObterTituloJanelaAtiva() {
                const int nChars = 256;
                StringBuilder Buff = new StringBuilder(nChars);
                IntPtr handle = GetForegroundWindow();

                if (GetWindowText(handle, Buff, nChars) > 0) {
                    return Buff.ToString();
                }
                return null;
            }
        }


        private void Navegar(UserControl novaTela) {

            if (_telaAtiva != null) {
                pnlConteudo.Controls.Remove(_telaAtiva);
                _telaAtiva.Dispose();
            }

            _telaAtiva = novaTela;
            pnlConteudo.Controls.Clear();
            novaTela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(novaTela);
            novaTela.BringToFront();

        }

        private void AbrirDetalheDaEquipe(int IdEquipe, string NomeEquipe) {

            UC_DetalhesEquipe tela = new UC_DetalhesEquipe(IdEquipe, NomeEquipe);

            tela.BotaoVoltarClicado += (s, e) => CarregarTelaEquipe();

            tela.OnProjetoClicado += (idDoProjeto) => {

                UC_JanelaDetalheProjeto telaproj = new UC_JanelaDetalheProjeto(idDoProjeto);

                telaproj.BotaoVoltarClicado += (s2, e2) => AbrirDetalheDaEquipe(IdEquipe, NomeEquipe);
                Navegar(telaproj);
            };

            Navegar(tela);

        }


        private void AbrirTelaCadastroEquipe(object sender, EventArgs e) {


            UC_CadastroEquipe telaCadastroEquipe = new UC_CadastroEquipe();
            telaCadastroEquipe.BotaoVoltarClicado += (s, args) => CarregarTelaEquipe();

            Navegar(telaCadastroEquipe);
        }

        private void CarregarTelaEquipe() {

            UC_Equipe telaEquipe = new UC_Equipe();

            telaEquipe.BotaoNovoClicado += AbrirTelaCadastroEquipe;

            telaEquipe.OnEquipeSelecionado += (IdEquipe, NomeEquipe) => {
                AbrirDetalheDaEquipe(IdEquipe, NomeEquipe);
            };
            Navegar(telaEquipe);
        }


        private void CarregarTelaCliente() {
            UC_Clientes telaClientes = new UC_Clientes();
            telaClientes.BotaoNovoClienteClicado += AbrirTelaCadastroClientes;
            telaClientes.OnClienteSelecionado += (IdCliente) => {
                AbrirDetalhesCliente(IdCliente);
            };


            Navegar(telaClientes);
        }


        private void AbrirDetalhesCliente(int ClienteId) {

            UC_JanelaDetalheCliente telaDetalhe = new UC_JanelaDetalheCliente(ClienteId);

            telaDetalhe.BotaoVoltarClicado += (s, e) => CarregarTelaCliente();

            telaDetalhe.OnProjetoClicado += (idProjeto) => {
                CarregarDetalhesDoProjeto(idProjeto);
            };

            telaDetalhe.OnNovoProjetoClicado += (idDoCliente) => {

                UC_CadastroProjeto telaCardProjeto = new UC_CadastroProjeto(idDoCliente);

                telaCardProjeto.BotaoVoltarClicado += (s2, e2) => AbrirDetalhesCliente(idDoCliente);
                
                

                Navegar(telaCardProjeto);
            };

            Navegar(telaDetalhe);
        }



        private void CarregarTelaProjeto() {
            UC_Projetos telaProjetos = new UC_Projetos();
            telaProjetos.BotaoNovoProjetoClicado += AbrirTelaCadastroProjetos;
            telaProjetos.OnDetalheProjetoClicado += (idDoProjetoClicado) => {
                CarregarDetalhesDoProjeto(idDoProjetoClicado);
            };
            Navegar(telaProjetos);
        }


        private void AbrirTelaCadastroClientes(object sender, EventArgs e) {

            UC_CadastroCliente telaCadastroClientes = new UC_CadastroCliente();
            telaCadastroClientes.BotaoVoltarClicado += (s, args) => CarregarTelaCliente();
            Navegar(telaCadastroClientes);
        }

        private void AbrirTelaCadastroProjetos(object sender, EventArgs e) {
            UC_CadastroProjeto telaCadastroProjetos = new UC_CadastroProjeto();
            telaCadastroProjetos.BotaoVoltarClicado += (s, args) => CarregarTelaProjeto();
            Navegar(telaCadastroProjetos);
        }

        private void CarregarDetalhesDoProjeto(int idProjeto) {
            UC_JanelaDetalheProjeto telaDetalhe = new UC_JanelaDetalheProjeto(idProjeto);


            telaDetalhe.BotaoVoltarClicado += (s, args) => btnProjetos_Click(this, EventArgs.Empty);

            Navegar(telaDetalhe);
        }



        private void btnHome_Click(object sender, EventArgs e) {
            Navegar(new UC_Home());
        }
        private void btnClientes_Click(object sender, EventArgs e) {

            CarregarTelaCliente();
        }

        private void btnProjetos_Click(object sender, EventArgs e) {
            CarregarTelaProjeto();

        }

        private void btnObras_Click(object sender, EventArgs e) {
            UC_RegistroObra telaRegistro = new UC_RegistroObra();
            Navegar(telaRegistro);
        }

        private void btnEquipe_Click(object sender, EventArgs e) {
            CarregarTelaEquipe();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            EncerrarSistema();
        }

        private void timerMonitor_Tick(object sender, EventArgs e) {
            try {

                if (SessaoSistema.UsuarioId == 0) return;

                int tempoOcioso = MonitorDeJanelas.ObtertempoOcioso();
                int tempoLimite = 300;

                if (tempoOcioso > tempoLimite) {
                    Console.WriteLine($"Usuário ausente há {tempoOcioso}s. Contagem Pausada.");
                    return;
                }

                string tituloJanela = MonitorDeJanelas.ObterTituloJanelaAtiva();

                // padrão: 123 - MARC - NOME CLIENTE - MARCENARIA - R00

                // Padrão: 0:CODIGO, 1:SIGLA, 2:CLIENTE, 3:CATEGORIA, 4:REV

                if (string.IsNullOrEmpty(tituloJanela)) return;

                if (tituloJanela.Contains("\\")) {
                    tituloJanela = tituloJanela.Substring(tituloJanela.LastIndexOf('\\') + 1);
                }
                else if (tituloJanela.Contains("[")) {

                    tituloJanela = tituloJanela.Substring(tituloJanela.IndexOf('[') + 1);
                }

                tituloJanela = tituloJanela.Replace("]", "").Replace("*", "").Replace(".dwg", "").Replace(".skp", "").Replace(".rvt", "").Trim();

                string codigoProjeto = "";
                string[] fatias = tituloJanela.Split('-');
                if (fatias.Length > 0) {
                    codigoProjeto = fatias[0].Trim();
                }

                string categoriaDetectada = "";
                string[] categoriasValidas = { "MARCENARIA", "OBRA", "LAYOUT", "3D", "DETALHES", "PROJETO LEGAL", "DOCUMENTOS", "LEVANTAMENTO", "APRESENTAÇÃO" };

                string tituloMaiusculo = tituloJanela.ToUpper();
                foreach (string cat in categoriasValidas) {

                    if (tituloMaiusculo.Contains(cat)) {
                        categoriaDetectada = cat;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(codigoProjeto) && !string.IsNullOrEmpty(categoriaDetectada)) {

                    RegistrarMinutoTrabalhado(codigoProjeto, categoriaDetectada);
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Erro no Monitor: " + ex.Message);
            }
        }

        private void RegistrarMinutoTrabalhado(string codigoProjeto, string nomeCategoria) {
            try {
                using (SqlConnection con = new SqlConnection(BancoConfig.StringConexao)) {
                    con.Open();
                    int IdProjeto = 0;
                    string sqlBuscaId = "SELECT Id FROM Projeto WHERE CodigoProjeto = @Cod";

                    using (SqlCommand cmdBusca = new SqlCommand(sqlBuscaId, con)) {
                        cmdBusca.Parameters.AddWithValue("@Cod", codigoProjeto);
                        object resultado = cmdBusca.ExecuteScalar();

                        if (resultado != null) IdProjeto = Convert.ToInt32(resultado);
                        else return; 
                    }

                    string sqlUpdate = @"UPDATE RegistroHoras
                                 SET QtHoras = QtHoras + @TempoExtra
                                 WHERE ProjetoId = @Proj AND Categoria = @Cat 
                                 AND DataRegistro = @Hoje AND UsuarioId = @User";

                    using (SqlCommand cmdUp = new SqlCommand(sqlUpdate, con)) {
                        cmdUp.Parameters.AddWithValue("@Proj", IdProjeto);
                        cmdUp.Parameters.AddWithValue("@User", SessaoSistema.UsuarioId);
                        cmdUp.Parameters.AddWithValue("@Cat", nomeCategoria);
                        cmdUp.Parameters.AddWithValue("@Hoje", DateTime.Today);
                        cmdUp.Parameters.AddWithValue("@TempoExtra", 0.0167m);

                        int linhasAfetadas = cmdUp.ExecuteNonQuery();

                        if (linhasAfetadas == 0) {
                            string sqlInsert = @"INSERT INTO RegistroHoras (ProjetoId, UsuarioId, Categoria, QtHoras, DataRegistro)
                                         VALUES (@Proj, @User, @Cat, @TempoExtra, @Hoje)";

                            using (SqlCommand cmdIn = new SqlCommand(sqlInsert, con)) {
                                cmdIn.Parameters.AddWithValue("@Proj", IdProjeto);
                                cmdIn.Parameters.AddWithValue("@User", SessaoSistema.UsuarioId); 
                                cmdIn.Parameters.AddWithValue("@Cat", nomeCategoria);
                                cmdIn.Parameters.AddWithValue("@Hoje", DateTime.Today);
                                cmdIn.Parameters.AddWithValue("@TempoExtra", 0.0167m);
                                cmdIn.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro invisível no banco ao salvar horas: " + ex.Message);
            }
        }

    }
}
