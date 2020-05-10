using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheCaregiver.Classes
{
    public enum MapRegionType
    {
        Otalio = 0,
        HyleoDesert = 1,
        LavaRegion = 2,
        NordArm = 3,
        HyleoForestWest = 4,
        HyleoForestEast = 5,
        HyleoSouthPlains = 6,
        HyleoPlains = 7,
        Apathy = 8,
        NordthilanHead = 9,
        NordthilanNeck = 10,
        NordthilanBelly = 11,
        NordthilanSpine = 12,
        Swamp = 13,
        Ocean = 14
    }

    public class MapRegion
    {
        public int RegionID { get; set; }
        public MapRegionType Type { get; set; }
        public int MaxMobCount { get; set; }

        public MapRegion(MapRegionType type, int x1, int x2, int y1, int y2, int maxmobs)
        {
            Type = type;
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
            MaxMobCount = maxmobs;
        }
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
    }
}
