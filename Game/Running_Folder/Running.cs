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
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.DoubleBuffered = false;
            this.UpdateStyles();
        }


        /// <summary>
        /// Extrai os radianos de um ângulo
        /// </summary>
        /// <returns>retorna os radianos correspondentes</returns>
        public double to_Radian(float angle)
        {
            return (Math.PI / 180) * angle;
        }


        /// <summary>
        /// Rotaciona uma imagem
        /// </summary>
        /// <returns>Retorna a imagem sobre o ângulo</returns>
        public Image rotate_Image(Bitmap target, float angle)
        {

            if (target == null)
                return null;

            // descobre as dimensões
            int width;
            int height;

            double radian = to_Radian(angle <= 0.0 ? -angle : angle);

            double sin = Math.Sin(radian);
            double cos = Math.Cos(radian);

            // calculamos a largura nova
            int minus = target.Width - (int)(cos * target.Width);
            int bonus = (int)(sin * target.Height);
            int diffw = bonus - minus;

            // calculamos a altura nova
            minus = target.Height - (int)(cos * target.Height);
            bonus = (int)(sin * target.Width);
            int diffh = bonus - minus;

            width = target.Width + diffw;
            height = target.Height + diffh;

            Image result = new Bitmap(width, height);

            using (Graphics gfx = Graphics.FromImage(result))
            {
                PointF point = new PointF(width / 2, height / 2);
                gfx.TranslateTransform(point.X, point.Y, System.Drawing.Drawing2D.MatrixOrder.Prepend);
                gfx.RotateTransform(angle);
                gfx.TranslateTransform(-target.Width / 2, -target.Height / 2, System.Drawing.Drawing2D.MatrixOrder.Prepend);
                gfx.DrawImage(target, new PointF());
                gfx.Dispose();
            }

            return result;
        }
        

        /// <summary>
        /// Anima os paineis
        /// </summary>
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


        /// <summary>
        /// Atualiza a mão do jogador
        /// </summary>
        /// <param name="query"> Verifica se deve realizar uma requisição ou não </param>
        public void update_Hand( bool query)
        {
            if (query)
            {
                Global.match.get_Hand();
            }

            // sen ( pi * (x / w)) * (h / c) + h

            // variáveis
            { 
                int width = 100;
                int height = 150;
                int pWidth = this.pnlCards.Width;
                int pHeight = this.pnlCards.Height;
                int count = Global.player.cards.Count;

                // espaço de sobra
                double dispWidth = pWidth - width * count;

                // centralizamos as cartas
                double betweenWidth = dispWidth / (count + 1);

                // para apertar as cartas
                double auxWidth = count <= 1 ? 0 : (400 / count);

                // preparamos as variáveis da fórmula da posição
                // y = sin( pi * (x/w)) * (h / c) + h;
                double w1 = pWidth + 20;
                double c1 = 1.5;
                double h = pHeight - height - 20;

                double x = auxWidth / 2;
                double y;


                // preparamos as variáveis da fórmula do ângulo
                // a = - (x / w) * v + c;
                double w2 = pWidth;
                double c2 = -30;
                double v = 60;

                // extraimos os bitmaps a serem usados
                Bitmap[] cards = new Bitmap[count];
                for(int i = 0; i < count; i++)
                {
                    cards[i] = new Bitmap(width, height);
                    cards[i].MakeTransparent();

                    Global
                    .player
                    .cards
                    .ElementAt(i)
                    .get_Panel(width, height)
                    .panel
                    .DrawToBitmap(cards[i], new Rectangle(0, 0, width, height));
                }

                Graphics phandle = pnlCards.CreateGraphics();
                phandle.Clear(Color.White);
                this.pnlCards.BackColor = System.Drawing.Color.Transparent;
                this.pnlCards.ForeColor = System.Drawing.Color.Transparent;
                
                for (int i = 0; i < count; i++)
                {
                    x += betweenWidth;

                    // extraimos o ângulo
                    float a = (float)(((x + width / 2) / w2) * v + c2);

                    // desenhamos o cartão
                    Image rotated = rotate_Image(cards[i] , a);

                    // extraimos o Y
                    y = Math.Sin(-Math.PI * ((x + (rotated.Width / 2)) / w1)) * (h / c1) + h;

                    phandle.DrawImage(rotated, (int)x, (int)y);

                    // movimentamos o X
                    x += width - (auxWidth * 2 / count);
                }
                phandle.Dispose();
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
            //Formato: Separar por \r\n e depois dar split na virgula

            string ret = Jogo.VerificarMesa(Global.match.id);
            MessageBox.Show(ret);
            ret = ret.Replace("\n", "");
            ret = ret.Substring(0, ret.Length - 1);
            string[] formattedRet = ret.Split('\r');
            
            string ilha = formattedRet[0];
            if(!formattedRet[0].Equals(""))
            {
                ilha = ilha.Substring(1, ilha.Length - 1);
                lblIlhas.Text = ilha;
                Global.match.ilha = Int32.Parse(ilha);
            }
            
            flpTable.Controls.Clear();
            for (int i = 1; i < formattedRet.Length; i++)
            {
                string[] aux = formattedRet[i].Split(',');
                int idPlayer = Int32.Parse(aux[0]);
                int idCard = Int32.Parse(aux[1]);

                // exibe graficamente
                var temp = Global.cards[idCard - 1].get_Panel(100, 150);
                flpTable.Controls.Add(temp.panel);
                foreach (Global.Enemy enemy in Global.enemies)
                {
                    if (idPlayer == enemy.id)
                    {
                        if (!enemy.cards.Contains(Global.cards[idCard - 1]))
                        {
                            enemy.cards.AddLast(Global.cards[idCard - 1]);
                        }
                    }
                }
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
