namespace D_DCharLists
{
	/// <summary>
	/// �� ����������.
	/// </summary>
	public class SpellsDataBaseDND5e
	{
		#region ���� � ��������

		/// <summary>
		/// ������ ����������.
		/// </summary>
		public static Dictionary<int, SpellBase> SpellsDB = new Dictionary<int, SpellBase>();

		/// <summary>
		/// ���������� � �����.
		/// </summary>
		private static DirectoryInfo folderInfo = new DirectoryInfo(String.Join("\\",
			AppDomain.CurrentDomain.BaseDirectory.Split('\\')
			[0..(AppDomain.CurrentDomain.BaseDirectory.Split('\\').Count() - 4)])
			+ "\\Data\\DND5E\\DataBases");

		#endregion

		#region ������

		/// <summary>
		/// �������� ��.
		/// </summary>
		public static void LoadDB()
		{
			foreach (var item in folderInfo.GetFiles())
			{
				if (item.Name == "DND5eSpellsDB.json")
				{
					JsonSaveLoad.JsonLoad(@"Data\DND5E\DataBases\DND5eSpellsDB.json", ref SpellsDB);
				}
			}
		}

		/// <summary>
		/// �������� ����������.
		/// </summary>
		/// <param name="spell">����������� ����������.</param>
		public static void AddSpell(SpellBase spell)
		{
			SpellsDB[spell.Id] = spell;
		}

		/// <summary>
		/// ��������� �� ����������.
		/// </summary>
		public static void SaveDB()
		{
			JsonSaveLoad.JsonSave("DND5eSpellsDB", SpellsDB, @"Data\DND5E\DataBases\");
		}

		#endregion
	}
}