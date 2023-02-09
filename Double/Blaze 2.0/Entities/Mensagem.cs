using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze_2._0.Entities {
    class Mensagem {

        public static Mensagem mensagem = new Blaze_2._0.Entities.Mensagem();
      



     

        public string Aguarde1Notificacao { get; set; }
        public string Quebrou2Crash { get; set; }
        public string EntradaConfirmada { get; set; }
        public string Martingale1 { get; set; }
        public string Martingale2 { get; set; }
        public string Martingale3 { get; set; }
        public string Martingale4 { get; set; }
        public string Martingale5 { get; set; }
        public string Win { get; set; }
        public string Loss { get; set; }


        public string WinBranco { get; set; }

        private Mensagem() {

        }

        public Mensagem(string aguarde1Notificacao, string quebrou2Crash, string entradaConfirmada, string martingale1, string martingale2, string martingale3, string martingale4, string martingale5, string win, string loss, string winBranco) {

            Aguarde1Notificacao = aguarde1Notificacao;
            Quebrou2Crash = quebrou2Crash;
            EntradaConfirmada = entradaConfirmada;
            Martingale1 = martingale1;
            Martingale2 = martingale2;
            Martingale3 = martingale3;
            Martingale4 = martingale4;
            Martingale5 = martingale5;
            Win = win;
            Loss = loss;
            WinBranco = winBranco;
        }

        public string ToUpdate() {
            return $"UPDATE Mensagem set Descricao = \"{Aguarde1Notificacao}\" WHERE Id =3;" +
                   $"UPDATE Mensagem set Descricao = \"{Quebrou2Crash}\" WHERE Id = 4;" +
                   $"UPDATE Mensagem set Descricao = \"{EntradaConfirmada}\" WHERE Id = 5;" +
                   $"UPDATE Mensagem set Descricao = \"{Martingale1}\" WHERE Id = 6;" +
                   $"UPDATE Mensagem set Descricao = \"{Martingale2}\" WHERE Id = 7;" +
                   $"UPDATE Mensagem set Descricao = \"{Martingale3}\" WHERE Id = 8;" +
                   $"UPDATE Mensagem set Descricao = \"{Martingale4}\" WHERE Id = 9;" +
                   $"UPDATE Mensagem set Descricao = \"{Martingale5}\" WHERE Id = 10;" +
                   $"UPDATE Mensagem set Descricao = \"{Win}\" WHERE Id = 11;" +
                   $"UPDATE Mensagem set Descricao = \"{Loss}\" WHERE Id = 12;" +
                   $"UPDATE Mensagem set Descricao = \"{WinBranco}\" WHERE Id = 13;";
        }
    }
}
