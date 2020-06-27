using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class HellHound : Monster
    {
        public HellHound() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Hell Hound"];
            Name = "HellHound";
            HealthMax = 6;
            Commonality = Commonality.Uncommon;
            Defense = 20;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Hell Hound towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 25 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.LavaRegion);
        }
    }
}
