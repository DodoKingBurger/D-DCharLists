namespace D_DCharLists
{
	/// <summary>
	/// Основные характеристики завищящие от класса.
	/// </summary>
	public class SaveThrows : SheetSaveThrows
	{
		#region Базовый класс

		public override void SetSaveTrows(EnumClasses className)
		{
			switch (className)
			{
				case EnumClasses.Bard:
					SaveThrows.Add(EnumAbilities.Agility);
					SaveThrows.Add(EnumAbilities.Charisma);
					break;

				case EnumClasses.Barbarian:
				case EnumClasses.Fighter:
					SaveThrows.Add(EnumAbilities.Strength);
					SaveThrows.Add(EnumAbilities.Physique);
					break;

				case EnumClasses.Wizard:
				case EnumClasses.Druid:
					SaveThrows.Add(EnumAbilities.Intelligence);
					SaveThrows.Add(EnumAbilities.Wisdom);
					break;

				case EnumClasses.Cleric:
				case EnumClasses.Warlock:
				case EnumClasses.Paladin:
					SaveThrows.Add(EnumAbilities.Wisdom);
					SaveThrows.Add(EnumAbilities.Charisma);
					break;

				case EnumClasses.Monk:
				case EnumClasses.Ranger:
					SaveThrows.Add(EnumAbilities.Strength);
					SaveThrows.Add(EnumAbilities.Agility);
					break;

				case EnumClasses.Rogue:
					SaveThrows.Add(EnumAbilities.Agility);
					SaveThrows.Add(EnumAbilities.Intelligence);
					break;

				case EnumClasses.Sorcerer:
					SaveThrows.Add(EnumAbilities.Physique);
					SaveThrows.Add(EnumAbilities.Charisma);
					break;
			}
		}

		public override bool CheckSaveThrow(EnumAbilities saveTrow)
		{
			return SaveThrows.Contains(saveTrow);
		}

		#endregion

		#region Конструкторы 

		/// <summary>
		/// Созадет список основных характеристик, которые завияст от класса.
		/// </summary>
		public SaveThrows()
		{
			SaveThrows = new List<EnumAbilities>();
		}

		#endregion
	}
}