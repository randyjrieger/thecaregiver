using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class Terrabird : Monster
    {
        public Terrabird() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Terrabird"];
            Name = "Terrabird";
            HealthMax = 6;
            Commonality = Commonality.Rare;
            Defense = 20;
            DamageMax = 6;

            NumberOfAttacks = 1;
            MinHourVisible = 1;
            MaxHourVisible = 17;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "A terrifying bird griffin like creature swoops toward you!";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 109, 77 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.NordthilanNeck);
            SpawnRegion.Add(MapRegionType.LavaRegion);
        }
    }
}
