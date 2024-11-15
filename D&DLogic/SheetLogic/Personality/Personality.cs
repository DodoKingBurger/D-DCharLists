namespace D_DCharLists
{
	/// <summary>
	/// Персональная информация.
	/// </summary>
	public class Personality : SheetPersonality
	{
		public override void AddPersonality(EnumPersonalities personality, string value)
		{
			this.PersonalityList[personality] = value;
		}

		/// <summary>
		/// Созадет список персональной информации.
		/// </summary>
		public Personality()
		{
			this.PersonalityList = new Dictionary<EnumPersonalities, string>();
		}
	}
}