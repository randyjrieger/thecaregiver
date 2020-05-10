using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheCaregiver.Player1;

namespace TheCaregiver.Classes
{
    public static class MobHelper
    {
        public static Dictionary<string, Bitmap> MobBitmapPairing = new Dictionary<string, Bitmap>();
        public static List<Mob> MobTypes = new List<Mob>();

        public static void CreateMobs(List<MapRegion> regions)
        {
            Dice dice = new Dice();
            Mob newMob = new Mob();
            int healthRoll = 6;

            //Create Mob-Bitmap Pairings
            MobBitmapPairing.Add("Ettin", new Bitmap(TheCaregiver.Tiles.ettin1));
            MobBitmapPairing.Add("Rock Spider", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Terrabird", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Bandit", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Plains Giant", new Bitmap(TheCaregiver.Tiles.plainsGiant));
            MobBitmapPairing.Add("Sand Giant", new Bitmap(TheCaregiver.Tiles.sandGiant));
            MobBitmapPairing.Add("Emerald Giant", new Bitmap(TheCaregiver.Tiles.emeraldGiant));
            MobBitmapPairing.Add("Amber Giant", new Bitmap(TheCaregiver.Tiles.amberGiant));
            MobBitmapPairing.Add("Amber Beetle", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Amber Hatchling", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Orc", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Treant", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Centaur", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Squidling", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Water Spider", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Frog Jelly", new Bitmap(TheCaregiver.Tiles.frogjelly));
            MobBitmapPairing.Add("Shark", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Merman", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Great Squid", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Kobold", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Goblin", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Fire Turtle", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Hell Hound", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Fire Giant", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Swamp Turtle", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Scorpian", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Shadow", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Sand Worm", new Bitmap(TheCaregiver.Tiles.terrabird));
            MobBitmapPairing.Add("Venom Weed", new Bitmap(TheCaregiver.Tiles.venomweed));
            MobBitmapPairing.Add("Fire Ants", new Bitmap(TheCaregiver.Tiles.fireants));

            //Create Monsters

            //FOOTHILLS
            //Common -  healthRoll = dice.Roll(3, 6);
            newMob = new Mob
            {
                Name = "Ettin",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 3,
                
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "An Ettin towers above you. He looks unimpressed.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.HyleoSouthPlains, MapRegionType.HyleoPlains, MapRegionType.NordthilanHead },
                Tile = MobBitmapPairing["Ettin"],
                AllowedTiles = new int[] { 120, 109 }
            };

            MobTypes.Add(newMob);


            //UnCommon - healthRoll = dice.Roll(18, 30);
            newMob = new Mob
            {
                Name = "Rock Spider",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.HyleoSouthPlains, MapRegionType.HyleoPlains, MapRegionType.LavaRegion },
                Tile = MobBitmapPairing["Rock Spider"],
                AllowedTiles = new int[] { 120, 109, 70 },
            };

            MobTypes.Add(newMob);

            //Rare - healthRoll = dice.Roll(18, 30);
            newMob = new Mob
            {
                Name = "Terrabird",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                Introduction = "You hear a terrifying shriek from behind you. A brightly coloured giant dragon-like bird is running at you.",
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A terrifying bird griffin like creature swoops toward you!",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.NordthilanNeck, MapRegionType.LavaRegion },
                Tile = MobBitmapPairing["Terrabird"],
                AllowedTiles = new int[] { 109, 77 },

            };

            MobTypes.Add(newMob);

            //GRASS
            //Common - 
            newMob = new Mob
            {
                Name = "Bandit",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A Bandit steps out of the shadows. You are his next vicitm.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestWest, MapRegionType.NordArm, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains, MapRegionType.Otalio },
                Tile = MobBitmapPairing["Bandit"],
                AllowedTiles = new int[] { 120, 70, 89 },

            };

            MobTypes.Add(newMob);


            //Rare - 
            newMob = new Mob
            {
                Name = "Plains Giant",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "You see a Plains Giant take notice of you. That's never good.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains },
                Tile = MobBitmapPairing["Plains Giant"],
                AllowedTiles = new int[] { 120, 70, 89 },

            };

            MobTypes.Add(newMob);

            //Rare - 
            newMob = new Mob
            {
                Name = "Sand Giant",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "You turn a Sand Giant aggressively approaching you.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = {  MapRegionType.HyleoDesert },
                Tile = MobBitmapPairing["Sand Giant"],
                AllowedTiles = new int[] { 109, 58 },

            };

            MobTypes.Add(newMob);

            //Emerald Giant
            newMob = new Mob
            {
                Name = "Emerald Giant",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "An Emerald Giant towers over you. You feel powerless.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.NordthilanHead, MapRegionType.NordthilanSpine },
                Tile = MobBitmapPairing["Emerald Giant"],
                AllowedTiles = new int[] { 120, 70, 89, 109 },

            };

            MobTypes.Add(newMob);

            //Amber Giant
            newMob = new Mob
            {
                Name = "Amber Giant",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Apathy },
                Tile = MobBitmapPairing["Amber Giant"],
                AllowedTiles = new int[] { 120, 70, 89, 109 },

            };

            MobTypes.Add(newMob);

            //Amber Beetle
            newMob = new Mob
            {
                Name = "Amber Beetle",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Apathy },
                Tile = MobBitmapPairing["Amber Beetle"],
                AllowedTiles = new int[] { 120, 70, 89, 109 },

            };

