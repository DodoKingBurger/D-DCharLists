using D_DCharList.Modules;
using D_DCharLists;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DCharList
{
	public class Initialize
	{
		#region Поля и свойства

		/// <summary>
		/// Путь для содании папки.
		/// </summary>
		private string programmFolder;

		/// <summary>
		/// Создан ли папка Data.
		/// </summary>
		private bool isDataExist;

		/// <summary>
		/// Есть ли папка с ранее созданными персонажами.
		/// </summary>
		private bool isCharacterSheetsExist;

		/// <summary>
		/// Есть ли папка с БД предметов.
		/// </summary>
		private bool isDataBasesExist;

		/// <summary>
		/// Путь к директории.
		/// </summary>
		private DirectoryInfo folderInfo;

		#endregion

		#region Методы

		/// <summary>
		/// Проверка есть ли уже созданные папки для БД.
		/// </summary>
		/// <exception cref="ArgumentException"></exception>
		private void CheckAndCreateFolders()
		{
			foreach (var itemX in folderInfo.GetDirectories())
			{
				if (itemX.Name == "Data")
				{
					isDataExist = true;
					folderInfo = new DirectoryInfo(programmFolder + @"\Data");

					foreach (var itemY in folderInfo.GetDirectories())
					{
						if (itemY.Name == "DND5E")
						{
							folderInfo = new DirectoryInfo(programmFolder + @"\Data\DND5E");

							foreach (var itemZ in folderInfo.GetDirectories())
							{
								if (itemZ.Name == "CharacterSheets")
								{
									isCharacterSheetsExist = true;
								}
								else if (itemZ.Name == "DataBases")
								{
									isDataBasesExist = true;
								}
							}
						}
					}
				}
			}

			if (isDataExist == false)
			{
				Directory.SetCurrentDirectory(programmFolder);
				Directory.CreateDirectory("Data");
				Directory.SetCurrentDirectory(programmFolder + @"\Data");
				Directory.CreateDirectory("DND5E");
				Directory.SetCurrentDirectory(programmFolder + @"\Data\DND5E");
				Directory.CreateDirectory("CharacterSheets");
				Directory.CreateDirectory("DataBases");
			}
			else if (isCharacterSheetsExist == false)
			{
				Directory.SetCurrentDirectory(programmFolder + @"\Data\DND5E");
				Directory.CreateDirectory("CharacterSheets");
			}
			else if (isDataBasesExist == false)
			{
				Directory.SetCurrentDirectory(programmFolder + @"\Data\DND5E");
				Directory.CreateDirectory("DataBases");
			}

			Directory.SetCurrentDirectory(programmFolder);
		}

		/// <summary>
		/// Загрузка текущий версии.
		/// </summary>
		/// <param name="edition"></param>
		private void LoadEditionDND(EnumEditions edition)
		{
			CurrentHeroSheet.SetSheetEdition(edition);
		}

		/// <summary>
		/// Старутет проверку библиотек
		/// </summary>
		public void Start()
		{
			CheckAndCreateFolders();
			LoadDataBases();
			LoadEditionDND(EnumEditions.DND5E);
		}

		/// <summary>
		/// Загрузка предметов, азклинаний и талантов из БД.
		/// </summary>
		static private void LoadDataBases()
		{
			ItemsDataBaseDND5e.LoadItemsBase();
			SpellsDataBaseDND5e.LoadDB();
			TraitsDataBaseDND5e.LoadDB();
		}

		#endregion

		#region Конструкторы

		public Initialize()
		{
			isDataExist = false;
			isCharacterSheetsExist = false;
			isDataBasesExist = false;
			string[] stringsPath = AppDomain.CurrentDomain.BaseDirectory.Split('\\');
			programmFolder = String.Join("\\", stringsPath[0..(stringsPath.Count() - 4)]);
			folderInfo = new DirectoryInfo(programmFolder);
		}

		#endregion
	}
}
