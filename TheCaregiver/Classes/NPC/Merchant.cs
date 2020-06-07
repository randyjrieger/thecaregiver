using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheCaregiver.Classes
{
    public class Merchant : NPC
    {
        public Store store { get; set; }

        public Merchant()
        {
            //rockpath
            AllowedTiles = new int[] { 61 };
            Tile = TheCaregiver.Tiles.merchant;
            Type = NPCType.Merchant;
        }

        public bool CheckNextStep(int tile)
        {
            bool OkToStep = false;

            if (AllowedTiles.Contains(tile))
            {
                OkToStep = true;
            }

            return OkToStep;
        }


    }
}


