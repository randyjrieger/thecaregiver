using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class PlainsGiant : Monster
    {
        public PlainsGiant() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Plains Giant"];
            Name = "Plains Giant";
            HealthMax = 6;
            Commonality = Commonality.Rare;
            Defense = 15;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "A Plains Giant towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 120, 70, 89 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoPlains);
            SpawnRegion.Add(MapRegionType.HyleoSouthPlains);
        }
    }
}
