using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class SandWorm : Monster
    {
        public SandWorm() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Sand Worm"];
            Name = "SandWorm";
            HealthMax = 6;
            Commonality = Commonality.Uncommon;
            Defense = 15;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An SandWorm towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 58, 109 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoForestEast);
            SpawnRegion.Add(MapRegionType.NordthilanBelly);
            SpawnRegion.Add(MapRegionType.NordthilanHead);
            SpawnRegion.Add(MapRegionType.NordArm);
        }
    }
}
