using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.World;
using TheCaregiver.Classes;
using TheCaregiver.People;

namespace TheCaregiver.Player1
{
    public class Player : Person    {

        public int HealthMax { get; set; }
        public int PreviousMapX { get; set; }
        public int PreviousMapY { get; set; }

        public PlayerProgress CurrentState { get; set; }
        public MapRegion CurrentRegion {get; set;}
        public int coin { get; set; }
        public int food { get; set; }
        public bool Sleeping { get; set; }
        public int SleepTicker { get; set; }
        public bool Fishing { get; set; }
        public int FishTicker { get; set; }

        public int fish { get; set; }
        public bool Chopping { get; set; }
        public int ChopTicker { get; set; }
        public int wood { get; set; }
        public bool AttackTurn { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public Armour EquipedArmour{ get; set; }
        public Monster Opponent { get; set; }

        public bool CombatMode { get; set; }
        public bool NextToAttack { get; set; }

        public int BlindCounter { get; set; }
        public bool Blind { get; set; }
        public int DazedCounter { get; set; }
        public bool Dazed { get; set; }
        public int SleepCounter { get; set; }
        public bool Sailing { get; set; }
        public bool Dead { get; set; }

        public bool HasSeed { get; set; }
        public bool HasHoe { get; set; }
        public bool HasHouse { get; set; }
        public Map House { get; set; }
        public string HouseName { get; set; }
        public bool HasRaft { get; set; }
        public int HouseX { get; set; }
        public int HouseY { get; set; }

        public List<GardenPlot> GardenPlots = new List<GardenPlot>();
        public int MaxGardenCount { get; set; }
        public int NumberofSeeds { get; set; }
        public Place Map { get; set; }

        public int[] allowTiles { get; set; }
        //Skills
        public int Skill_Fishing { get; set; }
        public int Skill_Chopping { get; set; }
        public int Skill_Swordsmanship { get; set; }
        public int Skill_Defence { get; set; }
        
        public int Attribute_Strength { get; set; }
        public int Attribute_Charisma { get; set; }
        public int Attribute_Luck { get; set; }
        public int Attribute_Intellect { get; set; }
        public int Attribute_Insight { get; set; }
        public int Attribute_Agility { get; set; }

        public Player()
        {
            Name = "Alfred";
            CurrentState = PlayerProgress.none;
            Sleeping = false;
            Sailing = false;
            HasHouse = false;
            HasRaft = true;
            Fishing = false;
            Chopping = false;
            HasSeed = false;
            HasHoe = true;
            Map = Place.Wilderness;
            coin = 100;
            food = 3;
            NumberofSeeds = 0;
            allowTiles = new int[]  { 120, 109, 58, 89, 70, 115, 101, 102, 114, 79, 80 };
            Dead = false;
            MaxGardenCount = 10;

            CombatMode = false;
            NextToAttack = false;
        }

        public void SetStartPosition(byte[,] MapMatrix)
        { // X = 421; // DiceRoll.Roll(249);
            //  Y = 99; /// DiceRoll.Roll(149);
            Dice dice = new Dice();

            do
            {
                dice = new Dice();
                X = dice.Roll(130, 450);
                Y = dice.Roll(100, 150);
                dice = null;
            } while (!okToStart(MapMatrix[X, Y]));

        }

        public bool okToStart(int tile)
        {
            bool OkToStep = false;

            if (allowTiles.Contains(tile))
            {
                OkToStep = true;
            }

            return OkToStep;
        }

        public bool DidPlayerRaiseLevel()
        {
            //check experience vs level

            return false;
        }

    }
}
