namespace D_Dlib
{
	/// <summary>
	/// Тифлинг.
	/// </summary>
	public class TieflingRaceDND5e : SheetRaceBase
	{
		public TieflingRaceDND5e()
		{
			Name = EnumRacesDnd5E.Tiefling;
			Speed = 30;
			Size = EnumCreaturesSizesDND5e.Medium;
		}
	}
}