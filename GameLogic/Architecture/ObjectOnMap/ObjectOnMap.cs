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

		// � ������������ ��������� ������, � �� ������
		public ObjectOnMap(ObjectOnMapConfig config)
        {
			Type = config.Type;
			Config = config;
        }
    }

}
