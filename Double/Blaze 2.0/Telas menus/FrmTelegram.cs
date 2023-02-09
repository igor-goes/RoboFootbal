using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaze_2._0.Telas_menus {
    public partial class FrmTelegram : Form {
        public FrmTelegram() {
            InitializeComponent();
        }

        private void BtAtualizar_Click(object sender, EventArgs e) {

            if(string.IsNullOrEmpty(TxtId.Text)) {
                MessageBox.Show("Preencha o campo com o Id do grupo/Canal!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(TxtToken.Text)) {
                MessageBox.Show("Preencha o campo com o Token do grupo/Canal!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(new DataBase().Insert(new Blaze_2._0.Entities.Telegram(TxtId.Text, TxtToken.Text).ToUpdate())) {
                Blaze_2._0.Entities.Telegram.telegram.IdTelegram = TxtId.Text;
                Blaze_2._0.Entities.Telegram.telegram.Token = TxtToken.Text;

                MessageBox.Show("Dados salvos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            } else {
                MessageBox.Show("Erro ao salvar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmTelegram_Load(object sender, EventArgs e) {
    
                TxtId.Text = Blaze_2._0.Entities.Telegram.telegram.IdTelegram;
                TxtToken.Text = Blaze_2._0.Entities.Telegram.telegram.Token;

          
        }
    }
}
