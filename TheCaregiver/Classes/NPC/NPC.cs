using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security;
using TheCaregiver.Templates;
using TheCaregiver.People;

namespace TheCaregiver.Classes
{
    public enum NPCType
    {
        None = 0,
        Merchant = 1,
        Special = 2,

    }

    public class NPC : Person
    {        
        public NPCType Type { get; set; }
    }
}
