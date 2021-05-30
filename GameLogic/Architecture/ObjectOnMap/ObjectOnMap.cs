namespace GameLogic.Architecture
{
	public class ObjectOnMap
	{
		public readonly ObjectOnMapType Type;
		public readonly ObjectOnMapConfig Config;

		public ObjectOnMap (ObjectOnMapType type)
		{
			Type = type;
		}

		// В конструкторе принимаем конфиг, а не индекс
		public ObjectOnMap(ObjectOnMapConfig config)
        {
			Type = config.Type;
			Config = config;
        }
    }

}
