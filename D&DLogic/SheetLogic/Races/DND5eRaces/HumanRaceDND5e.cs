namespace D_Dlib
{
	/// <summary>
	/// �������.
	/// </summary>
	public class HumanRaceDND5e : SheetRaceBase
	{
		public HumanRaceDND5e()
		{
			Name = EnumRacesDnd5E.Human;
			Speed = 30;
			Size = EnumCreaturesSizesDND5e.Medium;
		}
	}
}