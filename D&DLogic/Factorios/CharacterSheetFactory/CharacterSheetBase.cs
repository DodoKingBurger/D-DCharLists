
using System.Xml.Linq;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность листа персонажа. 
	/// </summary>
	public abstract class CharacterSheetBase
	{
		#region Поля и свойства

		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Расса.
		/// </summary>
		public SheetRaceBase SheetRace { get; set; }

		/// <summary>
		/// Классс.
		/// </summary>
		public SheetClassBase SheetClass { get; set; }

		/// <summary>
		/// Характеристик.
		/// </summary>
		public SheetAbilities SheetAbilities { get; set; }

		/// <summary>
		/// Навыки.
		/// </summary>
		public SheetSkills SheetSkills { get; set; }

		/// <summary>
		/// Прогрессия.
		/// </summary>
		public SheetProgression SheetProgression { get; set; }

		/// <summary>
		/// Список основных характеристик.
		/// </summary>
		public SheetSaveThrows SheetSaveThrows { get; set; }

		/// <summary>
		/// Личность.
		/// </summary>
		public SheetPersonality SheetPersonality { get; set; }

		/// <summary>
		/// Боевые способности.
		/// </summary>
		public SheetCombatAbilities SheetCombatAbilities { get; set; }

		/// <summary>
		/// Профессиональные навыки.
		/// </summary>
		public SheetProficiencies SheetProficiencies { get; set; }

		/// <summary>
		/// Инвентарь.
		/// </summary>
		public SheetInventory SheetInventory { get; set; }

		/// <summary>
		/// Список талантов героя.
		/// </summary>
		public TraitsListBase TraitsList { get; set; }

		/// <summary>
		/// Заклинания.
		/// </summary>
		public SheetSpellsBase SheetSpells {  get; set; }

		/// <summary>
		/// Слоты снаряжения.
		/// </summary>
		public BaseEquipmentSystem SheetEquipmentSlots {  get; set; }

		/// <summary>
		/// Вдохновение.
		/// </summary>
		public bool Inspiration {  get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установка рассы.
		/// </summary>
		/// <param name="sheetRace">Присваемымывая расса.</param>
		public void SetUpRace(SheetRaceBase sheetRace)
		{
			SheetRace = sheetRace;
		}

		/// <summary>
		/// Установка класса.
		/// </summary>
		/// <param name="sheetClass">Присваемымывый класс.</param>
		public void SetUpClass(SheetClassBase sheetClass)
		{
			SheetClass = sheetClass;
		}

		/// <summary>
		/// Изменение вдохновения.
		/// </summary>
		public abstract void ChangeInspiration();

		#endregion
	}
}