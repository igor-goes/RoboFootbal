using Blaze_2._0.Entities;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Blaze_2._0.Telas_menus {
    public partial class FrmMensagem : Form {



        public FrmMensagem() {
            InitializeComponent();
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e) {

            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ContextMenuStrip s = (ContextMenuStrip)t.Owner;
            TextBox txt = s.SourceControl as TextBox;
            txt.Text += "<a href='https://blaze.com/pt/games/double/'>Double</a>";
            txt.Select(txt.Text.Length, 0);


        }


        private void BtAtualizar_Click(object sender, EventArgs e) {

            if (new DataBase().Insert(new Mensagem(
                 TxtAguarde1Notificacao.Text,
                 TxtQuebrou2Crash.Text,
                 TxtEntradaConfirmada.Text,
                 Txt1Martingale.Text,
                 Txt2Martingale.Text,
                 Txt3Martingale.Text,
                 Txt4Martingale.Text,
                 Txt5Martingale.Text,
                 TxtWin.Text,
                 TxtLoss.Text,
                  TxtWinBranco.Text).ToUpdate())) {


                Mensagem.mensagem.Aguarde1Notificacao = TxtAguarde1Notificacao.Text;
                Mensagem.mensagem.Quebrou2Crash = TxtQuebrou2Crash.Text;
                Mensagem.mensagem.EntradaConfirmada = TxtEntradaConfirmada.Text;
                Mensagem.mensagem.Martingale1 = Txt1Martingale.Text;
                Mensagem.mensagem.Martingale2 = Txt2Martingale.Text;
                Mensagem.mensagem.Martingale3 = Txt3Martingale.Text;
                Mensagem.mensagem.Martingale4 = Txt4Martingale.Text;
                Mensagem.mensagem.Martingale5 = Txt5Martingale.Text;
                Mensagem.mensagem.Win = TxtWin.Text;
                Mensagem.mensagem.Loss = TxtLoss.Text;
                Mensagem.mensagem.WinBranco = TxtWinBranco.Text;



                MessageBox.Show("Dados salvos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else {
                MessageBox.Show("Erro ao salvar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void FrmMensagem_Load(object sender, EventArgs e) {


            TxtAguarde1Notificacao.Text = Mensagem.mensagem.Aguarde1Notificacao;
            TxtQuebrou2Crash.Text = Mensagem.mensagem.Quebrou2Crash;
            TxtEntradaConfirmada.Text = Mensagem.mensagem.EntradaConfirmada;
            Txt1Martingale.Text = Mensagem.mensagem.Martingale1;
            Txt2Martingale.Text = Mensagem.mensagem.Martingale2;
            Txt3Martingale.Text = Mensagem.mensagem.Martingale3;
            Txt4Martingale.Text = Mensagem.mensagem.Martingale4;
            Txt5Martingale.Text = Mensagem.mensagem.Martingale5;
            TxtWin.Text = Mensagem.mensagem.Win;
            TxtLoss.Text = Mensagem.mensagem.Loss;
            TxtWinBranco.Text = Mensagem.mensagem.WinBranco;


        }

        private void winVariávelToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            ContextMenuStrip s = (ContextMenuStrip)t.Owner;
            TextBox txt = s.SourceControl as TextBox;
            txt.Text += "{CORES}";
            txt.Select(txt.Text.Length, 0);
        }
    }
}
