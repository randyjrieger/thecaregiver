using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class Kobold : Monster
    {
        public Kobold() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Kobold"];
            Name = "Kobold";
            HealthMax = 6;
            Commonality = Commonality.Common;
            Defense = 15;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "A kobold appears beside you, ready to attack.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 70, 89 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoForestEast);
            SpawnRegion.Add(MapRegionType.HyleoForestWest);
            SpawnRegion.Add(MapRegionType.NordthilanBelly);
            SpawnRegion.Add(MapRegionType.NordthilanHead);
        }
    }
}
