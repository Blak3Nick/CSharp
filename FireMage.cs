using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameBlake
{ 
    public class FireMage
    {
        public string Description = "Fire-wielding mage whose enemies burn quicker with each passing turn.";

        public double Attack = 3;
        public double Health = 2;
        public double fireAttackPower = 3;

        public string specialAttackDescription = "If the Fire Mage executes a successful fire attack, the enemy is dealt extra damage based on the Mage's fire Power. The successful attack increases damage dealt by doubling the fire damage dealt to an enemy who is already burning.";

        public double magicDefense = 15;
        public double physicalDefense = 1;
        public int manaCost = 3;
    }
}
