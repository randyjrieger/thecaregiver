using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class FireGiant : Monster
    {
        public FireGiant() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Fire Giant"];
            Name = "FireGiant";
            HealthMax = 6;
            Commonality = Commonality.Rare;
            Defense = 20;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Fire Giant towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 35, 109 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.LavaRegion);
            SpawnRegion.Add(MapRegionType.NordthilanNeck);
            SpawnRegion.Add(MapRegionType.NordthilanSpine);
        }
    }
}
