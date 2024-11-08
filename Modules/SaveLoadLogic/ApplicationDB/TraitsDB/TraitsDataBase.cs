namespace D_DCharLists
{
	/// <summary>
	/// БД талантов.
	/// </summary>
	public class TraitsDataBase
	{
		#region Поля и свойства
		
		/// <summary>
		/// Список талантов.
		/// </summary>
		public static Dictionary<int, TraitBase> TraitsDB = new Dictionary<int, TraitBase>();

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
		/// Загрузка БД.
		/// </summary>
		public static void LoadDB()
		{
			foreach (var item in folderInfo.GetFiles())
			{
				if (item.Name == "DNDTraitsDB.json")
				{
					JsonSaveLoad.JsonLoad(@"Data\DND\DataBases\DNDTraitsDB.json", ref TraitsDB);
				}
			}
		}

		/// <summary>
		/// Сохранить список талантов в БД.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DNDTraitsDB", TraitsDB, @"Data\DND\DataBases\");
		}

		/// <summary>
		/// Добавить талант.
		/// </summary>
		/// <param name="trait">Добавляймый талант.</param>
		public static void AddTrait(TraitBase trait)
		{
			TraitsDB[trait.Id] = trait;
		}

		#endregion
	}
}