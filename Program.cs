using System;

namespace CardGameBlake
{
	 class CardGame
	{
		public static void Main()
		{
			BasicPawn pawn = new BasicPawn(1, 1, 1, 1, 1);
            pawn.Description = "This is a basic unit with one attack.";
			System.Console.WriteLine ("Hello world");
			string returned = pawn.ReturnPawnDesc();
			System.Console.WriteLine (returned);
            pawn.Attack = 1;
            Console.WriteLine("The pawn has "+ pawn.Attack+" power.");
		}
	}
}


