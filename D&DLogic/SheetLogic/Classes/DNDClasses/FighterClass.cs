namespace D_DCharLists
{
	/// <summary>
	/// Боец. 
	/// </summary>
	public class FighterClass : SheetClassBase
	{
		/// <summary>
		/// Создает бойца.
		/// </summary>
		public FighterClass()
		{
			Name = EnumClasses.Fighter;
			HitDice = EnumDices.d10;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Physique,
				EnumAbilities.Strength
			};
		}
	}
}