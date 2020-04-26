using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace TheCaregiver.World
{
    public enum Place
    {
        Wilderness = 0,
        Lancer = 1,
        House = 2,
        NordPoint = 3,
        Fyster = 4,
        Iye = 5,
        Grove = 6,
        Nazidar = 7,
        Lawdyn = 8,
        Otalio = 9,
        Southwind = 10,
        Byas = 11,
        Garden = 12,
        Tempest = 13,
        Radius = 14,
        Snowport = 15, 
        Flagport = 16


    }

    public enum LocationType
    {
        None = 0,
        Town = 1,
        Special = 2
    }
    
    
    public class Map
    {
        //public const int SCREEN_RADIUS = 5;
        //public int offset = SCREEN_RADIUS;

        public Place MAPID { get; set; }

        public int WorldX { get; set; }
        public int WorldY { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public LocationType type { get; set; }
        public string filePath { get; set; }
        public string kingdomFilePath { get; set; }

        public Map()
        {
        }

        private string[,] MapExtract ;
        private string[,] KingdomExtract;

        public string [,] LoadKingdoms()
        {
            int lineCount = 0;
            string line;
            kingdomFilePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/kingdoms.txt");
            KingdomExtract = new string[X, Y];

            using (var fileStream = File.OpenRead(kingdomFilePath))
            {
                using (var reader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
                    do
                    {
                        line = reader.ReadLine().Trim();

                        for (int m = 0; m < X; m++)
                        {

                            KingdomExtract[m, lineCount] = line[m].ToString();
                        }

                        lineCount++;
                    } while (!reader.EndOfStream);

                }
            }
            return KingdomExtract;
        }

        public string[,] LoadMapFromFile()
        {
            int lineCount = 0;
            string line;
           
            MapExtract = new string[X, Y];

            using (var fileStream = File.OpenRead(filePath))
            {
                using (var reader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
                    do
                    {
                        line = reader.ReadLine().Trim();
                       
                        for (int m = 0; m < X; m++)
                        {
                               
                            MapExtract[m, lineCount] = line[m].ToString();
                        }
                       
                        lineCount++;
                    } while (!reader.EndOfStream);

                }
            }             

            return MapExtract;
        }

    }
}
