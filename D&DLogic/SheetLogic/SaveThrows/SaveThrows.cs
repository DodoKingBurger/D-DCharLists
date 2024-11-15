namespace D_DCharLists
{
	/// <summary>
	/// Характеристики базовые зависящие от класса.
	/// </summary>
	public class SaveThrows : SheetSaveThrows
	{
		#region Базовый класс

		public override void SetSaveTrows(EnumClasses className)
		{
			switch (className)
			{
				case EnumClasses.Bard:
					this.SaveThrows.Add(EnumAbilities.Agility);
					this.SaveThrows.Add(EnumAbilities.Charisma);
					break;

				case EnumClasses.Barbarian:
				case EnumClasses.Fighter:
					this.SaveThrows.Add(EnumAbilities.Strength);
					this.SaveThrows.Add(EnumAbilities.Physique);
					break;

				case EnumClasses.Wizard:
				case EnumClasses.Druid:
					this.SaveThrows.Add(EnumAbilities.Intelligence);
					this.SaveThrows.Add(EnumAbilities.Wisdom);
					break;

				case EnumClasses.Cleric:
				case EnumClasses.Warlock:
				case EnumClasses.Paladin:
					this.SaveThrows.Add(EnumAbilities.Wisdom);
					this.SaveThrows.Add(EnumAbilities.Charisma);
					break;

				case EnumClasses.Monk:
				case EnumClasses.Ranger:
					this.SaveThrows.Add(EnumAbilities.Strength);
					this.SaveThrows.Add(EnumAbilities.Agility);
					break;

				case EnumClasses.Rogue:
					this.SaveThrows.Add(EnumAbilities.Agility);
					this.SaveThrows.Add(EnumAbilities.Intelligence);
					break;

				case EnumClasses.Sorcerer:
					this.SaveThrows.Add(EnumAbilities.Physique);
					this.SaveThrows.Add(EnumAbilities.Charisma);
					break;
			}
		}

		public override bool CheckSaveThrow(EnumAbilities saveTrow)
		{
			return this.SaveThrows.Contains(saveTrow);
		}

    #endregion

    #region Конструкторы 

    /// <summary>
    /// Создаёт список основных параметров. 
    /// </summary>
    public SaveThrows()
		{
			this.SaveThrows = new List<EnumAbilities>();
		}

		#endregion
	}
}