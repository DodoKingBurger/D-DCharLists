namespace D_DCharLists
{
	/// <summary>
	/// Лист персонажа. 
	/// </summary>
	public class CharacterSheet : CharacterSheetBase
	{

		public override void ChangeInspiration()
		{
      this.Inspiration = !this.Inspiration;
		}

		/// <summary>
		/// Создаем лист персонажа.
		/// </summary>
		public CharacterSheet()
		{
      this.SheetAbilities = new AbilitiesDnd5E();
      this.SheetSaveThrows = new SaveThrows();
      this.SheetSkills = new Skills();
      this.SheetProgression = new Progression();
      this.SheetPersonality = new Personality();
      this.SheetCombatAbilities = new CombatAbilities();
      this.SheetProficiencies = new Proficiencies();
      this.SheetInventory = new Inventory();
      this.TraitsList = new TraitsList();
      this.SheetSpells = new SheetSpells();
      this.SheetEquipmentSlots = new Equipment();
      this.Inspiration = false;
		}
	}
}