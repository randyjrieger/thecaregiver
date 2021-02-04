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
        public List<Location> locations { get; set; }
    }
}
