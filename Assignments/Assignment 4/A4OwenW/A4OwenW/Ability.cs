using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4OwenW
{
    public class Ability : Character
    {
        public string AbilityName;
        public int AbilityLevel;

        public Ability(string abilityName, int abilityLevel)
        {
            AbilityName = abilityName;
            AbilityLevel = abilityLevel;
        }
    }
}
