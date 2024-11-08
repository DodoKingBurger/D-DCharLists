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
		public static CharacterSheetBase HeroSheet = new CharacterSheet();

		/// <summary>
		/// Сохраняем текущий лист персонажа.
		/// </summary>
		public static void SaveSheet()
		{
			JsonSaveLoad.JsonSave(HeroSheet.Name, HeroSheet, $@"Data\DND\CharacterSheets\");
		}
	}
}
