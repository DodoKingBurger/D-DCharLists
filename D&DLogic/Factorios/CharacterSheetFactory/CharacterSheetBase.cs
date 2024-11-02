
using System.Xml.Linq;

namespace D_DCharLists
{
	/// <summary>
	/// �������� ����� ���������.
	/// </summary>
	public abstract class CharacterSheetBase
	{
		#region ���� � ��������

		/// <summary>
		/// ���.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// �������.
		/// </summary>
		public EnumEditions Edition { get; set; }

		/// <summary>
		/// �����.
		/// </summary>
		public SheetRaceBase SheetRace { get; set; }

		/// <summary>
		/// ������.
		/// </summary>
		public SheetClassBase SheetClass { get; set; }

		/// <summary>
		/// �����������.
		/// </summary>
		public SheetAbilities SheetAbilities { get; set; }

		/// <summary>
		/// ������.
		/// </summary>
		public SheetSkills SheetSkills { get; set; }

		/// <summary>
		/// ����������.
		/// </summary>
		public SheetProgression SheetProgression { get; set; }

		/// <summary>
		/// ������ �������� �������������.
		/// </summary>
		public SheetSaveThrows SheetSaveThrows { get; set; }

		/// <summary>
		/// ��������.
		/// </summary>
		public SheetPersonality SheetPersonality { get; set; }

		/// <summary>
		/// ������ �����������.
		/// </summary>
		public SheetCombatAbilities SheetCombatAbilities { get; set; }

		/// <summary>
		/// ���������������� ������.
		/// </summary>
		public SheetProficiencies SheetProficiencies { get; set; }

		/// <summary>
		/// ���������.
		/// </summary>
		public SheetInventory SheetInventory { get; set; }

		/// <summary>
		/// ������ �������� �����.
		/// </summary>
		public TraitsListBase TraitsList { get; set; }

		/// <summary>
		/// ����������.
		/// </summary>
		public SheetSpellsBase SheetSpells {  get; set; }

		/// <summary>
		/// ����� ����������.
		/// </summary>
		public BaseEquipmentSystem SheetEquipmentSlots {  get; set; }

		/// <summary>
		/// �����������.
		/// </summary>
		public bool Inspiration {  get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ��������� �����.
		/// </summary>
		/// <param name="sheetRace">�������������� �����.</param>
		public void SetUpRace(SheetRaceBase sheetRace)
		{
			SheetRace = sheetRace;
		}

		/// <summary>
		/// ��������� ������.
		/// </summary>
		/// <param name="sheetClass">�������������� �����.</param>
		public void SetUpClass(SheetClassBase sheetClass)
		{
			SheetClass = sheetClass;
		}

		/// <summary>
		/// ��������� �����������.
		/// </summary>
		public abstract void ChangeInspiration();

		#endregion

	}
}