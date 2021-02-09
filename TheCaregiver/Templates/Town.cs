using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes
{
    public class Town
    {
        public string name { get; set; }
        public int id { get; set; }
        public int startX { get; set; }
        public int startY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int worldX { get; set; }
        public int worldY { get; set; }
        public string place { get; set; }
        public string filePath { get; set; }
        public List<Location> locations { get; set; }
    }
}
