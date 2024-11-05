namespace D_DCharLists
{
	/// <summary>
	/// Друид. 
	/// </summary>
	public class DruidClassDND5e : SheetClassBase
	{
		/// <summary>
		/// Создает друида.
		/// </summary>
		public DruidClassDND5e()
		{
			Name = EnumClassesDnd5E.Druid;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Intelligence,
				EnumAbilitiesDnd5E.Wisdom
			};
		}
	}
}