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
    public partial class FrmPlacar : Form {
        public FrmPlacar() {
            InitializeComponent();
        }

        private void FrmPlacar_Load(object sender, EventArgs e) {


            CbEstrategia.Items.Add("<TODOS>");
            foreach (var estrategia in Blaze_2._0.Entities.Estrategia.dadosCarregados.OrderBy(x => x.Descricao)) {
                CbEstrategia.Items.Add(estrategia.Descricao.ToUpper());
            }
            CbEstrategia.SelectedIndex = 0;
        }

        private void BtAtualizar_Click(object sender, EventArgs e) {


            string nome = CbEstrategia.Text.Replace("<TODOS>", "");
            string dataInicial = Convert.ToDateTime(DtInicial.Text).ToString("yyyy-MM-dd") + " 00:00:00";
            string dataFinal = Convert.ToDateTime(DtFinal.Text).ToString("yyyy-MM-dd") + " 23:59:59";
            string cmd = $"SELECT CAST(P.Data as Date) as DATA, P.Estrategia as ESTRATÉGIA, CAST(CONCAT(IF(P.Win = 1, \"WIN - \",\"LOSS - \"), COUNT(P.Estrategia)) as CHAR(50)) AS PLACAR FROM Placar as P WHERE P.Data between \"{dataInicial}\" and \"{dataFinal}\" and P.Estrategia like \"%{nome}%\" GROUP BY P.Estrategia,P.Win ORDER BY P.Estrategia, P.Win DESC";

            new DataBase().SelecionarGrid(cmd, DgDados);

            if (DgDados.Rows.Count > 0) {
                DgDados.Columns[0].Width = 150;
                DgDados.Columns[1].Width = 300;
                DgDados.Columns[2].Width = 150;
            }
        }

        private void esconderInformaçõesToolStripMenuItem_Click(object sender, EventArgs e) {
            if (DgDados.Rows.Count > 0) {
                if (esconderInformaçõesToolStripMenuItem.Text == "Esconder informações") {
                    esconderInformaçõesToolStripMenuItem.Text = "Mostrar informações";
                    Esconder();
                } else {
                    esconderInformaçõesToolStripMenuItem.Text = "Esconder informações";
                    Mostrar();
                }
            }
        }

        private void Esconder() {
            DgDados.Columns[1].Visible = false;
            GbEstrategias.Visible = false;
        }

        private void Mostrar() {
            DgDados.Columns[1].Visible = true;
            GbEstrategias.Visible = true;

        }
    }
}
