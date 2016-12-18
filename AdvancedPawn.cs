namespace CardGameBlake
{
    class AdvancedPawn: BasicUnit
    {
        public readonly string Description = "Merge of two basic pawns to create an advanced unit.";
        new readonly double Attack = 4;
        new readonly double Health = 15;
        new readonly double magicDefense = 4;
        new readonly double physicalDefense = 8;
        new readonly int manaCost = 0;

        public AdvancedPawn(int pawn1, int pawn2)
        {
            
        }
    }
}