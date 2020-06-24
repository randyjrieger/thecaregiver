using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Templates;

namespace TheCaregiver.Classes.Monsters
{
    public class Bandit : Monster
    {
        public Bandit() : base()
        {
            Tile = MonsterHelper.MonsterBitmapPairing["Bandit"];
            Name = "Bandit";
            HealthMax = 6;
            Commonality = Commonality.Common;
            Defense = 15;
            DamageMax = 6;

            NumberOfAttacks = 1;
            MinHourVisible = 7;
            MaxHourVisible = 23;
            SuddenAppearance = true;
            Aggressive = true;
            WelcomeMessage = "A Bandit steps out of the shadows. You are his next vicitm.";
            ChanceToFlee = 1;
            FleeThreshold = 1;            
            AllowedTiles = new int[] { 120, 70, 89 };

            SpawnRegion = new List<MapRegionType>();
            SpawnRegion.Add(MapRegionType.HyleoForestWest);
            SpawnRegion.Add(MapRegionType.NordArm);
            SpawnRegion.Add(MapRegionType.HyleoForestEast);
            SpawnRegion.Add(MapRegionType.NordthilanBelly);
            SpawnRegion.Add(MapRegionType.NordthilanHead);
            SpawnRegion.Add(MapRegionType.HyleoPlains);
            SpawnRegion.Add(MapRegionType.HyleoSouthPlains);
            SpawnRegion.Add(MapRegionType.Otalio);
        }
    }
}
