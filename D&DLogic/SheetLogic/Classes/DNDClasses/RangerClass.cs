namespace D_DCharLists
{
	/// <summary>
	/// Ренджер. 
	/// </summary>
	public class RangerClass : SheetClassBase
	{
		/// <summary>
		/// Создает ренджера.
		/// </summary>
		public RangerClass()
		{
			Name = EnumClasses.Ranger;
			HitDice = EnumDices.d10;
			SaveThrows = new List<EnumAbilities>()
			{
				EnumAbilities.Agility,
				EnumAbilities.Strength
			};
		}
	}
}