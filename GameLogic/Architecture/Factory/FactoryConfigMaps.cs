using System.Collections.Generic;

namespace GameLogic.Architecture
{
    public static class FactoryConfigMaps
    {
        public static Dictionary<MapType, MapConfig> CreateMaps()
        {
            Dictionary<MapType, MapConfig> maps = new Dictionary<MapType, MapConfig>()
            { 
                {
                    MapType.Empty, new MapConfig()
                    {
                        Type = MapType.Empty
                    }
                },
                {
                    MapType.PowerPlant, new MapConfig()
                    {
                        Type = MapType.PowerPlant,
                        ObjectsOnMapLimit = 5,
                        AvailableObjectsOnMap = new [] { ObjectOnMapType.Generator}
                    }
                },
                {
                    MapType.Smeltery, new MapConfig()
                    {
                        Type = MapType.Smeltery,
                        ObjectsOnMapLimit = 4,
                        AvailableObjectsOnMap = new [] { ObjectOnMapType.Furnace }
                    }
                },
                {
                    MapType.Roboport, new MapConfig()
                    {
                        Type = MapType.Roboport,
                        ObjectsOnMapLimit = 3,
                        AvailableObjectsOnMap = new []
                            {
                                ObjectOnMapType.Digger,
                                ObjectOnMapType.Miner
                            }
                    }
                },
                {
                    MapType.Objects, new MapConfig()
                    {
                        Type = MapType.Objects,
                        ObjectsOnMapLimit = 10000000,
                        AvailableObjectsOnMap = new []
                        {
		    //строения Buildings
		                    ObjectOnMapType.AutominerMetallOre,
                            ObjectOnMapType.AutominerRareEarthOre,
                            ObjectOnMapType.MiningComplex,
                            ObjectOnMapType.ConcentratingFactory,
                            ObjectOnMapType.SolarPanel,
                            ObjectOnMapType.NuclearPlant,
                            ObjectOnMapType.HeatGenerator,
                            ObjectOnMapType.WaterRig,
                            ObjectOnMapType.Greenhouse,
                            ObjectOnMapType.Conservatory,
                            ObjectOnMapType.HydroponicsFoodProduction,
                            ObjectOnMapType.HydroponicsVegetableRawProduction,
                            ObjectOnMapType.VacuumSmelter,
                            ObjectOnMapType.ElectrrolysSmelter,
                            ObjectOnMapType.ChemicalLaboratory,
                            ObjectOnMapType.PolymerSyntesis,
		    //марсоходы Rover
		                    ObjectOnMapType.RoverOnMetallOre,
                            ObjectOnMapType.RoverOnRareEarthOre,
		    //залежи ресурсов DepositRecources
		                    ObjectOnMapType.DepositIce,
                            ObjectOnMapType.DepositMetallOre,
                            ObjectOnMapType.DepositRareEarthOre,
		    //Особенности ландшафта
		                    ObjectOnMapType.Crater,
                            ObjectOnMapType.Rock
                        }
                    }
                },
                {
                    MapType.Buildings, new MapConfig()
                    {
                        Type = MapType.Buildings,
                        ObjectsOnMapLimit = 10000000,
                        AvailableObjectsOnMap = new []
                        {
		    //строения Buildings
		                    ObjectOnMapType.AutominerMetallOre,
                            ObjectOnMapType.AutominerRareEarthOre,
                            ObjectOnMapType.MiningComplex,
                            ObjectOnMapType.ConcentratingFactory,
                            ObjectOnMapType.SolarPanel,
                            ObjectOnMapType.NuclearPlant,
                            ObjectOnMapType.HeatGenerator,
                            ObjectOnMapType.WaterRig,
                            ObjectOnMapType.Greenhouse,
                            ObjectOnMapType.Conservatory,
                            ObjectOnMapType.HydroponicsFoodProduction,
                            ObjectOnMapType.HydroponicsVegetableRawProduction,
                            ObjectOnMapType.VacuumSmelter,
                            ObjectOnMapType.ElectrrolysSmelter,
                            ObjectOnMapType.ChemicalLaboratory,
                            ObjectOnMapType.PolymerSyntesis,
                        }
                    }
                },
                {
                    MapType.Rovers, new MapConfig()
                    {
                        Type = MapType.Rovers,
                        ObjectsOnMapLimit = 10000000,
                        AvailableObjectsOnMap = new []
                        {
		    //марсоходы Rover
		                    ObjectOnMapType.RoverOnMetallOre,
                            ObjectOnMapType.RoverOnRareEarthOre,
                        }
                    }
                },
                {
                    MapType.LandscapeFeatures, new MapConfig()
                    {
                        Type = MapType.LandscapeFeatures,
                        ObjectsOnMapLimit = 10000000,
                        AvailableObjectsOnMap = new []
                        {
		    //Особенности ландшафта
		                    ObjectOnMapType.Crater,
                            ObjectOnMapType.Rock,
                        }
                    }
                },
                {
                    MapType.DepositsResource, new MapConfig()
                    {
                        Type = MapType.DepositsResource,
                        ObjectsOnMapLimit = 10000000,
                        AvailableObjectsOnMap = new []
                        {
		    //залежи ресурсов DepositRecources
		                    ObjectOnMapType.DepositIce,
                            ObjectOnMapType.DepositMetallOre,
                            ObjectOnMapType.DepositRareEarthOre
                        }
                    }
                }
            };
            return maps;
        }
    }
}
