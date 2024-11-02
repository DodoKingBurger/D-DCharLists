using Newtonsoft.Json;
namespace D_DCharLists
{
	/// <summary>
	/// �� ���������.
	/// </summary>
	public class ItemsDataBaseDND5e
	{
		#region ���� � ��������

		/// <summary>
		/// ������ ���������.
		/// </summary>
		public static Dictionary<int, ItemBaseDND5e> ItemsDB = new Dictionary<int, ItemBaseDND5e>();

		/// <summary>
		/// ���������� � �����.
		/// </summary>
		private static DirectoryInfo _folderInfo = new DirectoryInfo(@"Data\DND5E\DataBases");

		#endregion

		#region ������

		/// <summary>
		/// ��������� ���� ������ ���������.
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
		/// �������� ������� � ���� ������.
		/// </summary>
		/// <param name="item">����������� �������.</param>
		public static void AddItem(ItemBaseDND5e item)
		{
			ItemsDB[item.ItemId] = item;
		}

		/// <summary>
		/// ��������� ���� ������.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DND5eItemsDB", ItemsDB, @"Data\DND5E\DataBases\");
		}

		#endregion
	}
}