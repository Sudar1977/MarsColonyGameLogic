using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Architecture
{
    static class FactoryConfigObjectsOnMap
    {
        public static readonly Dictionary<ObjectOnMapType, ObjectOnMapConfig> objectsOnMap =
            new Dictionary<ObjectOnMapType, ObjectOnMapConfig>()
        {
            {
                ObjectOnMapType.Generator, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.Generator
                }
            },
            {
                ObjectOnMapType.Furnace, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.Furnace
                }
            },
            {
                ObjectOnMapType.Digger, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.Digger
                }
            },
            {
                ObjectOnMapType.Miner, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.Miner
                }
            },
		//строения Buildings
            {
                ObjectOnMapType.AutominerMetallOre, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.AutominerMetallOre
                }
            },
            {
                ObjectOnMapType.AutominerRareEarthOre, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.AutominerRareEarthOre
                }
            },
            {
                ObjectOnMapType.AutominerMetallOre, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.AutominerMetallOre
                }
            },
            {
                ObjectOnMapType.MiningComplex, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.MiningComplex
                }
            },
            {
                ObjectOnMapType.ConcentratingFactory, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.ConcentratingFactory
                }
            },
            {
                ObjectOnMapType.SolarPanel, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.SolarPanel
                }
            },
            {
                ObjectOnMapType.NuclearPlant, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.NuclearPlant
                }
            },
            {
                ObjectOnMapType.HeatGenerator, new ObjectOnMapConfig()
                {
                    Type = ObjectOnMapType.HeatGenerator
                }
            },        

  //      ,
  //      WaterRig,
  //      Greenhouse,
  //      Conservatory,
  //      HydroponicsFoodProduction,
  //      HydroponicsVegetableRawProduction,
  //      VacuumSmelter,
  //      ElectrrolysSmelter,
  //      ChemicalLaboratory,
  //      PolymerSyntesis,
		////марсоходы Rover
		//RoverOnMetallOre,
  //      RoverOnRareEarthOre,
		////залежи ресурсов DepositRecources
		//DepositIce,
  //      DepositMetallOre,
  //      DepositRareEarthOre,
		////Особенности ландшафта
		//Rock,
  //      Crater,





        };


    }
}
