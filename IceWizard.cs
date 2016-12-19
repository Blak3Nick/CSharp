namespace CardGameBlake
{
	class IceWizard
    {
           
        public string Description = "Has 3 power and freezes on successful hit. If frozen enemies cannot attack on the next turn";
        public string ReturnPawnDesc()
        {
            return Description;
        }
        public double Attack = 3;
        public double Health = 2;
        public double freezeChance = 20;
       /* public bool DidFreeze(double magicDefense)
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
        */
        public double ReturnAttack()
        {
            return Attack;
        }
        public double magicDefense = 15;
        public double physicalDefense = 1;
        public int manaCost = 3;
    
        public IceWizard( )
        {

            
        }
        }
}