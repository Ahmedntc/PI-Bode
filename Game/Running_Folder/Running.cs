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
        }

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
                lblTurn.Text = formattedCheck[1];
            }
        }
    }
}
