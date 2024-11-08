namespace D_DCharLists
{
	/// <summary>
	/// ��������.
	/// </summary>
	public class Personality : SheetPersonality
	{
		public override void AddPersonality(EnumPersonalities personality, string value)
		{
			PersonalityList[personality] = value;
		}

		/// <summary>
		/// ������� ������ � ���������� � ��������, �������� �����.
		/// </summary>
		public Personality()
		{
			PersonalityList = new Dictionary<EnumPersonalities, string>();
		}
	}
}