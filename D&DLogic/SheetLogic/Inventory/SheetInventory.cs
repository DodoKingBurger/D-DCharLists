
using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// �������� ���������.
	/// </summary>
	public abstract class SheetInventory
	{
		#region ���� � �������� 

		/// <summary>
		///  ������ ���������.
		/// </summary>
		[JsonProperty("Inventory")]
		public Dictionary<int, int> Inventory { get; set; }

		#endregion

		#region ������

		/// <summary>
		/// �������� ����������� �������.
		/// </summary>
		/// <param name="item">ID ��������.</param>
		public abstract void AddItem(int item);
		
		/// <summary>
		/// ������� �������.
		/// </summary>
		/// <param name="item">ID ��������.</param>
		public abstract void RemoveItem(int item);
		
		/// <summary>
		/// ��������� ����������� ���������.
		/// </summary>
		/// <param name="item"></param>
		public abstract void DecreaseItem(int item);

		#endregion
	}
}