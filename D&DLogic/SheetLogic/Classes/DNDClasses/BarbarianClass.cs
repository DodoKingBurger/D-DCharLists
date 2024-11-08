namespace D_DCharLists
{
	/// <summary>
	/// Варвар. 
	/// </summary>
	public class BarbarianClass : SheetClassBase
	{
		/// <summary>
		/// Создает варвара.
		/// </summary>
		public BarbarianClass()
		{
			Name = EnumClasses.Barbarian;
			HitDice = EnumDices.d12;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Physique,
				EnumAbilities.Strength
			};
		}
	}
}