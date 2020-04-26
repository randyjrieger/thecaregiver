using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCaregiver.World;
using TheCaregiver.People;
using TheCaregiver.Classes;

namespace TheCaregiver
{
    public partial class Form1 : Form
    {
        public const int SCREEN_DIM = 11;
        public const int SCREEN_RADIUS = 5;
        public int offset = SCREEN_RADIUS;
        public Player player1;
        public Map CurrentMap { get; set; }

        public string [,] MapExtract;
        public byte[,] MapMatrix;
        public byte[,] ScreenMatrix = new byte[SCREEN_DIM, SCREEN_DIM];
        public bool startTimers = false;
        //Timers
        private int waterTicker = 0;
        private List<Tile> Tiles = new List<Tile>();

        public Form1()
        {             
            InitializeComponent();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Player
            player1 = new Player();

            //Create Atlas
            Atlas.BuildAtlas(player1);
            LoadTiles();

            //Set Current Map
            GameState.CurrentMap = Atlas.Maps[player1.Map];
            
            //Load Current Map into Map Array object
            MapExtract = GameState.CurrentMap.LoadMapFromFile();

            if (player1.HasHouse)
                MapExtract[player1.HouseX, player1.HouseY] = "H";

            TranslateMap();

            GameTimer.Enabled = true;
        }

        public void StartNewGame()
        {
            UpdateActionWindow("Start Game");
        }

        public void LoadNewGame()
        {
            UpdateActionWindow("Welcome back");
        }

        public void UpdateActionWindow(string s)
        {
            ActionWindow.Text = ActionWindow.Text + Environment.NewLine + "   " + s;
        }

        public void TranslateMap()
        {

            MapMatrix = new byte[GameState.CurrentMap.X, GameState.CurrentMap.Y];
            //switch (player1.Map)
            //{
            //    case Place.Wilderness:
            //       MapMatrix = new byte[300,155];
            //        break;

            //    case Place.Lancer:
            //        MapMatrix = new byte[65, 35];
            //        break;

            //    case Place.House:
            //        MapMatrix = new byte[11, 11];
            //        break;

            //    default:
            //        break;
            //}

            for (var x = 0; x < GameState.CurrentMap.X; x++)
            {
                for (var y = 0; y < GameState.CurrentMap.Y; y++)
                {
                    MapMatrix[x,y] = Encoding.Default.GetBytes(MapExtract[x, y])[0];
                }
            }
        }

