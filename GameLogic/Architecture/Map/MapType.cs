namespace GameLogic.Architecture
{
	public enum MapType
	{
		Empty,
		Objects,//пока будет карта только этого типа, т.е. все объекты на карте
		Buildings,
		LandscapeFeatures,
		DepositsResource,
		Rovers,
		//рудимент старого кода нужно убрать
		PowerPlant,
		Smeltery,
		Roboport
	}
}
