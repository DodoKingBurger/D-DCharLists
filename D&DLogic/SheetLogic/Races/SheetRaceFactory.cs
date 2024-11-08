namespace D_DCharLists
{
	/// <summary>
	/// Фабрика по инициализации расс.
	/// </summary>
	public class SheetRaceFactory
	{
		/// <summary>
		/// Инициализирует по переданному из списка названию рассу.
		/// </summary>
		/// <param name="sheetRace">Название рассы из списка.</param>
		/// <returns>Инициализрованную сущность, если переданный список не подходт под рассовый, то создаст Драконорожденного.</returns>
		public SheetRaceBase CreateSheetRace(Enum sheetRace)
		{
			if (Enum.TryParse<EnumRaces>(sheetRace.ToString(), out EnumRaces result))
			{
				switch (result)
				{
					case EnumRaces.Dragonborn:
						return new DragonbornRace();

					case EnumRaces.Dwarf:
						return new DwarfRace();

					case EnumRaces.Elf:
						return new ElfRace();

					case EnumRaces.Gnome:
						return new GnomeRace();

					case EnumRaces.Halfelf:
						return new HalfelfRace();

					case EnumRaces.Halfling:
						return new HalflingRace();

					case EnumRaces.Halforc:
						return new HalforcRace();

					case EnumRaces.Human:
						return new HumanRace();

					case EnumRaces.Tiefling:
						return new TieflingRace();
				}
			}

			return new DragonbornRace();
		}

		/// <summary>
		/// Инициализирует по переданному строке с названием рассы.
		/// </summary>
		/// <param name="sheetRace">Название рассы.</param>
		/// <returns>Инициализрованную сущность рассы.</returns>
		/// <exception cref="NotImplementedException">В списке такой рассы нету.</exception>
		public SheetRaceBase CreateSheetRace(string sheetRace)
		{
			if (Enum.TryParse<EnumRaces>(sheetRace, out EnumRaces result))
			{
				switch (sheetRace)
				{
					case "Dragonborn":
						return new DragonbornRace();

					case "Dwarf":
						return new DwarfRace();

					case "Elf":
						return new ElfRace();

					case "Gnome":
						return new GnomeRace();

					case "Halfelf":
						return new HalfelfRace();

					case "Halfling":
						return new HalflingRace();

					case "Halforc":
						return new HalforcRace();

					case "Human":
						return new HumanRace();

					case "Tiefling":
						return new TieflingRace();
					default:
						throw new NotImplementedException("Попытка создания не описанной рассы.");
				}
			}
			else
			{
				throw new NotImplementedException("Попытка создания не описанной рассы.");
			}
		}
	}
}
