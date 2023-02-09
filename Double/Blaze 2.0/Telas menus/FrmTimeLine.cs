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
    public partial class FrmTimeLine : Form {
        public FrmTimeLine() {
            InitializeComponent();
        }

        private void BtAtualizar_Click(object sender, EventArgs e) {


            string dataInicial = Convert.ToDateTime(DtData.Text).ToString("yyyy-MM-dd") + " 00:00:00";
            string dataFinal = Convert.ToDateTime(DtData.Text).ToString("yyyy-MM-dd") + " 23:59:59";


            string cmd = $"Select Hora as HORA, Jogada as JOGADA from Game WHERE Hora between \"{dataInicial}\" and \"{dataFinal}\" order by Hora";

            new DataBase().SelecionarGrid(cmd, DgDados);

            if (DgDados.Rows.Count > 0) {
                DgDados.Columns[0].Width = 130;
                DgDados.Columns[1].Width = 90;

                for (int t = 0; t < DgDados.Rows.Count; t++) {
                    if (DgDados[1, t].Value.ToString() == "red") {
                        DgDados[0, t].Style.BackColor = Color.Red;
                        DgDados[1, t].Style.BackColor = Color.Red;
                    } else if (DgDados[1, t].Value.ToString() == "black") {

                        DgDados[0, t].Style.BackColor = Color.DimGray;
                        DgDados[1, t].Style.BackColor = Color.DimGray;
                    } else {
                        DgDados[0, t].Style.BackColor = Color.White;
                        DgDados[1, t].Style.BackColor = Color.White;
                    }



                }
            }


        }
    }
}
