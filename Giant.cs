namespace CardGameBlake
{
    class Giant : BasicUnit
    {
        public Giant(double attack, double health, double magicDef, double physicalDef, int manaCost )
        {
            this.Attack = attack;
            this.Health = health;
            this.magicDefense = magicDef;
            this.physicalDefense = physicalDef;
            this.manaCost = manaCost;
        }

    }
}