        private void LoadTiles()
        {
            Tile tmpTile;
            //WILDERNESS

            Tiles.Add(new Tile
            {
                Letter = 'p',
                Picture = new Bitmap(TheCaregiver.Tiles.grass)
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
                Picture = new Bitmap(TheCaregiver.Tiles.mountain)
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

            Tiles.Add(new Tile
            {
                Letter = 'b',
               // Picture = new Bitmap(TheCaregiver.Tiles.)
            });

            Tiles.Add(new Tile
            {
                Letter = 'j',
                Picture = new Bitmap(TheCaregiver.Tiles.bridge)
            });
        }
        public void CreateScreen()
        {
            //screen boundaries
            int Screen_Map_Left = player1.X - SCREEN_RADIUS;
            int Screen_Map_Right = player1.X + SCREEN_RADIUS;
            int Screen_Map_Top = player1.Y - SCREEN_RADIUS;
            int Screen_Map_Bottom = player1.Y + SCREEN_RADIUS;

            ScreenMatrix = new byte[SCREEN_DIM, SCREEN_DIM];

            int x;
            int j = 0;

            for (int MapY = Screen_Map_Top; MapY <= Screen_Map_Bottom; MapY++)
            {
                x = 0;
                for (int MapX = Screen_Map_Left; MapX <= Screen_Map_Right; MapX++)
                {
                    if ((MapX < 0) || (MapX >= GameState.CurrentMap.X) || (MapY < 0) || (MapY >= GameState.CurrentMap.Y))
                    {
                        ScreenMatrix[x, j] = 0;
                    }
                    else
                    {
                        ScreenMatrix[x, j] = MapMatrix[MapX, MapY];
                    }
                    

                    x++;
                }

                j++;
            }
            
            player1.CurrentTile = ScreenMatrix[5, 5];
        }


        public void DrawScreen()
        {

            int tileWidth = 51;
            int tileHeight = 51;
            PictureBox p;
            Point loc;
            Graphics G;
            Bitmap tile;
            Point[] mapArray = new Point[1];
            Bitmap sourceBmp = null;
            Bitmap player1Bmp = null;
            Bitmap defaultTile = Tiles.Single(t => t.Letter == '~').Picture;

            for (int j = 10; j >= 0; j--)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (startTimers)
                    {
                        p = (PictureBox)this.Controls.Find((tileWidth * i).ToString() + "_" + (tileHeight * j).ToString(), true)[0];
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

                    //Player1
                    if ((j == 5) && (i == 5))
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
                        else if (player1.Sailing)
                        {
                            //sailing
                            player1Bmp = new Bitmap(TheCaregiver.Tiles.raft);
                        }

                        else if (player1.Fishing)
                        {
                            //fishing
                            // if mod is 0 then cast else no cast
                            if (player1.FishTicker == 0)
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.fishing_casting);
                            else
                                player1Bmp = new Bitmap(TheCaregiver.Tiles.fishing_linein);
                        }

                        else if (player1.Chopping)
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
                            player1Bmp = new Bitmap(TheCaregiver.Tiles.player1);
                        }
                    }

                    try
                    {
                        //Some tiles are animated and move with the water timer                        
                        if (((char)ScreenMatrix[i, j] == ',') || ((char)ScreenMatrix[i, j] == '.') || ((char)ScreenMatrix[i, j] == '%'))                          
                            sourceBmp = (Tiles.Single(t => (t.Letter == (char)ScreenMatrix[i, j])).getMovingPicture(waterTicker));

                        //Some tiles are constants
                        else if (((char)ScreenMatrix[i, j] != ',') && ((char)ScreenMatrix[i, j] != '.'))
                            sourceBmp = Tiles.Single(t => t.Letter == (char)ScreenMatrix[i, j]).Picture;
                        
                    }
                    catch (System.InvalidOperationException e)
                    {
                        sourceBmp = defaultTile;
                    }


                    p.SizeMode = PictureBoxSizeMode.StretchImage;

                    /* Centre of screen - this is the player tile
                     * Player tile is a transparent .png written on top of the background tile
                     */
                    if ((j == 5) && (i == 5))
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
                    p.Location = loc;
                    p.Tag = loc;

                    this.Controls.Add(p);

                }
            }
        }
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //sleep check
            if (player1.Sleeping)
                if (player1.SleepCounter == 0)
                    player1.Sleeping = false;
                else
                    player1.SleepCounter--;

            if (player1.Fishing)
            {
                if (player1.FishTicker >= 14)
                    player1.FishTicker = 0;
                else
                    player1.FishTicker++;

                //check chance of fish
            }

            if (player1.Chopping)
            {
                if (player1.ChopTicker >= 6)
                    player1.ChopTicker = 0;
                else
                    player1.ChopTicker++;

                //check chance of wood
            }

            //increment Tickers
            if (waterTicker >= 3)
                waterTicker = 0;
            else
                waterTicker++;

            //increment Tickers
            if (player1.SleepTicker >= 3)
                player1.SleepTicker = 0;
            else
                player1.SleepTicker++;

            //Create viewable screen based on characters position
            CreateScreen();

            DrawScreen();

            startTimers = true;

        }

        private bool PlayerStillOnMap(Keys k)
        {
            Boolean onMap = false;
            if (k == Keys.W)
            {
                onMap = ((player1.X >= 0) && (player1.X < GameState.CurrentMap.X) && ((player1.Y - 1) >= 0) && (player1.Y < GameState.CurrentMap.Y));
            }
            else if (k == Keys.S)
            {
                onMap = ((player1.X >= 0) && (player1.X < GameState.CurrentMap.X) && (player1.Y >= 0) && ((player1.Y + 1) < GameState.CurrentMap.Y));
            }
            else if (k == Keys.A)
            {
                onMap = (((player1.X - 1) >= 0) && (player1.X < GameState.CurrentMap.X) && (player1.Y >= 0) && (player1.Y < GameState.CurrentMap.Y));
            }
            else if (k == Keys.D)
            {
                onMap = ((player1.X >= 0) && ((player1.X + 1) < GameState.CurrentMap.X) && (player1.Y >= 0) && (player1.Y < GameState.CurrentMap.Y));
            }

            return onMap;
        }

        private bool OkToStep()
        {
            bool okToStep = true;

            switch (player1.CurrentTile)
            {
                //walking on a mountain
                case 77:
                    okToStep = false;
                    break;

                //walking on shallow/deep water
                case 46: case 44:

                    // and has a boat then he is sailing
                    if (player1.HasBoat)
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


            

            return okToStep;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean watercheck = false;
            Boolean treescheck = false;
            player1.Fishing = false;
            player1.Chopping = false;

            switch (e.KeyCode)
            {
                

                //north
                case Keys.W:
                    player1.FormerTile = player1.CurrentTile;
                    player1.CurrentTile = ScreenMatrix[5, 4];

                    if (OkToStep() && PlayerStillOnMap(e.KeyCode))
                        player1.Y--;
                    else
                    {
                        player1.CurrentTile = player1.FormerTile;
                        player1.FormerTile = player1.CurrentTile;
                    }

                    //DiceRoll for event
                    break;

                //south
                case Keys.S:
                    if (e.Shift)
                    {

                        MessageBox.Show("Saved!");
                    }
                    else
                    {
                        player1.FormerTile = player1.CurrentTile;
                        player1.CurrentTile = ScreenMatrix[5, 6];

                        if (OkToStep() && PlayerStillOnMap(e.KeyCode))
                            player1.Y++;
                        else
                        {
                            player1.CurrentTile = player1.FormerTile;
                            player1.FormerTile = player1.CurrentTile;
                        }
                    }

                    //DiceRoll for event
                    
                    break;

                //west
                case Keys.A:
                    player1.FormerTile = player1.CurrentTile;
                    player1.CurrentTile = ScreenMatrix[4, 5];
                    if (OkToStep() && PlayerStillOnMap(e.KeyCode))
                        player1.X--;
                    else
                    {
                        player1.CurrentTile = player1.FormerTile;
                        player1.FormerTile = player1.CurrentTile;
                    }

                    //DiceRoll for event

                    break;

                //east
                case Keys.D:
                    player1.FormerTile = player1.CurrentTile;
                    player1.CurrentTile = ScreenMatrix[6, 5];

                    if (OkToStep() && PlayerStillOnMap(e.KeyCode))
                        player1.X++;
                    else
                    {
                        player1.CurrentTile = player1.FormerTile;
                        player1.FormerTile = player1.CurrentTile;
                    }

                    //DiceRoll for event
                    break;

                case Keys.H:
                    if (!player1.HasHouse)
                    {
                        player1.HasHouse = true;
                        player1.HouseX = player1.X;
                        player1.HouseY = player1.Y;
                        Atlas.Maps[Place.House].WorldX = player1.X;
                        Atlas.Maps[Place.House].WorldY = player1.Y;
                        MapExtract[player1.HouseX, player1.HouseY] = "H";
                        MapMatrix[player1.HouseX, player1.HouseY] = 72;
                        UpdateActionWindow("You build a house");
                    }
                    break;

                case Keys.L:
                    MessageBox.Show("Coordinates: " + player1.X + ", " + player1.Y + " @ " + player1.CurrentTile);
                    break;
                case Keys.P:
                    var tp = new TheCaregiver.Resources.TransPanel();
                    tp.Location = new Point(0,0);
                    tp.Width = 51*11;
                    tp.Height = 51*11;
                    tp.BackColor = Color.Aquamarine;
                    tp.BringToFront();
                    Image img = Image.FromFile(@"C:\Users\Randy\source\repos\TheCaregiver\TheCaregiver\Resources\scroll.png");
                    Bitmap bmp = (Bitmap)img;
                    var pb = new PictureBox();
                    pb.Image = img;
                    tp.Width = 51 * 11;
                    pb.Height = 51*11;
                    pb.Location = new Point(0, 0);
                    tp.Controls.Add(pb);
                  //  pi.BackgroundImage = bmp;
                    this.Controls.Add(tp);
                   // ShowScroll("hiya");
                    break;

                //Fish
                case Keys.F:
                    //If player has a boat and in water, they can fish in shallow water
                    watercheck = false;

                    for (int i = 4; i <= 6; i++)
                    {
                        for (int j = 4; j <= 6; j++)
                        {
                            //if (i == 5 & j == 5)
                            //    break;
                            //else
                            {
                                //check if this adjacent tile is water
                                if (((char)ScreenMatrix[i, j] == '.') || ((char)ScreenMatrix[i, j] == ','))
                                {
                                    watercheck = true;
                                    player1.Fishing = true;
                                }
                            }
                        }
                    }                    

                    break;
                    
                //Fish
                case Keys.C:
                    //If player has a boat and in water, they can fish in shallow water
                    treescheck = false;

                    for (int i = 4; i <= 6; i++)
                    {
                        for (int j = 4; j <= 6; j++)
                        {
                            //if (i == 5 & j == 5)
                            //    break;
                            //else
                            {
                                //check if this adjacent tile is water
                                if (((char)ScreenMatrix[i, j] == 'F') || ((char)ScreenMatrix[i, j] == 'Y'))
                                {
                                    treescheck = true;
                                    player1.Chopping = true;
                                }
                            }
                        }
                    }

                    break;

                //Rest
                case Keys.R:
                    //MSG - amount of sleep is random

                    if (!player1.Sleeping)
                    {
                        player1.Sleeping = true;
                        player1.SleepCounter = DiceRoll.Roll(9);
                    }

                    break;

                default:
                    switch (e.KeyValue)
                    {
                        case 13:
                            //if checkCoordinates
                            if (player1.X == 28 && player1.Y == 118)
                            {
                                GameState.PreviousMap = GameState.CurrentMap;
                                GameState.CurrentMap = (Atlas.Maps.Single(m => m.Value.WorldX == player1.X && m.Value.WorldY == player1.Y)).Value;
                                
                                player1.Map = Place.Lancer;

                                player1.X = GameState.CurrentMap.StartX;
                                player1.Y = GameState.CurrentMap.StartY;
                                MapExtract = GameState.CurrentMap.LoadMapFromFile();
                                TranslateMap();
                                player1.CurrentTile = MapMatrix[player1.X, player1.Y];
                            }
                            else if (player1.X == player1.HouseX && player1.Y == player1.HouseY)
                            {
                                GameState.PreviousMap = GameState.CurrentMap;
                                GameState.CurrentMap = (Atlas.Maps.Single(m => m.Value.WorldX == player1.X && m.Value.WorldY == player1.Y)).Value;

                                player1.Map = Place.House;

                                player1.X = GameState.CurrentMap.StartX;
                                player1.Y = GameState.CurrentMap.StartY;
                                MapExtract = GameState.CurrentMap.LoadMapFromFile();
                                TranslateMap();
                                player1.CurrentTile = MapMatrix[player1.X, player1.Y];
                                UpdateActionWindow("You entered your smelly house");

                            }
                            break;
                            //if (Keyboard.IsKeyDown(Key.T) && Keyboard.IsKeyDown(Key.LeftCtrl)
                            //if (e.KeyCode == Keys.F1 && (e.Alt || e.Control || e.Shift))

                    }
                    break;

            }

            //Create viewable screen based on characters position
            CreateScreen();

            DrawScreen();



            //if (e.Control && e.Alt && e.KeyCode == Keys.O)
            //{
            //    MessageBox.Show("Ctrl+Alt+O: magic!");
            //}
        }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
