namespace D_DCharLists
{
	/// <summary>
	/// Чернокижник.
	/// </summary>
	public class WarlockClass : SheetClassBase
	{
		/// <summary>
		/// Создает чернокнижника. 
		/// </summary>
		public WarlockClass()
		{
			Name = EnumClasses.Warlock;
			HitDice = EnumDices.d6;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Physique,
				EnumAbilities.Charisma
			};
		}
	}
}