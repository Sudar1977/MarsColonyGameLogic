using GameLogic.Architecture;
using System;

namespace GameLogic
{
	public class Core
	{
		public static void Main() 
		{
			System.Console.ReadLine();
		}

		public readonly Mars Mars = new Mars();

		public Core ()
		{
			Mars.CreateEmptyColony();
		}
	}
}
