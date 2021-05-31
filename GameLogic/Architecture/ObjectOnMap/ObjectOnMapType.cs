using System.IO;

namespace GameLogic.Architecture
{
	public enum ObjectOnMapType
	{
		//�������� Buildings
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
		//��������� Rover
		RoverOnMetallOre,
		RoverOnRareEarthOre,
		//������ �������� DepositRecources
		DepositIce,
		DepositMetallOre,
		DepositRareEarthOre,
		//����������� ���������
		Rock,
		Crater,
		//�������� ������� ���� ����� ������
		Generator,
		Furnace,
		Digger,
		Miner
	};

}
