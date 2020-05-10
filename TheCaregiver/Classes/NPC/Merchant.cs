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
        public string Name { get; set; }
        public Store store { get; set; }

        public Bitmap Tile { get; set; }
        public NPCType Type { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int ScreenX { get; set; }
        public int ScreenY { get; set; }

        public int CurrentTile { get; set; }
        public int FormerTile { get; set; }
        
        public bool checked_north { get; set; }
        public bool checked_south { get; set; }
        public bool checked_west { get; set; }
        public bool checked_east { get; set; }
        public int[] AllowedTiles { get; set; }

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


