namespace D_DCharLists
{
	/// <summary>
	/// Основные характеристики завищящие от класса.
	/// </summary>
	public class SaveThrowsDnd5E : SheetSaveThrows
	{
		#region Базовый класс

		public override void SetSaveTrows(EnumClassesDnd5E className)
		{
			switch (className)
			{
				case EnumClassesDnd5E.Bard:
					SaveThrows.Add(EnumAbilitiesDnd5E.Agility);
					SaveThrows.Add(EnumAbilitiesDnd5E.Charisma);
					break;

				case EnumClassesDnd5E.Barbarian:
				case EnumClassesDnd5E.Fighter:
					SaveThrows.Add(EnumAbilitiesDnd5E.Strength);
					SaveThrows.Add(EnumAbilitiesDnd5E.Physique);
					break;

				case EnumClassesDnd5E.Wizard:
				case EnumClassesDnd5E.Druid:
					SaveThrows.Add(EnumAbilitiesDnd5E.Intelligence);
					SaveThrows.Add(EnumAbilitiesDnd5E.Wisdom);
					break;

				case EnumClassesDnd5E.Cleric:
				case EnumClassesDnd5E.Warlock:
				case EnumClassesDnd5E.Paladin:
					SaveThrows.Add(EnumAbilitiesDnd5E.Wisdom);
					SaveThrows.Add(EnumAbilitiesDnd5E.Charisma);
					break;

				case EnumClassesDnd5E.Monk:
				case EnumClassesDnd5E.Ranger:
					SaveThrows.Add(EnumAbilitiesDnd5E.Strength);
					SaveThrows.Add(EnumAbilitiesDnd5E.Agility);
					break;

				case EnumClassesDnd5E.Rogue:
					SaveThrows.Add(EnumAbilitiesDnd5E.Agility);
					SaveThrows.Add(EnumAbilitiesDnd5E.Intelligence);
					break;

				case EnumClassesDnd5E.Sorcerer:
					SaveThrows.Add(EnumAbilitiesDnd5E.Physique);
					SaveThrows.Add(EnumAbilitiesDnd5E.Charisma);
					break;
			}
		}

		public override bool CheckSaveThrow(EnumAbilitiesDnd5E saveTrow)
		{
			return SaveThrows.Contains(saveTrow);
		}

		#endregion

		#region Конструкторы 

		/// <summary>
		/// Созадет список основных характеристик, которые завияст от класса.
		/// </summary>
		public SaveThrowsDnd5E()
		{
			SaveThrows = new List<EnumAbilitiesDnd5E>();
		}

		#endregion
	}
}