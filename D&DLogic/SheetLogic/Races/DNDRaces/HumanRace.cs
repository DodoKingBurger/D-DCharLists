namespace D_DCharLists
{
	/// <summary>
	/// Человек.
	/// </summary>
	public class HumanRace : SheetRaceBase
	{
		public HumanRace()
		{
			Name = EnumRaces.Human;
			Speed = 30;
			Size = EnumCreaturesSizes.Medium;
		}
	}
}