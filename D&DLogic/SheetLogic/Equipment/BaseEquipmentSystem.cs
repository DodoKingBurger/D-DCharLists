using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������� ����������. 
	/// </summary>
	public abstract class BaseEquipmentSystem
	{
		#region ���� � ��������

		/// <summary>
		/// ������ ������ � ���������� ����������� � ���.
		/// </summary>
		[JsonProperty("EquipmentSlots")]
		public Dictionary<EnumEquipmentSlots, ItemBase> EquipmentSlots {  get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ������ ���������� � ����.
		/// </summary>
		/// <param name="slot">������ �����.</param>
		/// <param name="item">����� �������.</param>
		public void EquipItem(EnumEquipmentSlots slot, ItemBase item)
		{
			EquipmentSlots[slot] = item;
		}

		/// <summary>
		/// �������� ���������� �� �����.
		/// </summary>
		/// <param name="slot">������ �����.</param>
		public void UnEquipSlot(EnumEquipmentSlots slot)
		{
			if (EquipmentSlots.ContainsKey(slot))
			{
				EquipmentSlots.Remove(slot);
			}
		}

		#endregion
	}
}
