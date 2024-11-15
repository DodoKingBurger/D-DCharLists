namespace D_DCharLists
{
	/// <summary>
	/// Фабрика для инициализации класса.
	/// </summary>
	public class SheetClassFactory
	{
		/// <summary>
		/// Создает сущность для хранения информации о классе.
		/// </summary>
		/// <param name="sheetClass">Названия класса.</param>
		/// <returns>Сзданный дата щит запрошенного класса, если название отправленно неизвестное создает Варвара по дефолту.</returns>
		public SheetClassBase CreateSheetClass(Enum sheetClass)
		{
			if (Enum.TryParse<EnumClasses>(sheetClass.ToString(), out EnumClasses result))
			{
				switch (result)
				{
					case EnumClasses.Barbarian:
						return new BarbarianClass();

					case EnumClasses.Bard:
						return new BardClass();

					case EnumClasses.Cleric:
						return new ClericClass();

					case EnumClasses.Druid:
						return new DruidClass();

					case EnumClasses.Fighter:
						return new FighterClass();

					case EnumClasses.Monk:
						return new MonkClass();

					case EnumClasses.Paladin:
						return new PaladinClass();

					case EnumClasses.Ranger:
						return new RangerClass();

					case EnumClasses.Rogue:
						return new RogueClass();

					case EnumClasses.Sorcerer:
						return new SorcererClass();

					case EnumClasses.Warlock:
						return new WarlockClass();

					case EnumClasses.Wizard:
						return new WizardClass();

					default:
						throw new NotImplementedException("Неизвестная раса");	
				}
			}
			else
				throw new NotImplementedException("Неивестный список рас");
		}

		/// <summary>
		/// Создает сущность для хранения информации о классе.
		/// </summary>
		/// <param name="sheetClass">Названия класса.</param>
		/// <returns>Сзданный дата щит запрошенного класса, если название отправленно неизвестное создает Варвара по дефолту.</returns>
		public SheetClassBase CreateSheetClass(string sheetClass)
		{
			if (Enum.TryParse<EnumClasses>(sheetClass, out EnumClasses result))
			{
				switch (result)
				{
					case EnumClasses.Barbarian:
						return new BarbarianClass();

					case EnumClasses.Bard:
						return new BardClass();

					case EnumClasses.Cleric:
						return new ClericClass();

					case EnumClasses.Druid:
						return new DruidClass();

					case EnumClasses.Fighter:
						return new FighterClass();

					case EnumClasses.Monk:
						return new MonkClass();

					case EnumClasses.Paladin:
						return new PaladinClass();

					case EnumClasses.Ranger:
						return new RangerClass();

					case EnumClasses.Rogue:
						return new RogueClass();

					case EnumClasses.Sorcerer:
						return new SorcererClass();

					case EnumClasses.Warlock:
						return new WarlockClass();

					case EnumClasses.Wizard:
						return new WizardClass();

					default:
						throw new NotImplementedException("Неизвестная раса");
				}
			}
			else
				throw new NotImplementedException("Неивестный список рас");
		}
	}
}
