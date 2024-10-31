using Newtonsoft.Json;

namespace D_Dlib
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
		public Dictionary<EnumEquipmentSlotsDND5e, ItemBaseDND5e> EquipmentSlots {  get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ������ ���������� � ����.
		/// </summary>
		/// <param name="slot">������ �����.</param>
		/// <param name="item">����� �������.</param>
		public void EquipItem(EnumEquipmentSlotsDND5e slot, ItemBaseDND5e item)
		{
			EquipmentSlots[slot] = item;
		}

		/// <summary>
		/// �������� ���������� �� �����.
		/// </summary>
		/// <param name="slot">������ �����.</param>
		public void UnEquipSlot(EnumEquipmentSlotsDND5e slot)
		{
			if (EquipmentSlots.ContainsKey(slot))
			{
				EquipmentSlots.Remove(slot);
			}
		}

		#endregion
	}
}
