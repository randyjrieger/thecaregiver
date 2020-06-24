using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCaregiver.Templates
{
    public interface IMonster
    {
        object Clone();
        bool CheckNextStep(int tile);

        void DetermineStartingHealth();
    }
}
