namespace D_DCharLists
{
	/// <summary>
	/// Личность.
	/// </summary>
	public class Personality : SheetPersonality
	{
		public override void AddPersonality(EnumPersonalities personality, string value)
		{
			PersonalityList[personality] = value;
		}

		/// <summary>
		/// Созадет список с информации о личности, описания героя.
		/// </summary>
		public Personality()
		{
			PersonalityList = new Dictionary<EnumPersonalities, string>();
		}
	}
}