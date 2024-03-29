﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCaregiver.World;
using TheCaregiver.Player1;
using TheCaregiver.Classes;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TheCaregiver.Dialogs;
using System.Diagnostics;
using TheCaregiver.Templates;

namespace TheCaregiver
{
    public partial class GameBoard : Form
    {
        public int SCREEN_DIM = 11;
        public int TILE_PIXELS = 51;
        public int WIDTH_BOARD_TILES = 11;
        public int HEIGHT_BOARD_TILES = 11;
        public int WIDTH_TILE_RADIUS = 5;
        public int WIDTH_LEFTOVER = 0;
        public int HEIGHT_LEFTOVER = 0;
        public int HEIGHT_TILE_RADIUS = 5;
        public int offset_width;
        public int offset_height;
        public Player player1;
        public Map CurrentMap { get; set; }
        List<MapRegion> regions = new List<MapRegion>();
        public List<Monster> MonsterTypes = new List<Monster>();
        public List<Monster> Monsters = new List<Monster>();
        public List<Merchant> Merchants = new List<Merchant>();
        public List<QuestPerson> QuestPeople = new List<QuestPerson>();
        public List<Weapon> Weapons = new List<Weapon>();
        public List<Armour> ArmourTypes = new List<Armour>();
        public string[,] KingdomExtract;
        public string[,] MapExtract;
        public byte[,] MapMatrix;
        public byte[,] ScreenMatrix = new byte[11, 11]; //TODO need constants
        public bool startTimers = false;
        public GameState gameState;
        protected Monster Opponent { get; set; }
        //Timers
        private List<Tile> Tiles = new List<Tile>();
        public CombatManager combatmanager = new CombatManager();
        private bool IsFirstResizeOnLoad = true;

        private List<Bitmap> MonsterTiles = new List<Bitmap>();
        private Dice dice = new Dice();
        public Town currentTown = null;
        public GameMode Mode { get; set; }

