using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Classes
{
    public static class SignHelper  {
        
        public static string ReadSign(int x, int y)
        {
            string s = File.ReadAllText(@"..\..\Resources\jsonDB\signs.json");
            var signCollection = JObject.Parse(s).SelectToken("signs").ToString();
            var signs = JsonConvert.DeserializeObject<List<Sign>>(signCollection);
            var sign = signs.Find(t => t.x == x && t.y == y);

            return sign.text;          
        }
    }

    public class Sign
    {
        public string text { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
