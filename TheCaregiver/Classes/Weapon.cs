using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Classes
{
    public enum WeaponHandedness
    {
        OneHanded = 0,
        TwoHanded = 1
    };
    public class Weapon
    {
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public WeaponHandedness Handedness { get; set; }
    }
}
