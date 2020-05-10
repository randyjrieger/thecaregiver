using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.World;
using System.Drawing;
using Newtonsoft.Json;

namespace TheCaregiver.Classes
{
    public enum Commonality
    {
        Common = 0,
        Uncommon = 1,
        Rare = 2
    }

    public enum SpecialAttack
    {
        Blind = 0,
        Poison = 1
    }


        public class Mob : ICloneable
    {
        //Attributes
        public string Name { get; set; }
        public Commonality Commonality { get; set; }
        public List<MapRegionType> SpawnRegion { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int HealthMax { get; set; }
        public int DamageMax { get; set; }
        public string Introduction { get; set; }
        public SpecialAttack SpecialAttack { get; set; }
        public string SpecialAttackDescription { get; set; }
        public int NumberOfAttacks { get; set; }
        public int MinHourVisible { get; set; }
        public int MaxHourVisible { get; set; }
        public bool SuddenAppearance { get; set; }
        public string WelcomeMessage { get; set; }
        public int[] AllowedTiles { get; set; }

        [JsonIgnore]

        public Bitmap Tile { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int ScreenX { get; set; }
        public int ScreenY { get; set; }

        public int CurrentTile { get; set; }
        public int FormerTile { get; set; }

        // All Mobs might flee if the conditions are right. When the FleeTheshold is reached, what are the odds for this type?
        // if ChanceToFlee = 1, then 10% chance they will flee
        public int ChanceToFlee { get; set; }

        // At what point does the Mob consider Fleeing an option
        // if FleeThreshold = 1, then at 10% 
        public bool CombatMode { get; set; }
        public bool Aggressive { get; set; }
        public bool OpponentInBattle { get; set; }
        public bool AttackTurn { get; set; }
        public int FleeThreshold { get; set; }
        public Place Map { get; set; }

        public bool checked_north { get; set; }
        public bool checked_south { get; set; }
        public bool checked_west { get; set; }
        public bool checked_east { get; set; }

        //grass, foothill, Desert, tree, forest, swamp, flowers..
      //  private int[] allowTiles = { 120, 109, 58, 89, 70, 115, 101, 102, 114 };
        
        public Mob()
        {
            SpawnRegion = new List<MapRegionType>();
        }

        public bool CheckNextStep(int tile)
        {
            bool OkToStep = false;

            if (AllowedTiles.Contains(tile))
            {
                OkToStep = true;
            }

            return OkToStep;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
