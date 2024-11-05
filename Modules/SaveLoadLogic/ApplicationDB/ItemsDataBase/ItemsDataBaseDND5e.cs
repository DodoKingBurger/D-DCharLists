using Newtonsoft.Json;
namespace D_DCharLists
{
	/// <summary>
	/// БД предметов.
	/// </summary>
	public class ItemsDataBaseDND5e
	{
		#region Поля и свойства

		/// <summary>
		/// Список предметов.
		/// </summary>
		public static Dictionary<int, ItemBaseDND5e> ItemsDB = new Dictionary<int, ItemBaseDND5e>();

		/// <summary>
		/// Информация о папке.
		/// </summary>
		private static DirectoryInfo _folderInfo = new DirectoryInfo(@"Data\DND5E\DataBases");

		#endregion

		#region Методы

		/// <summary>
		/// Загрузить базу данных предметов.
		/// </summary>
		public static void LoadItemsBase()
		{
			foreach (var item in _folderInfo.GetFiles())
			{
				if (item.Name == "DND5eItemsDB.json")
				{
					JsonSaveLoad.JsonLoad(@"Data\DND5E\DataBases\DND5eItemsDB.json", ref ItemsDB);
				}
			}
		}

		/// <summary>
		/// Добавить предмет в базу данных.
		/// </summary>
		/// <param name="item">Добавляймый предмет.</param>
		public static void AddItem(ItemBaseDND5e item)
		{
			ItemsDB[item.ItemId] = item;
		}

		/// <summary>
		/// Сохранить базу данных.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DND5eItemsDB", ItemsDB, @"Data\DND5E\DataBases\");
		}

		#endregion
	}
}