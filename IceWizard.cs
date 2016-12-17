namespace CardGameBlake
{
	class IceWizard
    {
           
        public string Description = "Has 3 power and freezes on successful hit. If frozen enemies cannot attack on the next turn";
        public string ReturnPawnDesc()
        {
            return Description;
        }
        public int Attack = 3;
        public int Health = 2;
        public double freezeChance = .75;
        public bool DidFreeze(double magicDefense)
        {
            double freezeSuccess = magicDefense * freezeChance;
            bool didFreeze;
            if(freezeSuccess>7.5)
            {didFreeze = true;}
            else
            {
                didFreeze = false;
            }
            return didFreeze;
        }
        public int ReturnAttack()
        {
            return Attack;
        }
    }
}