        public GameBoard(GameMode mode, Player p)
        {
            InitializeComponent();

            Mode = mode;

            if (Mode == GameMode.New)
            {
                player1 = p;
            }

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            SetupWeapons();
            SetupArmour();

            pnlDevSettings.Visible = false;
            //Create Player
            if (Mode == GameMode.New)
            {
                gameState = new GameState(Mode);

                //temp
                //  player1.DamageMax = 6;
                //  player1.Defense = 20;

                //Load Current Map into Map Array object
                // MapExtract = gameState.CurrentMap.LoadMapFromFile();
                //SpawnMonsters(regions); 
                StartNewGame();
            }
            else
            {
                player1 = new Player();
                gameState = new GameState(Mode);

                //Deserialize Save File into Classes

                var saveFilePath = Application.LocalUserAppDataPath;
                string json = "";
                using (StreamReader sr = new StreamReader(saveFilePath + @"//" + "savefile.crg"))
                {

                    //    Dictionary<string, object> dic = new Dictionary<string, object>
                    //{
                    //    { "player1", player1 },
                    //    { "gamestate", gameState}
                    //};

                    //  string json = JsonConvert.DeserializeObject(dic, Formatting.Indented);

                    try
                    {
                        json = sr.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                //player1
                player1 = JsonConvert.DeserializeObject<Player>(dic["player1"].ToString());
                //gamestate
                gameState = JsonConvert.DeserializeObject<GameState>(dic["gamestate"].ToString());

                World_Refresh(player1.Map);

                MonsterHelper.CreateMonsterTypes(regions);
                Monsters.Clear();
                Monsters = JsonConvert.DeserializeObject<List<Monster>>(dic["mobs"].ToString());

                //foreach(Monster m in Monsters)
                //{
                //    if (m.Tile == null)
                //    {
                //        m.Tile = MonsterHelper.MonsterBitmapPairing[m.Name.ToString()];
                //    }
                //}
            }
            //   DrawUI();


            // inventoryPanel.Visible = false;
            // statsPanel.Visible = false;
            DrawUI();
            GameTimer.Enabled = true;

            //Getting Ready...
            if (Mode == GameMode.New)
            {
                player1.SetStartPosition(MapMatrix);
            }

            this.Focus();

            this.Text = AssemblyTitle;
        }

        public void SetupArmour()
        {
            ArmourTypes.Add(new Armour
            {
                Type = "Nothing",
                Protection = 6
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Cloth",
                Protection = 8
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Light Leather",
                Protection = 9
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Heavy Leather",
                Protection = 11
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Chainmail",
                Protection = 13
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Bandedmail",
                Protection = 14
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Platemail",
                Protection = 16
            }
            );

            ArmourTypes.Add(new Armour
            {
                Type = "Lava Forge Mail",
                Protection = 19
            }
            );

        }

        public void SetupWeapons()
        {
            Weapons.Add(new Weapon
            {
                Name = "Dagger",
                MaxDamage = 3,
                Handedness = WeaponHandedness.OneHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Sword Sword",
                MaxDamage = 4,
                Handedness = WeaponHandedness.OneHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Long Sword",
                MaxDamage = 6,
                Handedness = WeaponHandedness.OneHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Bastard Sword",
                MaxDamage = 8,
                Handedness = WeaponHandedness.OneHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Axe",
                MaxDamage = 4,
                Handedness = WeaponHandedness.OneHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "2 Handed Axe",
                MaxDamage = 6,
                Handedness = WeaponHandedness.TwoHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Battle-Axe",
                MaxDamage = 8,
                Handedness = WeaponHandedness.TwoHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Great Sword",
                MaxDamage = 10,
                Handedness = WeaponHandedness.TwoHanded
            }
            );

            Weapons.Add(new Weapon
            {
                Name = "Lava Forge Sword",
                MaxDamage = 15,
                Handedness = WeaponHandedness.TwoHanded
            }
            );
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public void Resurrection()
        {
            //return, not fully healed
            player1.Health = player1.HealthMax - 2;

            //lose one agility point - 9 lowest
            if (player1.Attribute_Agility > 9)
                player1.Attribute_Agility--;

            //lost weapon or armour??

            //random respawn in Hyleo
            UpdateActionWindow("Whatever power controls the universe, it seems they are giving you another chance.");
            UpdateActionWindow("");

            //if House, they respawn there
            if (player1.HasHouse)
            {
                gameState.CurrentMap = Atlas.Maps[Place.House];
                player1.Map = Place.House;
                player1.PreviousMapX = player1.HouseX;
                player1.PreviousMapY = player1.HouseY;

                player1.X = gameState.CurrentMap.StartX;
                player1.Y = gameState.CurrentMap.StartY;
                MapExtract = gameState.CurrentMap.LoadMapFromFile();
                TranslateMap();
                player1.CurrentTile = MapMatrix[player1.X, player1.Y];
                UpdateActionWindow("The following day, you wake up in the safety of your cottage, " + player1.HouseName);
            }
            else
            {
                player1.SetStartPosition(MapMatrix);
                UpdateActionWindow("The following day, you find yourself somewhere in the wilderness.");
            }

            //    World_Refresh(player1.Map);
            gameState.reality.Day++;
            gameState.reality.Hour = 7;
            gameState.reality.Minute = 0;
        }

        public void StartNewGame()
        {
            World_Refresh(player1.Map);
            MonsterHelper.CreateMonsterTypes(regions);

            Monsters = MonsterHelper.SpawnMonsters(regions);

            player1.CurrentState = PlayerProgress.name;

            player1.HealthMax = dice.Roll(15, 20);
            if (player1.Attribute_Constitution > 9)
            {
                player1.HealthMax += 3;
            }
            else if (player1.Attribute_Constitution > 7)
            {
                player1.HealthMax += 2;
            }
            else if (player1.Attribute_Constitution > 5)
            {
                player1.HealthMax += 1;
            }
            else
            {
                player1.HealthMax -= 1;
            }

            player1.Health = player1.HealthMax;
            player1.Attribute_Strength = player1.Attribute_Strength;
            player1.Attribute_Agility = player1.Attribute_Agility;
            player1.Attribute_Luck = player1.Attribute_Luck;
            player1.Attribute_Constitution = player1.Attribute_Constitution;
            player1.EquipedWeapon = Weapons.Find(w => w.Name == "Dagger");
            player1.EquipedArmour = ArmourTypes.Find(a => a.Type == "Cloth");

            //How many garden plot creations until seed is found?
            gameState.seedPolt = dice.Roll(5, 9);

            var saveFilePath = Application.LocalUserAppDataPath;
            if (!File.Exists(saveFilePath + @"//" + "savefile.crg"))
            {
                File.CreateText(saveFilePath + @"//" + "savefile.crg");
            }

            UpdateActionWindow(player1.Name + ", Your Adventure Begins.");
            UpdateActionWindow("It's a lovely spring day. With winter finally over, you are ready to be on your own, apart from your family, crafting your own path.");
            UpdateActionWindow("You decide to make your start in the wilds of Hyleo. What will be your destiny? What will you learn about yourself? There is nothing more important than leading a meaningful life.");
            UpdateActionWindow("");
        }



        public void LoadGame()
        {
            UpdateActionWindow("Welcome back");
        }

        public void UpdateActionWindow(string s)
        {
            ActionWindow.AppendText(Environment.NewLine + "  " + s);

            ActionWindow.SelectionStart = ActionWindow.Text.Length;
            // scroll it automatically
            ActionWindow.ScrollToCaret();
        }

        public void AppendActionWindow(string s)
        {
            ActionWindow.Text = ActionWindow.Text + s;

            ActionWindow.SelectionStart = ActionWindow.Text.Length;
            // scroll it automatically
            ActionWindow.ScrollToCaret();
        }


        public void UpdateActionWindow_ShowItems(string message, string[] items)
        {
            int x = 0;
            ActionWindow.AppendText(Environment.NewLine + Environment.NewLine + "  " + message);
            foreach (string s in items)
            {
                x++;
                ActionWindow.AppendText(Environment.NewLine + String.Format("     {0}) {1}", x, s));
            }

            ActionWindow.AppendText(Environment.NewLine + "Choice? ");

            ActionWindow.SelectionStart = ActionWindow.Text.Length;
            // scroll it automatically
            ActionWindow.ScrollToCaret();
        }

        public void TranslateMap()
        {

            MapMatrix = new byte[gameState.CurrentMap.X, gameState.CurrentMap.Y];


            for (var x = 0; x < gameState.CurrentMap.X; x++)
            {
                for (var y = 0; y < gameState.CurrentMap.Y; y++)
                {
                    MapMatrix[x, y] = Encoding.Default.GetBytes(MapExtract[x, y])[0];
                }
            }

        }


        private void Assign_Tile_By_Ascii()
        {
            Tile tmpTile;
            //WILDERNESS
            Tiles.Clear();
            Tiles.Add(new Tile
            {
                Letter = 'p',
                Picture = new Bitmap(TheCaregiver.Tiles.patch)
            });

            Tiles.Add(new Tile
            {
                Letter = 's',
                Picture = new Bitmap(TheCaregiver.Tiles.swamp)
            });

            Tiles.Add(new Tile
            {
                Letter = '*',
                Picture = new Bitmap(TheCaregiver.Tiles.snow)
            });

            Tiles.Add(new Tile
            {
                Letter = '!',
                Picture = new Bitmap(TheCaregiver.Tiles.swamptree)
            });

            Tiles.Add(new Tile
            {
                Letter = 'Y',
                Picture = new Bitmap(TheCaregiver.Tiles.trees)
            });

            Tiles.Add(new Tile
            {
                Letter = 'F',
                Picture = new Bitmap(TheCaregiver.Tiles.forest)
            }); ;

            Tiles.Add(new Tile
            {
                Letter = 'M',
                Picture = new Bitmap(TheCaregiver.Tiles.mount)
            }); ;

            Tiles.Add(new Tile
            {
                Letter = 'm',
                Picture = new Bitmap(TheCaregiver.Tiles.foothill)
            });

            Tiles.Add(new Tile
            {
                Letter = 'v',
                Picture = new Bitmap(TheCaregiver.Tiles.cactus)
            });

            Tiles.Add(new Tile
            {
                Letter = ':',
                Picture = new Bitmap(TheCaregiver.Tiles.desert)
            });

            Tiles.Add(new Tile
            {
                Letter = 'x',
                Picture = new Bitmap(TheCaregiver.Tiles.grass)
            });

            Tiles.Add(new Tile
            {
                Letter = 'e',
                Picture = new Bitmap(TheCaregiver.Tiles.redbloom)
            });

            Tiles.Add(new Tile
            {
                Letter = 'f',
                Picture = new Bitmap(TheCaregiver.Tiles.purbloom)
            });

            Tiles.Add(new Tile
            {
                Letter = 'r',
                Picture = new Bitmap(TheCaregiver.Tiles.rocks)
            });

            //PLACES

            Tiles.Add(new Tile
            {
                Letter = 'y',
                Picture = new Bitmap(TheCaregiver.Tiles.castleL)
            });

            Tiles.Add(new Tile
            {
                Letter = 'z',
                Picture = new Bitmap(TheCaregiver.Tiles.castleR)
            });

            Tiles.Add(new Tile
            {
                Letter = 'H',
                Picture = new Bitmap(TheCaregiver.Tiles.house)
            });

            Tiles.Add(new Tile
            {
                Letter = 'G',
                Picture = new Bitmap(TheCaregiver.Tiles.garden)
            });

            Tiles.Add(new Tile
            {
                Letter = 't',
                Picture = new Bitmap(TheCaregiver.Tiles.town)
            });

            //FEATURES

            Tiles.Add(new Tile
            {
                Letter = 'W',
                Picture = new Bitmap(TheCaregiver.Tiles.wall)
            });

            Tiles.Add(new Tile
            {
                Letter = 'V',
                Picture = new Bitmap(TheCaregiver.Tiles.brickwall)
            });
            Tiles.Add(new Tile
            {
                Letter = 'O',
                Picture = new Bitmap(TheCaregiver.Tiles.opendoor)
            });

            Tiles.Add(new Tile
            {
                Letter = 'S',
                Picture = new Bitmap(TheCaregiver.Tiles.shutdoor)
            });
            Tiles.Add(new Tile
            {
                Letter = 'P',
                Picture = new Bitmap(TheCaregiver.Tiles.opendoorH)
            });

            Tiles.Add(new Tile
            {
                Letter = 'T',
                Picture = new Bitmap(TheCaregiver.Tiles.shutdoorH)
            });
            Tiles.Add(new Tile
            {
                Letter = 'D',
                Picture = new Bitmap(TheCaregiver.Tiles.drawbrid)
            });

            Tiles.Add(new Tile
            {
                Letter = 'C',
                Picture = new Bitmap(TheCaregiver.Tiles.counter)
            });

            Tiles.Add(new Tile
            {
                Letter = 'B',
                Picture = new Bitmap(TheCaregiver.Tiles.bed)
            });

            Tiles.Add(new Tile
            {
                Letter = '=',
                Picture = new Bitmap(TheCaregiver.Tiles.rockpath)
            });

            Tiles.Add(new Tile
            {
                Letter = '~',
                Picture = new Bitmap(TheCaregiver.Tiles.FOW)
            });

            Tiles.Add(new Tile
            {
                Letter = '$',
                Picture = new Bitmap(TheCaregiver.Tiles.sign)
            });

            //WATER
            //shallow
            tmpTile = new Tile
            {
                Letter = ',',
                Picture = new Bitmap(TheCaregiver.Tiles.sea1)

            };
            tmpTile.setMovingPicture(0, new Bitmap(TheCaregiver.Tiles.sea1));
            tmpTile.setMovingPicture(1, new Bitmap(TheCaregiver.Tiles.sea2));
            tmpTile.setMovingPicture(2, new Bitmap(TheCaregiver.Tiles.sea3));
            tmpTile.setMovingPicture(3, new Bitmap(TheCaregiver.Tiles.sea4));
            Tiles.Add(tmpTile);
            tmpTile = null;

            //deep
            tmpTile = new Tile
            {
                Letter = '.',
                Picture = new Bitmap(TheCaregiver.Tiles.deepsea)
            };
            tmpTile.setMovingPicture(0, new Bitmap(TheCaregiver.Tiles.deepsea));
            tmpTile.setMovingPicture(1, new Bitmap(TheCaregiver.Tiles.deepsea2));
            tmpTile.setMovingPicture(2, new Bitmap(TheCaregiver.Tiles.deepsea3));
            tmpTile.setMovingPicture(3, new Bitmap(TheCaregiver.Tiles.deepsea4));
            Tiles.Add(tmpTile);
            tmpTile = null;

            //searock
            tmpTile = new Tile
            {
                Letter = '%',
                Picture = new Bitmap(TheCaregiver.Tiles.searock1)
            };
            tmpTile.setMovingPicture(0, new Bitmap(TheCaregiver.Tiles.searock1));
            tmpTile.setMovingPicture(1, new Bitmap(TheCaregiver.Tiles.searock2));
            tmpTile.setMovingPicture(2, new Bitmap(TheCaregiver.Tiles.searock3));
            tmpTile.setMovingPicture(3, new Bitmap(TheCaregiver.Tiles.searock4));
            Tiles.Add(tmpTile);
            tmpTile = null;

            //waterfall
            tmpTile = new Tile
            {
                Letter = '[',
                Picture = new Bitmap(TheCaregiver.Tiles.waterfall1)
            };
            tmpTile.setMovingPicture(0, new Bitmap(TheCaregiver.Tiles.waterfall1));
            tmpTile.setMovingPicture(1, new Bitmap(TheCaregiver.Tiles.waterfall2));
            tmpTile.setMovingPicture(2, new Bitmap(TheCaregiver.Tiles.waterfall3));
            tmpTile.setMovingPicture(3, new Bitmap(TheCaregiver.Tiles.waterfall4));
            Tiles.Add(tmpTile);
            tmpTile = null;

            //fire
            tmpTile = new Tile
            {
                Letter = '{',
                Picture = new Bitmap(TheCaregiver.Tiles.waterfall1)
            };
            tmpTile.setMovingPicture(0, new Bitmap(TheCaregiver.Tiles.waterfall1));
            tmpTile.setMovingPicture(1, new Bitmap(TheCaregiver.Tiles.waterfall2));
            tmpTile.setMovingPicture(2, new Bitmap(TheCaregiver.Tiles.waterfall3));
            tmpTile.setMovingPicture(3, new Bitmap(TheCaregiver.Tiles.waterfall4));
            Tiles.Add(tmpTile);
            tmpTile = null;

            //LAVA
            tmpTile = new Tile
            {
                Letter = '#',
                Picture = new Bitmap(TheCaregiver.Tiles.lava1)

            };
            tmpTile.setMovingPicture(0, new Bitmap(TheCaregiver.Tiles.lava1));
            tmpTile.setMovingPicture(1, new Bitmap(TheCaregiver.Tiles.lava2));
            tmpTile.setMovingPicture(2, new Bitmap(TheCaregiver.Tiles.lava3));
            tmpTile.setMovingPicture(3, new Bitmap(TheCaregiver.Tiles.lava4));
            Tiles.Add(tmpTile);
            tmpTile = null;

            Tiles.Add(new Tile
            {
                Letter = 'j',
                Picture = new Bitmap(TheCaregiver.Tiles.bridge)
            });
        }
        
        private void GameBoard_Resize(object sender, EventArgs e)
        {
            if (!IsFirstResizeOnLoad)
            {
                DrawUI();
            }
        }

        private void CalculateStuff()
        {
            panel1.Width = 270;

            int newWidthInTiles = (this.Width - panel1.Width) / TILE_PIXELS;
            WIDTH_LEFTOVER = 0;
            if (newWidthInTiles % 2 == 0)
            {
                newWidthInTiles -= 1;
                WIDTH_LEFTOVER = this.Width - (newWidthInTiles * TILE_PIXELS) + panel1.Width + TILE_PIXELS;
            }
            else
            {
                WIDTH_LEFTOVER = this.Width - (newWidthInTiles * TILE_PIXELS) + panel1.Width;
            }

            panel1.Left = newWidthInTiles * TILE_PIXELS;
            panel1.Width += WIDTH_LEFTOVER; //this widens to make up for leftover and also removing tile if it was EVEN

            WIDTH_TILE_RADIUS = (newWidthInTiles - 1) / 2;
            WIDTH_BOARD_TILES = newWidthInTiles;

            int newHeightInTiles = (this.Height) / TILE_PIXELS;
            HEIGHT_LEFTOVER = this.Height - (newHeightInTiles * TILE_PIXELS);

            if (newHeightInTiles % 2 == 0)
            {
                newHeightInTiles -= 1;
                HEIGHT_LEFTOVER += TILE_PIXELS;
            }

            HEIGHT_TILE_RADIUS = (newHeightInTiles - 1) / 2;
            HEIGHT_BOARD_TILES = newHeightInTiles;

        }
        /// <summary>
        /// This is called when there is a resize or on first load        /// 
        /// </summary>
        public void DrawUI()
        {           
            //set defaults
            panel1.Width = 270;
            WIDTH_LEFTOVER = 0;
            int GAMEBOARD_WIDTH = this.Width;
            int GAMEBOARD_HEIGHT = this.Height;
            int GAMEBOARD_CANVAS_WIDTH_NET = 0;
            int GAMEBOARD_CANVAS_WIDTH_ADJ = 0;
            int GAMEBOARD_CANVAS_HEIGHT_NET = 0;
            int GAMEBOARD_CANVAS_HEIGHT_ADJ = 0;

            GAMEBOARD_CANVAS_WIDTH_NET = GAMEBOARD_WIDTH - panel1.Width;
            WIDTH_BOARD_TILES = Math.DivRem(GAMEBOARD_CANVAS_WIDTH_NET, TILE_PIXELS, out WIDTH_LEFTOVER);

            //if number of tiles wide is even, we need to adjust
            if (WIDTH_BOARD_TILES % 2 == 0)
            {
                WIDTH_BOARD_TILES--;
                GAMEBOARD_CANVAS_WIDTH_NET -= TILE_PIXELS;
                panel1.Width += TILE_PIXELS;
            }
            panel1.Width += WIDTH_LEFTOVER;

            WIDTH_TILE_RADIUS = (WIDTH_BOARD_TILES - 1) / 2;
            //gameboard pixels height
            GAMEBOARD_CANVAS_WIDTH_ADJ = WIDTH_BOARD_TILES * TILE_PIXELS;
            panel1.Left = GAMEBOARD_CANVAS_WIDTH_ADJ;            

            //add the leftover amount to widen panel1
            panel1.Width += WIDTH_LEFTOVER;

            ActionWindow.Width = panel1.Width;
            CommandArea.Width = panel1.Width;
            panel3.Width = panel1.Width;
            
            //HEIGHT ADJUSTMENTS
            GAMEBOARD_CANVAS_HEIGHT_NET = GAMEBOARD_HEIGHT;
            HEIGHT_BOARD_TILES = Math.DivRem(GAMEBOARD_CANVAS_HEIGHT_NET, TILE_PIXELS, out HEIGHT_LEFTOVER);

            //if number of tiles high is even, we need to adjust
            if (HEIGHT_BOARD_TILES%2 == 0)
            {
                //HEIGHT_BOARD_TILES--;
                GAMEBOARD_CANVAS_HEIGHT_NET -= TILE_PIXELS;
                HEIGHT_BOARD_TILES = Math.DivRem(GAMEBOARD_CANVAS_HEIGHT_NET, TILE_PIXELS, out HEIGHT_LEFTOVER);
            }

            HEIGHT_TILE_RADIUS = (HEIGHT_BOARD_TILES - 1) / 2;
            //gameboard pixels height
            GAMEBOARD_CANVAS_HEIGHT_ADJ = HEIGHT_BOARD_TILES * TILE_PIXELS;
            panel1.Height = GAMEBOARD_CANVAS_HEIGHT_ADJ;
            
            ActionWindow.Height = GAMEBOARD_CANVAS_HEIGHT_ADJ - panel3.Height - CommandArea.Height - toolStrip1.Height;
            CommandArea.Top = ActionWindow.Height + ActionWindow.Top;
            panel3.Top = CommandArea.Top + CommandArea.Height;
        }

        public void CreateScreen()
        {
            //screen boundaries - this is tile based, not pixel based
            //this is the area in the ASCII file that will be visible
            int MapFile_Border_Left = player1.X - WIDTH_TILE_RADIUS;
            int MapFile_Border_Right = player1.X + WIDTH_TILE_RADIUS;
            int MapFile_Border_Top = player1.Y - HEIGHT_TILE_RADIUS;
            int MapFile_Border_Bottom = player1.Y + HEIGHT_TILE_RADIUS;

            ScreenMatrix = new byte[WIDTH_BOARD_TILES, HEIGHT_BOARD_TILES];

            int x;
            int j = 0;

            //Moving down in the map increments Y
            for (int MapY = MapFile_Border_Top; MapY <= MapFile_Border_Bottom; MapY++)
            {
                x = 0;
                //Moving left to right in the map increments X
                for (int MapX = MapFile_Border_Left; MapX <= MapFile_Border_Right; MapX++)
                {
                    try
                    {
                        if ((MapX < 0) || (MapX >= gameState.CurrentMap.X) || (MapY < 0) || (MapY >= gameState.CurrentMap.Y))
                        {
                            ScreenMatrix[x, j] = 0;
                        }
                        else
                        {
                            ScreenMatrix[x, j] = MapMatrix[MapX, MapY];
                        }

                    }
                    catch (Exception)
                    {

                    }

                    x++;
                }

                j++;
            }

            player1.CurrentTile = ScreenMatrix[WIDTH_TILE_RADIUS, HEIGHT_TILE_RADIUS];

            //Monsters
            //search collection of Monsters for an X -5 or +5 and Y -5 and + 5 of player
            //   Monsters[0].CurrentTile = ScreenMatrix[3, 3];


        }


        public void DrawScreen()
        {

            int tileWidth = TILE_PIXELS;
            int tileHeight = TILE_PIXELS;
            PictureBox p;
            Point loc;
            Graphics G;
            Bitmap tile;
            Point[] mapArray = new Point[1];
            Bitmap sourceBmp = null;
            Bitmap player1Bmp = null;
            Bitmap defaultTile = Tiles.Single(t => t.Letter == '~').Picture;
            Bitmap mob1Bmp = null;
            Bitmap merchantBmp = null;
            Bitmap QuestPersonBmp = null;
            List<Monster> MonstersOnScreen = new List<Monster>();
            List<Merchant> MerchantOnScreen = new List<Merchant>();
            List<QuestPerson> PeopleOnScreen = new List<QuestPerson>();

            Monster monster;
            Merchant merchant;
            QuestPerson person;

            //getting four corners of screen coordinates 
            int x1 = player1.X - WIDTH_TILE_RADIUS;
            if (x1 < 0) x1 = 0;

            int x2 = player1.X + WIDTH_TILE_RADIUS;
            if (x2 > gameState.CurrentMap.X) x2 = gameState.CurrentMap.X;

            int y1 = player1.Y - HEIGHT_TILE_RADIUS;
            if (y1 < 0) y1 = 0;

            int y2 = player1.Y + HEIGHT_TILE_RADIUS;
            if (y2 > gameState.CurrentMap.Y) y2 = gameState.CurrentMap.Y;

            if (gameState.CurrentMap.MAPID == Place.Wilderness)
            {
                foreach (Monster m in Monsters)
                {
                    //determine if on screen somehow
                    if (IsTargetOnScreen(x1, x2, y1, y2, m))
                    {
                        //MonstersOnScreen.Add Monster with a new X, Y for screen
                        MonstersOnScreen.Add(m);
                    }
                }

                //then we draw MonstersOnScreen only
            }
            else if (gameState.CurrentMap.MAPID == Place.Lancer)
            {
                foreach (Merchant m in Merchants)
                {
                    //determine if on screen somehow
                    if (IsTargetOnScreen(x1, x2, y1, y2, m))
                    {
                        //MonstersOnScreen.Add Monster with a new X, Y for screen
                        MerchantOnScreen.Add(m);
                    }
                }

                foreach (QuestPerson m in QuestPeople)
                {
                    //determine if on screen somehow
                    if (IsTargetOnScreen(x1, x2, y1, y2, m))
                    {
                        //MonstersOnScreen.Add Monster with a new X, Y for screen
                        PeopleOnScreen.Add(m);
                    }
                }
            }

            for (int j = HEIGHT_BOARD_TILES - 1; j >= 0; j--)
            {
                for (int i = 0; i <= WIDTH_BOARD_TILES - 1; i++)
                {
                    if (startTimers)
                    {
                        try
                        {
                            p = (PictureBox)this.Controls.Find((tileWidth * i).ToString() + "_" + (tileHeight * j).ToString(), true)[0];
                        }
                        catch (Exception)
                        {
                            p = new PictureBox();
                        }
                    }
                    else
                    {
                        p = new PictureBox();
                    }

                    p.Width = tileWidth;
                    p.Height = tileHeight;
                    p.Left = tileWidth * i;
                    p.Top = tileHeight * j;
                    p.Name = p.Left.ToString() + "_" + p.Top.ToString();
                    loc = new Point(tileWidth * i, tileHeight * j);

                    //    mob1Bmp = new Bitmap(TheCaregiver.Tiles.ettin1);

                    //Player1
                    if ((j == HEIGHT_TILE_RADIUS) && (i == WIDTH_TILE_RADIUS))
                    {
                        player1Bmp = new Bitmap(TheCaregiver.Tiles.player1);
                        if (player1.Sleeping)
                        {
                            //sleeping - outdoor
                            if (player1.SleepTicker == 0)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.sleep1);
                            else if (player1.SleepTicker == 1)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.sleep2);
                            else if (player1.SleepTicker == 2)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.sleep3);
                            else if (player1.SleepTicker == 3)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.sleep4);
                        }


                        else if (player1.Sailing && gameState.CurrentMap.MAPID == Place.Wilderness)
                        {
                            //sailing
                            player1Bmp = new Bitmap(TheCaregiver.Tiles.raft);
                        }

                        else if (player1.Fishing && gameState.CurrentMap.MAPID == Place.Wilderness)
                        {
                            //fishing
                            // if mod is 0 then cast else no cast
                            if (player1.FishTicker == 0)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.fishing_casting);
                            else
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.fishing_linein);
                        }

                        else if (player1.Chopping && gameState.CurrentMap.MAPID == Place.Wilderness)
                        {
                            //chopping trees

                            // if mod is 0 then swing else no swing
                            if (player1.ChopTicker == 0)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.chopping_swing);
                            else
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.chopping);
                        }

