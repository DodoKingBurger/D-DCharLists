namespace D_DCharLists
{
	/// <summary>
	/// Жрец. 
	/// </summary>
	public class ClericClassDND5e : SheetClassBase
	{
		/// <summary>
		/// Создает жреца.
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