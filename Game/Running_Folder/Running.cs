using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;

namespace Game.Game.Running_Folder
{
    public partial class Running : Form
    {
        
        public Running()
        {
            InitializeComponent();
        }

        public class Enemies {
            public string id;
            public string name;
            //public Card[] cards;
        }

        private void Running_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Global.Match.player.id.ToString());
            string ret = Jogo.IniciarPartida(Global.Match.player.id, Global.Match.player.idPartida);
            if (ret.StartsWith("ERRO"))
            {
                MessageBox.Show(ret);
            }
            else
            {
                MessageBox.Show("Partida iniciada!");
                btnStart.Hide();
            }

            // precisa de revisão
            string jogadores = Jogo.ListarJogadores(Global.Match.id);
            lstPlayers.Items.Clear();
            if (jogadores != "")
            {
                jogadores = jogadores.Replace("\r", "");
                jogadores = jogadores.Substring(0, jogadores.Length - 1);
                string[] Jformatted = jogadores.Split('\n');

                //MessageBox.Show(jogadores);
                Global.Match.enemies = new Global.Selected_Match.Enemy[Jformatted.Length];
                for (int i = 0; i < Jformatted.Length; i++)
                {
                    // MessageBox.Show(Jformatted[i]);
                    string[] jogador = Jformatted[i].Split(',');
                    string id = jogador[0].ToString();
                    string name = jogador[1].ToString();
                    string[] row = { id, name };
                    new ListViewItem(row);
                    lstPlayers.Items.Add(new ListViewItem(row));

                    Global.Match.enemies[i] = new Global.Selected_Match.Enemy(id, name);
                }
            }
            else
            {
                string[] row = { "", "Sem Jogadores" };
                new ListViewItem(row);
                lstPlayers.Items.Add(new ListViewItem(row));
            }


        }


        /// <summary>
        /// 
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string retChecker = Jogo.VerificarVez(Global.Match.id);
            string[] formattedCheck = retChecker.Split(',');
            if (retChecker.StartsWith("ERRO"))
            {
                lblTurn.Text = retChecker;
            }
            else
            {
                lblTurn.Text = retChecker;
                foreach (Global.Selected_Match.Enemy aux in Global.Match.enemies)
                {
                    if (aux.id == Int32.Parse(formattedCheck[1]))
                        lblTurn.Text = aux.name;
                }
            }
        }


        /// <summary>
        /// Exemplo de retorno
        /// {user} iniciou a partida {match}, é a vez de {user_vez}
        /// {user} entrou na partida com id {user_id}
        /// {user2} entrou na partida com id {user2_id}
        /// Criada a partida ben10
        /// 
        /// 
        /// </summary>
        private void btnNarration_Click(object sender, EventArgs e)
        {
            txtNarration.Text = (Jogo.ExibirNarracao(Global.Match.id));
        }
    }
}
