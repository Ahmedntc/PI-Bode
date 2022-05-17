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
                int island = show_Island(form);
                if(island > 0)
                {
                    Jogo.DefinirIlha(
                    Global.player.id,
                    Global.player.token,
                    island
                    );
                }
            }
            else if (Global.match.status == 'B')
            {
                //Jogar Carta
                Global.match.play_Card(Global.player.cards.ElementAt(0).id);
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

            return false;
        }


        public void Loop(Running form)
        {
            // nossa vez?
            if (check_Turn(form))
            {
                Play(form);
            }
        }
    }
}
