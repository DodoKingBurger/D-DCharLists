namespace D_DCharLists
{
	/// <summary>
	/// �����.
	/// </summary>
	public class MonkClassDND5e : SheetClassBase
	{
		/// <summary>
		/// ������� ������.
		/// </summary>
		public MonkClassDND5e()
		{
			Name = EnumClassesDnd5E.Monk;
			HitDice = EnumDices.d8;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Agility,
				EnumAbilitiesDnd5E.Strength
			};
		}
	}
}