namespace D_DCharLists
{
	/// <summary>
	/// Монах. 
	/// </summary>
	public class MonkClass : SheetClassBase
	{
		/// <summary>
		/// Создает монаха.
		/// </summary>
		public MonkClass()
		{
			Name = EnumClasses.Monk;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Agility,
				EnumAbilities.Strength
			};
		}
	}
}