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

        } static Card[] cards;


        /// <summary>
        /// Partida selecionada principal
        /// </summary>
        public class Selected_Match
        {
            public int id;
            public string name;
            public string date;
            public char status;

            public class Player
            {
                public string name;
                public string id;
                public LinkedList<Card> cards;

                /// <summary>
                /// Prepara o jogador
                /// </summary>
                public Player()
                {
                    this.name = ""; // 
                    this.id = "";
                    this.cards = new LinkedList<Card>();
                }

            }
            public Player player;

            
            /// <summary>
            /// Prepara o objeto Match
            /// </summary>
            public Selected_Match(string player_Name, string player_Id, Client.Match target)
            {
                // jogador
                this.player = new Player();
                this.player.name = player_Name;
                this.player.id = player_Id;

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
