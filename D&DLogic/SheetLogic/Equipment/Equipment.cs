namespace D_DCharLists
{
	/// <summary>
	/// Экипировка персонажа.
	/// </summary>
	public class Equipment : BaseEquipmentSystem
	{
		/// <summary>
		/// Список чем снаряжон персонаж.
		/// </summary>
		public Equipment()
		{
			EquipmentSlots = new Dictionary<EnumEquipmentSlots, ItemBase>();
		}
	}
}