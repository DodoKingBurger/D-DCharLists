
using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность инвентаря.
	/// </summary>
	public abstract class SheetInventory
	{
		#region Поля и свойства 

		/// <summary>
		///  Список предметов.
		/// </summary>
		[JsonProperty("Inventory")]
		public Dictionary<int, int> Inventory { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Добавить предмет +1.
		/// </summary>
		/// <param name="item">ID предмета.</param>
		public abstract void AddItem(int item);
		
		/// <summary>
		/// Удалить предмет.
		/// </summary>
		/// <param name="item">ID предмета.</param>
		public abstract void RemoveItem(int item);
		
		/// <summary>
		/// Уменьшить количество товара.
		/// </summary>
		/// <param name="item">ID предмета.</param>
		public abstract void DecreaseItem(int item);

		#endregion
	}
}