using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                frame.id.AutoSize = false;
                frame.id.Width = 30;
                frame.id.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                frame.id.Location = new System.Drawing.Point(3, 3);
                frame.id.BackColor = System.Drawing.Color.White;
                frame.id.ForeColor = System.Drawing.Color.Red;

                // bodes
                frame.bodes.Text = this.bodes;
                frame.bodes.AutoSize = false;
                frame.bodes.Width = 30;
                frame.bodes.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                frame.bodes.Location = new System.Drawing.Point(3, height - 20);
                frame.bodes.BackColor = System.Drawing.Color.White;
                frame.bodes.ForeColor = System.Drawing.Color.Red;


                return frame;
            }

        } public static Card[] cards;

        /// <summary>
        /// Classe do nosso jogador na partida
        /// </summary>
        public class Player
        {
            public int id;
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
                this.id = 0;
                this.cards = new LinkedList<Card>();
                this.name = name;
                this.token = token; // Senha unica gerada pelo banco
                this.id = id;
            }

        }
        static public Player player;

        /// <summary>
        /// Partida selecionada principal
        /// </summary>
        public class Selected_Match
        {
            public int id;
            public string name;
            public string date;
            public char status;
            public string senha; // senha da partida.           
            
            /// <summary>
            /// Prepara o objeto Match
            /// </summary>
            public Selected_Match(string senha,Client.Match target)
            {
                // Match
                this.id = target.id;
                this.name = target.name;
                this.date = target.date;
                this.status = target.status;
                this.senha = senha;
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
        } static public Selected_Match Match;
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
