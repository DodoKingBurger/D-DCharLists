namespace D_DCharLists
{
	/// <summary>
	/// ���������� ���������.
	/// </summary>
	public class Equipment : BaseEquipmentSystem
	{
		/// <summary>
		/// ������ ��� �������� ��������.
		/// </summary>
		public Equipment()
		{
			EquipmentSlots = new Dictionary<EnumEquipmentSlots, ItemBase>();
		}
	}
}