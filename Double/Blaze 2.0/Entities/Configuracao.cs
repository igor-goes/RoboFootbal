namespace Blaze_2._0.Entities {
    class Configuracao {

        public static Configuracao configuracao = new Blaze_2._0.Entities.Configuracao();
        public bool Som { get; set; }

        public string  Margingale{ get; set; }
        private Configuracao() {

        }

        public Configuracao(bool som, string margingale) {
            Som = som;
            Margingale = margingale;

        }

        public string ToUpdate() {
            return $"UPDATE Configuracao set Som = {Som}, Martingale = \"{Margingale}\";";
        }
    }
}
