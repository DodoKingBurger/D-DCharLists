namespace D_Dlib
{
	/// <summary>
	/// ���������� ���������.
	/// </summary>
	public class EquipmentDND5e : BaseEquipmentSystem
	{
		/// <summary>
		/// ������ ��� �������� ��������.
		/// </summary>
		public EquipmentDND5e()
		{
			EquipmentSlots = new Dictionary<EnumEquipmentSlotsDND5e, ItemBaseDND5e>();
		}
	}
}