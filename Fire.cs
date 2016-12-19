using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameBlake
{
    public class Fire
    {
        public bool fireAttackSuccess= false;
        public bool fireStatus = false;
        public bool FireAttack(double defendingUnitMagicDefense, double attackingUnitFireRating)
        {
            //Fire attack success should increase damage dealt by FireAttackPower and increase exponentially if successful through fire status
            if (defendingUnitMagicDefense > attackingUnitFireRating)
            {
                fireAttackSuccess = false;
            }
            else
            { fireAttackSuccess = true;
            }
            return fireAttackSuccess;         
        }
        public bool FireStatus(bool fireAttackSuccess)
        {
            if(fireAttackSuccess)
            {
                fireStatus = true;
            }
            else { fireStatus = false; }
            return fireStatus;
        }
    }
}
