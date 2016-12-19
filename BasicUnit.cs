namespace CardGameBlake
{
    class BasicUnit
    {
        public double Attack = 0;
        public double Health = 0;
        public double magicDefense = 0;
        public double physicalDefense = 0;
        public int manaCost = 1;
        public int range = 1;
        public void onBoardEntry()
        {
            //This method will be used for battlefield entry effects
            //These effects will be things like raising attack power or increasing resources
        }
        public void specialAttack()
        {
            //Here the special method of attack will be implemented.
            //Example: Fire, Ice, Death, Poison
        }
        public void makeSummonSound()
        {
            //This is the method for emiting a sound when summoning the unit 
        }

        

    }
}