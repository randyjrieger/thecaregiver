using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.World;
using System.Drawing;
using Newtonsoft.Json;
using TheCaregiver.Templates;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace TheCaregiver.Classes
{
    public class Monster : ICloneable, IMonster
    {
        //Attributes
        public string Name { get; set; }
        public List<MapRegionType> SpawnRegion { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int HealthMin { get; set; }
        public int HealthMax { get; set; }
        public int DamageMax { get; set; }
        public string Introduction { get; set; }
        public int NumberOfAttacks { get; set; }
        public int MinHourVisible { get; set; }
        public int MaxHourVisible { get; set; }
        public bool SuddenAppearance { get; set; }
        public string WelcomeMessage { get; set; }
        public int[] AllowedTiles { get; set; }
        [JsonIgnore]
        public Bitmap Tile { get; set; }
        [JsonIgnore]
        public Commonality Commonality { get; set; }
        public string CommonalityDesc
        {
            set
            {
                Enum.TryParse(value, out Commonality setValue);
                Commonality = setValue;
            }
        }


        public int X { get; set; }
        public int Y { get; set; }

        public int ScreenX { get; set; }
        public int ScreenY { get; set; }

        public string TileDesc { get; set; }
        public int CurrentTile { get; set; }
        public int FormerTile { get; set; }

        protected Dice dice = new Dice();

        // All Monsters might flee if the conditions are right. When the FleeTheshold is reached, what are the odds for this type?
        // if ChanceToFlee = 1, then 10% chance they will flee
        public int ChanceToFlee { get; set; }

        // At what point does the Monster consider Fleeing an option
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
        
        public Monster()
        {
            SpawnRegion = new List<MapRegionType>();
            DetermineStartingHealth();
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

        public void DetermineStartingHealth()
        {
            Health = dice.Roll(HealthMin, HealthMax);
        }
    }
}
