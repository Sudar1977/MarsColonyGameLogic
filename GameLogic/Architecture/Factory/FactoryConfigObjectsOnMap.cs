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
            }
        };


    }
}
