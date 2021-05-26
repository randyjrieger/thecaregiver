using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCaregiver.Classes;

namespace TheCaregiver.Templates
{
    public class Location : ILocation
    {
        public string name { get; set; }
        public string type { get; set; }
        public string merchant { get; set; }
        public List<ItemsForSale> items_for_sale { get; set; }
    }

    public class Root
    {
        public List<Town> towns { get; set; }
    }
}
