namespace D_Dlib
{
	/// <summary>
	/// ∆рец.
	/// </summary>
	public class ClericClassDND5e : SheetClassBase
	{
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