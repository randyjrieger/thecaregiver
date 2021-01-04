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

        public bool PlayerMonsterConflict { get; set; }

        public bool ShopMode { get; set; }

        public Reality reality { get; set; }
        public int seedPolt { get; set; }

        public GameState(GameMode mode) {
            reality = new Reality();

            if (mode == GameMode.New)
            {
                reality.Day = 1;
                reality.Season = Season.spring;
                reality.Hour = 7;
                reality.Minute = 0;
            }
        }
    }
}
