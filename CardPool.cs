namespace CardGameBlake
{
    public class CardPool
    {
        public int SelectCard(int numOfUnitType, int UserInput)
        {
            //numOfUnitType is the number that corresponds to the unit ex. Pawn = 1
           
            // selectedCard will return which card type has been selected
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
        public void setNumOfGiants(int giants)
        {
            this.numOfGiants = giants;
        }
        public int getNumOfPawns()
        {
            return this.numOfPawns;
        }
        public int getNumOfGiants()
        {
            return this.numOfGiants;
        }
        public void setNumOfIceWizards(int icewizards)
        {
            this.numOfIceWizards = icewizards;
        }
        public int getNumOfIceWizards()
        {
            return this.numOfIceWizards;
        }

    }
}