namespace D_DCharLists
{
	/// <summary>
	/// Разбойник.
	/// </summary>
	public class RogueClassDND5e : SheetClassBase
	{ 
		/// <summary>
		/// Создает разбойника.
		/// </summary>
		public RogueClassDND5e()
		{
			Name = EnumClassesDnd5E.Rogue;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Agility,
				EnumAbilitiesDnd5E.Intelligence
			};
		}
	}
}