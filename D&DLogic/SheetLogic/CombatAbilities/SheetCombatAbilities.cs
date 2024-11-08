
using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������� ������ ���������.
	/// </summary>
	public abstract class SheetCombatAbilities
	{
		#region ���� � ��������

		/// <summary>
		/// ���������� ������ ����������.
		/// </summary>
		[JsonProperty("CombatStats")]
		public Dictionary<EnumCombatStats, int> CombatStats {  get; set; }

		#endregion 

		#region ������

		/// <summary>
		/// �������� ��������.
		/// </summary>
		/// <param name="stat">����� �������.</param>
		/// <param name="value">����� ��������.</param>
		public abstract void ChangeStat(Enum stat, int value);
		
		/// <summary>
		/// ����� �����������.
		/// </summary>
		public abstract void ResetDeathSaves();

		#endregion
	}
}
