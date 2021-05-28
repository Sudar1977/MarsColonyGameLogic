using System;
using System.Collections.Generic;

namespace GameLogic.Architecture
{
	public class Map
	{
		// Ограничим количество модулей, которые можно поставить в строение
		public readonly int BuildingLimit = 1000000;

		public readonly MapType Type;

		// Каждое здание имеет свою сообтвенную позицию
		private readonly Dictionary<int, Building> buildings = new Dictionary<int, Building>();
		//В статье позиция здания-модуля закодирована одним числом position 
		//у нас же на карте нужны две координаты x, y. 
		//Пока для простоты пусть координата будет закодирована 1,10,100, 
		//а координата y 1000,10000,100000. Т.е.Мы получим поле 999,999. 
		//Пример координата(x, y) = (1,2) будет закодирована числом position = 001002 
		//(x, y) = (517, 62) position=517062 
		//(x, y) = (1,999) position=001999   
		//Впоследствии можно будет закодировать массивом int[] из двух элементов.
		public IEnumerable<Building> Builings {
			get { return buildings.Values; }
		}

		public Map (MapType type)
		{
			Type = type;
		}

		public Building GetBuilding (int position)
		{
			return buildings.ContainsKey(position)
				? buildings[position]
				: null;
		}

		public void SetBuilding (int position, Building building)
		{
			if (position < 0 || position >= BuildingLimit) {
				throw new IndexOutOfRangeException(
					"Position " + position + " is out of range [0:" + BuildingLimit + "]"
				);
			}

			buildings[position] = building;
		}
	}
}
