using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Classes
{

    public class MonsterCard
    {
        public int Name { get; set; }
        public Commonality Commonality { get; set; }

        public List<MapRegion> RegionsFound { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int HealthMax { get; set; }
        public int DamageMax { get; set; }
        public string Introduction { get; set; }
        public SpecialAttack SpecialAttack { get; set; }
        public string SpecialAttackDescription { get; set; }
        public int NumberOfAttacks { get; set; }
        public int MinHourVisible { get; set; }
        public int MaxHourVisible { get; set; }
        public int SuddenAppearance { get; set; }
        public int AllowedTiles { get; set; }

        public MonsterCard()
        {
            RegionsFound = new List<MapRegion>();
        }
    }
}
