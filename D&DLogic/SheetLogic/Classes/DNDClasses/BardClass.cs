namespace D_DCharLists
{
	/// <summary>
	/// Бард. 
	/// </summary>
	public class BardClass : SheetClassBase
	{
		/// <summary>
		/// Созадет барда.
		/// </summary>
		public BardClass()
		{
			Name = EnumClasses.Bard;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Agility,
				EnumAbilities.Charisma
			};
		}
	}
}