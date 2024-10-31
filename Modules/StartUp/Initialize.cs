using D_Dlib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DCharList.Modules.StartUp
{
	public class Initialize
	{
		#region Поля и свойства

		/// <summary>
		/// Путь для содании папки.
		/// </summary>
		private string _programmFolder;

		/// <summary>
		/// Создан ли папка Data.
		/// </summary>
		private bool _isDataExist;

		/// <summary>
		/// Есть ли папка с ранее созданными персонажами.
		/// </summary>
		private bool _isCharacterSheetsExist;

		/// <summary>
		/// Есть ли папка с БД предметов.
		/// </summary>
		private bool _isDataBasesExist;

		/// <summary>
		/// Путь к директории.
		/// </summary>
		private DirectoryInfo _folderInfo;

		#endregion

		#region Методы

		/// <summary>
		/// Проверка есть ли уже созданные персонажы, и проверяет есть ли база данных предметов.
		/// </summary>
		/// <exception cref="ArgumentException"></exception>
		private void CheckAndCreateFolders()
		{
			foreach (var itemX in _folderInfo.GetDirectories())
			{
				if (itemX.Name == "Data")
				{
					_isDataExist = true;
					_folderInfo = new DirectoryInfo(_programmFolder + @"\Data");

					foreach (var itemY in _folderInfo.GetDirectories())
					{
						if (itemY.Name == "DND5E")
						{
							_folderInfo = new DirectoryInfo(_programmFolder + @"\Data\DND5E");

							foreach (var itemZ in _folderInfo.GetDirectories())
							{
								if (itemY.Name == "CharacterSheets")
								{
									_isCharacterSheetsExist = true;
								}
								else if (itemY.Name == "DataBases")
								{
									_isDataBasesExist = true;
								}
							}
						}
					}
				}
			}

			if (_isDataExist == false)
			{
				Directory.SetCurrentDirectory(_programmFolder);
				Directory.CreateDirectory("Data");
				Directory.SetCurrentDirectory(_programmFolder + @"\Data");
				Directory.CreateDirectory("DND5E");
				Directory.SetCurrentDirectory(_programmFolder + @"\Data\DND5E");
				Directory.CreateDirectory("CharacterSheets");
				Directory.CreateDirectory("DataBases");
			}
			else if (_isCharacterSheetsExist == false)
			{
				Directory.SetCurrentDirectory(_programmFolder + @"\Data\DND5E");
				Directory.CreateDirectory("CharacterSheets");
			}
			else if (_isDataBasesExist == false)
			{
				Directory.SetCurrentDirectory(_programmFolder + @"\Data\DND5E");
				Directory.CreateDirectory("DataBases");
			}

			Directory.SetCurrentDirectory(_programmFolder);
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
			_isDataExist = false;
			_isCharacterSheetsExist = false;
			_isDataBasesExist = false;
			_programmFolder = Directory.GetCurrentDirectory();
			_folderInfo = new DirectoryInfo(_programmFolder);
		}

		#endregion
	}
}