            MobTypes.Add(newMob);

            //Amber Beetle
            newMob = new Mob
            {
                Name = "Amber Hatchling",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Apathy },
                Tile = MobBitmapPairing["Amber Hatchling"],
                AllowedTiles = new int[] { 120, 70, 89, 109 },

            };

            MobTypes.Add(newMob);

            //Common
            newMob = new Mob
            {
                Name = "Orc",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "An orc jumps up from behind you.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.HyleoPlains, MapRegionType.HyleoSouthPlains, MapRegionType.NordArm },
                Tile = MobBitmapPairing["Orc"],
                AllowedTiles = new int[] { 120, 70, 89 },

            };

            MobTypes.Add(newMob);

            //Rare -Treant
            newMob = new Mob
            {
                Name = "Treant",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.NordthilanNeck, MapRegionType.NordthilanHead, MapRegionType.NordthilanBelly },
                Tile = MobBitmapPairing["Treant"],
                AllowedTiles = new int[] { 89 },

            };

            MobTypes.Add(newMob);


            //UnCommon
            newMob = new Mob
            {
                Name = "Centaur",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A centaur gallops toward you, hate in his eyes!",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.LavaRegion, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.NordthilanNeck },
                Tile = MobBitmapPairing["Centaur"],
                AllowedTiles = new int[] { 120, 77, 109 },

            };

            MobTypes.Add(newMob);

            //OCEAN
            //Create the Mob
            //Common
            newMob = new Mob
            {
                Name = "Squidling",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 3,
                
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Ocean, MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly },
                Tile = MobBitmapPairing["Squidling"],
                AllowedTiles = new int[] { 44, 46 }
            };

            MobTypes.Add(newMob);

            //Water Spider - Common
            newMob = new Mob
            {
                Name = "Water Spider",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 3,
                
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A water spider swims after you.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Ocean, MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly },
                Tile = MobBitmapPairing["Water Spider"],
                AllowedTiles = new int[] { 44 }
            };

            MobTypes.Add(newMob);

            //Frog Jelly - UnCommon
            newMob = new Mob
            {
                Name = "Frog Jelly",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 3,
                
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A terrifying gelatinous frog like creature jumps at you!",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Swamp, MapRegionType.HyleoSouthPlains, MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast },
                Tile = MobBitmapPairing["Frog Jelly"],
                AllowedTiles = new int[] { 44, 115 }
            };

            MobTypes.Add(newMob);

            //Shark - Uncommon
            newMob = new Mob
            {
                Name = "Shark",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 3,
                Introduction = ".",
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "You see the dorsal fin of a hungry shark beside you.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.NordArm, MapRegionType.NordthilanBelly, MapRegionType.Otalio, MapRegionType.Ocean },
                Tile = MobBitmapPairing["Shark"],
                AllowedTiles = new int[] { 44, 46 }
            };

            MobTypes.Add(newMob);

            //Merman - Uncommon
            newMob = new Mob
            {
                Name = "Merman",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 3,
                Introduction = ".",
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.NordArm, MapRegionType.NordthilanBelly, MapRegionType.Ocean },
                Tile = MobBitmapPairing["Merman"],
                AllowedTiles = new int[] { 44, 46 }
            };

            MobTypes.Add(newMob);

            //Great Squid - Rare
            newMob = new Mob
            {
                Name = "Great Squid",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 3,
                
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A huge many-armed beast surfaces beside you. It's a Giant Squid!",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Ocean, MapRegionType.Otalio },
                Tile = MobBitmapPairing["Great Squid"],
                AllowedTiles = new int[] { 46 }
            };

            MobTypes.Add(newMob);

            //Kobold - Common
            newMob = new Mob
            {
                Name = "Kobold",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A kobold appears beside you, ready to attack.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestWest, MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead },
                Tile = MobBitmapPairing["Kobold"],
                AllowedTiles = new int[] { 70, 89 },

            };

            MobTypes.Add(newMob);

            //Goblin - UnCommon
            newMob = new Mob
            {
                Name = "Goblin",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A goblin appears from out of the shadows.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.NordthilanHead, MapRegionType.NordthilanBelly, MapRegionType.NordthilanSpine, MapRegionType.NordthilanNeck },
                Tile = MobBitmapPairing["Goblin"],
                AllowedTiles = new int[] { 109, 89 },

            };

            MobTypes.Add(newMob);

            //Fire Turtle - Common
            newMob = new Mob
            {
                Name = "Fire Turtle",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.LavaRegion },
                Tile = MobBitmapPairing["Fire Turtle"],
                AllowedTiles = new int[] { 109, 35 },

            };

            MobTypes.Add(newMob);

            //Hell Hound - UnCommon
            newMob = new Mob
            {
                Name = "Hell Hound",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "The haunting growls of a Hell Hound fill your ears. You are not alone!",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.LavaRegion },
                Tile = MobBitmapPairing["Hell Hound"],
                AllowedTiles = new int[] { 35 },

            };

            MobTypes.Add(newMob);

            //Fire Giant
            newMob = new Mob
            {
                Name = "Fire Giant",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A firey, monstrous giant appears before you. From whence did it come? No matter, you're in trouble.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.NordArm },
                Tile = MobBitmapPairing["Fire Giant"],
                AllowedTiles = new int[] { 35, 109 },

            };

            MobTypes.Add(newMob);

            //Common -Swamp Turtle
            newMob = new Mob
            {
                Name = "Swamp Turtle",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Swamp },
                Tile = MobBitmapPairing["Swamp Turtle"],
                AllowedTiles = new int[] { 115 },

            };

            MobTypes.Add(newMob);


            //Shark - Uncommon
            newMob = new Mob
            {
                Name = "Scorpian",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 3,
                Introduction = ".",
                NumberOfAttacks = 1,
                MinHourVisible = 0,
                MaxHourVisible = 23,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "A scorpian scampers toward you, tail stinger raised.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoDesert, MapRegionType.NordthilanNeck},
                Tile = MobBitmapPairing["Scorpian"],
                AllowedTiles = new int[] { 109, 58 }
            };

            MobTypes.Add(newMob);

            //Rare - Shadow
            newMob = new Mob
            {
                Name = "Shadow",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "Shadows around your feet begin to swirl around you, forming into a dark spirit, with soulless yellow eyes.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = {MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.NordArm },
                Tile = MobBitmapPairing["Shadow"],
                AllowedTiles = new int[] { 109, 89 },

            };

            MobTypes.Add(newMob);

            //Sand Worm
            newMob = new Mob
            {
                Name = "Sand Worm",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Uncommon,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.HyleoForestEast, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead, MapRegionType.NordArm },
                Tile = MobBitmapPairing["Sand Worm"],
                AllowedTiles = new int[] { 109, 58 },

            };

            MobTypes.Add(newMob);

            //Rare - Venom Weed
            newMob = new Mob
            {
                Name = "Venom Weed",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Rare,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = false,
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Swamp, MapRegionType.HyleoForestWest, MapRegionType.HyleoSouthPlains, MapRegionType.NordthilanNeck, MapRegionType.NordthilanSpine, MapRegionType.NordthilanHead },
                Tile = MobBitmapPairing["Venom Weed"],
                AllowedTiles = new int[] { },

            };

            MobTypes.Add(newMob);

            //Common - Fire Ants
            newMob = new Mob
            {
                Name = "Fire Ants",
                Health = healthRoll,
                HealthMax = healthRoll,
                Commonality = Commonality.Common,
                Defense = 15,
                DamageMax = 6,
                
                NumberOfAttacks = 1,
                SpecialAttack = SpecialAttack.Blind,
                SpecialAttackDescription = "Bright Ray of Colour",
                MinHourVisible = 7,
                MaxHourVisible = 17,
                SuddenAppearance = true,
                Aggressive = true,
                WelcomeMessage = "You suddenly feel covered in burning, tiny bites. You've disurbed a nest of Fire Ants.",
                ChanceToFlee = 1,
                FleeThreshold = 1,
                SpawnRegion = { MapRegionType.Swamp, MapRegionType.HyleoForestEast, MapRegionType.HyleoSouthPlains, MapRegionType.NordthilanSpine, MapRegionType.NordthilanBelly, MapRegionType.NordthilanHead },
                Tile = MobBitmapPairing["Fire Ants"],
                AllowedTiles = new int[] { 58, 109 },

            };

            MobTypes.Add(newMob);
                       
        }


        private static bool FindMobs(Mob mob)
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

        public static void ReSpawnMob(List<Mob> MobList, Player player1)
        {
            // List<Mob> CandidateMobs = null;
            Mob OpponentToRemove = player1.Opponent;

            Dice dice = new Dice();
            Mob CandidateMob = null;
            Commonality commonality;
            commonality = CommonalityCheck();
            
            CandidateMob = MobTypes.Find(m => m.Commonality == commonality && m.SpawnRegion.Contains(player1.CurrentRegion.Type));

            CandidateMob.X = dice.Roll(player1.CurrentRegion.X1, player1.CurrentRegion.X2);
            CandidateMob.Y = dice.Roll(player1.CurrentRegion.Y1, player1.CurrentRegion.Y2);

            //remove as Opponent, should also remove from MobList
            player1.Opponent = null;
            MobList.Remove(OpponentToRemove);
            MobList.Add(CandidateMob);
        }

        public static List<Mob> SpawnMobs(List<MapRegion> regions)
        {
            Dice dice = new Dice();
            List<Mob> Mobs = new List<Mob>();
            List<Mob> SelectedMobs = new List<Mob>();
            Commonality commonality;
            Mob newMob;

            //OTALIO - 1 - Don't want anything here
            // MobTypes.Add(new Mob { X = dice.Roll(regions[0].X1, regions[0].X2), Y = dice.Roll(regions[0].Y1, regions[0].Y2) });

            foreach (MapRegion r in regions)
            {
                //skip Otalio
                for (int i = 1; i < r.MaxMobCount; i++)
                {
                    //What is the Commonality of the new Mob?
                    SelectedMobs = new List<Mob>();

                    //Find Mob
                    // SelectedMobs = MobTypes.FindAll(FindMobs);

                    //Commonality of Mob
                    commonality = CommonalityCheck();

                    try
                    {
                       SelectedMobs = MobTypes.FindAll(m => m.Commonality == commonality && m.SpawnRegion.Contains(r.Type));
                    }
                    catch (Exception)
                    {
                        SelectedMobs.Add(MobTypes[0]);
                    }

                    if (SelectedMobs.Count == 0)
                    {
                        SelectedMobs.Add(MobTypes[0]);
                    }

                    //take first mob - skip allowed tile test
                   // Mobs.Add(new Mob { X = dice.Roll(regions[i].X1, regions[i].X2), Y = dice.Roll(regions[i].Y1, regions[i].Y2) });
                    newMob = (Mob)SelectedMobs[0].Clone();
                    newMob.X = dice.Roll(r.X1, r.X2);
                    newMob.Y = dice.Roll(r.Y1, r.Y2);
                    Mobs.Add(newMob);

                }
            }


            return Mobs;




        }
    }
}
