using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность экипировки. 
	/// </summary>
	public abstract class BaseEquipmentSystem
	{
		#region Поля и свойства

		/// <summary>
		/// Список слотов и экипировка приписанная к ним.
		/// </summary>
		[JsonProperty("EquipmentSlots")]
		public Dictionary<EnumEquipmentSlots, ItemBase> EquipmentSlots {  get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Запись экипировки в слот.
		/// </summary>
		/// <param name="slot">Ячейка слота.</param>
		/// <param name="item">Новый предмет.</param>
		public void EquipItem(EnumEquipmentSlots slot, ItemBase item)
		{
			EquipmentSlots[slot] = item;
		}

		/// <summary>
		/// Удаление экипировки из слота.
		/// </summary>
		/// <param name="slot">Ячейка слота.</param>
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
