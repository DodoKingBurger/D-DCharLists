namespace D_Dlib
{
	/// <summary>
	/// ����������.
	/// </summary>
	public class HalflingRaceDND5e : SheetRaceBase
	{
		public HalflingRaceDND5e()
		{
			Name = EnumRacesDnd5E.Halfling;
			Speed = 25;
			Size = EnumCreaturesSizesDND5e.Small;
		}
	}
}