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
            }//,
            //{

            //}
        };



        public Map CreateMap(MapType type) 
        {

            //var content = File.ReadAllText("test");
            //JsonConvert.DeserializeObject<ModuleConfig>(content);

            throw new Exception("Not implemented yet");
        }
        public ObjectOnMap CreateObject(ObjectOnMapType type)
        {
            throw new Exception("Not implemented yet");
        }

    }
}
