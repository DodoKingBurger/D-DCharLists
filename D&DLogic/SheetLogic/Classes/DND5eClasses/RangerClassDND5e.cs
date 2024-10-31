namespace D_Dlib
{
	/// <summary>
	/// Ренджер.
	/// </summary>
	public class RangerClassDND5e : SheetClassBase
	{
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