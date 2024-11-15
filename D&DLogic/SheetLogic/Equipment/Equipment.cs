namespace D_DCharLists
{
	/// <summary>
	/// Снаряжения.
	/// </summary>
	public class Equipment : BaseEquipmentSystem
	{
		/// <summary>
		/// Создаёт список слотов для снаряжения.
		/// </summary>
		public Equipment()
		{
			this.EquipmentSlots = new Dictionary<EnumEquipmentSlots, ItemBase>();
		}
	}
}