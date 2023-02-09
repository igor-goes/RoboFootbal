using Blaze_2._0.Entities;
using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Blaze_2._0 {
    public partial class Splash : Form {
        public Splash() {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e) {
            
                Thread th = new Thread(Inicia);
                th.Start();
                Thread th2 = new Thread(StartProgressBar);
                th2.Start();   

        }


        Thread ThAbrir;

        private void StartProgressBar() {
            for (int t = 1; t <= 100; t++) {
                Action acao = delegate {
                    progressBar1.Value = t;
                };
                Invoke(acao);
                Thread.Sleep(100);
            }
            Thread.Sleep(500);
            Action acaoFechaTela = delegate {
                this.Close();
            };
            Invoke(acaoFechaTela);
            ThAbrir = new Thread(Abrir);
            ThAbrir.SetApartmentState(ApartmentState.STA);
            ThAbrir.Start();
        }

        private void Abrir() {
            Application.Run(new FrmLogin());
            ThAbrir.Abort();
        }

        private void Inicia() {

       
         

        }
    }
}
