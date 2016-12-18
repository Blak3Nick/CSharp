namespace CardGameBlake
{
    class AttackSequence
    {
        public double HealthAfterAttack;
        public double physicalAttack(double attackingUnitAttack, double defendingUnitDefense, double defendingUnitHealth )
        {
            double defenseCheck = defendingUnitDefense * .25;
            double healthToDecrease = attackingUnitAttack - defenseCheck;
            HealthAfterAttack =  defendingUnitHealth - healthToDecrease;
            return HealthAfterAttack;
        }
    }
}