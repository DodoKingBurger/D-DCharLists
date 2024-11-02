namespace D_DCharLists
{
	/// <summary>
	/// Волшебник.
	/// </summary>
	public class WizardClassDND5e : SheetClassBase
	{
		/// <summary>
		/// Создает волшебника.
		/// </summary>
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