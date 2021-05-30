using System.Collections.Generic;

namespace GameLogic.Architecture
{
	public class Colony
	{
		public readonly int Index;

		// каждая комната является пристанищем для строения
		public Map Map { get; set; }

		public Colony (int index, Map map)
		{
			Index = index;
			// и по-умолчанию - это пустое строение
			Map = map;
			//создадим карты???
		}

		// Добавим по несколько карт в одну колонию различного типа
		private readonly Dictionary<MapType, Map> maps = new Dictionary<MapType, Map>();
		public IEnumerable<Map> Maps
		{
			get { return maps.Values; }
		}

		public Map GetMap(MapType type)
		{
			return maps.ContainsKey(type)
				? maps[type]
				: null;
		}

		public void SetMap(MapType type, Map map)
		{
			maps[type] = map;
		}
	}
}
