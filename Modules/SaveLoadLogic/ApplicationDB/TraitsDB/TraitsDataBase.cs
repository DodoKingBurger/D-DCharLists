namespace D_DCharLists
{
	/// <summary>
	/// �� ��������.
	/// </summary>
	public class TraitsDataBase
	{
		#region ���� � ��������
		
		/// <summary>
		/// ������ ��������.
		/// </summary>
		public static Dictionary<int, TraitBase> TraitsDB = new Dictionary<int, TraitBase>();

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
		/// �������� ��.
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
		/// ��������� ������ �������� � ��.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DNDTraitsDB", TraitsDB, @"Data\DND\DataBases\");
		}

		/// <summary>
		/// �������� ������.
		/// </summary>
		/// <param name="trait">����������� ������.</param>
		public static void AddTrait(TraitBase trait)
		{
			TraitsDB[trait.Id] = trait;
		}

		#endregion
	}
}