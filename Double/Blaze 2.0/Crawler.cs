using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Blaze_2._0 {
    class Crawler {



        public static string[] retornos { get; private set; }
        public static bool Atualizou { get; set; }


        ChromeDriver driver;
        private IWebDriver _webDriver;
        public void Iniciar() {
            try {
                DownloadChorme.DonwloadChorme();
                retornos = new string[12];


                ChromeDriverService service = ChromeDriverService.CreateDefaultService(Path.GetTempPath() + @"\V4");
                string oi = Path.GetTempPath() + @"\V4";
                service.HideCommandPromptWindow = true;

                ChromeOptions options = new ChromeOptions();
                 // options.AddArgument("headless");

                try
                {
                    new DriverManager().SetUpDriver(new ChromeConfig(), "109.0.5414.74");

                    driver = new ChromeDriver(service,options);

                }
                catch
                {
                    new DriverManager().SetUpDriver(new ChromeConfig(), "110.0.5481.30");
                    driver = new ChromeDriver(service,options);

                }
                driver.Navigate().GoToUrl("https://casino.netbet.com/br/play/football-studio");
                Thread.Sleep(10000);
                driver.FindElement(By.Name("username")).Click();
                driver.FindElement(By.Name("username")).SendKeys("goesi195@gmail.com");
                driver.FindElement(By.Name("password")).Click();
                driver.FindElement(By.Name("password")).SendKeys("robofootbalstudio");
                driver.FindElement(By.XPath("//*[@id=\"LoginModal\"]/div/div/div/div/div[2]/div/div/div[2]/div/div/div/div/form/div[3]/div[1]/div/button")).Click();
                Thread.Sleep(40000);

                string[] ultimasEntradas = new string[10];
                // var elementod = driver.FindElements(By.CssSelector("div[data-role ='history-statistic']"));

                    var elementod = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div[2]/div[6]/div/div[3]/div/div/div")).FindElements(By.ClassName("historyItem"));

                while (true)
                {
                    try {


                        int contador = 0;
                        foreach (var teste in elementod) 
                        {
                            string dadoAtual = teste.GetAttribute("style");
                            retornos[contador] = dadoAtual;
                            contador++;
                            if(contador >= 12) {
                                break;
                            }
                        }

                        driver.Navigate().GoToUrl(Constantes.linkRobo);
                        foreach (var elemento in driver.FindElement(By.ClassName("roulette-previous")).FindElement(By.ClassName("entries")).FindElements(By.ClassName("entry")))
                        {
                            string dadoAtual = elemento.FindElement(By.ClassName("roulette-tile")).FindElement(By.ClassName("sm-box")).GetAttribute("class").Replace("sm-box ", "");
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
