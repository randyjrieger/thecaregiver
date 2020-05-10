using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Classes
{
    public class agencia
    {
        public string name { get; set; }
        public object[] data { get; set; }
    }
    public class Dice
    {

        private Random rnd = new Random();

        public int Roll(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }
    }
}
