namespace D_DCharLists
{
	/// <summary>
	/// Варвар.
	/// </summary>
	public class BarbarianClassDND5e : SheetClassBase
	{
		/// <summary>
		/// Создает варвара.
		/// </summary>
		public BarbarianClassDND5e()
		{
			Name = EnumClassesDnd5E.Barbarian;
			HitDice = EnumDices.d12;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Physique,
				EnumAbilitiesDnd5E.Strength
			};
		}
	}
}