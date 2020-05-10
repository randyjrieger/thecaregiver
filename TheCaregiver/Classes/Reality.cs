using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Classes
{
    public enum Season
    {
        winter = 0,
        spring,
        summer,
        autumn
    }

    public class Reality
    {
        public int Year { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Season Season { get; set; }
    }

}
