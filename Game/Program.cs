using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;

#pragma warning disable IDE1006 // Estilos de Nomenclatura

namespace Game
{

    /// <summary>
    /// Objetos ou estruturas de dados globais existentes no jogo
    /// </summary>
    public class Global
    {

        /// <summary>
        /// Todas as cartas do jogo
        /// </summary>
        public struct Card
        {
            public string id;
            public string bodes;
            public System.Drawing.Bitmap img;


            /// <summary>
            /// Estrutura que agrupa a parte gráfica de uma carta.
            /// </summary>
            public struct Graphical
            {
                public Panel panel;
                public Label bodes;
                public Label id;
                

                public Graphical(System.Drawing.Size size)
                {

                    this.bodes = new Label();
                    this.id = new Label();
                    this.panel = new Panel();

                    panel.Controls.Add(this.id);
                    panel.Controls.Add(this.bodes);
                    panel.Size = size;
                }
            }


            /// <summary>
            /// Gera uma nova carta
            /// </summary>
            public Card(string id, string bodes, string img)
            {
                this.id = "";
                this.id = id;
                this.bodes = "";
                this.bodes = bodes;
               
                switch (Int32.Parse(img))
                {
                    case 1:
                        this.img = Properties.Resources.b1;

                        break;

                    case 2:
                        this.img = Properties.Resources.b2;
                        break;

                    case 3:
                        this.img = Properties.Resources.b3;
                        break;

                    case 4:
                        this.img = Properties.Resources.b4;
                        break;

                    case 5:
                        this.img = Properties.Resources.b5;
                        break;

                    case 6:
                        this.img = Properties.Resources.b6;
                        break;

                    case 7:
                        this.img = Properties.Resources.b7;
                        break;

                    case 8:
                        this.img = Properties.Resources.b8;
                        break;

                    case 9:
                        this.img = Properties.Resources.b9;
                        break;

                    default:
                        this.img = Properties.Resources.b10;
                        break;
                }
            }
            

            /// <summary>
            /// Retorna um painel desta carta
            /// </summary>
            public Graphical get_Panel(int width, int height)
            {
                System.Drawing.Size size = new System.Drawing.Size(width, height);
                Graphical frame = new Graphical( size );

                // panel
                frame.panel.BackgroundImage = this.img;
                frame.panel.BackgroundImageLayout = ImageLayout.Stretch;

                // id
                frame.id.Text = this.id;
                frame.id.AutoSize = true;
                frame.id.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                frame.id.Location = new System.Drawing.Point(3, 3);
                frame.id.BackColor = System.Drawing.Color.White;
                frame.id.ForeColor = System.Drawing.Color.Red;

                // bodes
                frame.bodes.Text = this.bodes;
                frame.bodes.AutoSize = true;
                frame.bodes.Width = 30;
                frame.bodes.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                frame.bodes.Location = new System.Drawing.Point(3, height - 20);
                frame.bodes.BackColor = System.Drawing.Color.White;
                frame.bodes.ForeColor = System.Drawing.Color.Red;


                return frame;
            }

        } 
        public static Card[] cards;


        /// <summary>
        /// Classe do nosso jogador na partida
        /// </summary>
        public class Player
        {
            public int id;
            public int bodes;
            public string name;
            public string token;
            public LinkedList<Card> cards;

            /// <summary>
            /// Prepara o jogador
            /// </summary>
            public Player(string name, string token, int id)
            {
                // jogador
                
                this.name = ""; // 
                this.cards = new LinkedList<Card>();
                this.name = name;
                this.token = token; // Senha unica gerada pelo banco
                this.id = id;
                this.bodes = 0;
            }


            /// <summary>
            /// Extrai o ID da carta do deck no meio
            /// </summary>
            /// <returns>Retorna o ID da carta na posição central</returns>
            public string get_cardMID()
            {
                int index = this.cards.Count / 2;
                return this.cards.ElementAt(index).id;
            }

            /// <summary>
            /// Soma os IDs das cartas na mão e retorna uma media.
            /// </summary>
            /// <returns></returns>
            public int get_AvgCardsIDS()
            {
                int idSum = 0;
                foreach(Card card in this.cards)
                {
                    idSum += Int32.Parse(card.id);
                }
                return idSum/(this.cards.Count);
            }


            /// <summary>
            /// Recebe um index, positivo ou negativo, e retorna o ID da carta naquela posição
            /// </summary>
            /// <param name="index"> Se positivo procura a partir da posição 0, se negativo procura a partir do final em forma reversa</param>
            /// <returns>Retorna o ID da carta na posição</returns>
            public string get_cardID(int index)
            {
                if (index < 0)
                {
                    int real_index = this.cards.Count + index;
                    return this.cards.ElementAt(real_index).id;
                }

                else
                {
                    return this.cards.ElementAt(index).id;
                }
            }

        } static public Player player;


