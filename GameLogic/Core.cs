using GameLogic.Architecture;
using System;

namespace GameLogic
{
	public class Core
	{
		public readonly Mars Mars = new Mars();
		public readonly Factory Factory = new Factory();
		public readonly Turns Turns = new Turns();

		public Core ()
		{
			// � �������� ������ �������� �������
			Mars.CreateEmptyColony(Factory);
			//Mars.CreateEmptyColony();
		}
		public static void Main()
		{
			System.Console.ReadLine();
		}

	}
}
