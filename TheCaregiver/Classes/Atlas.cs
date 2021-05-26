using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TheCaregiver.Player1;
using TheCaregiver.Classes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace TheCaregiver.World
{
    public static class Atlas
    {
        public static Dictionary<Place, Map> Maps = new Dictionary<Place, Map>();
        public static Dictionary<Coordinates, Place> Locations = new Dictionary<Coordinates, Place>();

        public static Boolean BuildTownDatabase(Season season)
        {
            Boolean success = true;

            string s = File.ReadAllText(@"..\..\Resources\jsonDB\town_locations.json");
            var townCollection = JObject.Parse(s).SelectToken("towns").ToString();
            var towns = JsonConvert.DeserializeObject<List<Town>>(townCollection);
            //   var sign = signs.Find(t => t.x == x && t.y == y);


            try
            {
                //Wilderness
                Maps.Add(Place.Wilderness, new Map
                {
                    StartX = 65,
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
                foreach (Town t in towns)
                {

                    Locations.Add(new Coordinates { X = t.worldX, Y = t.worldY }, (Place)System.Enum.Parse(typeof(Place), t.place));

                    Maps.Add((Place)System.Enum.Parse(typeof(Place), t.place), new Map
                    {
                        StartX = t.startX,
                        StartY = t.startY,
                        WorldX = t.worldX,
                        WorldY = t.worldY,
                        X = t.X,
                        Y = t.Y,
                        type = LocationType.Town,
                        filePath = Path.Combine(Environment.CurrentDirectory, t.filePath),
                        MAPID = (Place)System.Enum.Parse(typeof(Place), t.place)
                    });
                }

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
