namespace D_DCharLists
{
	/// <summary>
	/// ����.
	/// </summary>
	public class ClericClassDND5e : SheetClassBase
	{
		/// <summary>
		/// ������� �����.
		/// </summary>
		public ClericClassDND5e()
		{
			Name = EnumClassesDnd5E.Cleric;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Wisdom,
				EnumAbilitiesDnd5E.Charisma
			};
		}
	}
}