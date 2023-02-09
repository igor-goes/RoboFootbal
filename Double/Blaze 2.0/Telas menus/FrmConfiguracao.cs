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
    public partial class FrmConfiguracao : Form {
        public FrmConfiguracao() {
            InitializeComponent();
        }

        private void FrmConfiguracao_Load(object sender, EventArgs e) {

            CkSom.Checked = Entities.Configuracao.configuracao.Som;
            TxtNumeroMartingale.Value = decimal.Parse(Blaze_2._0.Entities.Configuracao.configuracao.Margingale);



        }

        private void BtAtualizar_Click(object sender, EventArgs e) {

            if (new DataBase().Insert(new Blaze_2._0.Entities.Configuracao(CkSom.Checked, TxtNumeroMartingale.Value.ToString()).ToUpdate())) {
                Blaze_2._0.Entities.Configuracao.configuracao.Som = CkSom.Checked;
                Blaze_2._0.Entities.Configuracao.configuracao.Margingale = TxtNumeroMartingale.Value.ToString();

                MessageBox.Show("Dados salvos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            } else {
                MessageBox.Show("Erro ao salvar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
