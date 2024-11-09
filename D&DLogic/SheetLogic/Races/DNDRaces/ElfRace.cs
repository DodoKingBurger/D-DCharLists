namespace D_DCharLists
{
	/// <summary>
	/// Эльф.
	/// </summary>
	public class ElfRace : SheetRaceBase
	{
		public ElfRace()
		{
			Name = EnumRaces.Elf;
			Speed = 30;
			Size = EnumCreaturesSizes.Medium;
		}
	}
}