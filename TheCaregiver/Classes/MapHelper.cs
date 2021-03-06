﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Classes
{
    public static class MapHelper
    {

        public static List<MapRegion> CreateRegions()
        {
            List<MapRegion> Regions = new List<MapRegion>();

            //Otalio Region
            Regions.Add(new MapRegion(MapRegionType.Otalio, 423, 426, 97, 100, 1));

            //Hyleo Desert
            Regions.Add(new MapRegion(MapRegionType.HyleoDesert, 366, 466, 112, 144, 8));

            //Hyleo Lava
            Regions.Add(new MapRegion(MapRegionType.LavaRegion, 302, 380, 88, 108, 8));

            //Nord Arm
            Regions.Add(new MapRegion(MapRegionType.NordArm, 233, 291, 96, 110, 3));

            //Hyleo Forest
            Regions.Add(new MapRegion(MapRegionType.HyleoForestWest, 185, 265, 126, 130, 3));
            Regions.Add(new MapRegion(MapRegionType.HyleoForestEast, 298, 319, 116, 127, 2));

            //Hyleo South Plains
            Regions.Add(new MapRegion(MapRegionType.HyleoSouthPlains, 176, 361, 132, 144, 5));

            //Hyleo Plains
            Regions.Add(new MapRegion(MapRegionType.HyleoPlains, 340, 368, 111, 144, 8));

            //Apathy
            Regions.Add(new MapRegion(MapRegionType.Apathy, 142, 145, 87, 87, 1));

            //Nordthilan Dragon's Head
            Regions.Add(new MapRegion(MapRegionType.NordthilanHead, 16, 84, 26, 57, 8));

            //Neck
            Regions.Add(new MapRegion(MapRegionType.NordthilanNeck, 85, 142, 34, 45, 5));

            //Belly
            Regions.Add(new MapRegion(MapRegionType.NordthilanBelly, 149, 357, 35, 74, 13));

            //Spine
            Regions.Add(new MapRegion(MapRegionType.NordthilanSpine, 326, 346, 22, 34, 4));

            //Swamp
            Regions.Add(new MapRegion(MapRegionType.Swamp, 163, 216, 65, 67, 3));

            //Ocean
            Regions.Add(new MapRegion(MapRegionType.Ocean, 1, 500, 1, 165, 20));

            //SouthWind
            Regions.Add(new MapRegion(MapRegionType.SouthWind, 352, 414,  72, 86, 5));


            return Regions;
        }

        public static bool BoundaryCheck(int newX, int newY, TheCaregiver.World.Map m )
        {
            bool inBounds = true;

            if (newX >= m.X || newY >= m.Y)
                return false;
            else if (newX <= 0 || newY <= 0)
                return false;

            return inBounds;

        }
    }
}
