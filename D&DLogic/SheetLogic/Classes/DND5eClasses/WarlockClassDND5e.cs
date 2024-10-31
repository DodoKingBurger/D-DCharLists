namespace D_Dlib
{
	/// <summary>
	/// �����������.
	/// </summary>
	public class WarlockClassDND5e : SheetClassBase
	{
		public WarlockClassDND5e()
		{
			Name = EnumClassesDnd5E.Warlock;
			HitDice = EnumDices.d6;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Physique,
				EnumAbilitiesDnd5E.Charisma
			};
		}
	}
}