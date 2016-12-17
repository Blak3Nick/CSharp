namespace CardGameBlake
{
	class BasicPawn
    {
           
        public string Description = "Basic unit with low attack and no special skills";
        public string ReturnPawnDesc()
        {
            return Description;
        }
        public double Attack = 1;
        public double Health = 5;
        public double ReturnAttack()
        {
            return Attack;
        }
        public double magicDefense = 1;
        public double physicalDefense = 1;
        public int manaCost = 1;
        public BasicPawn(double attack, double health, double magicDef, double physicalDef, int manaCost )
        {
            this.Attack = attack;
            this.Health = health;
            this.magicDefense = magicDef;
            this.physicalDefense = physicalDef;
            this.manaCost = manaCost;
            

        }

    }
}
