using Newtonsoft.Json;
namespace D_DCharLists
{
	/// <summary>
	/// �� ���������.
	/// </summary>
	public class ItemsDataBase
	{
		#region ���� � ��������

		/// <summary>
		/// ������ ���������.
		/// </summary>
		public static Dictionary<int, ItemBase> ItemsDB = new Dictionary<int, ItemBase>();

		/// <summary>
		/// ���������� � �����.
		/// </summary>
		private static DirectoryInfo folderInfo = new DirectoryInfo(String.Join("\\", 
			AppDomain.CurrentDomain.BaseDirectory.Split('\\')
			[0..(AppDomain.CurrentDomain.BaseDirectory.Split('\\').Count() - 4)]) 
			+ "\\Data\\DND\\DataBases");
		#endregion

		#region ������

		/// <summary>
		/// ��������� ���� ������ ���������.
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
		/// �������� ������� � ���� ������.
		/// </summary>
		/// <param name="item">����������� �������.</param>
		public static void AddItem(ItemBase item)
		{
			ItemsDB[item.ItemId] = item;
		}

		/// <summary>
		/// ��������� ���� ������.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DNDItemsDB", ItemsDB, @"Data\DND\DataBases\");
		}

		#endregion
	}
}