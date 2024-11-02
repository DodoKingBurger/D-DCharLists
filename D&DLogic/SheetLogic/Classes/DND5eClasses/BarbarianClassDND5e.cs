namespace D_DCharLists
{
	/// <summary>
	/// ������.
	/// </summary>
	public class BarbarianClassDND5e : SheetClassBase
	{
		/// <summary>
		/// ������� �������.
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