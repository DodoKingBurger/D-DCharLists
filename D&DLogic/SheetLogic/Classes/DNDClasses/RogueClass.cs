namespace D_DCharLists
{
	/// <summary>
	/// Разбойник.
	/// </summary>
	public class RogueClass : SheetClassBase
	{ 
		/// <summary>
		/// Создает разбойника.
		/// </summary>
		public RogueClass()
		{
			Name = EnumClasses.Rogue;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Agility,
				EnumAbilities.Intelligence
			};
		}
	}
}