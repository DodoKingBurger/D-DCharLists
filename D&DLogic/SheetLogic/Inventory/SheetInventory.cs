
using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность инвенторя.
	/// </summary>
	public abstract class SheetInventory
	{
		#region Поля и свойства 

		/// <summary>
		///  Список инвенторя.
		/// </summary>
		[JsonProperty("Inventory")]
		public Dictionary<int, int> Inventory { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Добавить колличество предмет.
		/// </summary>
		/// <param name="item">ID предмета.</param>
		public abstract void AddItem(int item);
		
		/// <summary>
		/// Удалить предмет.
		/// </summary>
		/// <param name="item">ID предмета.</param>
		public abstract void RemoveItem(int item);
		
		/// <summary>
		/// Уменьшить колличесвто предметов.
		/// </summary>
		/// <param name="item"></param>
		public abstract void DecreaseItem(int item);

		#endregion
	}
}