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




        /// <summary>
        /// Escolhe uma carta para jogar
        /// </summary>
        /// <returns>Retorna um ID da carta selecionada</returns>
        public string choose_Card()
        {
            int TIlha = Global.match.ilha; // Tamanho atual da ilha
            int QBodes = Global.player.bodes; // Quantidade de bodes
            int Rodada = Global.match.rodada; // Rodada atual
            string id; // Id da carta que será jogada

            if (Global.player.get_AvgCardsIDS() > 20)
            {
                if (Rodada <= 3)
                {
                    id = Global.player.get_cardID(0);
                }
                else if (Rodada == 4)
                {
                    if (TIlha > 3 * QBodes)
                    {
                        id = Global.player.get_cardID(-1);
                    }
                    else if (TIlha > QBodes)
                    {
                        id = Global.player.get_cardMID();
                    }
                    else
                    {
                        id = Global.player.get_cardID(0);
                    }
                }
                else if (Rodada == 5)
                {
                    if (TIlha > 2.5 * QBodes)
                    {
                        id = Global.player.get_cardID(-1);
                    }
                    else if (TIlha > QBodes)
                    {
                        id = Global.player.get_cardMID();
                    }
                    else
                    {
                        id = Global.player.get_cardID(0);
                    }
                }
                else if (Rodada >= 6)
                {
                    if (TIlha > QBodes)
                    {
                        id = Global.player.get_cardMID();
                    }
                    else
                    {
                        id = Global.player.get_cardID(0);
                    }
                }
                else
                {
                    id = Global.player.get_cardID(0);
                }
            } 
            
            
            else
            {
                if (Rodada <=2)
                {
                    id = Global.player.get_cardID(0);
                }
                else if (Rodada == 3)
                {
                    if(TIlha > 2*QBodes)
                    {
                        id = Global.player.get_cardMID();
                    } else if (TIlha > QBodes)
                    {
                        id = Global.player.get_cardMID();
                    } else
                    {
                        id = Global.player.get_cardID(0);
                    }
                }
                else if (Rodada == 4)
                {
                    if (TIlha > 2 * QBodes)
                    {
                        id = Global.player.get_cardID(-1);
                    }
                    else if (TIlha > QBodes)
                    {
                        id = Global.player.get_cardMID();
                    }
                    else
                    {
                        id = Global.player.get_cardID(0);
                    }
                }
                else if (Rodada >= 5)
                {
                    if (TIlha > 1.5*QBodes)
                    {
                        id = Global.player.get_cardID(-1);
                    }
                    else if (TIlha < QBodes)
                    {
                        id = Global.player.get_cardID(0);
                    }
                    else 
                    {
                        id = Global.player.get_cardID(0);
                    }
                }
                else
                {
                    id = Global.player.get_cardID(0);
                }
            }


            /*if (TIlha > QBodes)
            {
                
                if (TIlha > (QBodes * 2) && Rodada <= 4)
                {
                    id = Global.player.get_cardID(-1);
                }
                // igual?
                else if (TIlha > (QBodes * 2) && Rodada <= 5)
                {
                    id = Global.player.get_cardID(-1);
                }

                // rodada >= 8?, jogo terminado já?
                else if ((QBodes >= (TIlha * 0.70) && QBodes <= TIlha) && Rodada >= 8)
                {
                    id = Global.player.get_cardID(0);
                }


                // rodada >= 8?, jogo terminado já?
                else if ((QBodes >= (TIlha * 0.30) && QBodes <= (TIlha * 0.70)) && Rodada >= 8)
                {
                    id = Global.player.get_cardMID();
                } 
                // igual?
                else
                {
                    id = Global.player.get_cardMID();
                }

            }  
            
            else
            {
                //id = Int32.Parse(Global.player.cards.ElementAt(0).id);
                id = Global.player.get_cardID(0);
            }*/

            return id;
        }


        /// <summary>
        /// Escolhe uma ilha para jogar
        /// </summary>
        /// <returns>Retorna o tamanho da ilha selecionada</returns>
        public int choose_Isle()
        {
            int IlhaMaior;
            int IlhaMenor;

            int[] ilhas = Global.match.check_Isle();

            if (ilhas != null)
            {
                if (ilhas[0] > ilhas[1])
                {
                    IlhaMaior = ilhas[0];
                    IlhaMenor = ilhas[1];
                }

                else
                {
                    IlhaMaior = ilhas[1];
                    IlhaMenor = ilhas[0];
                }

                int TIlha = Global.match.ilha; // Tamanho atual da ilha
                int QBodes = Global.player.bodes; // Quantidade de bodes

                if (Global.player.get_AvgCardsIDS() > 20)
                {
                    return IlhaMaior;
                }

                else if (TIlha > 2*QBodes)
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


        /// <summary>
        /// Realiza uma jogada
        /// </summary>
        public void Play(Running form)
        {
            if (Global.match.status == 'I')
            {
                //Jogar ilha
                
                int island = choose_Isle();
                Global.match.play_Isle(island);
                form.update_Narration();
            }
            else
            {
                //Jogar Carta
                
                string id = choose_Card();
                Global.match.play_Card(id);
                form.update_Hand( false );
                form.update_Narration();
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

            return false;
        }


        /// <summary>
        /// Loop do bot
        /// </summary>
        public void Loop(Running form)
        {
            // nossa vez?
            if (this.check_Turn(form))
            {
                this.Play(form);
            }
            
            // atualiza a mesa da rodada
            form.update_Table();
        }
    }
}
