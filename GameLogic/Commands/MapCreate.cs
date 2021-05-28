using GameLogic.Architecture;

namespace GameLogic.Commands
{
	public class MapCreate : Command
	{
		public readonly Colony Colony;
		public readonly Map Map;

		public MapCreate (Colony colony, Map map)
		{
			Colony = colony;
			Map = map;
		}

		protected override bool Run ()
		{
			// Нельзя строить там, где уже что-то есть
			if (Colony.Map.Type != MapType.Empty) {
				return false;
			}
			// Нельзя строить пустую карту
			if (Map.Type == MapType.Empty) {
				return false;
			}

			Colony.Map = Map;
			return true;
		}
	}
}
