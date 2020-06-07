using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes
{
    public class Town : ITown
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
