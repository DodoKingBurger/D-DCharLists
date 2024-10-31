namespace D_Dlib
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
			if (Enum.TryParse<EnumClassesDnd5E>(sheetClass.ToString(), out EnumClassesDnd5E result))
			{
				switch (result)
				{
					case EnumClassesDnd5E.Barbarian:
						return new BarbarianClassDND5e();

					case EnumClassesDnd5E.Bard:
						return new BardClassDND5e();

					case EnumClassesDnd5E.Cleric:
						return new ClericClassDND5e();

					case EnumClassesDnd5E.Druid:
						return new DruidClassDND5e();

					case EnumClassesDnd5E.Fighter:
						return new FighterClassDND5e();

					case EnumClassesDnd5E.Monk:
						return new MonkClassDND5e();

					case EnumClassesDnd5E.Paladin:
						return new PaladinClassDND5e();

					case EnumClassesDnd5E.Ranger:
						return new RangerClassDND5e();

					case EnumClassesDnd5E.Rogue:
						return new RogueClassDND5e();

					case EnumClassesDnd5E.Sorcerer:
						return new SorcererClassDND5e();

					case EnumClassesDnd5E.Warlock:
						return new WarlockClassDND5e();

					case EnumClassesDnd5E.Wizard:
						return new WizardClassDND5e();
				}
			}
			return new BarbarianClassDND5e();
		}
	}
}
