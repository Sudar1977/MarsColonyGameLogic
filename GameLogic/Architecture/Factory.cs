using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Architecture
{
    public class Factory
    {
        private readonly Dictionary<MapType, MapConfig> maps = new Dictionary<MapType, MapConfig>()
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
                        ObjectOnMapType.DepositRareEarthOre                    
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

        private readonly Dictionary<ObjectOnMapType, ObjectOnMapConfig> objectsOnMap =
            new Dictionary<ObjectOnMapType, ObjectOnMapConfig> ()
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
        };



        public Map CreateMap(MapType type) 
        {
            if (!maps.ContainsKey(type))
            {
                throw new Exception("Uncknown map type: " + type);
            }
            return new Map(maps[type]);
        }
        public ObjectOnMap CreateObject(ObjectOnMapType type)
        {
            if (!objectsOnMap.ContainsKey(type))
            {
                throw new Exception("Not implemented yet");
            }
            return new ObjectOnMap(objectsOnMap[type]);
        }

    }
}
