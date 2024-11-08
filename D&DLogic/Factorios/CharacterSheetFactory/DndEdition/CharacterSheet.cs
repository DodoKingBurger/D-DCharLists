namespace D_DCharLists
{
	/// <summary>
	/// Лист персонажа. 
	/// </summary>
	public class CharacterSheet : CharacterSheetBase
	{

		public override void ChangeInspiration()
		{
			Inspiration = !Inspiration;
		}

		/// <summary>
		/// Создаем лист персонажа.
		/// </summary>
		public CharacterSheet()
		{
			SheetAbilities = new AbilitiesDnd5E();
			SheetSaveThrows = new SaveThrows();
			SheetSkills = new Skills();
			SheetProgression = new Progression();
			SheetPersonality = new Personality();
			SheetCombatAbilities = new CombatAbilitiesDND5E();
			SheetProficiencies = new Proficiencies();
			SheetInventory = new Inventory();
			TraitsList = new TraitsList();
			SheetSpells = new SheetSpells();
			SheetEquipmentSlots = new Equipment();
			Inspiration = false;
		}
	}
}