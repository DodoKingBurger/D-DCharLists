namespace D_Dlib
{
	/// <summary>
	/// �� ��������.
	/// </summary>
	public class TraitsDataBaseDND5e
	{
		#region ���� � ��������
		
		/// <summary>
		/// ������ ��������.
		/// </summary>
		public static Dictionary<int, TraitBase> TraitsDB = new Dictionary<int, TraitBase>();
		
		/// <summary>
		/// ���� � ��.
		/// </summary>
		private static DirectoryInfo folderInfo = new DirectoryInfo(@"Data\DND5E\DataBases");

		#endregion

		#region ������

		/// <summary>
		/// �������� ��.
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
		/// ��������� ������ �������� � ��.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DND5eTraitsDB", TraitsDB, @"Data\DND5E\DataBases\");
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