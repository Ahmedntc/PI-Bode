using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{


    /// <summary>
    /// Objetos ou estruturas de dados existentes no jogo
    /// </summary>
    public class Global
    {


        /// <summary>
        /// Todas as cartas do jogo
        /// </summary>
        public struct Card
        {
            // imagem
            // bodes
            // path

            // load imagens()
            // load cartas()
            /*{
             *  carta = Jogo.listarcartas
             *  foreach carta
             *      com base no num da carta carrega a imagem
             *      carrega bodes
             *      s
             * }
             */
        } static Card[] cards; 
        // cards[1]; id = 1;


        /// <summary>
        /// Partida selecionada principal
        /// </summary>
        public class Selected_Match
        {
            public int id;
            public string name;
            public string date;
            public char status;

            
            /// <summary>
            /// 
            /// </summary>
            public class Player
            {
                public string name;
                public string idPartida; // Id que recebemos ao entrar na partida.
                public int id;
                public string senhaPartida;// senha da partida. 
                public LinkedList<Card> cards;

                /// <summary>
                /// Prepara o jogador
                /// </summary>
                public Player()
                {
                    this.name = ""; // 
                    this.id = 0;
                    this.cards = new LinkedList<Card>();
                }

            } public Player player;


            /// <summary>
            /// 
            /// </summary>
            public class Enemy
            {
                public int id;
                public string name;

                public Enemy( string id, string name)
                {
                    this.id = Int32.Parse(id);
                    this.name = name;
                }
            } public Enemy[] enemies;


           
            
            /// <summary>
            /// Prepara o objeto Match
            /// </summary>
            public Selected_Match(int id, string player_Name, string player_Id, string senhaPartida,Client.Match target)
            {
                // jogador
                this.player = new Player();
                this.player.name = player_Name;
                this.player.idPartida = player_Id;
                this.player.id = id;
                this.player.senhaPartida = senhaPartida;

                // Match
                this.id = target.id;
                this.name = target.name;
                this.date = target.date;
                this.status = target.status;
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
            Application.Run(new Client());
        }
    }
}
