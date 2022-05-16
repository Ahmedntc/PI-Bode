using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Game.Running_Folder;
using BodeOfWarServer;

#pragma warning disable IDE1006

namespace Game
{
    public class Automata
    {
        public Automata()
        {


        }

        public int CartaDoMeio()
        {
            int id = 0;
            if (Global.player.cards.Count == 1)
            {
                return 0;
            }
                
                
            if (Global.player.cards.Count%2 !=0)
            {
                id = ((Global.player.cards.Count-1)/2) + 1;
            } else
            {
                id = ((Global.player.cards.Count-1)/2);
            }


            return id;
        }

        public void AutoJogarCarta()
        {
            int TIlha = Global.match.ilha; // Tamanho atual da ilha
            int QBodes = Global.player.bodes; // Quantidade de bodes
            int Rodada = Global.match.rodada; // Rodada atual
            int id = 0; // Id da carta que será jogada


            if (TIlha > QBodes)
            {

                if (TIlha > (QBodes * 2) && Rodada <= 4)
                {
                    id = Int32.Parse(Global.player.cards.ElementAt(Global.player.cards.Count-1).id);
                }


                else if (TIlha > (QBodes * 2) && Rodada <= 5)
                {
                    id = Int32.Parse(Global.player.cards.ElementAt(Global.player.cards.Count-1).id);
                }

                else if ((QBodes >= (TIlha * 0.70) && QBodes <= TIlha) && Rodada >= 8)
                {
                    id = Int32.Parse(Global.player.cards.ElementAt(0).id);
                }

                else if ((QBodes >= (TIlha * 0.30) && QBodes <= (TIlha * 0.70)) && Rodada >= 8)
                {

                    id = Int32.Parse(Global.player.cards.ElementAt(CartaDoMeio()).id);
                } else
                {
                    id = Int32.Parse(Global.player.cards.ElementAt(CartaDoMeio()).id);
                }

            }  else
            {
                id = Int32.Parse(Global.player.cards.ElementAt(0).id);
            }

            System.Windows.Forms.MessageBox.Show(id.ToString());

            Global.match.play_Card(id.ToString());
        }

        public int AutoJogarIlha()
        {
            int IlhaMaior = 0;
            int IlhaMenor = 0;

            string ret = Jogo.VerificarIlha(Global.player.id, Global.player.token);
            if (!ret.StartsWith("ERRO"))
            {
                string[] formattedRet = ret.Split(',');
                if (Int32.Parse(formattedRet[0]) > Int32.Parse(formattedRet[1]))
                {
                    IlhaMaior = Int32.Parse(formattedRet[0]);
                    IlhaMenor = Int32.Parse(formattedRet[1]);
                }
                else
                {
                    IlhaMaior = Int32.Parse(formattedRet[1]);
                    IlhaMenor = Int32.Parse(formattedRet[0]);
                }

                int TIlha = Global.match.ilha; // Tamanho atual da ilha
                int QBodes = Global.player.bodes; // Quantidade de bodes
                int Rodada = Global.match.rodada; // Rodada atual
                


                if (TIlha > QBodes)
                {
                    return IlhaMenor;

                }
                else if (TIlha < QBodes)
                {
                    return IlhaMaior;
                }
                else
                {
                    return IlhaMaior;
                }

            }
            return 0;
        }



        public int show_Island(Running match)
        {
            string ret = Jogo.VerificarIlha(Global.player.id, Global.player.token);
            if (!ret.StartsWith("ERRO"))
            {
                string[] formattedRet = ret.Split(',');
                if (Int32.Parse(formattedRet[0]) > Int32.Parse(formattedRet[1]))
                {
                    return Int32.Parse(formattedRet[0]);
                }
                else
                {
                    return Int32.Parse(formattedRet[1]);
                }


            }
            return 0;
        }


        public void Play(Running form)
        {
            if (Global.match.status == 'I')
            {
                //Jogar ilha
                //int island = show_Island(form);
                int island = AutoJogarIlha();

                if(island > 0)
                {
                    Jogo.DefinirIlha(
                    Global.player.id,
                    Global.player.token,
                    island
                    );
                }
            }
            else 
            {
                //Jogar Carta
                //Global.match.play_Card(Global.player.cards.ElementAt(0).id);
                AutoJogarCarta();
                form.update_Hand( false );
            }
        }


        /// <summary>
        /// Checa se é a nossa vez ou não
        /// </summary>
        /// <returns> Retorna true para sim false para não</returns>
        public bool check_Turn(Running form)
        {
            form.btnCheck_Click(null, null);
            string ret = Global.match.vez;

            //Verifica se é nossa vez
            if (ret.Equals(Global.player.name))
            {
                return true;
            }
            else if (ret == "")
            {
                form.tmrTrigger.Enabled = false;
                System.Windows.Forms.MessageBox.Show("Acabou!");
            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        public void check_Table(Running form)
        {
            form.update_Table();
        }


        public void Loop(Running form)
        {
            // nossa vez?
            if (this.check_Turn(form))
            {
                this.Play(form);
            }
            this.check_Table(form);
        }
    }
}
