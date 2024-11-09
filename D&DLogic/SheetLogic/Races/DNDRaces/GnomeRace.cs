namespace D_DCharLists
{
	/// <summary>
	/// Гном.
	/// </summary>
	public class GnomeRace : SheetRaceBase
	{
		public GnomeRace()
		{
			Name = EnumRaces.Gnome;
			Speed = 25;
			Size = EnumCreaturesSizes.Small;
		}
	}
}