using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class Merman : Monster
    {
        public Merman() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Merman"];
            Name = "Merman";
            HealthMax = 6;
            Commonality = Commonality.Uncommon;
            Defense = 20;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Merman towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 44, 46 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.Ocean);
            SpawnRegion.Add(MapRegionType.NordthilanBelly);
            SpawnRegion.Add(MapRegionType.NordArm);
        }
    }
}
