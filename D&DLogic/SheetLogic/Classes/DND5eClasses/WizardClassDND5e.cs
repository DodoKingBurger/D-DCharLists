namespace D_Dlib
{
	/// <summary>
	/// ���������.
	/// </summary>
	public class WizardClassDND5e : SheetClassBase
	{
		public WizardClassDND5e()
		{
			Name = EnumClassesDnd5E.Wizard;
			HitDice = EnumDices.d6;
			SaveThrows = new List<EnumAbilitiesDnd5E>()
			{
				EnumAbilitiesDnd5E.Intelligence,
				EnumAbilitiesDnd5E.Wisdom
			};
		}
	}
}