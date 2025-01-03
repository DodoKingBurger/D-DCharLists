using Newtonsoft.Json;
namespace D_DCharLists
{
	/// <summary>
	/// БД предметов.
	/// </summary>
	public class ItemsDataBase
	{
		#region Поля и свойства

		/// <summary>
		/// Список предметов.
		/// </summary>
		public static Dictionary<int, ItemBase> ItemsDB = new Dictionary<int, ItemBase>();

		/// <summary>
		/// Информация о папке.
		/// </summary>
		private static DirectoryInfo folderInfo = new DirectoryInfo(String.Join("\\",
			AppDomain.CurrentDomain.BaseDirectory.Split('\\')
			[0..(AppDomain.CurrentDomain.BaseDirectory.Split('\\').Count() - 4)])
			+ "\\Data\\DND\\DataBases");
		#endregion

		#region Методы

		/// <summary>
		/// Загрузить базу данных предметов.
		/// </summary>
		public static void LoadItemsBase()
		{
			foreach (var item in folderInfo.GetFiles())
			{
				if (item.Name == "DNDItemsDB.json")
				{
					JsonSaveLoad.JsonLoad(@"Data\DND\DataBases\DNDItemsDB.json", ref ItemsDB);
				}
			}
		}

		/// <summary>
		/// Добавить предмет в базу данных.
		/// </summary>
		/// <param name="item">Добавляймый предмет.</param>
		public static void AddItem(ItemBase item)
		{
			if (!ItemsDB.ContainsKey(item.ItemId))
			{
				if (!string.IsNullOrEmpty(item.Name))
				{
					if (item.Rarity != null)
					{
						if (item.BaseCost >= 0)
						{
							if (item.Weight >= 0)
								ItemsDB[item.ItemId] = item;
							else
								throw new ArgumentException("Вес не может быть отритальеным");
						}
						else
							throw new ArgumentNullException("предмет не может иметь отрицательную стоймость!");
					}
					else
						throw new ArgumentNullException("Редкость не указана!");
				}
				else
					throw new ArgumentException("Название предмета не указано!");
			}
			else
			{
				throw new ArgumentException("Такой ID уже существует!");
			}
		}

		/// <summary>
		/// Сохранить базу данных.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DNDItemsDB", ItemsDB, @"Data\DND\DataBases\");
		}

		#endregion
	}
}