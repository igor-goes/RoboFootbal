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
    public partial class FrmUsuario : Form {
        public FrmUsuario() {
            InitializeComponent();
        }

        private void BtAtualizar_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(TxtUsuario.Text.Trim())) {
                MessageBox.Show("Preencha o nome do usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(TxtSenha.Text.Trim())) {
                MessageBox.Show("Preencha a senha do usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           if( new DataBase().Insert(new Blaze_2._0.Entities.Usuario(TxtUsuario.Text.Trim(), TxtSenha.Text.Trim()).ToInsertOrUpdate())) {
                MessageBox.Show("Usuário salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Atualizar();
            } else {
                MessageBox.Show("Erro ao atualizar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void Atualizar() {
            string cmd = $"Select Nome as NOME, Senha as SENHA from Usuario order by Nome";

            new DataBase().SelecionarGrid(cmd, DgDados);

            if (DgDados.Rows.Count > 0) {
                DgDados.Columns[0].Width = 200;
                DgDados.Columns[1].Width = 200;              

            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e) {
            Atualizar();
        }
    }
}
