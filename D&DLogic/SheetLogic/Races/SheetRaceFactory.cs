namespace D_DCharLists
{
	/// <summary>
	/// ������� �� ������������� ����.
	/// </summary>
	public class SheetRaceFactory
	{
		/// <summary>
		/// �������������� �� ����������� �� ������ �������� �����.
		/// </summary>
		/// <param name="sheetRace">�������� ����� �� ������.</param>
		/// <returns>����������������� ��������, ���� ���������� ������ �� ������� ��� ��������, �� ������� �����������������.</returns>
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
		/// �������������� �� ����������� ������ � ��������� �����.
		/// </summary>
		/// <param name="sheetRace">�������� �����.</param>
		/// <returns>����������������� �������� �����.</returns>
		/// <exception cref="NotImplementedException">� ������ ����� ����� ����.</exception>
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
						throw new NotImplementedException("������� �������� �� ��������� �����.");
				}
			}
			else
			{
				throw new NotImplementedException("������� �������� �� ��������� �����.");
			}
		}
	}
}
