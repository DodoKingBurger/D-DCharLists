namespace D_DCharLists
{
	/// <summary>
	/// Фабрика для расы.
	/// </summary>
	public class SheetRaceFactory
	{
    /// <summary>
    /// Инициализирует расу по отправленному названию из списка представленных рас.
    /// </summary>
    /// <param name="sheetRace">Название расы.</param>
    /// <returns>Создаёт запрошенную расу.</returns>
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

					default:
						throw new NotImplementedException("Данная раса не представлена в списке.");
				}
			}
			else
				throw new ArgumentException("Неизвестная расса");
		}

    /// <summary>
    /// Инициализирует расу по отправленному названию из списка представленных рас.
    /// </summary>
    /// <param name="sheetRace">Название расы.</param>
    /// <returns>Создаёт запрошенную расу.</returns>
		/// <exception cref="NotImplementedException">Неизвестная название расы.</exception>
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
						throw new NotImplementedException("Данная раса не представлена в списке.");
				}
			}
			else
			{
				throw new NotImplementedException("Не возможно найти данную расу в записанном списке существующих рас.");
			}
		}
	}
}
