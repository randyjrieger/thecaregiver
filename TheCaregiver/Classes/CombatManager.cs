using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TheCaregiver.Player1;

namespace TheCaregiver.Classes
{
    public class CombatManager
    {
        protected Mob Opponent { get; set; }
        public NPC NPCOpponent { get; set; }

        protected Timer CombatTimer { get; set; }
        protected Player Player1 { get; set; }

        public CombatManager()
        {
            //Interval is 1 second for now (1000 milliseconds)
          //  CombatTimer.Interval = 1000;

            //determine surprise

            //determine fighting order


        }

        public CombatManager(Mob mob, Player player1)
        {
            //Interval is 1 second for now (1000 milliseconds)
         //   CombatTimer.Interval = 1000;

            //determine surprise

            //determine fighting order

            mob.CombatMode = true;
            mob.AttackTurn = true;
            mob.OpponentInBattle = true;

            Player1 = player1;
            Player1.Opponent = mob;
            Player1.CombatMode = true;

        }

        public void StartRound()
        {
            if (Player1.Opponent.AttackTurn)
            {

            }
            else 
            {

            }

        }


        public void FinishRound()
        {
            //Check Flee Change of Mob


        }



    }
}