        /// <summary>
        /// Classe dos inimigos na partida
        /// </summary>
        public class Enemy
        {
            public int id;
            public string name;
            public LinkedList<Global.Card> cards = new LinkedList<Global.Card>();

            public Enemy(string id, string name)
            {
                this.id = Int32.Parse(id);
                this.name = name;
            }
        }
        public static Enemy[] enemies;


        /// <summary>
        /// Partida selecionada principal
        /// </summary>
        public class Selected_Match
        {
            public int id;
            public int ilha;
            public int rodada;
            public char status;
            public string name;
            public string date; 
            public string vez;  
            public string senha;
            public LinkedList<Global.Card> table_Cards;


            /// <summary>
            /// Prepara o objeto Match
            /// </summary>
            public Selected_Match(string senha,Client.Match target)
            {
                // Match
                this.id = target.id;
                this.name = target.name;
                this.date = target.date;
                this.senha = senha;
                this.status = '0';
                this.ilha = 0;
                this.rodada = 0;
                this.table_Cards = new LinkedList<Card>();
            }


            /// <summary>
            /// Joga uma carta na partida atual
            /// </summary>
            /// <returns>Retorna true se foi um sucesso, false se falhou</returns>
            public bool play_Card(string id)
            {
                    string ret = Jogo.Jogar(
                   Global.player.id
                   , Global.player.token
                   , Int32.Parse(id)
                   );

                if (!ret.StartsWith("ERRO"))
                {
                    foreach (Global.Card card in Global.player.cards)
                    {
                        if (card.id == id)
                        {
                            Global.player.cards.Remove(card);
                            break;
                        }
                    }

                    return true;
                }

                else MessageBox.Show("ERRO PLAY_CARD : " + ret);
                return false;
            }
            
            
            /// <summary>
            /// Joga uma ilha na partida atual
            /// </summary>
            /// <returns> retorna true se foi um sucesso, ou false com erro</returns>
            public bool play_Isle(int value)
            {
                string ret = Jogo.DefinirIlha(
                    player.id,
                    player.token,
                    value
                );

                if (!ret.StartsWith("ERRO"))
                {
                    return true;
                }

                MessageBox.Show("ERRO PLAY_ISLE : " +ret);
                return false;
            }


            /// <summary>
            /// Checa de quem é a vez na rodada, alterando o campo name
            /// </summary>
            /// <returns> Retorna o nome de quem é a vez, ou null se a partida não estiver rodando </returns>
            public string check_Turn()
            {
                string retChecker = Jogo.VerificarVez(Global.match.id);
                // exemplo de retorno
                // "J,44,1,B\r\n"
                // "E,44,8,E\r\n"
                if(retChecker.StartsWith("ERRO"))
                {
                    this.vez = "";
                    MessageBox.Show("ERRO CHECK_TURN : " + retChecker);
                    return null;
                }
                
                
                string[] formattedCheck = retChecker.Split(',');

                this.status = formattedCheck[formattedCheck.Length - 1][0];

                if (Int32.Parse(formattedCheck[2]) != this.rodada)
                {
                    this.rodada = Int32.Parse(formattedCheck[2]);
                    this.check_pastTable();
                }

                if (retChecker[0] == 'J')
                {
                    if (Global.player.id == Int32.Parse(formattedCheck[1]))
                    {
                        this.vez = player.name;
                        return player.name;
                    }
                    foreach (Enemy aux in enemies)
                    {
                        if (aux.id == Int32.Parse(formattedCheck[1]))
                        {
                            this.vez = aux.name;
                            return aux.name;
                        }
                    }

                    // se não estiver na estrutura
                    MessageBox.Show(retChecker);
                    return null;
                }

                else if (retChecker[0] == 'E')
                {
                    this.vez = "";
                    return null;
                }

                MessageBox.Show(retChecker);
                return null;
            }


            /// <summary>
            /// Checa a as ilhas para escolhe disponíveis
            /// </summary>
            /// <returns>Retorna um vetor de 2 valores se foi um sucesso, ou null em erro</returns>
            public int[]  check_Isle()
            {
                string ret = Jogo.VerificarIlha(Global.player.id, Global.player.token);
                if (!ret.StartsWith("ERRO"))
                {
                    ret = ret.Trim();
                    string[] retformatted = ret.Split(',');
                    int[] iret = new int[retformatted.Length];

                    for (int i = 0; i < retformatted.Length; i++)
                    {
                        iret[i] = int.Parse(retformatted[i]);
                    }

                    return iret;
                }

                else MessageBox.Show("ERRO CHECK_ISLE : " + ret);
                return null;
            }


