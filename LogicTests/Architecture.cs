using System.Linq;
using GameLogic;
using GameLogic.Architecture;
using GameLogic.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests
{
	[TestClass]
	public class Architecture
	{
		[TestMethod]
		public void CorrectConstruction ()
		{
			var core = new Core();
			var colony = core.Mars.GetColony(0);

			Assert.AreEqual(MapType.Empty, colony.Map.Type);
			Assert.AreEqual(0, colony.Map.Builings.Count());

			Assert.IsTrue(
				new MapCreate(
					colony,
					new Map(MapType.PowerPlant)
				)
				.Execute(core)
				.IsValid
			);

			Assert.AreEqual(MapType.PowerPlant, colony.Map.Type);
			Assert.AreEqual(0, colony.Map.Builings.Count());

			Assert.IsTrue(
				new BuildingConstruct(
					colony.Map,
					new Building(BuildingType.Generator),
					2
				)
				.Execute(core)
				.IsValid
			);

			Assert.AreEqual(MapType.PowerPlant, colony.Map.Type);
			Assert.AreEqual(BuildingType.Generator, colony.Map.GetBuilding(2).Type);
			Assert.AreEqual(1, colony.Map.Builings.Count());
		}

		[TestMethod]
		public void IncorrectConstruction ()
		{
			var core = new Core();
			var room = core.Mars.GetColony(0);

			Assert.IsFalse(
				new MapCreate(
					room,
					new Map(MapType.Empty)
				)
				.Execute(core)
				.IsValid
			);

			Assert.IsFalse(
				new BuildingConstruct(
					room.Map,
					new Building(BuildingType.Generator),
					2
				)
				.Execute(core)
				.IsValid
			);

			new MapCreate(
				room,
				new Map(MapType.PowerPlant)
			)
			.Execute(core);

			Assert.IsFalse(
				new MapCreate(
					room,
					new Map(MapType.PowerPlant)
				)
				.Execute(core)
				.IsValid
			);

			Assert.IsFalse(
				new BuildingConstruct(
					room.Map,
					new Building(BuildingType.Generator),
					1000001
				)
				.Execute(core)
				.IsValid
			);
		}
	}
}
