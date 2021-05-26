using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheCaregiver.Player1;
using TheCaregiver.World;
using TheCaregiver.Classes.Monsters;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization;

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


    public static class MonsterHelper
    {
        public static Dictionary<string, Bitmap> MonsterBitmapPairing = new Dictionary<string, Bitmap>();
        public static List<Monster> MonsterTypes = new List<Monster>();

        private static void MonsterBitMapPairing()
        {
            //Create Monster-Bitmap Pairings
            MonsterBitmapPairing.Add("Ettin", new Bitmap(TheCaregiver.Tiles.ettin1));
            MonsterBitmapPairing.Add("Rock Spider", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Terrabird", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Bandit", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Plains Giant", new Bitmap(TheCaregiver.Tiles.plainsGiant));
            MonsterBitmapPairing.Add("Sand Giant", new Bitmap(TheCaregiver.Tiles.sandGiant));
            MonsterBitmapPairing.Add("Emerald Giant", new Bitmap(TheCaregiver.Tiles.emeraldGiant));
            MonsterBitmapPairing.Add("Amber Giant", new Bitmap(TheCaregiver.Tiles.amberGiant));
            MonsterBitmapPairing.Add("Amber Beetle", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Amber Hatchling", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Orc", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Treant", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Centaur", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Squidling", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Water Spider", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Frog Jelly", new Bitmap(TheCaregiver.Tiles.frogjelly));
            MonsterBitmapPairing.Add("Shark", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Merman", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Great Squid", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Kobold", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Goblin", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Fire Turtle", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Hell Hound", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Fire Giant", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Swamp Turtle", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Scorpian", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Shadow", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Sand Worm", new Bitmap(TheCaregiver.Tiles.terrabird));
            MonsterBitmapPairing.Add("Venom Weed", new Bitmap(TheCaregiver.Tiles.venomweed));
            MonsterBitmapPairing.Add("Fire Ants", new Bitmap(TheCaregiver.Tiles.fireants));
        }

        public static void CreateMonsterTypes(List<MapRegion> regions)
        {
            MonsterBitMapPairing();

            string s = File.ReadAllText(@"..\..\Resources\jsonDB\monsters.json");
            var monstersCollection = JObject.Parse(s).SelectToken("monsters").ToString();
            var monsters = JsonConvert.DeserializeObject<List<Monster>>(monstersCollection);
            Monster m = new Monster();
            foreach (Monster t in monsters)
            {
                m = new Monster
                {
                    Name = t.Name,
                    Health = t.Health,
                    HealthMax = t.HealthMax,
                    Commonality = t.Commonality,
                    Defense = t.Defense,
                    DamageMax = t.DamageMax,
                    NumberOfAttacks = t.NumberOfAttacks,
                    MinHourVisible = t.MinHourVisible,
                    MaxHourVisible = t.MaxHourVisible,
                    SuddenAppearance = t.SuddenAppearance,
                    Aggressive = t.Aggressive,
                    WelcomeMessage = t.Introduction,
                    ChanceToFlee = t.ChanceToFlee,
                    FleeThreshold = t.FleeThreshold,
                    AllowedTiles = t.AllowedTiles,
                    Tile = MonsterBitmapPairing[t.TileDesc],
                    SpawnRegion = t.SpawnRegion
                };
                
                MonsterTypes.Add(m);
            }

        }



        //public static void CreateMonsterTypes3(List<MapRegion> regions)
        //{
        //    //Pair Monsters with Bitmap Tiles
        //    MonsterBitMapPairing();

        //    MonsterTypes.Add(new AmberBeetle());
        //    MonsterTypes.Add(new AmberGiant());
        //    MonsterTypes.Add(new AmberHatchling());
        //    MonsterTypes.Add(new Bandit());
        //    MonsterTypes.Add(new Centaur());
        //    MonsterTypes.Add(new EmeraldGiant());
        //    MonsterTypes.Add(new Ettin());
        //    MonsterTypes.Add(new FireAnts());
        //    MonsterTypes.Add(new FireGiant());
        //    MonsterTypes.Add(new FireTurtle());
        //    MonsterTypes.Add(new FrogJelly());
        //    MonsterTypes.Add(new Goblin());
        //    MonsterTypes.Add(new GreatSquid());
        //    MonsterTypes.Add(new HellHound());
        //    MonsterTypes.Add(new Kobold());
        //    MonsterTypes.Add(new Merman());
        //    MonsterTypes.Add(new PlainsGiant());
        //    MonsterTypes.Add(new RockSpider());
        //    MonsterTypes.Add(new SandGiant());
        //    MonsterTypes.Add(new SandWorm());
        //    MonsterTypes.Add(new Scorpian());
        //    MonsterTypes.Add(new Shadow());
        //    MonsterTypes.Add(new Shark());
        //    MonsterTypes.Add(new Squidling());
        //    MonsterTypes.Add(new SwampTurtle());
        //    MonsterTypes.Add(new Terrabird());
        //    MonsterTypes.Add(new Treant());
        //    MonsterTypes.Add(new VenomWeed());
        //    MonsterTypes.Add(new WaterSpider());
        //    MonsterTypes.Add(new AmberBeetle());
        //}

        //public static void CreateMonsterTypes2(List<MapRegion> regions)
        //{
        //    Dice dice = new Dice();
        //    Monster newMonster = new Monster();
        //    int healthRoll = 6;

        //    //Pair Monsters with Bitmap Tiles
        //    MonsterBitMapPairing();

        //    //Create Monsters

        //    //FOOTHILLS
        //    //Common -  healthRoll = dice.Roll(3, 6);
        //    newMonster = new Monster
        //    {
        //        Name = "Ettin",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 3,
                
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "An Ettin towers above you. He looks unimpressed.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.HyleoForestWest, MapRegionType.NordthilanNeck, MapRegionType.NordArm },
        //        Tile = MonsterBitmapPairing["Ettin"],
        //        AllowedTiles = new int[] { 120, 109 }
        //    };

        //    MonsterTypes.Add(newMonster);


        //    //UnCommon - healthRoll = dice.Roll(18, 30);
        //    newMonster = new Monster
        //    {
        //        Name = "Rock Spider",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains, MapRegionType.HyleoSouthPlains, MapRegionType.HyleoDesert, MapRegionType.LavaRegion, MapRegionType.NordArm },
        //        Tile = MonsterBitmapPairing["Rock Spider"],
        //        AllowedTiles = new int[] { 120, 109, 70 },
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Rare - healthRoll = dice.Roll(18, 30);
        //    newMonster = new Monster
        //    {
        //        Name = "Terrabird",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
        //        Introduction = "You hear a terrifying shriek from behind you. A brightly coloured giant dragon-like bird is running at you.",
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A terrifying bird griffin like creature swoops toward you!",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.NordthilanNeck, MapRegionType.LavaRegion, MapRegionType.NordthilanHead },
        //        Tile = MonsterBitmapPairing["Terrabird"],
        //        AllowedTiles = new int[] { 109, 77 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //GRASS
        //    //Common - 
        //    newMonster = new Monster
        //    {
        //        Name = "Bandit",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A Bandit steps out of the shadows. You are his next vicitm.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoForestWest, MapRegionType.HyleoSouthPlains, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.SouthWind, MapRegionType.HyleoPlains },
        //        Tile = MonsterBitmapPairing["Bandit"],
        //        AllowedTiles = new int[] { 120, 70, 89 },

        //    };

        //    MonsterTypes.Add(newMonster);


        //    //Rare - 
        //    newMonster = new Monster
        //    {
        //        Name = "Plains Giant",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "You see a Plains Giant take notice of you. That's never good.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains, MapRegionType.NordthilanBelly, MapRegionType.SouthWind },
        //        Tile = MonsterBitmapPairing["Plains Giant"],
        //        AllowedTiles = new int[] { 120, 70, 89 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Rare - 
        //    newMonster = new Monster
        //    {
        //        Name = "Sand Giant",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "You turn a Sand Giant aggressively approaching you.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = {  MapRegionType.HyleoDesert },
        //        Tile = MonsterBitmapPairing["Sand Giant"],
        //        AllowedTiles = new int[] { 109, 58 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Emerald Giant
        //    newMonster = new Monster
        //    {
        //        Name = "Emerald Giant",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "An Emerald Giant towers over you. You feel powerless.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.NordthilanHead, MapRegionType.NordthilanSpine, MapRegionType.Swamp },
        //        Tile = MonsterBitmapPairing["Emerald Giant"],
        //        AllowedTiles = new int[] { 120, 70, 89, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Amber Giant
        //    newMonster = new Monster
        //    {
        //        Name = "Amber Giant",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Apathy , MapRegionType.NordthilanSpine, MapRegionType.NordthilanNeck},
        //        Tile = MonsterBitmapPairing["Amber Giant"],
        //        AllowedTiles = new int[] { 120, 70, 89, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Amber Beetle
        //    newMonster = new Monster
        //    {
        //        Name = "Amber Beetle",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Apathy, MapRegionType.NordthilanBelly, MapRegionType.NordthilanSpine },
        //        Tile = MonsterBitmapPairing["Amber Beetle"],
        //        AllowedTiles = new int[] { 120, 70, 89, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Amber Beetle
        //    newMonster = new Monster
        //    {
        //        Name = "Amber Hatchling",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Apathy, MapRegionType.NordthilanBelly, MapRegionType.NordthilanSpine },
        //        Tile = MonsterBitmapPairing["Amber Hatchling"],
        //        AllowedTiles = new int[] { 120, 70, 89, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Common
        //    newMonster = new Monster
        //    {
        //        Name = "Orc",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "An orc jumps up from behind you.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains },
        //        Tile = MonsterBitmapPairing["Orc"],
        //        AllowedTiles = new int[] { 120, 70, 89 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Rare -Treant
        //    newMonster = new Monster
        //    {
        //        Name = "Treant",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.NordthilanNeck, MapRegionType.NordthilanHead, MapRegionType.NordthilanBelly },
        //        Tile = MonsterBitmapPairing["Treant"],
        //        AllowedTiles = new int[] { 89 },

        //    };

        //    MonsterTypes.Add(newMonster);


        //    //UnCommon
        //    newMonster = new Monster
        //    {
        //        Name = "Centaur",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A centaur gallops toward you, hate in his eyes!",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.NordthilanBelly, MapRegionType.SouthWind },
        //        Tile = MonsterBitmapPairing["Centaur"],
        //        AllowedTiles = new int[] { 120, 77, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //OCEAN
        //    //Create the Monster
        //    //Common
        //    newMonster = new Monster
        //    {
        //        Name = "Squidling",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 3,
                
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Ocean, MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly },
        //        Tile = MonsterBitmapPairing["Squidling"],
        //        AllowedTiles = new int[] { 44, 46 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Water Spider - Common
        //    newMonster = new Monster
        //    {
        //        Name = "Water Spider",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 3,
                
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A water spider swims after you.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Ocean, MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly },
        //        Tile = MonsterBitmapPairing["Water Spider"],
        //        AllowedTiles = new int[] { 44 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Frog Jelly - UnCommon
        //    newMonster = new Monster
        //    {
        //        Name = "Frog Jelly",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 3,
                
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A terrifying gelatinous frog like creature jumps at you!",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains, MapRegionType.NordArm, MapRegionType.Swamp },
        //        Tile = MonsterBitmapPairing["Frog Jelly"],
        //        AllowedTiles = new int[] { 44, 115 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Shark - Uncommon
        //    newMonster = new Monster
        //    {
        //        Name = "Shark",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 3,
        //        Introduction = ".",
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "You see the dorsal fin of a hungry shark beside you.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.NordArm, MapRegionType.NordthilanBelly, MapRegionType.Otalio, MapRegionType.Ocean },
        //        Tile = MonsterBitmapPairing["Shark"],
        //        AllowedTiles = new int[] { 44, 46 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Merman - Uncommon
        //    newMonster = new Monster
        //    {
        //        Name = "Merman",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 3,
        //        Introduction = ".",
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.NordArm, MapRegionType.NordthilanBelly, MapRegionType.Ocean },
        //        Tile = MonsterBitmapPairing["Merman"],
        //        AllowedTiles = new int[] { 44, 46 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Great Squid - Rare
        //    newMonster = new Monster
        //    {
        //        Name = "Great Squid",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 3,
                
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A huge many-armed beast surfaces beside you. It's a Giant Squid!",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Ocean, MapRegionType.Otalio },
        //        Tile = MonsterBitmapPairing["Great Squid"],
        //        AllowedTiles = new int[] { 46 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Kobold - Common
        //    newMonster = new Monster
        //    {
        //        Name = "Kobold",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A kobold appears beside you, ready to attack.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanSpine,  MapRegionType.SouthWind },
        //        Tile = MonsterBitmapPairing["Kobold"],
        //        AllowedTiles = new int[] { 70, 89 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Goblin - UnCommon
        //    newMonster = new Monster
        //    {
        //        Name = "Goblin",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A goblin appears from out of the shadows.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.NordthilanHead, MapRegionType.NordthilanSpine, MapRegionType.NordthilanNeck },
        //        Tile = MonsterBitmapPairing["Goblin"],
        //        AllowedTiles = new int[] { 109, 89 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Fire Turtle - Common
        //    newMonster = new Monster
        //    {
        //        Name = "Fire Turtle",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.LavaRegion },
        //        Tile = MonsterBitmapPairing["Fire Turtle"],
        //        AllowedTiles = new int[] { 109, 35 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Hell Hound - UnCommon
        //    newMonster = new Monster
        //    {
        //        Name = "Hell Hound",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "The haunting growls of a Hell Hound fill your ears. You are not alone!",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.LavaRegion },
        //        Tile = MonsterBitmapPairing["Hell Hound"],
        //        AllowedTiles = new int[] { 35 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Fire Giant
        //    newMonster = new Monster
        //    {
        //        Name = "Fire Giant",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A firey, monstrous giant appears before you. From whence did it come? No matter, you're in trouble.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.LavaRegion },
        //        Tile = MonsterBitmapPairing["Fire Giant"],
        //        AllowedTiles = new int[] { 35, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Common -Swamp Turtle
        //    newMonster = new Monster
        //    {
        //        Name = "Swamp Turtle",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Swamp },
        //        Tile = MonsterBitmapPairing["Swamp Turtle"],
        //        AllowedTiles = new int[] { 115 },

        //    };

        //    MonsterTypes.Add(newMonster);


        //    //Shark - Uncommon
        //    newMonster = new Monster
        //    {
        //        Name = "Scorpian",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 3,
        //        Introduction = ".",
        //        NumberOfAttacks = 1,
        //        MinHourVisible = 0,
        //        MaxHourVisible = 23,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "A scorpian scampers toward you, tail stinger raised.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoDesert, MapRegionType.NordthilanNeck},
        //        Tile = MonsterBitmapPairing["Scorpian"],
        //        AllowedTiles = new int[] { 109, 58 }
        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Rare - Shadow
        //    newMonster = new Monster
        //    {
        //        Name = "Shadow",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "Shadows around your feet begin to swirl around you, forming into a dark spirit, with soulless yellow eyes.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = {MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.NordArm },
        //        Tile = MonsterBitmapPairing["Shadow"],
        //        AllowedTiles = new int[] { 109, 89 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Sand Worm
        //    newMonster = new Monster
        //    {
        //        Name = "Sand Worm",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Uncommon,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.HyleoDesert },
        //        Tile = MonsterBitmapPairing["Sand Worm"],
        //        AllowedTiles = new int[] { 109, 58 },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Rare - Venom Weed
        //    newMonster = new Monster
        //    {
        //        Name = "Venom Weed",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Rare,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = false,
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = { MapRegionType.Swamp, MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains, MapRegionType.NordArm},
        //        Tile = MonsterBitmapPairing["Venom Weed"],
        //        AllowedTiles = new int[] { },

        //    };

        //    MonsterTypes.Add(newMonster);

        //    //Common - Fire Ants
        //    newMonster = new Monster
        //    {
        //        Name = "Fire Ants",
        //        Health = healthRoll,
        //        HealthMax = healthRoll,
        //        Commonality = Commonality.Common,
        //        Defense = 15,
        //        DamageMax = 6,
                
        //        NumberOfAttacks = 1,
        //        SpecialAttack = SpecialAttack.Blind,
        //        SpecialAttackDescription = "Bright Ray of Colour",
        //        MinHourVisible = 7,
        //        MaxHourVisible = 17,
        //        SuddenAppearance = true,
        //        Aggressive = true,
        //        WelcomeMessage = "You suddenly feel covered in burning, tiny bites. You've disurbed a nest of Fire Ants.",
        //        ChanceToFlee = 1,
        //        FleeThreshold = 1,
        //        SpawnRegion = {  MapRegionType.HyleoDesert, MapRegionType.NordthilanNeck },
        //        Tile = MonsterBitmapPairing["Fire Ants"],
        //        AllowedTiles = new int[] { 58, 109 },

        //    };

        //    MonsterTypes.Add(newMonster);
                       
        //}


        private static bool FindMonsters(Monster mob)
        {
          //  if (mob.SpawnRegion.Contains(r.Type))
            {
                if (mob.Commonality == Commonality.Common)
                    return true;
                else
                    return false;
            }

           // return false;
        }

        public static Commonality CommonalityCheck()
        {
            Commonality c = Commonality.Common;
            Random rnd = new Random();

            int result = rnd.Next(1, 20);

            if (result <= 12)
                c = Commonality.Common;
            else if (result <= 17)
                c = Commonality.Uncommon;
            else
                c = Commonality.Rare;

            return c;

        }

        public static void ReSpawnMonster(List<Monster> MonsterList, Player player1)
        {
            // List<Monster> CandidateMonsters = null;
            Monster OpponentToRemove = player1.Opponent;

            Dice dice = new Dice();
            Monster CandidateMonster = null;
            Commonality commonality;
            commonality = CommonalityCheck();


           // CandidateMonster = MonsterTypes.Find(m => m.Name.Length > 0);
            CandidateMonster = MonsterTypes.Find(m => m.Commonality == commonality && m.SpawnRegion.Contains(player1.CurrentRegion.Type));

            CandidateMonster.X = dice.Roll(player1.CurrentRegion.X1, player1.CurrentRegion.X2);
            CandidateMonster.Y = dice.Roll(player1.CurrentRegion.Y1, player1.CurrentRegion.Y2);

            //remove as Opponent, should also remove from MonsterList
            player1.Opponent = null;
            MonsterList.Remove(OpponentToRemove);
            MonsterList.Add(CandidateMonster);
        }

        public static List<Monster> SpawnMonsters(List<MapRegion> regions)
        {
            Dice dice = new Dice();
            List<Monster> Monsters = new List<Monster>();
            List<Monster> SelectedMonsters = new List<Monster>();
            Commonality commonality;
            Monster newMonster;

            //Run through all Regions
            foreach (MapRegion r in regions)
            {
                //Regions have a max number of Monsters
                for (int i = 1; i < r.MaxMonsterCount; i++)
                {
                    //What is the Commonality of the new Monster?
                    SelectedMonsters = new List<Monster>();

                    //Find Monster
                    // SelectedMonsters = MonsterTypes.FindAll(FindMonsters);

                    //Commonality of Monster - this is a Random event
                    commonality = CommonalityCheck();

                    try
                    {
                        //Get all monsters with the chosen commonality and region type
                       // SelectedMonsters = MonsterTypes.FindAll(m => m.Name.Length > 0);
                        SelectedMonsters = MonsterTypes.FindAll(m => m.Commonality == commonality && m.SpawnRegion.Contains(r.Type));
                    }
                    catch (Exception)
                    {
                        SelectedMonsters.Add(MonsterTypes[0]);
                    }

                    if (SelectedMonsters.Count == 0)
                    {
                        SelectedMonsters.Add(MonsterTypes[0]);
                    }

                    //for the moment, we take the first monster type, clone it and add it to the Monster list
                   
                    //TODO: this will need to be random as well since there could be more than one monster
                    newMonster = (Monster)SelectedMonsters[0].Clone();
                    newMonster.X = dice.Roll(r.X1, r.X2);
                    newMonster.Y = dice.Roll(r.Y1, r.Y2);
                    Monsters.Add(newMonster);
                }
            }

            return Monsters;
        }
    }
}
