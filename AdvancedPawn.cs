namespace CardGameBlake
{
    class AdvancedPawn
    {
        public string Description = "Merge of two basic pawns to create an advanced unit.";
        public double Attack = 4;
        public double Health = 15;
        public  double magicDefense = 4;
        public double physicalDefense = 8;
        public int manaCost = 0;

        public AdvancedPawn()
        {
            this.Attack = 4;
            this.Health = 15;
            this.magicDefense = 4;
            this.physicalDefense = 8;
            this.manaCost = 0;
        }
    }
}