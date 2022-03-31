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


        /// <summary>
        /// A estrutura dos inimigos na partida
        /// </summary>
        public class Enemy
        {

            // COMENTÁRIO PARA DELETAR, EXPLICATÓRIO :
            /* A estrutura não fazia muito sentido estar em Global.Match, pois não vamos acessar esta em outros forms,
             * por isto a mudança para cá, sobre os valores, teremos outros muito importantes no futuro:
             * 
             * public LinkedList<Global.Card> cards para possíveis cartas que ele pode ter (não sabemos, sabemos apenas as nossas), para operarmos com previsões no decision-making
             * 
             */

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


        /// <summary>
        /// Inicia a partida, armazenando os jogadores dela na estrutura Global.Match.enemies
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // partida iniciada
            //MessageBox.Show(Global.Match.player.id.ToString());

            btnStart.Hide();
            this.btnQuit.Location = new System.Drawing.Point(5, 5);


            // posicionamos lentamente os paineis da direita e baixo na interface
            // pnl Right
            // posição original:  720; 3
            // posição escondida: 1020; 3

            // pnl Bottom
            // posição original:  4; 487
            // posição escondida: 4; 650
            {
                // 50 iterações

                // função escolhida direita
                // f(x) = 1020 - (x^2)/2 + (x/5)^3 - x

                // função escolhida baixo
                // f(X) = 644 - (X^2)/4 + (X/6)^3 - 2X

                for (double i = 0; i < 50; i++)
                {

                    Thread.Sleep(20);
                    //right
                    double c1 = i;
                    double c2 = Math.Pow(i, 2) / 2;
                    double c3 = Math.Pow((i / 5), 3);
                    int fx = (int)(1030 - c2 + c3 - c1);
                    pnlRight.Location = new System.Drawing.Point(fx, 0);

                    //bottom
                    c1 = 2*i;
                    c2 = Math.Pow(i, 2) / 4;
                    c3 = Math.Pow((i / 6), 3);
                    fx = (int)(644 - c2 + c3 - c1);
                    pnlBottom.Location = new System.Drawing.Point(0, fx);
                }
            }

            //inserimos as nossas credenciais
            string ret = Jogo.IniciarPartida(Global.Match.player.id, Global.Match.player.idPartida);
            if (ret.StartsWith("ERRO"))
            {
                MessageBox.Show(ret);
            }
            else
            {
                // abrimos as "cortinas"
                // trazemos os paineis pnlRight e pnlBottom para a interface
                // escondemos o botão de btnStart
                // movimentamos as imagens dos personagens

                //MessageBox.Show("Partida iniciada!");
                btnStart.Hide();
                this.btnQuit.Location = new System.Drawing.Point(5, 5);


                // BUG IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // listar jogadores também lista o NOSSO jogador, trabalhar nisso antes de começarmos a jogar pra valer.

                // listamos os jogadores da partida no início:
                
                string jogadores = Jogo.ListarJogadores(Global.Match.id);
                lstPlayers.Items.Clear();
                if (jogadores != "")
                {
                    jogadores = jogadores.Replace("\r", "");
                    jogadores = jogadores.Substring(0, jogadores.Length - 1);
                    string[] Jformatted = jogadores.Split('\n');

                    // alocamos a memória
                    enemies = new Enemy[Jformatted.Length];

                    // instanciamos os jogadores
                    for (int i = 0; i < Jformatted.Length; i++)
                    {
                        // MessageBox.Show(Jformatted[i]);
                        string[] jogador = Jformatted[i].Split(',');
                        string id = jogador[0].ToString();
                        string name = jogador[1].ToString();
                        string[] row = { id, name };
                        new ListViewItem(row);
                        lstPlayers.Items.Add(new ListViewItem(row));

                        enemies[i] = new Enemy(id, name);
                    }
                }
                else
                {
                    string[] row = { "", "Sem Jogadores" };
                    new ListViewItem(row);
                    lstPlayers.Items.Add(new ListViewItem(row));
                }
                btnShowHand.PerformClick();
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
                // BUG IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // se arrumarmos a função btnStart_Click, para não armazenar o nosso jogador,
                // não será possível escolher a nossa vez visto que realizamos o foreach com a estrutura
                // enemies: (se arrumarmos enemies para não nos incluir, seria necessário tratar isso aqui)
                //
                // solução: antes do foreach: if ( nosso jogador id == Int32.Parse(...)) = nossa vez

                foreach (Enemy aux in enemies)
                {
                    if (aux.id == Int32.Parse(formattedCheck[1]))
                        lblTurn.Text = "A vez é de " + aux.name;
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
            txtNarration.Text = (Jogo.ExibirNarracao(Global.Match.id));
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

        private void btnShowHand_Click(object sender, EventArgs e)
        {
            btnShowHand.Hide();
            string retorno = Jogo.VerificarMao(Global.Match.player.id, Global.Match.player.idPartida);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] Jformatted = retorno.Split('\n');

            Global.Match.player.cards.Clear();

            foreach (Global.Card card in Global.cards)
            {
                for(int i = 0; i < Jformatted.Length; i++)
                {
                    if(card.id == Jformatted[i])
                    {
                        Global.Match.player.cards.AddLast(card);
                    }
                }
            }
            foreach (Global.Card card in Global.Match.player.cards)
            {
                Global.Card.Graphical card_image = card.get_Panel(80, 135);
                flpHand.Controls.Add(card_image.panel);
            }
        }
    }
}