                        else
                        {
                            //Warrior
                            player1Bmp = new Bitmap
                                (TheCaregiver.Tiles.player1);
                        }
                    }
                    int lavaRoll;
                    //Determine BMP to use
                    try
                    {
                        switch ((char)ScreenMatrix[i, j])
                        {
                            case ',':
                            case '.':
                                sourceBmp = (Tiles.Single(t => (t.Letter == (char)ScreenMatrix[i, j])).getMovingPicture(gameState.waterTicker));
                                break;

                            case '%':
                                sourceBmp = (Tiles.Single(t => (t.Letter == (char)ScreenMatrix[i, j])).getMovingPicture(gameState.waterTicker));
                                break;

                            case '[':
                                sourceBmp = (Tiles.Single(t => (t.Letter == (char)ScreenMatrix[i, j])).getMovingPicture(gameState.waterTicker));
                                break;

                            case '#':
                                lavaRoll = dice.Roll(0, 3);
                                sourceBmp = (Tiles.Single(t => (t.Letter == (char)ScreenMatrix[i, j])).getMovingPicture(lavaRoll));
                                break;
                            case 'G':
                                //if in Wilderness, the garden belongs to player1
                                if (player1.Map == Atlas.Maps[Place.Wilderness].MAPID)
                                {
                                    int gX = player1.X - (WIDTH_TILE_RADIUS - i);
                                    int gY = player1.Y - (HEIGHT_TILE_RADIUS - j);

                                    //will this be an issue if near end of map (no gardens there anyway)
                                    GardenPlot g = player1.GardenPlots.Find(w => w.X == gX && w.Y == gY);

                                    sourceBmp = g.GetGardenTileToDraw();
                                }
                                //Otherwise, in a town where the crops are always ready
                                else
                                {
                                    sourceBmp = new Bitmap(TheCaregiver.Tiles.gardenready);
                                }
                                break;

                            default:
                                sourceBmp = Tiles.Single(t => t.Letter == (char)ScreenMatrix[i, j]).Picture;
                                break;
                        }


                    }
                    catch (System.InvalidOperationException e)
                    {
                        sourceBmp = defaultTile;
                    }


                    p.SizeMode = PictureBoxSizeMode.StretchImage;

                    /* Centre of screen - this is the player tile
                     * Player tile is a transparent .png written on top of the background tile
                     */
                    if ((j == HEIGHT_TILE_RADIUS) && (i == WIDTH_TILE_RADIUS))
                    {
                        var overlay = new Bitmap(p.Width, p.Height);
                        G = Graphics.FromImage(overlay);
                        G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                        G.DrawImage(sourceBmp, 0, 0);
                        G.DrawImage(player1Bmp, 0, 0);
                        p.Image = overlay;
                    }
                    else
                    {
                        tile = new Bitmap(tileWidth, tileHeight);
                        G = Graphics.FromImage(tile);
                        G.DrawImage(sourceBmp, loc);
                        p.Image = sourceBmp;
                    }


                    if (gameState.CurrentMap.MAPID == Place.Wilderness)
                    {
                        monster = MonstersOnScreen.Find(x => x.ScreenX == i && x.ScreenY == j);

                        if (monster != null)
                        {
                            mob1Bmp = monster.Tile;
                            var mobOverlay = new Bitmap(p.Width, p.Height);
                            G = Graphics.FromImage(mobOverlay);
                            G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                            G.DrawImage(sourceBmp, 0, 0);
                            G.DrawImage(mob1Bmp, 0, 0);
                            p.Image = mobOverlay;
                        }
                    }

                    //TODO Fix Merchant Issue
                    else if (gameState.CurrentMap.MAPID == Place.Lancer)
                    {
                        merchant = MerchantOnScreen.Find(x => x.ScreenX == i && x.ScreenY == j);

                        if (merchant != null)
                        {
                            merchantBmp = merchant.Tile;
                            var merchantOverlay = new Bitmap(p.Width, p.Height);
                            G = Graphics.FromImage(merchantOverlay);
                            G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                            G.DrawImage(sourceBmp, 0, 0);
                            G.DrawImage(merchantBmp, 0, 0);
                            p.Image = merchantOverlay;
                        }

                        person = PeopleOnScreen.Find(x => x.ScreenX == i && x.ScreenY == j);

                        if (person != null)
                        {
                            QuestPersonBmp = person.Tile;
                            var personOverlay = new Bitmap(p.Width, p.Height);
                            G = Graphics.FromImage(personOverlay);
                            G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                            G.DrawImage(sourceBmp, 0, 0);
                            G.DrawImage(QuestPersonBmp, 0, 0);
                            p.Image = personOverlay;
                        }
                    }


                    p.Location = loc;
                    p.Tag = loc;

                    this.Controls.Add(p);

                }
            }
            IsFirstResizeOnLoad = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == Keys.Tab)
            //{
            //    // Handle key at form level.
            //    // Do not send event to focused control by returning true.
            //    return true;
            //}
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void BuildMonsterTypes()
        {
            MonsterTiles.Add(new Bitmap(TheCaregiver.Tiles.ettin1));
            MonsterTiles.Add(new Bitmap(TheCaregiver.Tiles.partman_trans));

        }

        private bool IsTargetOnScreen(int x1, int x2, int y1, int y2, Object o)
        {
            bool onScreen = false;

            if (o is Merchant)
            {
                Merchant m = (Merchant)o;

                if ((m.X >= x1) && (m.X <= x2) && (m.Y >= y1) && (m.Y <= y2))
                {
                    onScreen = true;
                    m.ScreenX = Math.Abs(x1 - m.X);
                    m.ScreenY = Math.Abs(y1 - m.Y);

                }
            }
            else if (o is Monster)
            {
                Monster meanie = (Monster)o;

                if ((meanie.X >= x1) && (meanie.X <= x2) && (meanie.Y >= y1) && (meanie.Y <= y2))
                {
                    onScreen = true;
                    meanie.ScreenX = Math.Abs(x1 - meanie.X);
                    meanie.ScreenY = Math.Abs(y1 - meanie.Y);
                }
            }
            else if (o is QuestPerson)
            {
                QuestPerson meanie = (QuestPerson)o;

                if ((meanie.X >= x1) && (meanie.X <= x2) && (meanie.Y >= y1) && (meanie.Y <= y2))
                {
                    onScreen = true;
                    meanie.ScreenX = Math.Abs(x1 - meanie.X);
                    meanie.ScreenY = Math.Abs(y1 - meanie.Y);
                }
            }

            return onScreen;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //  int roll = DiceRoll.Roll(9);
            int roll = dice.Roll(1, 9);
            int tempValue = 0;

            if (player1.GardenPlots.Count > 0)
            {
                foreach (GardenPlot gp in player1.GardenPlots)
                {
                    if (gp.GrowthStage != GardenGrowthStages.ReadyToHarvest)
                    {
                        gp.GrowTicker--;
                        if (gp.GrowTicker < 0)
                        {
                            gp.GrowthStage = GardenGrowthStages.ReadyToHarvest;
                            gp.GrowTicker = 10;
                        }
                        else
                        {
                            gp.GrowthStage = GardenGrowthStages.Growing;
                        }

                    }

                }

            }


            #region Game Clock
            //gameState.reality Check
            gameState.reality.Minute++;

            if (gameState.reality.Hour == 24)
            {
                gameState.reality.Day++;
                gameState.reality.Hour = gameState.reality.Hour - 24;
                gameState.reality.Minute = 0;
            }

            if (gameState.reality.Minute > 60)
            {
                gameState.reality.Hour++;
                gameState.reality.Minute = 0;

                if (gameState.reality.Hour > 24)
                {
                    gameState.reality.Day++;
                    gameState.reality.Hour = 0;

                    if (gameState.reality.Day == 2 && !player1.HasHouse)
                    {
                        UpdateActionWindow("It's a new day. I need to start thinking about where my path may lead me. For now, it's time to build myself a house. From there, my life can begin.");
                    }

                    if (gameState.reality.Day > 90)
                    {
                        if (gameState.reality.Day > 360)
                        {
                            gameState.reality.Season = Season.winter;
                            gameState.reality.Year++;
                            UpdateActionWindow("A new year is upon us. This is the first day of the year " + gameState.reality.Year.ToString());
                        }
                        else
                        {
                            gameState.reality.Season++;

                            switch (gameState.reality.Season)
                            {
                                case Season.autumn:
                                    UpdateActionWindow("A cool wind starts to blow from the west. Autumn has come at last.");
                                    World_Refresh(player1.Map);
                                    break;

                                case Season.winter:
                                    UpdateActionWindow("The air is cool and crisp. The woods are silent these days and the flowers are resting. Winter has come.");
                                    World_Refresh(player1.Map);
                                    break;

                                case Season.spring:

                                    UpdateActionWindow("From the branches above you hear the sweet, twiriping of baby birds. Spring has sprung.");
                                    World_Refresh(player1.Map);
                                    break;

                                case Season.summer:

                                    UpdateActionWindow("You stop for a moment and look around. The trees are in full green and the grasses are tall and soft. The summer sun has at least risen. ");
                                    World_Refresh(player1.Map);
                                    break;

                                default:
                                    break;


                            }
                        }
                    }
                }
            }


            lblReality.Text = String.Format("{0} Day:{1} - {2}:00", gameState.reality.Season.ToString(), gameState.reality.Day, gameState.reality.Hour.ToString("D2"));

            #endregion

            #region Monster Movement

            bool movecheck;
            movecheck = false;

            if (gameState.CurrentMap.MAPID == Place.Wilderness)
            {
                foreach (Monster m in Monsters)
                {
                    //if this Monster is attacking the Player, they don't move
                    if (m.CombatMode)
                    {
                        // AttackTurn(m);
                    }
                    else
                    {
                        movecheck = false;
                        m.checked_north = false;
                        m.checked_south = false;
                        m.checked_west = false;
                        m.checked_east = false;

                        //Move in an allowed direction
                        // - they move either N,S,W,E, not diagnol

                        do
                        {
                            switch (dice.Roll(1, 4))
                            {
                                case 1:
                                    if (!m.checked_north)
                                    {
                                        if (MapHelper.BoundaryCheck(m.X, m.Y - 1, gameState.CurrentMap))
                                        {
                                            if (m.CheckNextStep(MapMatrix[m.X, m.Y - 1]))
                                            {
                                                m.Y--;
                                                m.FormerTile = m.CurrentTile;
                                                m.CurrentTile = MapMatrix[m.X, m.Y];
                                            }
                                        }
                                        movecheck = true;
                                        m.checked_north = true;
                                    }
                                    break;
                                case 2:
                                    if (!m.checked_south)
                                    {
                                        if (MapHelper.BoundaryCheck(m.X, m.Y + 1, gameState.CurrentMap))
                                        {
                                            if (m.CheckNextStep(MapMatrix[m.X, m.Y + 1]))
                                            {
                                                m.Y++;
                                                m.FormerTile = m.CurrentTile;
                                                m.CurrentTile = MapMatrix[m.X, m.Y];
                                            }
                                        }
                                        movecheck = true;
                                        m.checked_south = true;
                                    }
                                    break;
                                case 3:
                                    if (!m.checked_west)
                                    {
                                        if (MapHelper.BoundaryCheck(m.X - 1, m.Y, gameState.CurrentMap))
                                        {
                                            if (m.CheckNextStep(MapMatrix[m.X - 1, m.Y]))
                                            {
                                                m.X--;
                                                m.FormerTile = m.CurrentTile;
                                                m.CurrentTile = MapMatrix[m.X, m.Y];
                                            }
                                        }
                                        movecheck = true;
                                        m.checked_west = true;
                                    }
                                    break;
                                case 4:
                                    if (!m.checked_east)
                                    {
                                        if (MapHelper.BoundaryCheck(m.X + 1, m.Y, gameState.CurrentMap))
                                        {
                                            if (m.CheckNextStep(MapMatrix[m.X + 1, m.Y]))
                                            {
                                                m.X++;
                                                m.FormerTile = m.CurrentTile;
                                                m.CurrentTile = MapMatrix[m.X, m.Y];
                                            }
                                        }
                                        movecheck = true;
                                        m.checked_east = true;
                                    }
                                    break;
                            }
                        } while (!movecheck);
                    }

                }
            }
            #endregion

            #region Monster Nearby Check
            if (gameState.CurrentMap.MAPID == Place.Wilderness)
            {
                if ((!CombatTimer.Enabled) && (!player1.CombatMode))
                {
                    //    Monster meanie = Monsters.Find(m => m.CombatMode);
                    //}
                    //else
                    //{
                    Monster meanie = (Monster)TileCheckForInteraction(InteractionType.Monster);

                    // if ((meanie != null) && (meanie.Aggressive))
                    if (meanie != null)
                    {
                        UpdateActionWindow(meanie.WelcomeMessage);

                        GameTimer.Enabled = false;

                        combatmanager = new CombatManager(meanie, player1);
                        //Enable Combat Timer
                        StartCombat();

                        combatmanager.StartRound();

                    }
                }
            }
            #endregion


            #region Merchant Movement
            if (gameState.CurrentMap.MAPID == Place.Lancer)
            {
                foreach (Merchant m in Merchants)
                {
                    //    movecheck = false;
                    //    m.checked_north = false;
                    //    m.checked_south = false;
                    //    m.checked_west = false;
                    //    m.checked_east = false;

                    //Move in an allowed direction
                    // - they move either N,S,W,E, not diagnol

                    switch (dice.Roll(1, 4))
                    {
                        case 1:
                            if (m.CheckNextStep(MapMatrix[m.X, m.Y - 1]))
                            {
                                m.Y--;
                                m.FormerTile = m.CurrentTile;
                                m.CurrentTile = MapMatrix[m.X, m.Y];
                            }
                            break;
                        case 2:

                            if (m.CheckNextStep(MapMatrix[m.X, m.Y + 1]))
                            {
                                m.Y++;
                                m.FormerTile = m.CurrentTile;
                                m.CurrentTile = MapMatrix[m.X, m.Y];
                            }
                            break;
                        case 3:
                            if (m.CheckNextStep(MapMatrix[m.X - 1, m.Y]))
                            {
                                m.X--;
                                m.FormerTile = m.CurrentTile;
                                m.CurrentTile = MapMatrix[m.X, m.Y];
                            }
                            break;
                        case 4:
                            if (m.CheckNextStep(MapMatrix[m.X + 1, m.Y]))
                            {
                                m.X++;
                                m.FormerTile = m.CurrentTile;
                                m.CurrentTile = MapMatrix[m.X, m.Y];
                            }
                            break;
                    }

                }
            }
            #endregion

            //sleep check
            if (player1.Sleeping)
                if (player1.SleepCounter == 0)
                    player1.Sleeping = false;
                else
                    player1.SleepCounter--;


            if (gameState.CurrentMap.MAPID == Place.Wilderness)
            {
                if (player1.Chopping)
                {
                    if (player1.wood + 1 > 10)
                    {
                        UpdateActionWindow("You can't carry anymore wood.");
                        player1.Chopping = false;
                    }
                    else
                    {
                        if (player1.ChopTicker >= 3)
                        {
                            player1.ChopTicker = 0;

                            AppendActionWindow(".");
                            //Check if received wood
                            if (roll >= 5)
                            {
                                UpdateActionWindow("You gained some wood.");
                                player1.wood++;
                            }
                        }
                        else
                            player1.ChopTicker++;
                    }
                }

                if (player1.Fishing)
                {
                    if (player1.fish + 1 > 20)
                    {
                        UpdateActionWindow("You can't carry anymore fish.");
                        player1.Fishing = false;
                    }
                    else
                    {
                        if (player1.FishTicker >= 6)
                        {
                            player1.FishTicker = 0;

                            AppendActionWindow(".");
                            //Check if received fish
                            if (roll > 6)
                            {
                                UpdateActionWindow("You caught a fish.");
                                player1.fish++;
                            }
                        }
                        else
                            player1.FishTicker++;
                    }
                }
            }
            else if (gameState.CurrentMap.MAPID == Place.Lancer)
            {

            }

            //water Tickers
            if (gameState.waterTicker >= 3)
                gameState.waterTicker = 0;
            else
                gameState.waterTicker++;

            //lava Ticker
            if (gameState.lavaTicker >= 3)
                gameState.lavaTicker = 0;
            else
                gameState.lavaTicker++;

            //increment Tickers
            if (player1.SleepTicker >= 3)
                player1.SleepTicker = 0;
            else
                player1.SleepTicker++;

            //Monsters move

            //Create viewable screen based on characters position
            Screen_ReDraw();

            startTimers = true;

        }

        public void StartCombat()
        {
            CombatTimer.Enabled = true;
            CombatTimer.Start();
        }
        public void EndCombat()
        {
            CombatTimer.Stop();
            CombatTimer.Enabled = false;
        }
        //private void AttackTurn(Monster m)
        //{
        //    if (player1.AttackTurn)
        //    {
        //        //Roll to Hit

        //        //Roll for Damage

        //        //Health check on Monster

        //        UpdateActionWindow("You killed de beast!");
        //        gameState.PlayerMonsterConflict = false;
        //        m.OpponentInBattle = false;

        //        player1.AttackTurn = false;
        //        m.AttackTurn = true;

        //        //Respawn Monster
        //    }
        //    else if (m.AttackTurn)
        //    {
        //        //Roll to Hit

        //        //Roll for Damage

        //        //Health check on Player

        //        UpdateActionWindow("You dead boi!");

        //        gameState.PlayerMonsterConflict = false;
        //        m.OpponentInBattle = false;


        //        player1.AttackTurn = true;
        //        m.AttackTurn = false;
        //        //Last Last Life
        //    }

        //}
        private bool PlayerStillOnMap(Keys k)
        {
            Boolean onMap = false;
            if (k == Keys.Up)
            {
                onMap = ((player1.X >= 0) && (player1.X < gameState.CurrentMap.X) && ((player1.Y - 1) >= 0) && (player1.Y < gameState.CurrentMap.Y));
            }
            else if (k == Keys.Down)
            {
                onMap = ((player1.X >= 0) && (player1.X < gameState.CurrentMap.X) && (player1.Y >= 0) && ((player1.Y + 1) < gameState.CurrentMap.Y));
            }
            else if (k == Keys.Left)
            {
                onMap = (((player1.X - 1) >= 0) && (player1.X < gameState.CurrentMap.X) && (player1.Y >= 0) && (player1.Y < gameState.CurrentMap.Y));
            }
            else if (k == Keys.Right)
            {
                onMap = ((player1.X >= 0) && ((player1.X + 1) < gameState.CurrentMap.X) && (player1.Y >= 0) && (player1.Y < gameState.CurrentMap.Y));
            }

            return onMap;
        }

        private void ChangeStep(int x0, int y0)
        {
            switch (player1.CurrentTile)
            {
                case 84:
                    //open the door - swapping tile with open tile
                    player1.CurrentTile = 80;
                    ScreenMatrix[5, 5] = 80;
                    MapMatrix[x0, y0] = 80;
                    break;

                case 83:
                    //open the door - swapping tile with open tile
                    player1.CurrentTile = 79;
                    ScreenMatrix[5, 5] = 79;
                    MapMatrix[x0, y0] = 79;

                    break;


            }
        }

        private bool OkToStep()
        {
            bool okToStep = true;


            switch (player1.CurrentTile)
            {
                case 80:

                    okToStep = true;
                    break;

                case 79:

                    okToStep = true;
                    break;

                //walking on a mountain
                case 77:
                    okToStep = false;
                    break;

                //walking on shallow/deep water
                case 46:
                case 44:

                    // and has a boat then he is sailing
                    if (player1.HasRaft)
                    {
                        player1.Sailing = true;
                    }
                    else
                    {
                        // otherwise block
                        okToStep = false;
                    }

                    break;

                default:

                    // if player1 was on water, then he is no longer sailing
                    if (player1.FormerTile == 46 || player1.FormerTile == 44)
                    {
                        player1.Sailing = false;
                    }

                    //otherwise
                    else
                        player1.Sailing = false;
                    break;

            }

            //Are you stepping off map?
            //        private int[] allowTiles = { 120, 109, 58, 89, 70, 115, 101, 102, 114 };



            return okToStep;
        }

        private void TransferFocusToCommandArea()
        {
            CommandArea.Clear();
            CommandArea.Enabled = true;
            this.ActiveControl = CommandArea;
        }

        private void WaitForResponseInActionWindow()
        {
            ActionWindow.Enabled = true;
            this.ActiveControl = ActionWindow;
        }

        private void CommandArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (ActiveControl != null && ActiveControl.Name == "CommandArea")
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:

                        if (player1.CurrentState == PlayerProgress.house)
                        {
                            UpdateActionWindow("You have named your cottage " + CommandArea.Text);
                            player1.HouseName = CommandArea.Text;

                            this.ActiveControl = null;
                            CommandArea.Clear();
                            CommandArea.Enabled = false;
                        }
                        else if (player1.CurrentState == PlayerProgress.name)
                        {
                            player1.Name = CommandArea.Text.Trim();
                            UpdateActionWindow("Greetings " + player1.Name + ". Let the story begin...");

                            this.ActiveControl = null;
                            CommandArea.Clear();
                            CommandArea.Enabled = false;
                        }
                        else
                        {
                            this.ActiveControl = null;
                            UpdateActionWindow(CommandArea.Text);
                            CommandArea.Clear();
                            CommandArea.Enabled = false;
                        }


                        break;
                }
            }
        }

        private void BackToTheWilderness()
        {
            player1.CurrentTile = player1.FormerTile;
            player1.FormerTile = player1.CurrentTile;

            Map tempMap = gameState.CurrentMap;
            gameState.CurrentMap = Atlas.Maps[Place.Wilderness];
            gameState.PreviousMap = tempMap;
            player1.Map = Place.Wilderness;
            player1.X = player1.PreviousMapX;
            player1.Y = player1.PreviousMapY;
            player1.PreviousMapX = 0;
            player1.PreviousMapY = 0;
            MapExtract = gameState.CurrentMap.LoadMapFromFile();
            TranslateMap();

            // Overwrite map with garden
            //foreach (GardenPlot g in player1.GardenPlots)
            //{
            //    //MapExtract[g.X, g.Y] = "1";
            //    //MapMatrix[g.X, g.Y] = Encoding.Default.GetBytes("1")[0];
            //    MapExtract[g.X, g.Y] = "G";
            //}

            //// if (player1.Map == Place.Wilderness)
            ////     KingdomExtract = gameState.CurrentMap.LoadKingdoms();

            //if (player1.HasHouse)
            //    MapExtract[player1.HouseX, player1.HouseY] = "H";

            player1.CurrentTile = MapMatrix[player1.X, player1.Y];
            UpdateActionWindow("You are back in the wilderness.");

            World_Refresh(player1.Map);

        }

        private void GameBoard_KeyDown(object sender, KeyEventArgs e)
        {

            if (ActiveControl != null && ActiveControl.Name == "CommandArea")
            {
                CommandArea_KeyDown(sender, e);
            }
            else if (ActiveControl == null)
            {

                //Special Keys
                SpecialKeyPress(e);
                //Non-Special Keys
                NonSpecialKeyPress(e);

            }
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="tilesToFind"></param>
        /// <returns></returns>

        private bool TileCheck(char[] tilesToFind)
        {
            bool found = false;

            for (int i = WIDTH_TILE_RADIUS - 1; i <= WIDTH_TILE_RADIUS + 1; i++)
            {
                for (int j = HEIGHT_TILE_RADIUS - 1; j <=  HEIGHT_TILE_RADIUS + 1; j++)
                {
                    //if (i == 5 & j == 5)
                    //    break;
                    //else
                    {
                        //check if this adjacent tile is your house
                        if (tilesToFind.Contains((char)ScreenMatrix[i, j]))
                        //  if ((char)ScreenMatrix[i, j] == tileToFind)
                        {
                            found = true;
                        }

                    }
                }
            }
            return found;
        }

        //private Monster TileCheckForMonster()
        //{
        //    Monster meanie = new Monster();

        //    for (int i = player1.X-1; i <= player1.X + 1; i++)
        //    {
        //        for (int j = player1.Y - 1; j <= player1.Y + 1; j++)
        //        {
        //            meanie = Monsters.Find(m => (m.X == i) && (m.Y == j));

        //            if (meanie != null)
        //                return meanie;

        //        }
        //    }

        //    return meanie;

        //}

        public enum InteractionType
        {
            Monster = 0,
            Merchant = 1,
            QuestPerson = 2

        }


        private Object TileCheckForInteraction(InteractionType intType)
        {
            if (intType == InteractionType.Monster)
            {
                Monster meanie = new Monster();

                for (int i = player1.X - 1; i <= player1.X + 1; i++)
                {
                    for (int j = player1.Y - 1; j <= player1.Y + 1; j++)
                    {
                        meanie = Monsters.Find(m => (m.X == i) && (m.Y == j));

                        if (meanie != null)
                            return meanie;

                    }
                }

                return meanie;
            }
            else if (intType == InteractionType.Merchant)
            {
                Merchant merchant = new Merchant();

                for (int i = player1.X - 1; i <= player1.X + 1; i++)
                {
                    for (int j = player1.Y - 1; j <= player1.Y + 1; j++)
                    {
                        merchant = Merchants.Find(m => (m.X == i) && (m.Y == j));

                        if (merchant != null)
                            return merchant;

                    }
                }

                return merchant;
            }
            else if (intType == InteractionType.QuestPerson)
            {
                QuestPerson person = new QuestPerson();

                for (int i = player1.X - 1; i <= player1.X + 1; i++)
                {
                    for (int j = player1.Y - 1; j <= player1.Y + 1; j++)
                    {
                        person = QuestPeople.Find(m => (m.X == i) && (m.Y == j));

                        if (person != null)
                            return person;

                    }
                }

                return person;
            }

            return null;
        }

        private void StartMap()
        {
            //using(StreamReader reader = File.OpenText(@"c:\person.json"))
            //{
            //    JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            //    // do stuff
            //}

        }
                //Load in Merchants
              /*  Merchants.Add(
                    new Merchant
                    {
                        Name = "Steve",
                        store = new Store { Name = "Candlestick Inn" },
                        X = 113,
                        Y = 20
                    }
                );
                */
                /*QuestPeople.Clear();
                QuestPeople.Add(
                    new QuestPerson
                    {
                        Name = "Silverblade",
                        X = 104,
                        Y = 47
                    }
                );*/
            
        


        private void ShowScroll(String message)
        {

            Graphics G;
            Bitmap tile;
            Point[] mapArray = new Point[1];

            using (Form form = new Form())
            {
                Image img = Image.FromFile(@"C:\Users\Randy\source\repos\TheCaregiver\TheCaregiver\Resources\scroll.png");
                Bitmap bmp = (Bitmap)img;

                G = Graphics.FromImage(bmp);
                G.DrawImage(bmp, (this.Width - 200) / 2, (this.Height - 300) / 2, 200, 300);

                // form.StartPosition = FormStartPosition.CenterScreen;
                // form.Size = img.Size;

                // PictureBox pb = new PictureBox();
                // pb.Dock = DockStyle.Fill;
                // pb.Image = img;
                // // change size, and  make on top and transpartent
                // form.Controls.Add(pb);
                // form.MinimizeBox = false;
                // form.MaximizeBox = false;
                // form.Opacity = 100;
                // form.ShowDialog(this);


                //// var overlay = new Bitmap(p.Width, p.Height);
                // G = Graphics.FromImage(bmp);
                // G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                // G.DrawImage(sourceBmp, 0, 0);
                // G.DrawImage(player1Bmp, 0, 0);
                // p.Image = overlay;
            }

        }

        private void statsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadInventoryDialog()
        {
            Inventory ic = new Inventory(player1);
            ic.StartPosition = FormStartPosition.CenterScreen;
            ic.Show(this);
        }

        #region UIButtons
        private void LoadCharacterDialog   ()
        {
            CharacterCard cc = new CharacterCard(player1);
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.Show(this);
        }

        #endregion

        #region KeyPress
        private void NonSpecialKeyPress(KeyEventArgs key)
        {
            Boolean housecheck = false;
            Boolean gardencheck = false;
            Boolean treescheck = false;

            if (!player1.Sleeping)
            {
                //Key Combo for attacking

                switch (key.KeyCode)
                {
                    case Keys.W:  //NORTH
                        if (key.Shift)
                        {
                            player1.X = 157;
                            player1.Y = 133;

                            UpdateActionWindow("WARP DRIVE!");
                        }
                        break;

                    // MOVEMENT  
                    #region Movement
                    case Keys.Up:  //NORTH
                        {
                            player1.FormerTile = player1.CurrentTile;
                            player1.CurrentTile = ScreenMatrix[5, 4];

                            ChangeStep(player1.X, player1.Y - 1);

                            if (OkToStep())
                            {
                                if (PlayerStillOnMap(key.KeyCode))
                                {
                                    player1.Y--;
                                }
                                else
                                {
                                    BackToTheWilderness();  //Great Scott!!
                                }
                            }                            
                        }
                        //DiceRoll for event
                        break;

                    //south
                    case Keys.Down:
                        player1.FormerTile = player1.CurrentTile;
                        player1.CurrentTile = ScreenMatrix[5, 6];

                        ChangeStep(player1.X, player1.Y + 1);

                        if (OkToStep())
                        {
                            if (PlayerStillOnMap(key.KeyCode))
                            {
                                player1.Y++;
                            }
                            else
                            {
                                BackToTheWilderness();  //Great Scott!!
                            }
                        }

                        //DiceRoll for event

                        break;

                    //west
                    case Keys.Left:
                        player1.FormerTile = player1.CurrentTile;
                        player1.CurrentTile = ScreenMatrix[4, 5];

                        ChangeStep(player1.X - 1, player1.Y);


                        if (OkToStep())
                        {
                            if (PlayerStillOnMap(key.KeyCode))
                            {
                                player1.X--;
                            }
                            else
                            {
                                BackToTheWilderness();  //Great Scott!!
                            }
                        }

                        //DiceRoll for event

                        break;

                    //east
                    case Keys.Right:
                        player1.FormerTile = player1.CurrentTile;
                        player1.CurrentTile = ScreenMatrix[6, 5];

                        ChangeStep(player1.X + 1, player1.Y);


                        if (OkToStep())
                        {
                            if (PlayerStillOnMap(key.KeyCode))
                            {
                                player1.X++;
                            }
                            else
                            {
                                BackToTheWilderness();  //Great Scott!!
                            }
                        }

                        //DiceRoll for event
                        break;

                    #endregion


                    //Chop
                    case Keys.C:

                        if (player1.Chopping)
                        {
                            UpdateActionWindow("That's enough for now.");
                            player1.Chopping = false;
                        }
                        else
                        {
                            UpdateActionWindow("Let's chop some wood. Hit 'C' to stop.");

                            treescheck = false;

                            for (int i = 4; i <= 6; i++)
                            {
                                for (int j = 4; j <= 6; j++)
                                {
                                    //if (i == 5 & j == 5)
                                    //    break;
                                    //else
                                    {
                                        //check if this adjacent tile is tree
                                        if (((char)ScreenMatrix[i, j] == 'F') || ((char)ScreenMatrix[i, j] == 'Y'))
                                        {
                                            treescheck = true;
                                            player1.Chopping = true;
                                        }
                                    }
                                }
                            }
                        }

                        break;

                    //Developer Window
                    case Keys.D:
                        {
                            pnlDevSettings.Show();
                            break;
                        }

                    //Fish
                    case Keys.F:

                        if (player1.Fishing)
                        {
                            UpdateActionWindow("That's enough for now.");
                            player1.Fishing = false;
                        }
                        else
                        {
                            UpdateActionWindow("Let's catch some fish. Hit 'F' to stop.");

                            if (TileCheck(new char[] { '.', ',' }))
                            {
                                player1.Fishing = true;
                            }
                        }


                        break;


                    //If attempting to build a garden on grass...
                    case Keys.G:

                        //Planting a Garden
                        housecheck = false;
                        gardencheck = false;

                        //You need a house and a hoe to work the land
                        if (player1.HasHouse && player1.HasHoe)
                        {
                            housecheck = TileCheck(new char[] { 'H' });
                            gardencheck = TileCheck(new char[] { 'G' });

                            //Garden has to be beside a house or garden
                            if (player1.GardenPlots.Count < 10)
                            {
                                if (housecheck || gardencheck)
                                {
                                    //Are you on grass? You can only build on grass
                                    if (MapMatrix[player1.X, player1.Y] == 120)
                                    {
                                        //Add new garden plot
                                        player1.GardenPlots.Add(
                                            new GardenPlot
                                            {
                                                X = player1.X,
                                                Y = player1.Y,
                                                GrowthStage = GardenGrowthStages.Nothing,
                                                GrowTicker = 10,
                                            }
                                        );

                                        //Plot gardon on map
                                        MapExtract[player1.X, player1.Y] = "G";
                                        MapMatrix[player1.X, player1.Y] = 71;

                                        //First Garden?
                                        if (player1.GardenPlots.Count == 1)
                                        {
                                            UpdateActionWindow("You have build yourself a fine garden.");
                                            player1.CurrentState = PlayerProgress.garden;
                                        }
                                        else if (player1.GardenPlots.Count < 10)
                                        {
                                            UpdateActionWindow("You have added to your garden.");
                                        }

                                        //Finding the seed - randomly between the 6th and 9th plot
                                        if (player1.GardenPlots.Count == gameState.seedPolt)
                                        {
                                            UpdateActionWindow("What's this?");
                                            UpdateActionWindow("You spy a pinkish glimmer poking up from undernearth the soil.");

                                            UpdateActionWindow("You reach down and pick up a small oval object. It looks much like a gem but there is small softness to it.");
                                            UpdateActionWindow("Strange indeed. You shrug your shoulders and drop it into your pocket.");
                                            UpdateActionWindow("Perhaps someone in town will know of this? Perhaps, even, it were worth a few crown. That'd be splendid!");
                                            player1.HasSeed = true;
                                        }
                                    }
                                    else
                                    {
                                        UpdateActionWindow("You can only build your garden on grass.");
                                    }
                                }
                                else
                                {
                                    UpdateActionWindow("You need to build your garden beside your house or the rest of your garden.");
                                }
                            }

                            else
                            {
                                UpdateActionWindow("You just don't have the time to care for more garden than what you already have!");
                            }
                        }
                        else if (!player1.HasHouse)
                        {
                            UpdateActionWindow("You don't even have a house. Where do you expect to creaet a garden?");
                        }
                        else if (!player1.HasHoe)
                        {
                            UpdateActionWindow("It would be more helpful to use a hoe to make a garden than your fingernails.");
                        }
                        break;


                    case Keys.H:
                        if (!player1.HasHouse)
                        {
                            //can only build on grass
                            if (MapMatrix[player1.X, player1.Y] == 120)
                            {
                                {
                                    player1.HasHouse = true;
                                    player1.HouseX = player1.X;
                                    player1.HouseY = player1.Y;

                                    //create House
                                    Map newHouse = new Map
                                    {
                                        StartX = 5,
                                        StartY = 5,
                                        WorldX = player1.HouseX,
                                        WorldY = player1.HouseY,
                                        X = 11,
                                        Y = 11,
                                        filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/house.txt"),
                                        MAPID = Place.House
                                    };

                                    Atlas.Locations.Add(new Coordinates { X = player1.HouseX, Y = player1.HouseY }, Place.House);
                                    Atlas.Maps.Add(Place.House, newHouse);

                                    MapExtract[player1.HouseX, player1.HouseY] = "H";
                                    MapMatrix[player1.HouseX, player1.HouseY] = 72;
                                    UpdateActionWindow("You have built a modest cottage.");
                                    UpdateActionWindow("It is tradition to name a new home after it's been built. What shall you call it?");

                                    player1.CurrentState = PlayerProgress.house;
                                    TransferFocusToCommandArea();

                                    //TODO: it costs 10 wood for a house
                                    //player1.wood = player1.wood - 10;
                                }
                            }
                            else
                            {
                                UpdateActionWindow("You can only build your house on grass.");
                            }
                        }
                        else
                            UpdateActionWindow("You already have a very nice cottage.");
                        //future option - allow moving cottage for a price

                        break;

                    case Keys.L:
                        UpdateActionWindow("Coordinates: [" + player1.Map.ToString() + "] (" + (int)(player1.X + 1) + ", " + (int)(player1.Y + 1) + ") ASCII " + player1.CurrentTile);
                        break;
                    
                    //Read
                    case Keys.R:
                        //search signs.json
                        if (MapMatrix[player1.X, player1.Y] == 36)
                        {
                            var signWords = SignHelper.ReadSign(player1.X, player1.Y);
                            if (!String.IsNullOrEmpty(signWords))
                            {
                                UpdateActionWindow("You read a sign which says...");
                                UpdateActionWindow(SignHelper.ReadSign(player1.X, player1.Y));
                            }
                            else
                            {
                                UpdateActionWindow("Um, there's nothing to read here.");
                            }
                        }
                        else
                        {
                            UpdateActionWindow("Um, there's nothing to read here.");
                        }

                        break;
                    //Sleep
                    case Keys.S:
                        //MSG - amount of sleep is random

                        if (key.Shift)
                        {

                            MessageBox.Show("Saved!");
                        }
                        else if (!player1.Sleeping)
                        {
                            player1.Sleeping = true;
                            player1.SleepCounter = dice.Roll(1, 8);
                            gameState.reality.Hour += player1.SleepCounter;
                        }

                        break;
                    case Keys.Space:
                        CommandArea.Enabled = true;
                        this.ActiveControl = CommandArea;
                        break;

                    default:

                        break;
                    //Start Conversation - talking
                    case Keys.T:
                        //Determine Town
                        if (gameState.CurrentMap.MAPID == Place.Lancer)
                        {
                            Merchant merchant = (Merchant)TileCheckForInteraction(InteractionType.Merchant);

                            if (merchant != null)
                            {
                                //A merchant has been discovered beside player1

                                // Start dialogue with merchant - find in Merchants list


                                gameState.ShopMode = true;
                                // this merchant should stop moving

                                // Intro in below panel

                                // a choice of buy or sell is displayed
                                UpdateActionWindow("Looking to (B)uy or (S)ell?");
                                WaitForResponseInActionWindow();
                            }

                            QuestPerson person = (QuestPerson)TileCheckForInteraction(InteractionType.QuestPerson);

                            if (person != null)
                            {
                                if (person.Name == "Silverblade")
                                {
                                    if (player1.CurrentState == PlayerProgress.hoe)
                                    {
                                        UpdateActionWindow("With great seeds come great responsibility, Mr. Cactus!");
                                        player1.CurrentState = PlayerProgress.seed;

                                    }
                                    else
                                    {
                                        UpdateActionWindow("Sorry, I am far too busy to talk!");

                                        //change to someone else
                                        player1.HasHoe = true;
                                        player1.NumberofSeeds = 10;
                                    }
                                }
                            }

                            World_Refresh(gameState.CurrentMap.MAPID);

                        }

                        break;

                    //case Keys.P:
                    //    //   GameTimer.Stop();
                    //    var tp = new TheCaregiver.Resources.TransPanel();
                    //    tp.Location = new Point(0, 0);
                    //    tp.Width = TILE_PIXELS * WIDTH_BOARD_TILES;
                    //    tp.Height = TILE_PIXELS * HEIGHT_BOARD_TILES;
                    //    tp.BackColor = Color.Aquamarine;
                    //    tp.BringToFront();
                    //    Image img = Image.FromFile(@"Resources\scroll.png");
                    //    Bitmap bmp = (Bitmap)img;
                    //    var pb = new PictureBox();
                    //    pb.Image = img;
                    //    tp.Width = TILE_PIXELS * WIDTH_BOARD_TILES;
                    //    tp.Height = TILE_PIXELS * HEIGHT_BOARD_TILES;
                    //    pb.Location = new Point(0, 0);
                    //    tp.Controls.Add(pb);
                    //    //  pi.BackgroundImage = bmp;
                    //    this.Controls.Add(tp);
                    //    // ShowScroll("hiya");
                    //    break;

                }
            }
            else
            {
                UpdateActionWindow("You can't walk in your sleep.");
            }

            ////Developer Window
            //if (key.Control && key.KeyCode == Keys.D)
            //{
            //    pnlDevSettings.Show();
            //}
        }

        private void SpecialKeyPress(KeyEventArgs key)
        {
            if (key.Control)
            {
                switch (key.KeyCode)
                {
                    case Keys.D1:
                        {
                            if (player1.HasHouse)
                            {
                                UpdateActionWindow("Warp to House!");
                                player1.X = player1.HouseX - 1;
                                player1.Y = player1.HouseY - 1;
                            }
                            break;
                        }
                    case Keys.D2:
                        {
                            UpdateActionWindow("Warp to Lancer!");
                            player1.X = Atlas.Maps[Place.Lancer].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Lancer].WorldY - 1;
                            break;
                        }
                    case Keys.D3:
                        {
                            UpdateActionWindow("Warp to Nord Point!");
                            player1.X = Atlas.Maps[Place.NordPoint].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.NordPoint].WorldY - 1;
                            break;
                        }
                    case Keys.D4:
                        {
                            UpdateActionWindow("Warp to Fyster!");
                            player1.X = Atlas.Maps[Place.Fyster].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Fyster].WorldY - 1;
                            break;
                        }
                    case Keys.D5:
                        {
                            UpdateActionWindow("Warp to Nazidar!");
                            player1.X = Atlas.Maps[Place.Nazidar].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Nazidar].WorldY - 1;
                            break;
                        }
                    case Keys.D6:
                        {
                            UpdateActionWindow("Warp to Lawdyn!");
                            player1.X = Atlas.Maps[Place.Lawdyn].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Lawdyn].WorldY - 1;
                            break;
                        }
                    case Keys.D7:
                        {
                            UpdateActionWindow("Warp to Otalio!");
                            player1.X = Atlas.Maps[Place.Otalio].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Otalio].WorldY - 1;
                            break;
                        }
                    case Keys.D8:
                        {
                            UpdateActionWindow("Warp to Southwind!");
                            player1.X = Atlas.Maps[Place.Southwind].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Southwind].WorldY - 1;
                            break;
                        }
                    case Keys.D9:
                        {
                            UpdateActionWindow("Warp to Byas!");
                            player1.X = Atlas.Maps[Place.Byas].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Byas].WorldY - 1;
                            break;
                        }
                    case Keys.D0:
                        {
                            UpdateActionWindow("Warp to Grove!");
                            player1.X = Atlas.Maps[Place.Grove].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Grove].WorldY - 1;
                            break;
                        }
                    case Keys.F1:
                        {
                            UpdateActionWindow("Warp to Radius!");
                            player1.X = Atlas.Maps[Place.Radius].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Radius].WorldY - 1;
                            break;
                        }
                    case Keys.F2:
                        {
                            UpdateActionWindow("Warp to Winter's Hold!");
                            player1.X = Atlas.Maps[Place.WintersHold].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.WintersHold].WorldY - 1;
                            break;
                        }
                    case Keys.F3:
                        {
                            UpdateActionWindow("Warp to Flagport!");
                            player1.X = Atlas.Maps[Place.Flagport].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Flagport].WorldY - 1;
                            break;
                        }
                    case Keys.F4:
                        {
                            UpdateActionWindow("Warp to Iye!");
                            player1.X = Atlas.Maps[Place.Iye].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Iye].WorldY - 1;
                            break;
                        }
                    case Keys.F5:
                        {
                            UpdateActionWindow("Warp to Tempest!");
                            player1.X = Atlas.Maps[Place.Tempest].WorldX - 1;
                            player1.Y = Atlas.Maps[Place.Tempest].WorldY - 1;
                            break;
                        }
                }

            }
            switch (key.KeyValue)
            {
                //Enter
                case 13:

                    //Garden Check
                    if (player1.CurrentTile == 71)
                    {
                        if (player1.Map == Atlas.Maps[Place.Wilderness].MAPID)
                        {
                            //Which gardenplot
                            GardenPlot tempplot = player1.GardenPlots.Find(g => g.X == player1.X & g.Y == player1.Y);

                            if (tempplot.GrowthStage == GardenGrowthStages.Growing)
                            {
                                //Still Growing
                                UpdateActionWindow("Have a little patience. It's still growing.");
                            }
                            else if (tempplot.GrowthStage == GardenGrowthStages.ReadyToHarvest)
                            {
                                //Harest Ready
                                tempplot.GrowthStage = GardenGrowthStages.Nothing;
                                UpdateActionWindow("You picked some lovely beans.");
                                player1.food++;
                            }
                            else if (tempplot.GrowthStage == GardenGrowthStages.Nothing)
                            {
                                //Plant Seed
                                if (player1.NumberofSeeds > 0)
                                {
                                    tempplot.GrowthStage = GardenGrowthStages.Growing;
                                    UpdateActionWindow("Seed planted.");
                                    player1.NumberofSeeds--;
                                }
                                else
                                {
                                    UpdateActionWindow("You have no seed to plant.");
                                }
                            }
                        }
                        //In garden, in a town - so harvesting
                        else
                        {
                            UpdateActionWindow("You have stolen some beans.  Oh, nice that! Who raised you?");
                            player1.food++;

                            //TODO: make crop disappear

                        }
                    }
                    else
                    {

                        Map newMap = null;

                        Place testLocation = Atlas.Locations.FirstOrDefault(x => x.Key.X == player1.X && x.Key.Y == player1.Y).Value;

                        if (testLocation > 0)
                        {
                            //newMap = Atlas.Maps.FirstOrDefault(x => x.Key == testLocation).Value;
                            newMap = Atlas.Maps.FirstOrDefault(x => x.Key == Place.Lancer).Value;
                        }
                        else
                        {
                            newMap = Atlas.Maps.FirstOrDefault(x => x.Key == Place.Wilderness).Value;
                        }

                        //if checkCoordinates

                        if (newMap != null)
                        {
                            player1.Map = newMap.MAPID;

                            //check Place
                            if (player1.Map == Place.House)
                            {

                                gameState.PreviousMap = gameState.CurrentMap;
                                player1.PreviousMapX = player1.X;
                                player1.PreviousMapY = player1.Y;

                                gameState.CurrentMap = Atlas.Maps[Place.House];
                                player1.X = gameState.CurrentMap.StartX;
                                player1.Y = gameState.CurrentMap.StartY;
                                MapExtract = gameState.CurrentMap.LoadMapFromFile();
                                TranslateMap();
                                player1.CurrentTile = MapMatrix[player1.X, player1.Y];
                                UpdateActionWindow("You've entered your cottage, " + player1.HouseName);

                            }//428 96
                            else if (newMap.type == LocationType.Town)
                            {
                                gameState.PreviousMap = gameState.CurrentMap;
                                gameState.CurrentMap = newMap;

                                player1.PreviousMapX = player1.X;
                                player1.PreviousMapY = player1.Y;
                                player1.X = gameState.CurrentMap.StartX;
                                player1.Y = gameState.CurrentMap.StartY;
                                MapExtract = gameState.CurrentMap.LoadMapFromFile();
                                TranslateMap();
                                player1.CurrentTile = MapMatrix[player1.X, player1.Y];

                                UpdateActionWindow("You've entered the Town of " + player1.Map.ToString());
                                StartMap();

                            }
                            else
                            {
                                UpdateActionWindow("There is nowhere to enter here.");
                            }
                        }

                    }


                    break;

            }


        }

        #endregion


        #region RedrawTheWorld

        private void World_Refresh(Place thisplace)
        {
            // player1.Map = thisplace;
            Atlas.BuildTownDatabase(gameState.reality.Season);
            gameState.CurrentMap = Atlas.Maps[player1.Map];

            MapExtract = gameState.CurrentMap.LoadMapFromFile();


            regions = MapHelper.CreateRegions();
            Assign_Tile_By_Ascii();  //should this be switched?
            TranslateMap();
            World_Layers();
        }

        private void World_Layers()
        {

            if (player1.Map == Place.Wilderness)
            {

                // Overwrite map with garden
                foreach (GardenPlot g in player1.GardenPlots)
                {
                    //MapExtract[g.X, g.Y] = "1";
                    //MapMatrix[g.X, g.Y] = Encoding.Default.GetBytes("1")[0];
                    MapExtract[g.X, g.Y] = "G";
                    MapMatrix[g.X, g.Y] = 71;
                }

                // if (player1.Map == Place.Wilderness)
                //     KingdomExtract = gameState.CurrentMap.LoadKingdoms();

                if (player1.HasHouse)
                {
                    MapExtract[player1.HouseX, player1.HouseY] = "H";
                    MapMatrix[player1.HouseX, player1.HouseY] = 72;
                }
            }
        }

        private void Screen_ReDraw()
        {
            // DrawUI();
            CreateScreen();

            DrawScreen();
        }

        #endregion

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {

            var saveFilePath = Application.LocalUserAppDataPath;

            using (StreamWriter sw = new StreamWriter(saveFilePath + @"//" + "savefile.crg"))
            {
                sw.AutoFlush = true;

                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    { "player1", player1 },
                    { "gamestate", gameState},
                    { "mobs", Monsters }
                };

                string json = JsonConvert.SerializeObject(dic, Formatting.Indented);

                try
                {
                    sw.Write(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void CombatTimer_Tick(object sender, EventArgs e)
        {
            int damageRoll = 0;

            //Determine if player or opponents turn
            // if start of new round, opponent always goes first - until we develop Surprise roll
            if (player1.Opponent.AttackTurn)
            {
                if (dice.Roll(1, 20) >= player1.EquipedArmour.Protection)
                {
                    //message should give an idea of players health

                    damageRoll = dice.Roll(1, player1.Opponent.DamageMax);
                    player1.Health = player1.Health - damageRoll;
                    if (player1.Health <= 0)
                    {
                        UpdateActionWindow("Dead men can never die.");
                        player1.Opponent.CombatMode = false;
                        player1.Opponent.OpponentInBattle = false;
                        player1.CombatMode = false;
                        player1.Opponent = null;
                        CombatTimer.Enabled = false;
                        GameTimer.Enabled = true;
                        player1.Dead = true;
                        Resurrection();
                    }
                    else
                    {
                        if (((Double)player1.Health / player1.HealthMax) >= 0.75)
                        {
                            UpdateActionWindow("You've been hit. It's just a flesh wound!");
                        }
                        else if (((Double)player1.Health / player1.HealthMax) >= 0.5)
                        {
                            UpdateActionWindow("You've been hit. You'll feel that in the morning.");
                        }
                        else if (((Double)player1.Health / player1.HealthMax) >= 0.25)
                        {
                            UpdateActionWindow("You've been hit. This is getting real!");
                        }
                        else
                        {
                            UpdateActionWindow("You have been critically wounded.");
                        }

                    }
                }
                else
                {
                    UpdateActionWindow("The " + player1.Opponent.Name + " misses.");
                }

                if (!player1.Dead)
                {
                    player1.AttackTurn = true;
                    player1.Opponent.AttackTurn = false;
                }
            }
            else
            {
                if (dice.Roll(1, 20) >= player1.Opponent.Defense)
                {
                    //message should give an idea of monster's health

                    damageRoll = dice.Roll(1, player1.EquipedWeapon.MaxDamage);
                    player1.Opponent.Health = player1.Opponent.Health - damageRoll;

                    if (player1.Opponent.Health <= 0)
                    {
                        UpdateActionWindow("You killed it.");
                        CombatTimer.Enabled = false;

                        player1.Opponent.AttackTurn = false;
                        player1.AttackTurn = false;

                        //get some XP

                        //What Region is player in
                        player1.CurrentRegion = regions.Find(r => ((player1.X >= r.X1 && player1.X <= r.X2) && (player1.Y >= r.Y1 && player1.Y <= r.Y2)));

                        if (player1.CurrentRegion != null)
                        {
                            player1.Opponent.CombatMode = false;
                            player1.Opponent.OpponentInBattle = false;

                            //Start Respawn counter - 10 seconds
                            MonsterHelper.ReSpawnMonster(Monsters, player1);

                        }

                        player1.CombatMode = false;
                        GameTimer.Enabled = true;

                    }
                    else
                    {
                        if (player1.Opponent.Health / player1.Opponent.HealthMax <= 0.25)
                        {
                            UpdateActionWindow("You hit the " + player1.Opponent.Name + ".");
                        }
                        else if (player1.Opponent.Health / player1.Opponent.HealthMax <= 0.5)
                        {
                            UpdateActionWindow("You hit the " + player1.Opponent.Name + ".");
                        }
                        else if (player1.Opponent.Health / player1.HealthMax <= 0.75)
                        {
                            UpdateActionWindow("You hit the " + player1.Opponent.Name + ".");
                        }
                        else
                        {
                            UpdateActionWindow("You hit the " + player1.Opponent.Name + ".");
                        }

                        player1.Opponent.AttackTurn = true;
                        player1.AttackTurn = false;
                    }
                }
                else
                {
                    UpdateActionWindow("You miss.");
                    player1.Opponent.AttackTurn = true;
                    player1.AttackTurn = false;
                }

            }

            //Roll for hit

            //roll for damage

            //death check - either side


            //If round is over
            if (!player1.Dead)
            {
                combatmanager.FinishRound();
            }

            //  Defense = 15,
            //     DamageMax = 3,
            //Flee Decision
            // FleeThreshold
            // ChanceToFlee
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void btnSaveDevSettings_Click(object sender, EventArgs e)
        {
            pnlDevSettings.Visible = false;
        }

        private void chkDevSetting_HasSeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDevSetting_HasSeed.Checked)
            {
                player1.HasSeed = true;
            }
            else
            {
                player1.HasSeed = false;
            }

            //save code
            player1.HasSeed = chkDevSetting_HasSeed.Checked;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {

        }

        private void tsInventory_Click(object sender, EventArgs e)
        {
            LoadInventoryDialog();
        }

        private void tsCharacter_Click(object sender, EventArgs e)
        {
            LoadCharacterDialog();
        }

        private void ActionWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if (ActiveControl != null && ActiveControl.Name == "ActionWindow")
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        //if in store mode then select Buy
                        if (gameState.ShopMode)
                        {
                            e.Handled = true;
                            UpdateActionWindow_ShowItems("Iolo's Bows", new string[] { "short bow [3]", "dagger [2]" });
                            //TransferFocusToCommandArea();

                        }
                        break;

                    case Keys.S:
                        e.Handled = true;
                        //if in store mode then select Sell
                        break;

                    case Keys.D1:
                        {
                            e.Handled = true;
                            if (gameState.ShopMode)
                            {
                                UpdateActionWindow(">1");

                                //call a method that knows the town, merhcant, choices and will make the transaction

                                this.ActiveControl = null;
                            }
                            break;
                        }
                    case Keys.D2:
                        {
                            e.Handled = true;
                            if (gameState.ShopMode)
                            {
                                UpdateActionWindow(">2");

                                this.ActiveControl = null;
                            }
                            break;
                        }
                        //case 1-9 for awares
                        /*
                         * 
                                    // if buy, wares posted in below panel
                                    UpdateActionWindow_ShowItems("Iolo's Bows", new string[] { "short bow [3 coin]", "dagger [2 coin]"});
                                    // player1 makes choice

                                    // checks cost vs player1 gold */
                }
            }
        }
    }
}

