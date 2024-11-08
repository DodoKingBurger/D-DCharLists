namespace D_DCharLists
{
	/// <summary>
	/// Полурослик.
	/// </summary>
	public class HalflingRace : SheetRaceBase
	{
		public HalflingRace()
		{
			Name = EnumRaces.Halfling;
			Speed = 25;
			Size = EnumCreaturesSizes.Small;
		}
	}
}