using GameLogic.Architecture;

namespace GameLogic.Commands
{
	public class BuildingConstruct : Command
	{
		public readonly Map Building;
		public readonly Building Module;
		public readonly int Position;

		public BuildingConstruct (Map building, Building module, int position)
		{
			Building = building;
			Module = module;
			Position = position;
		}

		protected override bool Run ()
		{
			if (Building.Type == MapType.Empty) {
				return false;
			}

			if (Position < 0 || Position >= Building.BuildingLimit) {
				return false;
			}

			if (Building.GetBuilding(Position) != null) {
				return false;
			}

			Building.SetBuilding(Position, Module);
			return true;
		}
	}

}
