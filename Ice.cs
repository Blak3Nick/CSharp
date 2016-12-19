using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameBlake
{
    public class Ice
    {
        public bool didFreeze;
        public bool freezeAttack(double defendingUnitMagicDefense, double attackingUnitFreezeChance)
        {
            //When a unit with ice element attacks there is a chance of freezing the unit attacked for one turn
            //Only affects units 
            //Magic Defense is used to check for success  of the attack
            if (defendingUnitMagicDefense > attackingUnitFreezeChance)
            {
                didFreeze = false;
            }
            else
            {
                didFreeze = true;
            }
            return didFreeze;
        }
    }
}
