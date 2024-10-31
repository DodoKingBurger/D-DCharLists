namespace D_Dlib
{
	/// <summary>
	/// ��������.
	/// </summary>
	public class PersonalityDND5E : SheetPersonality
	{
		public override void AddPersonality(EnumPersonalitiesDND5E personality, string value)
		{
			PersonalityList[personality] = value;
		}

		/// <summary>
		/// ������� ������ � ���������� � ��������, �������� �����.
		/// </summary>
		public PersonalityDND5E()
		{
			PersonalityList = new Dictionary<EnumPersonalitiesDND5E, string>();
		}
	}
}