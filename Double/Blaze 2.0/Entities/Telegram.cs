using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze_2._0.Entities {
    class Telegram {

        public static Telegram telegram = new Blaze_2._0.Entities.Telegram();
       public string IdTelegram { get; set; }

        public string Token { get; set; }

        private Telegram() {
       
        }

        public Telegram(string idTelegram, string token) {
            IdTelegram = idTelegram;
            Token = token;
        }

         public string ToUpdate() {
            return $"UPDATE Telegram set IdTelegram = \"{IdTelegram}\", Token = \"{Token}\";";
        }

    }
}
