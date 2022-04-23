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

#pragma warning disable IDE1006 // Estilos de Nomenclatura

namespace Game.Game.Running_Folder
{
    public partial class Running : Form
    {
        /// Variáveis
        private readonly Automata Bot;



    
        ///  Funções

        public Running()
        {
            InitializeComponent();
            this.Bot = new Automata();
        }

        private void update_Pannels()
        {

            // posicionamos lentamente os paineis da direita e baixo na interface
            // pnl Right
            // posição original:  720; 3
            // posição escondida: 1020; 3

            // pnl Bottom
            // posição original:  4; 487
            // posição escondida: 4; 650
            {
                // 50 iterações

                for (double i = 0; i < 50; i++)
                {

                    Thread.Sleep(10);
                    //right
                    double x = Math.Pow(i, 2) / 45;

                    double c1 = 1018 - 50 * Math.Sqrt(i) + x;
                    pnlRight.Location = new System.Drawing.Point((int)c1, 3);

                    //bottom
                    c1 = 686 - 31 * Math.Sqrt(i) + x;
                    pnlBottom.Location = new System.Drawing.Point(9, (int)c1);
                }
            }

        }

        public void update_Hand( bool query)
        {
            if (query)
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

            flpHand.Controls.Clear();

            foreach (Global.Card card in Global.player.cards)
            {
                Global.Card.Graphical card_image = card.get_Panel(80, 135);
                flpHand.Controls.Add(card_image.panel);
            }

            cmbCards.Items.Clear();

            foreach (Global.Card card in Global.player.cards)
            {
                cmbCards.Items.Add(card.id);
            }
        }

        public void update_Table()
        {
            flpTable.Controls.Clear();
            Global.match.check_Table();
            lblIlhas.Text = Global.match.ilha.ToString();

            if (Global.match.idCardJogada != 0)
            {
                // exibe graficamente
                var temp = Global.cards[Global.match.idCardJogada - 1].get_Panel(100, 150);
                flpTable.Controls.Add(temp.panel);
            }
        }




        /// Eventos

        private void Running_Load(object sender, EventArgs e)
        {
            // Esconde os painéis de interface

            // pnl Right
            // posição original:  720; 3
            // posição escondida: 1020; 3
            this.pnlRight.Location = new System.Drawing.Point(1020, 3);

            // pnl Bottom
            // posição original:  4; 487
            // posição escondida: 4; 650
            this.pnlBottom.Location = new System.Drawing.Point(4, 650);

            // btn Quit 
            // posição original: 448; 307
            // posição pós-start: 5; 5

            // Aplica uma sombra ao ambiente
        }
        

        public void btnStart_Click(object sender, EventArgs e)
        {
            // partida iniciada
            //MessageBox.Show(Global.match.player.id.ToString());

            btnStart.Hide();
            this.btnQuit.Location = new System.Drawing.Point(5, 5);

            //Liga o automata
            tmrTrigger.Enabled = true;

            update_Pannels();

            //inserimos as nossas credenciais
            string ret = Jogo.IniciarPartida(Global.player.id, Global.player.token);
            bool play = true;
            if (ret.StartsWith("ERRO"))
            {
                play = false;

                if (ret.Contains("Partida não está aberta"))
                {
                    play = true;
                }

                else
                {
                    MessageBox.Show(ret);
                }
            }

            if(play) 
            {
                // abrimos as "cortinas"
                // trazemos os paineis pnlRight e pnlBottom para a interface
                // escondemos o botão de btnStart
                // movimentamos as imagens dos personagens

                //MessageBox.Show("Partida iniciada!");
                btnStart.Hide();
                this.btnQuit.Location = new System.Drawing.Point(5, 5);

                // listamos os jogadores da partida no início:
                
                string jogadores = Jogo.ListarJogadores(Global.match.id);
                lstPlayers.Items.Clear();
                if (jogadores != "")
                {
                    jogadores = jogadores.Replace("\r", "");
                    jogadores = jogadores.Substring(0, jogadores.Length - 1);
                    string[] Jformatted = jogadores.Split('\n');

                    // alocamos a memória
                    Global.enemies = new Global.Enemy[Jformatted.Length - 1];

                    // instanciamos os jogadores
                    for (int i = 0, j = 0; i < Jformatted.Length; i++)
                    {
                        // MessageBox.Show(Jformatted[i]);
                        string[] jogador = Jformatted[i].Split(',');
                        string id = jogador[0].ToString();
                        string name = jogador[1].ToString();
                        string[] row = { id, name };
                        new ListViewItem(row);
                        lstPlayers.Items.Add(new ListViewItem(row));

                        if(Global.player.id != Int32.Parse(id))
                        {
                            Global.enemies[j] = new Global.Enemy(id, name);
                            j++;
                        }
                    }
                }
                else
                {
                    string[] row = { "", "Sem Jogadores" };
                    new ListViewItem(row);
                    lstPlayers.Items.Add(new ListViewItem(row));
                }
                update_Hand( true );
            }/**/
        }


        public void btnCheck_Click(object sender, EventArgs e)
        {
            string vez;
            vez = Global.match.check_Turn();

            // retornou uma vez
            if (vez != null)
            {
                lblTurn.Text = vez;
                Global.match.vez = vez;
            }

            // deu erro, para o timer para lidar
            else
            {
                lblTurn.Text = "";
                Global.match.vez = "";
                tmrTrigger.Enabled = false;
            }
        }


        public void btnNarration_Click(object sender, EventArgs e)
        {
            txtNarration.Text = (Jogo.ExibirNarracao(Global.match.id).Replace("\n", "\n\n"));
        }


        public void btnAllCards_Click(object sender, EventArgs e)
        {
            DebugConsole debug = new DebugConsole();
            debug.Show();
        }


        public void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbCards.SelectedItem != null)
            {
                Global.match.play_Card(cmbCards.SelectedItem.ToString());
                this.update_Hand(false);
            }
        }


        public void btnShowIslands_Click(object sender, EventArgs e)
        {
            
            int[] isles = Global.match.check_Isle();
            cmbIslands.Items.Clear();
            if (isles != null)
            {
                foreach (int i in isles)
                {
                    cmbIslands.Items.Add(i.ToString());
                }
            }
        }


        public void btnChooseIsland_Click(object sender, EventArgs e)
        {
            if (cmbIslands.SelectedItem != null)
            {
                Global.match.play_Isle(
                    int.Parse(cmbIslands.SelectedItem.ToString())
                    );
                cmbIslands.Items.Clear();
            }
        }


        public void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void btnTable_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            Global.match.check_Table();
            lblIlhas.Text = Global.match.ilha.ToString();

            if(Global.match.idCardJogada != 0)
            {
                // exibe graficamente
                var temp = Global.cards[Global.match.idCardJogada - 1].get_Panel(100, 150);
                flpTable.Controls.Add(temp.panel);
            }
            
        }

        /// Bot

        public void tmrTrigger_Tick(object sender, EventArgs e)
        {
            // bot checa se a partida acabou através do checar a vez.
            this.Bot.Loop(this);
        }
    }
}
