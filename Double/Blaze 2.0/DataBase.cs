using Blaze_2._0;
using Blaze_2._0.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

class DataBase {

    private MySqlConnection Connection = new MySqlConnection("Persist Security Info = False; server = 31.170.160.140; database = u755262732_SuitsDouble; uid = u755262732_SuitsDouble; pwd = 4984Card");
    // private MySqlConnection Connection = new MySqlConnection("Persist Security Info = False; server = localhost; database = u755262732_SuitsDouble; uid = root pwd = urubu100");

    private MySqlConnection Connect() {
        try {

                Connection.Open();
           
        } catch (MySqlException error) {
            Console.WriteLine(error.Message);
            Disconnect();
        }
        return Connection;
    }

    private MySqlConnection Disconnect() {
        Connection.Close();
        return Connection;
    }

    private bool ExecutaQuery(string cmd) {
        bool executed = false;
        try {
            MySqlCommand command = new MySqlCommand(cmd, Connect());
            command.ExecuteNonQuery();
            executed = true;
        } catch (MySqlException error) {
            Console.WriteLine(error.Message);
        } finally {
            Disconnect();
        }
        return executed;
    }

    public bool Insert(string sql) => ExecutaQuery(sql);


    public bool CarregaDadosTelegram() {
        bool foiCarregado = true;
        try {
            using (DataTable Dados_Tabela = new DataTable()) {
                using (MySqlCommand comando = Connect().CreateCommand()) {
                    comando.CommandText = "Select IdTelegram, Token from Telegram;";
                    Dados_Tabela.Load(comando.ExecuteReader());
                    foreach (DataRow linha in Dados_Tabela.Rows) {
                        Blaze_2._0.Entities.Telegram.telegram.IdTelegram = linha[0].ToString();
                        Blaze_2._0.Entities.Telegram.telegram.Token = linha[1].ToString();
                    }
                }
            }
        } catch {
            foiCarregado = false;
        } finally {
            Disconnect();
        }

        return foiCarregado;

    }


    public bool CarregaDadosConfiguracao() {
        bool foiCarregado = true;
        try {
            using (DataTable Dados_Tabela = new DataTable()) {
                using (MySqlCommand comando = Connect().CreateCommand()) {
                    comando.CommandText = "Select Som, Martingale from Configuracao;";
                    Dados_Tabela.Load(comando.ExecuteReader());
                    foreach (DataRow linha in Dados_Tabela.Rows) {
                        bool som = false;
                        if (linha[0].ToString() == "1") {
                            som = true;
                        }
                        Configuracao.configuracao.Som = som;
                        Configuracao.configuracao.Margingale = linha[1].ToString();
                    }
                }
            }
        } catch {
            foiCarregado = false;
        } finally {
            Disconnect();
        }

        return foiCarregado;

    }


    public bool CarregaDadosEstrategia() {
        bool foiCarregado = true;
        try {
            using (DataTable Dados_Tabela = new DataTable()) {
                using (MySqlCommand comando = Connect().CreateCommand()) {
                    comando.CommandText = "Select Estrategia, Descricao, Pontuar, Notificar from Estrategias;";
                    Dados_Tabela.Load(comando.ExecuteReader());
                    foreach (DataRow linha in Dados_Tabela.Rows) {
                        bool pontuar = false;
                        bool notificar = false;



                        if (linha[2].ToString() == "1") {
                            pontuar = true;
                        }

                        if (linha[3].ToString() == "1") {
                            notificar = true;
                        }

                        Blaze_2._0.Entities.Estrategia.dadosCarregados.Add(new Blaze_2._0.Entities.Estrategia(linha[0].ToString(), linha[1].ToString(), pontuar, notificar));

                    }
                }
            }
        } catch {
            foiCarregado = false;
        } finally {
            Disconnect();
        }

        return foiCarregado;

    }



    public bool CarregaDadosMensagem() {
        bool foiCarregado = true;
        try {
            using (DataTable Dados_Tabela = new DataTable()) {
                using (MySqlCommand comando = Connect().CreateCommand()) {
                    comando.CommandText = "Select Descricao from Mensagem order by Id;";
                    Dados_Tabela.Load(comando.ExecuteReader());


           
                    Mensagem.mensagem.Aguarde1Notificacao = Dados_Tabela.Rows[0][0].ToString();
                    Mensagem.mensagem.Quebrou2Crash = Dados_Tabela.Rows[1][0].ToString();
                    Mensagem.mensagem.EntradaConfirmada = Dados_Tabela.Rows[2][0].ToString();
                    Mensagem.mensagem.Martingale1 = Dados_Tabela.Rows[3][0].ToString();
                    Mensagem.mensagem.Martingale2 = Dados_Tabela.Rows[4][0].ToString();
                    Mensagem.mensagem.Martingale3 = Dados_Tabela.Rows[5][0].ToString();
                    Mensagem.mensagem.Martingale4 = Dados_Tabela.Rows[6][0].ToString();
                    Mensagem.mensagem.Martingale5 = Dados_Tabela.Rows[7][0].ToString();
                    Mensagem.mensagem.Win = Dados_Tabela.Rows[8][0].ToString();
                    Mensagem.mensagem.Loss = Dados_Tabela.Rows[9][0].ToString();
                    Mensagem.mensagem.WinBranco = Dados_Tabela.Rows[10][0].ToString();


                }
            }
        } catch {
            foiCarregado = false;
        } finally {
            Disconnect();
        }

        return foiCarregado;

    }




    private DataSet DSet;
    private MySqlDataAdapter Adapter;


    public DataSet SelecionarGrid(string cmd, DataGridView dg) {
        string[] extraiTabela = cmd.Split(' ');
        string tabela = "";

        for (int t = 0; t < extraiTabela.Length - 1; t++) {
            if (extraiTabela[t].Trim().ToLower() == "from") {
                tabela = extraiTabela[t + 1];
                break;
            }
        }


        try {
            DSet = new DataSet();
            Adapter = new MySqlDataAdapter(cmd, Connect());
            Adapter.Fill(DSet, tabela);
            dg.DataSource = DSet;
            dg.DataMember = tabela;
        } catch {

        } finally {
            Disconnect();

        }
        return DSet;

    }


    public bool Logado(string usuario, string senha) {
        bool logado = false;
        try {
            using (DataTable Dados_Tabela = new DataTable()) {
                using (MySqlCommand comando = Connect().CreateCommand()) {
                    comando.CommandText = $"Select * from Usuario where Nome = \"{usuario}\" and Senha = \"{senha}\";";
                    Dados_Tabela.Load(comando.ExecuteReader());
                    foreach (DataRow linha in Dados_Tabela.Rows) {
                        logado = true;
                        break;
                    }
                }
            }
        } catch {
            logado = false;
        } finally {
            Disconnect();
        }

        return logado;

    }
}

