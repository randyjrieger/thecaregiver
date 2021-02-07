using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Templates
{
    public interface ILocation
    {
        string name { get; set; } 
        string merchant { get; set; } 
        List<ItemsForSale> items_for_sale { get; set; } 
    }
}
