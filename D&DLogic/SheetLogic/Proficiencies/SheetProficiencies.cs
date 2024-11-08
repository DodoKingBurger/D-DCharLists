using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������� ������� ���������.
	/// </summary>
	public abstract class SheetProficiencies
	{
		#region ���� � ��������

		/// <summary>
		/// ������ �������.
		/// </summary>
		[JsonProperty("Proficiencies")]
		public List<EnumAllProficiencies> Proficiencies {  get; set; }

		#endregion

		#region ������

		/// <summary>
		/// �������� �����.
		/// </summary>
		/// <param name="prof">�����.</param>
		public abstract void AddProficiency(Enum prof);

		/// <summary>
		/// ��������� ���� �� ��� ����� �����.
		/// </summary>
		/// <param name="prof">����������� �����.</param>
		/// <returns>true, ���� �� ��� �������� ������ � ���������, � ��������� ������ false</returns>
		public abstract bool CheckProficiency(Enum prof);

		/// <summary>
		/// ������ �����.
		/// </summary>
		/// <param name="prof">��������� �����.</param>
		public abstract void RemoveProficiency(Enum prof);

		#endregion
	}
}
