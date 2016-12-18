using System;

namespace CardGameBlake
{
	 class CardGame
	{
		public static void Main()
		{
			CardPool player1CardPool = new CardPool();
			CardPool player2CardPool = new CardPool();
			ConvertString convert = new ConvertString();

            Console.WriteLine("PLayer 1, How many pawns would you like?");
			string PawnSelection = Console.ReadLine();
			int intPawnSelection = convert.Convert(PawnSelection);
			GameLaunch game = new GameLaunch(7,7);
			player1CardPool.setNumOfPawns(intPawnSelection);
			int pawns = player1CardPool.getNumOfPawns();
			Console.WriteLine("Your number of pawns is "+ pawns);

			Console.WriteLine("PLayer 1, How many Ice Wizards would you like?");
			string IceWizardSelection = Console.ReadLine();
			int intIceWizardSelection = convert.Convert(IceWizardSelection);
			player1CardPool.setNumOfIceWizards(intIceWizardSelection);
			int icewizards = player1CardPool.getNumOfIceWizards();
			Console.WriteLine("Your number of Ice Wizards is "+ icewizards);

			Console.WriteLine("PLayer 1, How many Giants would you like?");
			string GiantSelection = Console.ReadLine();
			int intGiantSelection = convert.Convert(GiantSelection);
			player1CardPool.setNumOfGiants(intGiantSelection);
			int giants = player1CardPool.getNumOfGiants();
			Console.WriteLine("Your number of Giants is "+ giants);

			BasicPawn pawn1 = new BasicPawn();
			Console.WriteLine(pawn1.Attack+ pawn1.Description + pawn1.Health);
			AdvancedPawn adPawn1 = new AdvancedPawn(1, 2);
			GameBoard gameBoard = new GameBoard();
			Console.WriteLine(gameBoard.xAxis);
			MapLocation mapLocation = new MapLocation(4,9);
			bool isonmap = mapLocation.checkMapLocation(mapLocation.xLocation, mapLocation.yLocation);
			Console.WriteLine(isonmap);

		}
	}
}


