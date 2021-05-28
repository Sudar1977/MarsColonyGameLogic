using System.Collections.Generic;

namespace GameLogic.Architecture
{
	public class Mars
	{
		// Временно добавим некоторое количество комнат
		public readonly int ColonyLimit = 10;

		private readonly List<Colony> colonies = new List<Colony>();

		public IEnumerable<Colony> Colonies {
			get { return colonies; }
		}

		public void CreateEmptyColony ()
		{
			for (var i = 0; i < ColonyLimit; i++) {
				colonies.Add(new Colony(i));
			}
		}

		public Colony GetColony (int index)
		{
			return colonies[index];
		}
	}
}
