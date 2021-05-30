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
			Assert.AreEqual(0, colony.Map.ObjectsOnMap.Count());

			Assert.IsTrue(
				new MapCreate(
					colony,
					core.Factory.CreateMap(MapType.PowerPlant)
				)
				.Execute(core)
				.IsValid
			);

			Assert.AreEqual(MapType.PowerPlant, colony.Map.Type);
			Assert.AreEqual(0, colony.Map.ObjectsOnMap.Count());

			Assert.IsTrue(
				new ObjectPlaceOnMap(
					colony.Map,
					core.Factory.CreateObject(ObjectOnMapType.Generator),
					2
				)
				.Execute(core)
				.IsValid
			);

			Assert.AreEqual(MapType.PowerPlant, colony.Map.Type);
			Assert.AreEqual(ObjectOnMapType.Generator, colony.Map.GetObjectonMap(2).Type);
			Assert.AreEqual(1, colony.Map.ObjectsOnMap.Count());
		}

		[TestMethod]
		public void IncorrectConstruction ()
		{
			var core = new Core();
			var colony = core.Mars.GetColony(0);

			Assert.IsFalse(
				new MapCreate(
					colony,
					core.Factory.CreateMap(MapType.Empty)
				)
				.Execute(core)
				.IsValid
			);

			Assert.IsFalse(
				new ObjectPlaceOnMap(
					colony.Map,
					core.Factory.CreateObject(ObjectOnMapType.Generator),
					2
				)
				.Execute(core)
				.IsValid
			);

			new MapCreate(
				colony,
				core.Factory.CreateMap(MapType.PowerPlant)
			)
			.Execute(core);

			Assert.IsFalse(
				new MapCreate(
					colony,
					core.Factory.CreateMap(MapType.PowerPlant)
				)
				.Execute(core)
				.IsValid
			);

			Assert.IsFalse(
				new ObjectPlaceOnMap(
					colony.Map,
					core.Factory.CreateObject(ObjectOnMapType.Generator),
					1000001
				)
				.Execute(core)
				.IsValid
			);
		}
	}
}
