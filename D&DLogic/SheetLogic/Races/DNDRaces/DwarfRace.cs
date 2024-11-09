namespace D_DCharLists
{
	/// <summary>
	/// Дворф.
	/// </summary>
	public class DwarfRace : SheetRaceBase
	{
		public DwarfRace()
		{
			Name = EnumRaces.Dwarf;
			Speed = 25;
			Size = EnumCreaturesSizes.Small;
		}
	}
}