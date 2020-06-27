using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class FireTurtle : Monster
    {
        public FireTurtle() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Fire Turtle"];
            Name = "Ettin";
            HealthMax = 6;
            Commonality = Commonality.Common;
            Defense = 20;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An FireTurtle towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 109, 35 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.LavaRegion);
        }
    }
}
