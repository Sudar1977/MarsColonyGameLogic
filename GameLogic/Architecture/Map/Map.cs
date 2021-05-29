using System;
using System.Collections.Generic;

namespace GameLogic.Architecture
{
	public class Map
	{
		// Ограничим количество модулей, которые можно поставить в строение
		public readonly int ObjectsOnMapLimit = 1000000;

		public readonly MapType Type;

		// Каждое здание имеет свою сообтвенную позицию
		private readonly Dictionary<int, ObjectOnMap> objectsOnMap = new Dictionary<int, ObjectOnMap>();
		//В статье позиция здания-модуля закодирована одним числом position 
		//у нас же на карте нужны две координаты x, y. 
		//Пока для простоты пусть координата будет закодирована 1,10,100, 
		//а координата y 1000,10000,100000. Т.е.Мы получим поле 999,999. 
		//Пример координата(x, y) = (1,2) будет закодирована числом position = 001002 
		//(x, y) = (517, 62) position=517062 
		//(x, y) = (1,999) position=001999   
		//Впоследствии можно будет закодировать массивом int[] из двух элементов.
		public IEnumerable<ObjectOnMap> ObjectsOnMap {
			get { return objectsOnMap.Values; }
		}

		public Map (MapType type)
		{
			Type = type;
		}

		public ObjectOnMap GetObjectonMap (int position)
		{
			return objectsOnMap.ContainsKey(position)
				? objectsOnMap[position]
				: null;
		}

		public void SetObjectonMap (int position, ObjectOnMap objectOnMap)
		{
			if (position < 0 || position >= ObjectsOnMapLimit) {
				throw new IndexOutOfRangeException(
					"Position " + position + " is out of range [0:" + ObjectsOnMapLimit + "]"
				);
			}

			objectsOnMap[position] = objectOnMap;
		}
	}
}
