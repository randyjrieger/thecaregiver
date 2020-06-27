using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class FireAnts : Monster
    {
        public FireAnts() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Fire Ants"];
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
            WelcomeMessage = "Fire Ants tower above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 58, 109 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoForestEast);
            SpawnRegion.Add(MapRegionType.HyleoForestWest);
            SpawnRegion.Add(MapRegionType.HyleoSouthPlains);
            SpawnRegion.Add(MapRegionType.Swamp);
            SpawnRegion.Add(MapRegionType.NordthilanNeck);
            SpawnRegion.Add(MapRegionType.NordthilanHead);
            SpawnRegion.Add(MapRegionType.NordthilanSpine);
        }
    }
}
