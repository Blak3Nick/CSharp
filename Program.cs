﻿using System;

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
		}
	}
}


