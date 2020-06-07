using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheCaregiver.Classes
{
    public class QuestPerson : NPC
    {
        public QuestPerson()
        {
            //rockpath
            AllowedTiles = new int[] { 61 };
            Tile = TheCaregiver.Tiles.emeraldGiant;
            Type = NPCType.Special;
        }

        public bool CheckNextStep(int tile)
        {
            bool OkToStep = false;

            //if (AllowedTiles.Contains(tile))
            //{
            //    OkToStep = true;
            //}

            return OkToStep;
        }
    }
}
