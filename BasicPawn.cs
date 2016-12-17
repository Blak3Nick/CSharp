namespace CardGameBlake
{
	class BasicPawn
    {
           
        public string Description = "Basic unit with low attack and no special skills";
        public string ReturnPawnDesc()
        {
            return Description;
        }
        public int Attack = 1;
        public int Health = 5;
        public int ReturnAttack()
        {
            return Attack;
        }
    }
}
