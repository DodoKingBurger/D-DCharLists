namespace D_DCharLists
{
	/// <summary>
	/// Экипировка персонажа.
	/// </summary>
	public class EquipmentDND5e : BaseEquipmentSystem
	{
		/// <summary>
		/// Список чем снаряжон персонаж.
		/// </summary>
		public EquipmentDND5e()
		{
			EquipmentSlots = new Dictionary<EnumEquipmentSlotsDND5e, ItemBaseDND5e>();
		}
	}
}