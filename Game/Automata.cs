using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Game.Running_Folder;
using BodeOfWarServer;

namespace Game
{
    public class Automata
    {
        public Automata()
        {

        }

        public int ShowIsland(Running match)
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

        public void Play(Running match)
        {
            if (match.RoundStatus.StartsWith("I"))
            {
                //Jogar ilha
                int island = ShowIsland(match);
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
                Jogo.Jogar(
                    Global.player.id,
                    Global.player.token,
                    Int32.Parse(Global.player.cards.ElementAt(0).id)
                );
                match.showHand();
            }
        }


        public void Check(Running match)
        {
            match.btnCheck_Click(null, null);
            string ret = match.PlayerTurn;

            //Verifica se é nossa vez
            if (ret.Equals(Global.player.name) && Global.player.cards.Count != 0)
            {
                this.Play(match);
            }
        }

        public void Loop(Running match)
        {
            this.Check(match);
        }
    }
}
