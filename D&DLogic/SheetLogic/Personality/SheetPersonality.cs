using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������� ��������.
	/// </summary>
	public abstract class SheetPersonality
	{
		/// <summary>
		/// ���������� � ��������.
		/// </summary>
		[JsonProperty("PersonalityList")]
		public Dictionary<EnumPersonalities, string> PersonalityList { get; protected set; }

		/// <summary>
		/// �������� ���������� � ��������.
		/// </summary>
		/// <param name="personality">����� ����� �������� ����� ��������.</param>
		/// <param name="value">����� ����������.</param>
		public abstract void AddPersonality(EnumPersonalities personality, string value);
	}
}
