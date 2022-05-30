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
            this.TransparencyKey = System.Drawing.Color.Green;
            this.AllowTransparency = true;
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

                    double c1 = 1104 - 50 * Math.Sqrt(i) + x;
                    pnlRight.Location = new System.Drawing.Point((int)c1, 3);

                    //bottom
                    c1 = 692 - 31 * Math.Sqrt(i) + x;
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
                int width = 80;
                int height = 120;
                int pWidth = this.pnlCards.Width;
                int pHeight = this.pnlCards.Height;
                int count = Global.player.cards.Count;

                // espaço de sobra
                double dispWidth = pWidth - width * count;

                // centralizamos as cartas
                double betweenWidth = dispWidth / (count + 1);

                // aperta as cartas
                double auxCoef = (count > 1) ? (100 + 180/count) : 0;
                double auxWidth = (auxCoef*2)/(count+1);

                // para apertar as cartas
                // preparamos as variáveis da fórmula da posição
                // y = sin( pi * (x/w)) * (h / c) + h;
                double w1 = pWidth + 20;
                double c1 = 3.5;
                double h = pHeight - height - 20;

                double x = 0;
                double y;


                // preparamos as variáveis da fórmula do ângulo
                // a = - (x / w) * v + c;
                double w2 = pWidth;
                double c2 = -20;
                double v = 40;

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

                Image aux = new Bitmap(pWidth, pHeight);
                Graphics phandle = Graphics.FromImage(aux);
                phandle.Clear(Color.Transparent);
                for (int i = 0; i < count; i++)
                {
                    auxCoef -= auxWidth;
                    x += betweenWidth;

                    // extraimos o ângulo
                    float a = (float)(((x + width / 2) / w2) * v + c2);

                    // desenhamos o cartão
                    Image rotated = rotate_Image(cards[i] , a);


                    y = Math.Sin(-Math.PI * ((x + width / 2) / w1)) * (h / c1) + h;
                    int diffx = (int)(rotated.Width - width);
                    phandle.DrawImage(rotated, (int)x - diffx/2 + (int)auxCoef, (int)y);
                    // movimentamos o X
                    x += width ;
                }

                pnlCards.BackgroundImage = aux;
                phandle.Dispose();
            }
        }


        /// <summary>
        /// Atualiza graficamente a mesa da partida, inserindo cartas e o tamanho da ilha
        /// </summary>
        public void update_Table()
        {

            flpTable.Controls.Clear();
            Global.match.check_Table();
            lblIlhas.Text = Global.match.ilha.ToString();

            foreach (Global.Card card in Global.match.table_Cards)
            {
                flpTable.Controls.Add(
                        card.get_Panel(60, 90).panel
                );
            }
        }


        /// <summary>
        /// Limpa a mesa da partida
        /// </summary>
        public void clear_Table()
        {
            flpTable.Controls.Clear();
            return;
        }




        /// Eventos

        private void Running_Load(object sender, EventArgs e)
        {
            // Esconde os painéis de interface

            // pnl Right
            // posição original:  720; 3
            // posição escondida: 1020; 3
            this.pnlRight.Location = new System.Drawing.Point(1160, 3);

            // pnl Bottom
            // posição original:  4; 487
            // posição escondida: 4; 650
            this.pnlBottom.Location = new System.Drawing.Point(4, 780);

            // btn Quit 
            // posição original: 448; 307
            // posição pós-start: 5; 5
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
            pnlMesa.Visible = true;

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
                this.btnQuit.Location = new System.Drawing.Point(156, 636);
                pnlRight.Controls.Add(btnQuit);
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

                    
                    Label[] nomes = new Label[Global.enemies.Length];
                    

                    for (int i = 0; i < Global.enemies.Length; i++)
                    {
                        nomes[0] = lblB_Nome1;

                        if (i == 1) nomes[1] = lblB_Nome2;

                        if (i == 2) nomes[2] = lblB_Nome3;

                        nomes[i].Visible = true;
                        nomes[i].Text = Global.enemies[i].name;
                    }

                    // seta a imagem de fundo correta
                    switch (Global.enemies.Length)
                    {
                        case 0:
                            pnlBode.BackgroundImage = null;
                            break;

                        case 1:
                            lblB_Nome1.Visible = true;
                            lblB_Nome1.Text = Global.enemies[0].name;
                            pnlBode.BackgroundImage = Properties.Resources.bode1;
                            break;

                        case 2:
                            lblB_Nome2.Visible = true;
                            lblB_Nome2.Text = Global.enemies[1].name;
                            pnlBode.BackgroundImage = Properties.Resources.bode2;
                            break;

                        case 3:
                            lblB_Nome3.Visible = true;
                            lblB_Nome3.Text = Global.enemies[2].name;
                            pnlBode.BackgroundImage = Properties.Resources.bode3;
                            break;
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
            lblPlayerBodes.Text = Global.player.bodes.ToString();
            // retornou uma vez
            if (vez != null)
            {
                
                switch (Global.match.rodada)
                {
                    case 2:
                        pnlIlhas.BackgroundImage = Properties.Resources.mesa_ilha1;
                        break;

                    case 3:
                        pnlIlhas.BackgroundImage = Properties.Resources.mesa_ilha2;
                        break;

                    case 4:
                        pnlIlhas.BackgroundImage = Properties.Resources.mesa_ilha3;
                        break;

                    case 5:
                        pnlIlhas.BackgroundImage = Properties.Resources.mesa_ilha4;
                        break;

                    default:           
                        break;
                }

                lblTurn.Text = vez;
                Global.match.vez = vez;
            }

            // deu erro, para o timer para lidar e acion
            else
            {
                lblTurn.Text = "";
                Global.match.vez = "";
                tmrTrigger.Enabled = false;
                MessageBox.Show("A partida acabou!");
                this.btnNarration_Click(sender, e);
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
            this.tmrTrigger.Enabled = false;
        }


        public void btnTable_Click(object sender, EventArgs e)
        {
            this.update_Table();
        }

        /// Bot

        public void tmrTrigger_Tick(object sender, EventArgs e)
        {
            // bot checa se a partida acabou através do checar a vez.
            tmrTrigger.Enabled = false;
            this.Bot.Loop(this);
            if (Global.match.status != 'E')
            {
                tmrTrigger.Enabled = true;
            }
        }
       
    }
}
