using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TheCaregiver.Player1;
using TheCaregiver.Classes;

namespace TheCaregiver.World
{
    public static class Atlas
    {
        public static Dictionary<Place, Map> Maps = new Dictionary<Place, Map>();
        public static Dictionary<Coordinates, Place> Locations = new Dictionary<Coordinates, Place>();



        public static Boolean BuildAtlas(Season season)
        {
            Boolean success = true;

            try
            {
                //Add Maps
                //Maps.Add(Place.Wilderness, new Map
                //{
                //    StartX = 30,
                //    StartY = 120,
                //    WorldX = 0,
                //    WorldY = 0,
                //    X = 300,
                //    Y = 155,
                //    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/world.txt"),
                //    MAPID = Place.Wilderness
                //});

                //Add Maps




                Maps.Add(Place.Wilderness, new Map
                {
                    StartX =65,
                    StartY = 25,
                    WorldX = 0,
                    WorldY = 0,
                    X = 500,
                    Y = 180,
                    type = LocationType.None,
                    filePath = season == Season.winter ? Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/world-winter.txt") : Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/world.txt"),
                    MAPID = Place.Wilderness
                });

                //Towns

                Locations.Add(new Coordinates { X = 158, Y = 141 }, Place.Lancer);
                Maps.Add(Place.Lancer, new Map
                {
                    StartX = 35,
                    StartY = 2,
                    WorldX = 158,
                    WorldY = 141,
                    X = 151,
                    Y = 53,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Lancer.txt"),
                    MAPID = Place.Lancer
                });

                Locations.Add(new Coordinates { X = 246, Y = 101 }, Place.NordPoint);
                Maps.Add(Place.NordPoint, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 246,
                    WorldY = 101,
                    X = 151,
                    Y = 53,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/NordPoint.txt"),
                    MAPID = Place.NordPoint
                });

                Locations.Add(new Coordinates { X = 77, Y = 61 }, Place.Fyster);
                Maps.Add(Place.Fyster, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 77,
                    WorldY = 61,
                    X = 151,
                    Y = 53,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Fyster.txt"),
                    MAPID = Place.Fyster
                });

                Locations.Add(new Coordinates { X = 264, Y = 47 }, Place.Grove);
                Maps.Add(Place.Grove, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 264,
                    WorldY = 47,
                    X = 151,
                    Y = 53,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/GroveOfFilu.txt"),
                    MAPID = Place.Grove
                });

                Locations.Add(new Coordinates { X = 87, Y = 100 }, Place.Nazidar);
                Maps.Add(Place.Nazidar, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 87,
                    WorldY = 100,
                    X = 151,
                    Y = 53,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Nazidar.txt"),
                    MAPID = Place.Nazidar
                });

                Locations.Add(new Coordinates { X = 417, Y = 108 }, Place.Lawdyn);
                Maps.Add(Place.Lawdyn, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 417,
                    WorldY = 108,
                    X = 151,
                    Y = 53,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Lawdyn.txt"),
                    MAPID = Place.Lawdyn
                });

                Locations.Add(new Coordinates { X = 428, Y = 96 }, Place.Otalio);
                Maps.Add(Place.Otalio, new Map
                {
                    StartX = 10,
                    StartY = 10,
                    WorldX = 418,
                    WorldY = 96,
                    X = 80,
                    Y = 35,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Otalio.txt"),
                    MAPID = Place.Otalio
                });

                Locations.Add(new Coordinates { X = 388, Y = 93 }, Place.Southwind);
                Maps.Add(Place.Southwind, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 388,
                    WorldY = 93,
                    X = 151,
                    Y = 53,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Southwind.txt"),
                    MAPID = Place.Southwind
                });

                Locations.Add(new Coordinates { X = 400, Y = 50 }, Place.Byas);
                Maps.Add(Place.Byas, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 400,
                    WorldY = 50,
                    X = 151,
                    Y = 53,
                    type = LocationType.Town,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Byas.txt"),
                    MAPID = Place.Byas
                });

                Locations.Add(new Coordinates { X = 286, Y = 73 }, Place.Iye);
                Maps.Add(Place.Iye, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 286,
                    WorldY = 73,
                    X = 165,
                    Y = 60,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Iye.txt"),
                    MAPID = Place.Iye
                });

                Locations.Add(new Coordinates { X = 319, Y = 98 }, Place.Tempest);
                Maps.Add(Place.Tempest, new Map
                {
                    StartX = 30, 
                    StartY = 30,
                    WorldX = 319,
                    WorldY = 98,
                    X = 151,
                    Y = 53,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Iye.txt"),
                    MAPID = Place.Tempest
                });

                Locations.Add(new Coordinates { X = 165, Y = 60 }, Place.Radius);
                Maps.Add(Place.Radius, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 165,
                    WorldY = 60,
                    X = 151,
                    Y = 53,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Iye.txt"),
                    MAPID = Place.Radius
                });

                Locations.Add(new Coordinates { X = 177, Y = 27 }, Place.Snowport);
                Maps.Add(Place.Snowport, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 177,
                    WorldY = 27,
                    X = 151,
                    Y = 53,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Iye.txt"),
                    MAPID = Place.Snowport
                });

                Locations.Add(new Coordinates { X = 317, Y = 147 }, Place.Flagport);
                Maps.Add(Place.Flagport, new Map
                {
                    StartX = 30,
                    StartY = 30,
                    WorldX = 317,
                    WorldY = 147,
                    X = 151,
                    Y = 53,
                    type = LocationType.Special,
                    filePath = Path.Combine(Environment.CurrentDirectory, @"../../Resources/maps/Iye.txt"),
                    MAPID = Place.Flagport
                });
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }

        //public static Map FindMapByPlaceID(Place id)
        //{
        //    return Maps[id];
        //}

    }
}
