using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.People
{

    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Bitmap Tile { get; set; }

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

        public Person() { }
    }
}
