using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Базовая система снаряжения персонажа. 
	/// </summary>
	public abstract class BaseEquipmentSystem
	{
		#region Поля и свойства

		/// <summary>
		/// Слоты и заполненные ими снаряжения.
		/// </summary>
		[JsonProperty("EquipmentSlots")]
		public Dictionary<EnumEquipmentSlots, ItemBase> EquipmentSlots {  get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установить в слот новое снаряжение.
		/// </summary>
		/// <param name="slot">В какой слот снаряжение будет помещено.</param>
		/// <param name="item">Новый предмет.</param>
		public void EquipItem(EnumEquipmentSlots slot, ItemBase item)
		{
			EquipmentSlots[slot] = item;
		}

		/// <summary>
		/// Очищает выбранный слот от снаряжения.
		/// </summary>
		/// <param name="slot">Слот снаряжения для очистки.</param>
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
