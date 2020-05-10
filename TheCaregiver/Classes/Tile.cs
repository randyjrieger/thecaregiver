using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheCaregiver.World
{
    public class Tile
    {
        private Bitmap[] movingpicture = new Bitmap[4];
        public char Letter { get; set; }
        public int Code { get; set; }
        public Bitmap Picture { get; set; }

        public string Filename { get; set; }


        public void setMovingPicture(int tick, Bitmap value)
        {
            movingpicture[tick] = value;
        }

        public Bitmap getMovingPicture(int tick)
        {
            return movingpicture[tick];
        }
    }
}
