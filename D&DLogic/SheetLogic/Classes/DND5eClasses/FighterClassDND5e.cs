namespace D_DCharLists
{
	/// <summary>
	/// ����.
	/// </summary>
	public class FighterClassDND5e : SheetClassBase
	{
		/// <summary>
		/// ������� �����.
		/// </summary>
		public FighterClassDND5e()
		{
			Name = EnumClassesDnd5E.Fighter;
			HitDice = EnumDices.d10;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Physique,
				EnumAbilitiesDnd5E.Strength
			};
		}
	}
}