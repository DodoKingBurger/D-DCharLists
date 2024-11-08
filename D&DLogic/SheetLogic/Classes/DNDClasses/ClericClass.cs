namespace D_DCharLists
{
	/// <summary>
	/// Жрец. 
	/// </summary>
	public class ClericClass : SheetClassBase
	{
		/// <summary>
		/// Создает жреца.
		/// </summary>
		public ClericClass()
		{
			Name = EnumClasses.Cleric;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Wisdom,
				EnumAbilities.Charisma
			};
		}
	}
}