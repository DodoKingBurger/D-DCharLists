namespace D_DCharLists
{
	/// <summary>
	/// Æנוצ.
	/// </summary>
	public class ClericClassDND5e : SheetClassBase
	{
		/// <summary>
		/// Ñמחהאוע זנוצא.
		/// </summary>
		public ClericClassDND5e()
		{
			Name = EnumClassesDnd5E.Cleric;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Wisdom,
				EnumAbilitiesDnd5E.Charisma
			};
		}
	}
}