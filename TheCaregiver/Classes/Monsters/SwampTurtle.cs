using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class Ettin : Monster
    {
        public Ettin() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Ettin"];
            Name = "Ettin";
            HealthMax = 6;
            Commonality = Commonality.Common;
            Defense = 15;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Ettin towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 120, 109 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoForestEast);
            SpawnRegion.Add(MapRegionType.NordthilanBelly);
            SpawnRegion.Add(MapRegionType.HyleoSouthPlains);
            SpawnRegion.Add(MapRegionType.HyleoPlains);
            SpawnRegion.Add(MapRegionType.NordthilanHead);
        }
    }
}
