using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class RockSpider : Monster
    {
        public RockSpider() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Rock Spider"];
            Name = "Rock Spider";
            HealthMax = 6;
            Commonality = Commonality.Uncommon;
            Defense = 20;
            DamageMax = 6;

            SpecialAttack = SpecialAttack.Blind;
            SpecialAttackDescription = "Bright Ray of Colour";
            NumberOfAttacks = 1;
            MinHourVisible = 7;
            MaxHourVisible = 17;
            SuddenAppearance = true;
            Aggressive = false;
            WelcomeMessage = "";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 120, 109, 70 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoForestEast);
            SpawnRegion.Add(MapRegionType.NordthilanBelly);
            SpawnRegion.Add(MapRegionType.HyleoSouthPlains);
            SpawnRegion.Add(MapRegionType.HyleoPlains);
            SpawnRegion.Add(MapRegionType.LavaRegion);
        }
    }
}
