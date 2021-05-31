using System.IO;

namespace GameLogic.Architecture
{
	public enum ObjectOnMapType
	{
		//строения Buildings
		AutominerMetallOre,
		AutominerRareEarthOre,
		MiningComplex,
		ConcentratingFactory,
		SolarPanel,
		NuclearPlant,
		HeatGenerator,
		WaterRig,
		Greenhouse,
		Conservatory,
		HydroponicsFoodProduction,
		HydroponicsVegetableRawProduction,
		VacuumSmelter,
		ElectrrolysSmelter,
		ChemicalLaboratory,
		PolymerSyntesis,
		//марсоходы Rover
		RoverOnMetallOre,
		RoverOnRareEarthOre,
		//залежи ресурсов DepositRecources
		DepositIce,
		DepositMetallOre,
		DepositRareEarthOre,
		//Особенности ландшафта
		Rock,
		Crater,
		//рудимент старого кода нужно убрать
		Generator,
		Furnace,
		Digger,
		Miner
	};

}