            /// <summary>
            /// Realiza uma requisição para atualizar a mão do jogador
            /// </summary>
            public void get_Hand()
            {
                string retorno = Jogo.VerificarMao(Global.player.id, Global.player.token);
                Global.player.cards.Clear();
                if (retorno != "")
                {
                    retorno = retorno.Replace("\r", "");
                    retorno = retorno.Substring(0, retorno.Length - 1);
                    string[] Jformatted = retorno.Split('\n');

                    foreach (Global.Card card in Global.cards)
                    {
                        for (int i = 0; i < Jformatted.Length; i++)
                        {
                            if (card.id == Jformatted[i])
                            {
                                Global.player.cards.AddLast(card);
                            }
                        }
                    }
                }
            }

            /// <summary>
            /// Checa a situaçao da mesa na rodada atual e atualiza informações sobre ilha e cartas jogadas
            /// </summary>
            public void check_Table()
            {
                //Formato: Separar por \r\n e depois dar split na virgula

                string ret = Jogo.VerificarMesa(Global.match.id);
                ret = ret.Replace("\n", "");
                ret = ret.Substring(0, ret.Length - 1);
                string[] formattedRet = ret.Split('\r');
                

                string ilhaAtual = formattedRet[0];
                if (!formattedRet[0].Equals(""))
                {
                    ilhaAtual = ilhaAtual.Substring(1, ilhaAtual.Length - 1);
                    Global.match.ilha = Int32.Parse(ilhaAtual);

                }

                this.table_Cards.Clear();

                for (int i = 1; i < formattedRet.Length; i++)
                {

                    string[] aux = formattedRet[i].Split(',');
                    int idPlayer = Int32.Parse(aux[0]);
                    int idCard = Int32.Parse(aux[1]);

                    this.table_Cards.AddFirst(Global.cards[idCard - 1]);

                    foreach (Global.Enemy enemy in Global.enemies)
                    {
                        if (idPlayer == enemy.id && !enemy.cards.Contains(Global.cards[idCard - 1]))
                        {
                            enemy.cards.AddLast(Global.cards[idCard - 1]);
                        }
                    }

                }

            }


            /// <summary>
            /// Checa a situaçao da rodada passada e atualiza as 
            /// </summary>
            public void check_pastTable()
            {
                //Formato: Separar por \r\n e depois dar split na virgula
                if (Global.match.rodada <= 1)
                    return;

                string ret = Jogo.VerificarMesa(Global.match.id, Global.match.rodada-1);
                ret = ret.Replace("\n", ""); 
                ret = ret.Substring(0, ret.Length - 1);
                string[] formattedRet = ret.Split('\r');

                // exemplo de retorno
                // "I20\r\n48,9\r\n"
                // "I8\r\n58,2\r\n57,4\r\n"


                string ilhaAtual = formattedRet[0];
                if (!formattedRet[0].Equals(""))
                {
                    ilhaAtual = ilhaAtual.Substring(1, ilhaAtual.Length - 1);
                    Global.match.ilha = Int32.Parse(ilhaAtual);

                }
                int idMaior = 0;
                int idVencedor = 0;
                int bodesSoma = 0;
                for (int i = 1; i < formattedRet.Length; i++)
                {
                    string[] aux = formattedRet[i].Split(',');
                    int idPlayer = Int32.Parse(aux[0]);
                    int idCard = Int32.Parse(aux[1]);

                    if (idCard > idMaior)
                    {
                        idMaior = idCard;
                        idVencedor = idPlayer;
                    }
                    
                    Global.Card carta = Global.cards[idCard -1];
                    bodesSoma += Int32.Parse(carta.bodes);

                    foreach (Global.Enemy enemy in Global.enemies)
                    {
                        if (idPlayer == enemy.id && !enemy.cards.Contains(Global.cards[idCard - 1]))
                        {
                            enemy.cards.AddLast(Global.cards[idCard - 1]);
                        }
                    }
                }

                if ( idVencedor ==  Global.player.id)
                    Global.player.bodes += bodesSoma;

            }


            /// <summary>
            /// Joga a partida
            /// </summary>
            public bool Play()
            {
                if (this == null)
                    return false;

                Game.Running_Folder.Running Running = new Game.Running_Folder.Running();

                Running.ShowDialog();

                return true;
            }




        } static public Selected_Match match;
    }

    /// <summary>
    /// Programa
    /// </summary>
    internal static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Client());
            Application.Run(new Client());
        }
    }
}
