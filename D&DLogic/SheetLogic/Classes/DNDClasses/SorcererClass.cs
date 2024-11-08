namespace D_DCharLists
{
	/// <summary>
	/// Колдун.
	/// </summary>
	public class SorcererClass : SheetClassBase
	{
		/// <summary>
		/// Созадет колдуна. 
		/// </summary>
		public SorcererClass()
		{
			Name = EnumClasses.Sorcerer;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Wisdom,
				EnumAbilities.Charisma
			};
		}
	}
}