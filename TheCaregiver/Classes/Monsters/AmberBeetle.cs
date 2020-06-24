using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class AmberBeetle : Monster
    {
        public AmberBeetle() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Amber Beetle"];
            Name = "AmberBeetle";
            HealthMax = 6;
            Commonality = Commonality.Uncommon;
            Defense = 15;
            DamageMax = 6;

            NumberOfAttacks = 1;
            MinHourVisible = 7;
            MaxHourVisible = 17;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Amber Beetle towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 120, 70, 89, 109 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.Apathy);
        }
    }
}
