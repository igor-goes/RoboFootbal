using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaze_2._0.Entities {
  public  class Estrategia {

        public static List<Blaze_2._0.Entities.Estrategia> dadosCarregados = new List<Entities.Estrategia>();


        public string Estrategy { get; set; }    
        public string Descricao { get; set; }
        public bool Pontuar { get; set; }
        public bool Notificar { get; set; }


        public Estrategia() {

        }

    


        public Estrategia(string estrategy, string descricao, bool pontuar, bool notificar) {
            Estrategy = estrategy;           
            Descricao = descricao;
            Pontuar = pontuar;
            Notificar = notificar;
        }

        public string ToInsert() {
            return $"INSERT INTO Estrategias VALUES (Null,\"{Estrategy}\" ,\"{Descricao}\",{Pontuar},{Notificar});";
        }

        public string ToUpdate(bool pontuar, bool notificar, string nome) {
            string not = "1";
            string pont = "1";
            if (!notificar) {
                not = "0";
            }
            if (!pontuar) {
                pont = "0";
            }


            return $"UPDATE Estrategias SET Pontuar = {pont}, Notificar = {not} WHERE Descricao = \"{nome}\";";
        }


        public string ToDelete(string nome) {
            return $"DELETE FROM Estrategias WHERE Descricao = \"{nome}\";";

        }
    }
}
