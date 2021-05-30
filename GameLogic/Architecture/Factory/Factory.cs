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
        private readonly Dictionary<MapType, MapConfig> maps = FactoryConfigMaps.CreateMaps();
        private readonly Dictionary<ObjectOnMapType, ObjectOnMapConfig> objectsOnMap =
             FactoryConfigObjectsOnMap.objectsOnMap;

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
