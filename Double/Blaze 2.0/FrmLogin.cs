using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaze_2._0 {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }
        Thread ThAbrir;
        private void BtEntrar_Click(object sender, EventArgs e) {
            if(new DataBase().Logado(TxtUsuario.Text.Trim(), TxtSenha.Text.Trim())) {
                this.Close();
                ThAbrir = new Thread(Abrir);
                ThAbrir.SetApartmentState(ApartmentState.STA);
                ThAbrir.Start();
            } else {
                MessageBox.Show("Usuário ou senha inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        private void Abrir() {
            Application.Run(new Form1());
            ThAbrir.Abort();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {

            this.Activate();
            this.TopMost = true;
            this.TopMost = false;
        }

        private void LbSenha_Click(object sender, EventArgs e) {

        }

        private void LbUsuario_Click(object sender, EventArgs e) {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e) {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e) {

        }
    }
}
