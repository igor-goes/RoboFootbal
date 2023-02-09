using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;

namespace Blaze_2._0 {
    class Crawler {



        public static string[] retornos { get; private set; }
        public static bool Atualizou { get; set; }


        ChromeDriver driver;
        public void Iniciar() {
            try {
                DownloadChorme.DonwloadChorme();
                retornos = new string[12];


                ChromeDriverService service = ChromeDriverService.CreateDefaultService(Path.GetTempPath() + @"\V4");
                string oi = Path.GetTempPath() + @"\V4";
                service.HideCommandPromptWindow = true;

                ChromeOptions options = new ChromeOptions();
                // options.AddArgument("headless");

                driver = new ChromeDriver(service, options);
                //driver.Navigate().GoToUrl(Constantes.linkRobo);
                driver.Navigate().GoToUrl("https://casino.netbet.com/br/play/football-studio");
                driver.FindElement(By.Id("LoginModal")).Click();
                driver.FindElement(By.Id("LoginModal")).SendKeys("goesi195@gmail.com");
                driver.FindElement(By.XPath("//*[@id=\"_1Hcn-kLmQsOrtPd9lYyKPX\"]")).Click();
                driver.FindElement(By.XPath("//*[@id=\"_1Hcn-kLmQsOrtPd9lYyKPX\"]")).SendKeys("robofootbalstudio");
                driver.FindElement(By.XPath("//*[@id=\"LoginModal\"]/div/div/div/div/div[2]/div/div/div[2]/div/div/div/div/form/div[3]/div[1]/div/button")).Click();



                string[] ultimasEntradas = new string[10];

                while (true) {
                    try {


                        int contador = 0;
                        foreach (var elemento in driver.FindElement(By.ClassName("roulette-previous")).FindElement(By.ClassName("entries")).FindElements(By.ClassName("entry"))) {
                            string dadoAtual = elemento.FindElement(By.ClassName("roulette-tile")).FindElement(By.ClassName("sm-box")).GetAttribute("class").Replace("sm-box ", "");
                            retornos[contador] = dadoAtual;
                            contador++;
                            if(contador >= 12) {
                                break;
                            }
                        }



                        if (string.IsNullOrEmpty(ultimasEntradas[0]) &&
                            string.IsNullOrEmpty(ultimasEntradas[1]) &&
                            string.IsNullOrEmpty(ultimasEntradas[2]) &&
                            string.IsNullOrEmpty(ultimasEntradas[3]) &&
                            string.IsNullOrEmpty(ultimasEntradas[4]) &&
                            string.IsNullOrEmpty(ultimasEntradas[5]) &&
                            string.IsNullOrEmpty(ultimasEntradas[6]) &&
                            string.IsNullOrEmpty(ultimasEntradas[7]) &&
                            string.IsNullOrEmpty(ultimasEntradas[8]) &&
                            string.IsNullOrEmpty(ultimasEntradas[9])) {                            

                            for (int t = 0; t < 10; t++) {      
                                    ultimasEntradas[t] = retornos[t];                                
                            }

                            Atualizou = true;
                            Thread th = new Thread(InserirGame);
                            th.Start();
                            Thread.Sleep(500);

                        } else {                
                            
                            if (ultimasEntradas[0] != retornos[0] ||
                                ultimasEntradas[1] != retornos[1] ||
                                ultimasEntradas[2] != retornos[2] ||
                                ultimasEntradas[3] != retornos[3] ||
                                ultimasEntradas[4] != retornos[4] ||
                                ultimasEntradas[5] != retornos[5] ||
                                ultimasEntradas[6] != retornos[6] ||
                                ultimasEntradas[7] != retornos[7] ||
                                ultimasEntradas[8] != retornos[8] ||
                                ultimasEntradas[9] != retornos[9]) {



                                for (int t = 0; t < 10; t++) {
                                    ultimasEntradas[t] = retornos[t];
                                }




                                Atualizou = true;
                                Thread th = new Thread(InserirGame);
                                th.Start();
                                Thread.Sleep(500);
                            }
                        }


                    } catch {

                    }

                }

            } catch {
            }
        }

        public static bool engine;

        private void InserirGame() {
            try {
              
                    new DataBase().Insert($"INSERT INTO Game VALUES (Null,\"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\",\"{ retornos[0].Replace("X", "")}\");");
                
            } catch {

            }
        }

        public void Close() {

            try {
                if (driver != null) {
                    driver.Close();
                    driver.Dispose();
                    driver.Quit();
                }
            } catch { }
        }

    }
}
