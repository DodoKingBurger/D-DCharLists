namespace D_DCharLists
{
	/// <summary>
	/// Волшебник.
	/// </summary>
	public class WizardClass : SheetClassBase
	{
		/// <summary>
		/// Создает волшебника. 
		/// </summary>
		public WizardClass()
		{
			Name = EnumClasses.Wizard;
			HitDice = EnumDices.d6;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Intelligence,
				EnumAbilities.Wisdom
			};
		}
	}
}