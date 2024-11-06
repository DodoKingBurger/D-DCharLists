using D_DCharLists;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DCharList.Modules
{
	/// <summary>
	/// Текущий лист персонажа.
	/// </summary>
	public class CurrentHeroSheet
	{
		/// <summary>
		/// Текущий персонаж.
		/// </summary>
		public static CharacterSheetBase HeroSheet = new CharacterSheetDnd5E();

		/// <summary>
		/// Выьор редакции D&D
		/// </summary>
		/// <param name="edition">Какая версия D&D листа созадеться</param>
		public static void SetSheetEdition(EnumEditions edition)
		{
			switch (edition)
			{
				case EnumEditions.DND5E:
					HeroSheet = new CharacterSheetDnd5E();
					break;
			}
		}

		/// <summary>
		/// Сохраняем текущий лист персонажа.
		/// </summary>
		public static void SaveSheet()
		{
			JsonSaveLoad.JsonSave(HeroSheet.Name, HeroSheet, $@"Data\DND5E\CharacterSheets\");
		}
	}
}
