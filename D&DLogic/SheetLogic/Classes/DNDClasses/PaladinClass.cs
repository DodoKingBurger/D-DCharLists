namespace D_DCharLists
{
	/// <summary>
	/// Паладин.
	/// </summary>
	public class PaladinClass : SheetClassBase
	{
		/// <summary>
		/// Создает паладина. 
		/// </summary>
		public PaladinClass()
		{
			Name = EnumClasses.Paladin;
			HitDice = EnumDices.d10;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Wisdom,
				EnumAbilities.Charisma
			};
		}
	}
}