using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Classes;

namespace TheCaregiver.World
{
    public enum PlayerProgress
    {
        none = 0,
        name = 1,
        house = 2, 
        hoe = 3,
        garden = 4,
        seed = 5
    }
    

    public class GameState
    {
        public int waterTicker = 0;
        public int lavaTicker = 0;
        public Map CurrentMap { get; set; }
        public Map PreviousMap { get; set; }

        public bool PlayerMobConflict { get; set; }

        public Reality reality { get; set; }
        public int seedPolt { get; set; }

        public GameState() {
            reality = new Reality();
        }
    }
}
