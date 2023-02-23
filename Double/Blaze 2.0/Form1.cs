using Blaze_2._0.Entities;
using Blaze_2._0.Telas_menus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Blaze_2._0 {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        static int quantidadeWin = 0;
        static int quantidadeLoss = 0;

        private void ClickCor(object sender, MouseEventArgs e) {
            Panel pn = (Panel)sender;
            if(e.Button == MouseButtons.Left) {
                if(pn.BackColor == Color.Red) {
                    pn.BackColor = Color.White;
                }
                else {
                    pn.BackColor = Color.Red;
                }
            }
            else {
                if(pn.BackColor == Color.Blue) {
                    pn.BackColor = Color.White;
                }
                else {
                    pn.BackColor = Color.Blue ;
                }
            }
        }

        private void ClickLabel(object sender, MouseEventArgs e) {
            Panel pn;

            Label ln = (Label)sender;

            if(ln == Msg1) {
                pn = Pn11;
            }
            else {
                pn = Pn12;
            }


            if(e.Button == MouseButtons.Left) {
                if(pn.BackColor == Color.Red) {
                    pn.BackColor = Color.White ;
                }
                else {
                    pn.BackColor = Color.Red;
                }
            }
            else {
                if(pn.BackColor == Color.Blue) {
                    pn.BackColor = Color.White;
                }
                else {
                    pn.BackColor = Color.Blue    ;
                }
            }
        }

        Crawler crawler;
        Thread th;
        int identificacaoEstrategia = -1;
        int estrategiaEncontrada = -1;
        private void Form1_Load(object sender, EventArgs e) {
            TimerRestart.Start();
            new DataBase().CarregaDadosConfiguracao();
            new DataBase().CarregaDadosEstrategia();
            new DataBase().CarregaDadosTelegram();
            new DataBase().CarregaDadosMensagem();

            
            this.Activate();
            this.TopMost = true;
            this.TopMost = false;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            CkEngine.Checked = true;

            CarregaBase();



            if(DgDados.Rows.Count > 0) {
                DgDados.Rows[0].Selected = false;
            }

            crawler = new Crawler();
            th = new Thread(() => {
                crawler.Iniciar();
            });
            th.Start();
            TimerAtualizaTela.Start();

        }


        private Color[] CarregaBase() {


            Color[] cores = new Color[13];

            foreach(var data in Blaze_2._0.Entities.Estrategia.dadosCarregados) {


                int contador = 0;
                string[] texto = data.Estrategy.Split(';');

                foreach(string dado in texto) {

                    if(dado == "1") {
                        cores[contador] = Color.Red;
                    }
                    else if(dado == "0") {
                        cores[contador] = Color.Blue;
                    }
                    else if(dado == "-1") {
                        cores[contador] = Color.White;
                    }

                    contador++;
                }
                AddRowsGrid(cores, data.Descricao, data.Pontuar, data.Notificar);

            }

            return cores;
        }

        private void AddRowsGrid() {

            DgDados.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", TxtDescricao.Text.Trim().ToUpper());


            DgDados[0, DgDados.Rows.Count - 1].Style.BackColor = Pn1.BackColor;
            DgDados[1, DgDados.Rows.Count - 1].Style.BackColor = Pn2.BackColor;
            DgDados[2, DgDados.Rows.Count - 1].Style.BackColor = Pn3.BackColor;
            DgDados[3, DgDados.Rows.Count - 1].Style.BackColor = Pn4.BackColor;
            DgDados[4, DgDados.Rows.Count - 1].Style.BackColor = Pn5.BackColor;
            DgDados[5, DgDados.Rows.Count - 1].Style.BackColor = Pn6.BackColor;
            DgDados[6, DgDados.Rows.Count - 1].Style.BackColor = Pn7.BackColor;
            DgDados[7, DgDados.Rows.Count - 1].Style.BackColor = Pn8.BackColor;
            DgDados[8, DgDados.Rows.Count - 1].Style.BackColor = Pn9.BackColor;
            DgDados[9, DgDados.Rows.Count - 1].Style.BackColor = Pn10.BackColor;
            DgDados[10, DgDados.Rows.Count - 1].Style.BackColor = Pn11.BackColor;
            DgDados[11, DgDados.Rows.Count - 1].Style.BackColor = Pn12.BackColor;
            DgDados[12, DgDados.Rows.Count - 1].Style.BackColor = PnOk.BackColor;
            DgDados[13, DgDados.Rows.Count - 1].Style.SelectionBackColor = Color.Red;
            DgDados[14, DgDados.Rows.Count - 1].Style.SelectionBackColor = Color.Red;
            DgDados[15, DgDados.Rows.Count - 1].Style.SelectionBackColor = Color.Red;

        }

        private void AddRowsGrid(Color[] cores, string descricao, bool pontuar, bool notificar) {
            DgDados.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", descricao, pontuar, notificar);


            for(int t = 0;t < 13;t++) {

                DgDados[t, DgDados.Rows.Count - 1].Style.BackColor = cores[t];
            }

            DgDados[13, DgDados.Rows.Count - 1].Style.SelectionBackColor = Color.Red;
            DgDados[14, DgDados.Rows.Count - 1].Style.SelectionBackColor = Color.Red;
            DgDados[15, DgDados.Rows.Count - 1].Style.SelectionBackColor = Color.Red;


        }

        private void ResetaCores() {
            foreach(Control controle in this.Controls) {
                if(controle is Panel) {
                    controle.BackColor = Color.White;
                }
            }
        }

        private void TimerAtualizaTela_Tick(object sender, EventArgs e) {


            int contador = 0;

            try {
                Resetar();
                if(Crawler.retornos != null && !string.IsNullOrEmpty(Crawler.retornos[contador])) {

                    LbIdentificador.Text = identificacaoEstrategia.ToString();

                    if(Crawler.Atualizou) {
                        Crawler.Atualizou = false;



                        foreach(Control controles in groupBox1.Controls) {
                            string entrada = Crawler.retornos[contador];


                            if(entrada == "red") {
                                controles.BackColor = Color.Red;
                            }
                            else if(entrada == "blue") {
                                controles.BackColor = Color.Blue;
                            }
                            else {
                                controles.BackColor = Color.WhiteSmoke;
                            }

                            contador++;
                        }


                        if(!CkEngine.Checked) {
                            return;
                        }




                        switch(identificacaoEstrategia) {

                            case -1:
                            estrategiaEncontrada = LocalizaEstrategia();
                            break;

                            case 1:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            EntradaConfirmada(estrategiaEncontrada);
                            break;
                            case 2:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            Win(estrategiaEncontrada);
                            break;
                            case 3:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            Martingale2(estrategiaEncontrada);
                            break;
                            case 4:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            Martingale3(estrategiaEncontrada);
                            break;
                            case 5:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            Martingale4(estrategiaEncontrada);
                            break;
                            case 6:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            Martingale5(estrategiaEncontrada);
                            break;
                            case 7:
                            if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                                SystemSounds.Beep.Play();
                            }
                            Loss(estrategiaEncontrada);
                            break;

                        }


                    }

                }
            } catch {

            }
        }

        private void BtExcluir_Click(object sender, EventArgs e) {
            if(DgDados.Rows.Count > 0) {

                int linhaSelecionada = DgDados.CurrentCellAddress.Y;
                try {
                    new DataBase().Insert(new Blaze_2._0.Entities.Estrategia().ToDelete(DgDados[13, linhaSelecionada].Value.ToString()));
                    DgDados.Rows.RemoveAt(linhaSelecionada);
                } catch {

                }
            }
        }




        private void BtAdicionar_Click(object sender, EventArgs e) {

            if(string.IsNullOrEmpty(TxtDescricao.Text.Trim())) {
                MessageBox.Show("A descrição é obrigatória!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            for(int t = 0;t < DgDados.Rows.Count;t++) {
                if(DgDados[13, t].Value.ToString().Trim().ToUpper() == TxtDescricao.Text.Trim().ToUpper()) {
                    MessageBox.Show("Estratégia já cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
            }

            AddRowsGrid();


            string[] dados = new string[13];

            StringBuilder cores = new StringBuilder();

            for(int t = 0;t < 13;t++) {
                if(DgDados[t, DgDados.Rows.Count - 1].Style.BackColor == Color.Red) {
                    cores.Append("1;");
                    dados[t] = "1";
                }
                else if(DgDados[t, DgDados.Rows.Count - 1].Style.BackColor == Color.Blue) {
                    cores.Append("0;");
                    dados[t] = "0";
                }
                else {
                    cores.Append("-1;");
                    dados[t] = "-1";
                }
            }

            DgDados[14, DgDados.Rows.Count - 1].Value = CkPontuar.Checked;
            DgDados[15, DgDados.Rows.Count - 1].Value = CkNotificar.Checked;

            try {

                if(new DataBase().Insert(new Blaze_2._0.Entities.Estrategia(cores.ToString().TrimEnd(';'), TxtDescricao.Text.Trim().ToUpper(), CkPontuar.Checked, CkNotificar.Checked).ToInsert())) {

                    ResetaCores();
                    TxtDescricao.Clear();
                    DgDados.Rows[DgDados.Rows.Count - 1].Selected = false;
                }
                else {
                    MessageBox.Show("Erro ao salvar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } catch { }

        }

        private void Fechando(object sender, FormClosingEventArgs e) {
            try {
                crawler.Close();
                th.Abort();
            } catch {

            }

        }






        private int LocalizaEstrategia() {



            if(DgDados.Rows.Count > 0) {



                List<Color> coresAtuais = new List<Color>();

                foreach(Control pn in groupBox1.Controls) {
                    coresAtuais.Add(pn.BackColor);
                }

                for(int linha = 0;linha < DgDados.Rows.Count;linha++) {

                    if(!bool.Parse(DgDados[14, linha].Value.ToString()) && !bool.Parse(DgDados[15, linha].Value.ToString())) {
                        continue;
                    }
                    List<Color> coresEstrategias = new List<Color>();


                    for(int coluna = DgDados.Columns.Count - 6;coluna >= 0;coluna--) {
                        if(DgDados[coluna, linha].Style.BackColor == Color.Red || DgDados[coluna, linha].Style.BackColor == Color.Blue) {
                            coresEstrategias.Add(DgDados[coluna, linha].Style.BackColor);
                        }
                    }

                    string cores = "";
                    string coresAtuaisa = "";

                    int contador = 0;
                    foreach(Color cor in coresEstrategias) {
                        cores += cor.ToString();
                        coresAtuaisa += coresAtuais[contador].ToString();
                        contador++;
                    }

                

                    if(cores == coresAtuaisa) {
                        if(Blaze_2._0.Entities.Configuracao.configuracao.Som) {
                            SystemSounds.Beep.Play();

                        }
                        Aguarde1Notificacao(linha);
                        return linha;
                    }
                }

            }
            return -1;
        }







        private void Aguarde1Notificacao(int linhaEstrategia) {


            identificacaoEstrategia = 1;
            if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {

                new TelegramBot().EnviarMensagem(Mensagem.mensagem.Aguarde1Notificacao, false, EnumMensagem.Aguarde2Notificacoes, DgDados[12, linhaEstrategia].Style.BackColor);
            }

        }

        private void EntradaConfirmada(int linhaEstrategia) {


            if(DgDados[11, linhaEstrategia].Style.BackColor == Lb12.BackColor) {
                identificacaoEstrategia = 2;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.EntradaConfirmada, false, EnumMensagem.EntradaConfirmada, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
            else {
                identificacaoEstrategia = -1;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Quebrou2Crash, true, EnumMensagem.QuebrouNo2Crash, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
        }
        private void Win(int linhaEstrategia) {


            if(DgDados[12, linhaEstrategia].Style.BackColor == Lb12.BackColor || Color.WhiteSmoke == Lb12.BackColor) {
                identificacaoEstrategia = -1;

                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    if(Color.WhiteSmoke == Lb12.BackColor) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.WinBranco, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    else {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Win, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                }
                PontuarJogada(true, linhaEstrategia);

            }
            else {
                identificacaoEstrategia = 3;

                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Martingale1, true, EnumMensagem.Martingale1, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
        }
        private void Martingale2(int linhaEstrategia) {
            if(DgDados[12, linhaEstrategia].Style.BackColor == Lb12.BackColor || Color.WhiteSmoke == Lb12.BackColor) {
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    if(Color.WhiteSmoke == Lb12.BackColor) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.WinBranco, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    else {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Win, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                }

                PontuarJogada(true, linhaEstrategia);
                identificacaoEstrategia = -1;
            }
            else {
                if(int.Parse(Blaze_2._0.Entities.Configuracao.configuracao.Margingale) < 2) {
                    identificacaoEstrategia = -1;


                    if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {

                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Loss, true, EnumMensagem.Loss, DgDados[12, linhaEstrategia].Style.BackColor);
                    }

                    PontuarJogada(false, linhaEstrategia);
                    return;
                }
                identificacaoEstrategia = 4;

                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Martingale2, true, EnumMensagem.Martingale2, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
        }
        private void Martingale3(int linhaEstrategia) {

            if(DgDados[12, linhaEstrategia].Style.BackColor == Lb12.BackColor || Color.WhiteSmoke == Lb12.BackColor) {
                identificacaoEstrategia = -1;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    if(Color.WhiteSmoke == Lb12.BackColor) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.WinBranco, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    else {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Win, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                }
                PontuarJogada(true, linhaEstrategia);

            }
            else {
                if(int.Parse(Blaze_2._0.Entities.Configuracao.configuracao.Margingale) < 3) {
                    identificacaoEstrategia = -1;
                    if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Loss, true, EnumMensagem.Loss, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    PontuarJogada(false, linhaEstrategia);
                    return;
                }
                identificacaoEstrategia = 5;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Martingale3, true, EnumMensagem.Martingale3, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
        }
        private void Martingale4(int linhaEstrategia) {

            if(DgDados[12, linhaEstrategia].Style.BackColor == Lb12.BackColor || Color.WhiteSmoke == Lb12.BackColor) {
                identificacaoEstrategia = -1;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    if(Color.WhiteSmoke == Lb12.BackColor) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.WinBranco, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    else {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Win, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                }
                PontuarJogada(true, linhaEstrategia);
            }
            else {


                if(int.Parse(Blaze_2._0.Entities.Configuracao.configuracao.Margingale) < 4) {
                    identificacaoEstrategia = -1;
                    if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Loss, true, EnumMensagem.Loss, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    PontuarJogada(false, linhaEstrategia);
                    return;
                }
                identificacaoEstrategia = 6;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {

                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Martingale4, true, EnumMensagem.Martingale4, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
        }
        private void Martingale5(int linhaEstrategia) {

            if(DgDados[12, linhaEstrategia].Style.BackColor == Lb12.BackColor || Color.WhiteSmoke == Lb12.BackColor) {
                identificacaoEstrategia = -1;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {

                    if(Color.WhiteSmoke == Lb12.BackColor) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.WinBranco, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    else {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Win, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                }
                PontuarJogada(true, linhaEstrategia);

            }
            else {
                if(int.Parse(Blaze_2._0.Entities.Configuracao.configuracao.Margingale) < 5) {
                    identificacaoEstrategia = -1;
                    if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Loss, true, EnumMensagem.Loss, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    PontuarJogada(false, linhaEstrategia);
                    return;
                }
                identificacaoEstrategia = 7;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {

                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Martingale5, true, EnumMensagem.Martingale5, DgDados[12, linhaEstrategia].Style.BackColor);
                }
            }
        }
        private void Loss(int linhaEstrategia) {

            if(DgDados[12, linhaEstrategia].Style.BackColor == Lb12.BackColor || Color.WhiteSmoke == Lb12.BackColor) {
                identificacaoEstrategia = -1;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {

                    if(Color.WhiteSmoke == Lb12.BackColor) {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.WinBranco, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                    else {
                        new TelegramBot().EnviarMensagem(Mensagem.mensagem.Win, true, EnumMensagem.Win, DgDados[12, linhaEstrategia].Style.BackColor);
                    }
                }
                PontuarJogada(true, linhaEstrategia);

            }
            else {
                identificacaoEstrategia = -1;
                if(bool.Parse(DgDados[15, linhaEstrategia].Value.ToString())) {
                    new TelegramBot().EnviarMensagem(Mensagem.mensagem.Loss, true, EnumMensagem.Loss, DgDados[12, linhaEstrategia].Style.BackColor);
                }
                quantidadeLoss++;
                PontuarJogada(false, linhaEstrategia);

            }
        }






        private void ClickNoConteudo(object sender, DataGridViewCellEventArgs e) {

            if(DgDados.Rows.Count > 0) {
                Point ponto = DgDados.CurrentCellAddress;

                if(ponto.X == 14 || ponto.X == 15) {
                    if(bool.Parse(DgDados[ponto.X, ponto.Y].Value.ToString())) {
                        DgDados[ponto.X, ponto.Y].Value = false;
                    }
                    else {
                        DgDados[ponto.X, ponto.Y].Value = true;
                    }

                    string nome = DgDados[13, ponto.Y].Value.ToString();
                    bool pontuar = bool.Parse(DgDados[14, ponto.Y].Value.ToString());
                    bool notificar = bool.Parse(DgDados[15, ponto.Y].Value.ToString());

                    try {
                        new DataBase().Insert(new Blaze_2._0.Entities.Estrategia().ToUpdate(pontuar, notificar, nome));
                    } catch {

                    }
                }


            }
        }

        private void BtConfiguracao_Click(object sender, EventArgs e) {
            FrmConfiguracao configuracao = new FrmConfiguracao();
            configuracao.ShowDialog();
        }

        private void BtMensagem_Click(object sender, EventArgs e) {
            FrmMensagem mensagem = new FrmMensagem();
            mensagem.ShowDialog();
        }

        private void BtDadosTelegram_Click(object sender, EventArgs e) {
            FrmTelegram telegram = new FrmTelegram();
            telegram.ShowDialog();
        }

        private void BtPlacar_Click(object sender, EventArgs e) {

            FrmPlacar placar = new FrmPlacar();
            placar.ShowDialog();

        }

        private void PontuarJogada(bool win, int linhaEstrategia) {

            if(bool.Parse(DgDados[14, linhaEstrategia].Value.ToString())) {
                string w = "1";
                if(!win) {
                    w = "0";
                }
                else
                {
                    quantidadeWin++;
                }

                string nome = DgDados[13, linhaEstrategia].Value.ToString();

                try {
                    new DataBase().Insert($"INSERT INTO Placar VALUES (Null,\"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\",\"{nome}\",{w});");
                } catch { }

            }
        }

        private void CkEngine_CheckedChanged(object sender, EventArgs e) {
            Crawler.engine = CkEngine.Checked;
        }

        private void tIMELINEToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTimeLine timeLine = new FrmTimeLine();
            timeLine.ShowDialog();
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog();
        }




        private void Maximizar() {

        }

        private void Minimizando(object sender, EventArgs e) {
        }

        private void MenuTopo_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        int restart = 1;
        private void TimerRestart_Tick(object sender, EventArgs e) {

            restart++;
        }

        private void Resetar() {
            if(restart > 60 && identificacaoEstrategia == -1) {
                try {
                    using(StreamWriter arquivo = new StreamWriter("Config.ini")) {
                        arquivo.WriteLine("Double.exe");
                        arquivo.WriteLine("0");
                    }
                    crawler.Close();
                    th.Abort();
                    Application.Exit();
                } catch {
                }
            }
        }

        private void Pn6_Paint(object sender, PaintEventArgs e)
        {

        }

        public int QuantidadeWin()
        {
            int quantidade = quantidadeWin;
            quantidadeWin = 0;
            return quantidade;
        }
        public int QuantidadeLoss()
        {
            int quantidade = quantidadeLoss;
            quantidadeLoss = 0;
            return quantidade;
        }
    }
}
