using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze_2._0.Entities {
    class Usuario {

        public string Nome { get; set; }

        public string Senha { get; set; }

        public Usuario(string nome, string senha) {
            Nome = nome;
            Senha = senha;
        }

        public string ToInsertOrUpdate() {
            return $"INSERT INTO Usuario Values (\"{Nome}\",\"{Senha}\") " +
               $"ON DUPLICATE KEY UPDATE Nome = \"{Nome}\", Senha = \"{Senha}\";";
        }

      
    }
}
