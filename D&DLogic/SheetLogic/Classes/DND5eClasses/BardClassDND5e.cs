namespace D_Dlib
{
	/// <summary>
	/// Бард.
	/// </summary>
	public class BardClassDND5e : SheetClassBase
	{
		public BardClassDND5e()
		{
			Name = EnumClassesDnd5E.Bard;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Agility,
				EnumAbilitiesDnd5E.Charisma
			};
		}
	}
}