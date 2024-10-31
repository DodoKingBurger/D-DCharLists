namespace D_Dlib
{
	/// <summary>
	/// Паладин.
	/// </summary>
	public class PaladinClassDND5e : SheetClassBase
	{
		public PaladinClassDND5e()
		{
			Name = EnumClassesDnd5E.Paladin;
			HitDice = EnumDices.d10;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Wisdom,
				EnumAbilitiesDnd5E.Charisma
			};
		}
	}
}