namespace D_Dlib
{
	/// <summary>
	/// БД талантов.
	/// </summary>
	public class TraitsDataBaseDND5e
	{
		#region Поля и свойства
		
		/// <summary>
		/// Список талантов.
		/// </summary>
		public static Dictionary<int, TraitBase> TraitsDB = new Dictionary<int, TraitBase>();
		
		/// <summary>
		/// Путь к БД.
		/// </summary>
		private static DirectoryInfo folderInfo = new DirectoryInfo(@"Data\DND5E\DataBases");

		#endregion

		#region Методы

		/// <summary>
		/// Загрузка БД.
		/// </summary>
		public static void LoadDB()
		{
			foreach (var item in folderInfo.GetFiles())
			{
				if (item.Name == "DND5eTraitsDB.json")
				{
					JsonSaveLoad.JsonLoad(@"Data\DND5E\DataBases\DND5eTraitsDB.json", ref TraitsDB);
				}
			}
		}

		/// <summary>
		/// Сохранить список талантов в БД.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DND5eTraitsDB", TraitsDB, @"Data\DND5E\DataBases\");
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