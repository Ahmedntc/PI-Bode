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
        
        public Running()
        {
            InitializeComponent();
        }


        /// <summary>
        /// A estrutura dos inimigos na partida
        /// </summary>
        public class Enemy
        {
            public int id;
            public string name;

            public Enemy(string id, string name)
            {
                this.id = Int32.Parse(id);
                this.name = name;
            }
        } public Enemy[] enemies;


        /// <summary>
        /// Realizada no carregamento da partida
        /// </summary>
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


        private void show_Pannels()
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
                    c1 = 651 - 31 * Math.Sqrt(i) + x;
                    pnlBottom.Location = new System.Drawing.Point(3, (int)c1);
                }
            }

        }

        /// <summary>
        /// Inicia a partida, armazenando os jogadores dela na estrutura Global.Match.enemies
        /// </summary>
        private async void btnStart_Click(object sender, EventArgs e)
        {
            // partida iniciada
            //MessageBox.Show(Global.Match.player.id.ToString());

            btnStart.Hide();
            this.btnQuit.Location = new System.Drawing.Point(5, 5);

            show_Pannels();

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
                
                string jogadores = Jogo.ListarJogadores(Global.Match.id);
                lstPlayers.Items.Clear();
                if (jogadores != "")
                {
                    jogadores = jogadores.Replace("\r", "");
                    jogadores = jogadores.Substring(0, jogadores.Length - 1);
                    string[] Jformatted = jogadores.Split('\n');

                    // alocamos a memória
                    enemies = new Enemy[Jformatted.Length - 1];

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
                            enemies[j] = new Enemy(id, name);
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
                showHand();
            }/**/
        }


        /// <summary>
        /// Checa de quem é a vez, retornando o nome do usuário
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
                if(Global.player.id == Int32.Parse(formattedCheck[1]))
                {
                    lblTurn.Text = Global.player.name;
                }
                foreach (Enemy aux in enemies)
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
        /// proposta: (deletem isso depois!!)
        /// 
        /// armazena este retorno em uma estrutura, e printa os últimos valores dessa string,
        /// a narração ocorre apenas na partida em questão (nesse forms), então vou deixar
        /// a estrutura no começo desse código, linha 
        ///
        /// podemos fazer a função escrever os últimos acontecimentos lentamente, como
        /// se estivesse sendo digitado
        /// 
        /// </summary>
        private void btnNarration_Click(object sender, EventArgs e)
        {
            txtNarration.Text = (Jogo.ExibirNarracao(Global.Match.id).Replace("\n", "\n\n"));

        }


        private void btnAllCards_Click(object sender, EventArgs e)
        {
            DebugConsole debug = new DebugConsole();
            debug.Show();
            foreach(Global.Card card in Global.cards)
            {
                Global.Card.Graphical card_image = card.get_Panel(125, 175);
                debug.pnlDisplay.Controls.Add(card_image.panel);
            }
        }

        private void showHand()
        {
            string retorno = Jogo.VerificarMao(Global.player.id, Global.player.token);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] Jformatted = retorno.Split('\n');

            Global.player.cards.Clear();


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
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbCards.SelectedItem != null)
            {
                string ret =Jogo.Jogar(
                    Global.player.id,
                    Global.player.token,
                    Int32.Parse(cmbCards.SelectedItem.ToString())
                    );

                if (!ret.StartsWith("ERRO"))
                    showHand();

                else MessageBox.Show(ret);
            }
        }

        private void btnShowIslands_Click(object sender, EventArgs e)
        {
            string ret = Jogo.VerificarIlha(Global.player.id, Global.player.token);
            if (!ret.StartsWith("ERRO"))
            {
                ret = ret.Trim();
                string[] retformatted = ret.Split(',');
                foreach (string str in retformatted)
                {
                    cmbIslands.Items.Add(str);
                }
            }

            else MessageBox.Show(ret);
        }

        private void btnChooseIsland_Click(object sender, EventArgs e)
        {
            if (cmbIslands.SelectedItem != null)
            {
                string ret = Jogo.DefinirIlha(
                    Global.player.id,
                    Global.player.token,
                    Int32.Parse(cmbIslands.SelectedItem.ToString())
                    );

                MessageBox.Show(ret);
                cmbIslands.Items.Clear();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Formato: Separar por \r\n e depois dar split na virgula
            string ret = Jogo.VerificarMesa(Global.Match.id);
            ret = ret.Replace("\r\n", "");
            ret = ret.Substring(0, ret.Length - 1);

            string[] formattedRet = ret.Split(',');

            string numIsland = formattedRet[0];

            string[] idJogadores = new String[formattedRet.Length];
            string[] idCartaFinal = new String[formattedRet.Length];

            for (int i = 0; i < formattedRet.Length; i++)
            {
                MessageBox.Show(formattedRet[i]);
            }
        }
    }
}
