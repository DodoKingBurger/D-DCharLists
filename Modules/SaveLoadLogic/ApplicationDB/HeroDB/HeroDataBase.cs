using D_DCharList.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DCharLists
{
	public static class HeroDataBase
	{
		#region Поля и свойства

		/// <summary>
		/// Список предметов.
		/// </summary>
		public static Dictionary<int, CharacterSheet> HeroDB = new Dictionary<int, CharacterSheet>();

		/// <summary>
		/// Информация о папке.
		/// </summary>
		private static DirectoryInfo folderInfo = new DirectoryInfo(String.Join("\\",
			AppDomain.CurrentDomain.BaseDirectory.Split('\\')
			[0..(AppDomain.CurrentDomain.BaseDirectory.Split('\\').Count() - 4)])
			+ "\\Data\\DND\\CharacterSheets");

		/// <summary>
		/// Список доступных персонажей для загрузки.
		/// </summary>
		public static List<string> sheetInFolder ;

    /// <summary>
    /// Делагат для события вывода персонажа.
    /// </summary>
    public delegate void ShowLoadHero();

    /// <summary>
    /// Событие для вывода персонажа.
    /// </summary>
    public static event ShowLoadHero ShowHero;

    #endregion

    #region Методы

    /// <summary>
    /// Смотрит список json файлов с персонажами
    /// </summary>
    /// <returns>Список имен доступных для загрузки персонажей.</returns>
    public static string[] CharactersAvailableForDownload()
		{
			if ((folderInfo.GetFiles().Length == 0))
				throw new ArgumentException("Каталог с персонажами пуст!");
			sheetInFolder = new List<string>();
			foreach (var item in folderInfo.GetFiles())
			{
				sheetInFolder.Add(item.Name);
			}
			return sheetInFolder.ToArray();
		}
    //Path.GetFileNameWithoutExtension(
    /// <summary>
    /// Загрузить из базы данных персонажа.
    /// </summary>
    public static void LoadHerosBase(string nameHero)
		{
			if ((folderInfo.GetFiles().Length == 0))
				throw new ArgumentException("Каталог с персонажами пуст!");
			foreach (var item in folderInfo.GetFiles())
			{
				if (item.Name == nameHero)
				{
					var tempSheet = new CharacterSheet();
						JsonSaveLoad.JsonLoad(@$"Data\DND\CharacterSheets\{nameHero}", ref tempSheet);
					CurrentHeroSheet.HeroSheet = tempSheet;
					ShowHero();
				}
			}
		}

		#endregion
	}
}
