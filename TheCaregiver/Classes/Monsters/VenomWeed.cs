using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class VenomWeed : Monster
    {
        public VenomWeed() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Venom Weed"];
            Name = "VenomWeed";
            HealthMax = 6;
            Commonality = Commonality.Rare;
            Defense = 20;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Venom Weed towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 120, 109  };

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
