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
		public readonly Factory Factory = new Factory();

		public Core ()
		{
			// В аргумент метода передаем фабрику
			Mars.CreateEmptyColony(Factory);
			//Mars.CreateEmptyColony();
		}
	}
}
