using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Templates
{
    public class Location : ILocation
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
