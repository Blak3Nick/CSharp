namespace CardGameBlake
{
    public class CardPool
    {
        public int SelectCard(int numOfUnitType, int UserInput)
        {
            //numOfUnitType is the number that corresponds to the unit ex. Pawn = 1
            // user will select how many of that type they want
            // selectedCard will return how many of that type to the players card pool
            int selectedCard = 0;
            return selectedCard;
        }
        public int numOfPawns = 0;
        public int numOfIceWizards = 0;
        public int numOfGiants = 0;
        public int PawnRef = 1;
        public int IceWizardRef = 2;
        public int GiantRef = 3;
        public void setNumOfPawns(int pawns)
        {
            this.numOfPawns = pawns;
        }
        public int getNumOfPawns()
        {
            return this.numOfPawns;
        }

    }
}