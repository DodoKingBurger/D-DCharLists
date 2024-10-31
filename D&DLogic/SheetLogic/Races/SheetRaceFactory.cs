namespace D_Dlib
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
			if (Enum.TryParse<EnumRacesDnd5E>(sheetRace.ToString(), out EnumRacesDnd5E result))
			{
				switch (result)
				{
					case EnumRacesDnd5E.Dragonborn:
						return new DragonbornRaceDND5e();

					case EnumRacesDnd5E.Dwarf:
						return new DwarfRaceDND5e();

					case EnumRacesDnd5E.Elf:
						return new ElfRaceDND5e();

					case EnumRacesDnd5E.Gnome:
						return new GnomeRaceDND5e();

					case EnumRacesDnd5E.Halfelf:
						return new HalfelfRaceDND5e();

					case EnumRacesDnd5E.Halfling:
						return new HalflingRaceDND5e();

					case EnumRacesDnd5E.Halforc:
						return new HalforcRaceDND5e();

					case EnumRacesDnd5E.Human:
						return new HumanRaceDND5e();

					case EnumRacesDnd5E.Tiefling:
						return new TieflingRaceDND5e();
				}
			}

			return new DragonbornRaceDND5e();
		}
	}
}
