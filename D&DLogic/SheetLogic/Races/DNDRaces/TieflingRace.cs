namespace D_DCharLists
{
	/// <summary>
	/// Тифлинг.
	/// </summary>
	public class TieflingRace : SheetRaceBase
	{
		public TieflingRace()
		{
			Name = EnumRaces.Tiefling;
			Speed = 30;
			Size = EnumCreaturesSizes.Medium;
		}
	}
}