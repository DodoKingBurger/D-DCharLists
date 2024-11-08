namespace D_DCharLists
{
	/// <summary>
	/// Друид. 
	/// </summary>
	public class DruidClass : SheetClassBase
	{
		/// <summary>
		/// Создает друида.
		/// </summary>
		public DruidClass()
		{
			Name = EnumClasses.Druid;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Intelligence,
				EnumAbilities.Wisdom
			};
		}
	}
}