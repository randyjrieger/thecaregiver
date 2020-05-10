using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheCaregiver.Classes
{
    public enum NPCType
    {
        None = 0,
        Merchant = 1,
        Special = 2,

    }

    public interface NPC
    {
        string Name { get; set; }

        Bitmap Tile { get; set; }
        NPCType Type { get; set; }

        int X { get; set; }
        int Y { get; set; }

        int ScreenX { get; set; }
        int ScreenY { get; set; }

        int CurrentTile { get; set; }
        int FormerTile { get; set; }

        bool checked_north { get; set; }
        bool checked_south { get; set; }
        bool checked_west { get; set; }
        bool checked_east { get; set; }
        int[] AllowedTiles { get; set; }
    }
}
