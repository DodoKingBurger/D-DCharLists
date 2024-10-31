using Newtonsoft.Json;

namespace D_Dlib
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
		public Dictionary<EnumPersonalitiesDND5E, string> PersonalityList { get; protected set; }

		/// <summary>
		/// �������� ���������� � ��������.
		/// </summary>
		/// <param name="personality">����� ����� �������� ����� ��������.</param>
		/// <param name="value">����� ����������.</param>
		public abstract void AddPersonality(EnumPersonalitiesDND5E personality, string value);
	}
}
