namespace D_DCharLists
{
	/// <summary>
	/// �������.
	/// </summary>
	public class RangerClassDND5e : SheetClassBase
	{
		/// <summary>
		/// ������� ��������.
		/// </summary>
		public RangerClassDND5e()
		{
			Name = EnumClassesDnd5E.Ranger;
			HitDice = EnumDices.d10;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Agility,
				EnumAbilitiesDnd5E.Strength
			};
		}
	}
}