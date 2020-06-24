using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class GreatSquid : Monster
    {
        public GreatSquid() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Great Squid"];
            Name = "GreatSquid";
            HealthMax = 6;
            Commonality = Commonality.Rare;
            Defense = 15;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "A huge many-armed beast surfaces beside you. It's a Giant Squid!";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 46 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.Ocean);
            SpawnRegion.Add(MapRegionType.Otalio);
        }
    }
}
