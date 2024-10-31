namespace D_Dlib
{
	/// <summary>
	/// Лист персонажа.
	/// </summary>
	public class CharacterSheetDnd5E : CharacterSheetBase
	{

		public override void ChangeInspiration()
		{
			Inspiration = !Inspiration;
		}

		/// <summary>
		/// Создаем лист персонажа.
		/// </summary>
		public CharacterSheetDnd5E()
		{
			SheetAbilities = new AbilitiesDnd5E();
			SheetSaveThrows = new SaveThrowsDnd5E();
			SheetSkills = new SkillsDnd5E();
			SheetProgression = new ProgressionDnd5E();
			Edition = EnumEditions.DND5E;
			SheetPersonality = new PersonalityDND5E();
			SheetCombatAbilities = new CombatAbilitiesDND5E();
			SheetProficiencies = new ProficienciesDND5E();
			SheetInventory = new InventoryDND5E();
			TraitsList = new TraitsListDND5e();
			SheetSpells = new SheetSpellsDND5e();
			SheetEquipmentSlots = new EquipmentDND5e();
			Inspiration = false;
		}
	}
}