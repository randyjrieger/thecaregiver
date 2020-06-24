using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class Scorpian : Monster
    {
        public Scorpian() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Scorpian"];
            Name = "Scorpian";
            HealthMax = 6;
            Commonality = Commonality.Common;
            Defense = 15;
            DamageMax = 3;

            NumberOfAttacks = 1;
            MinHourVisible = 0;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "An Scorpian towers above you. He looks unimpressed.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 109, 58 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoDesert);
            SpawnRegion.Add(MapRegionType.NordthilanNeck);
        }
    }
}
