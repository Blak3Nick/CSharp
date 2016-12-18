namespace CardGameBlake
{
	class BasicPawn
    {
           
        public readonly string Description = "Basic unit with low attack and no special skills";
        public string ReturnPawnDesc()
        {
            return Description;
        }
        public readonly double Attack = 1;
        public readonly double Health = 5;
        public double ReturnAttack()
        {
            return Attack;
        }
        public readonly double magicDefense = 1;
        public readonly double physicalDefense = 1;
        public readonly int manaCost = 1;
        public BasicPawn()
        {
                  
        }
        
    
    }
}
