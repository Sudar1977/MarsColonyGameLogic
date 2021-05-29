using GameLogic.Architecture;

namespace GameLogic.Commands
{
	public class ObjectPlaceOnMap : Command
	{
		public readonly Map Building;
		public readonly ObjectOnMap Module;
		public readonly int Position;

		public ObjectPlaceOnMap (Map building, ObjectOnMap module, int position)
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

			if (Position < 0 || Position >= Building.ObjectsOnMapLimit) {
				return false;
			}

			if (Building.GetObjectonMap(Position) != null) {
				return false;
			}

			Building.SetObjectonMap(Position, Module);
			return true;
		}
	}

}
