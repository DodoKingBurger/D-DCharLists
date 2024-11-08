using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// ������.
	/// </summary>
	public class ItemWeapon : ItemBase
	{
		#region ���� � ��������

		/// <summary>
		/// ���������� ������� �����.
		/// </summary>
		[JsonProperty("DamageDiceCount")]
		public int DamageDiceCount { get; set; }

		/// <summary>
		/// �������� ����� � �������.
		/// </summary>
		[JsonProperty("DamageDiceValue")]
		public EnumDices DamageDiceValue {  get; set; }

		/// <summary>
		/// ����������� �����.
		/// </summary>
		[JsonProperty("DamageModificator")]
		public int DamageModificator {  get; set; }

		/// <summary>
		/// ��� �����.
		/// </summary>
		[JsonProperty("DamageType")]
		public EnumItemDamageTypes DamageType {  get; set; }

		/// <summary>
		/// �������� ������.
		/// </summary>
		[JsonProperty("WeaponProperty")]
		public List<EnumWeaponProperties> WeaponProperty {  get; set; }

		/// <summary>
		/// �������� �������.
		/// </summary>
		[JsonProperty("WeaponProficiencyConcrete")]
		public EnumWeaponsProficiencies WeaponProficiencyConcrete {  get; set; }

		/// <summary>
		/// ������ ������ ������.
		/// </summary>
		[JsonProperty("WeaponProficiencyGroup")]
		public EnumWeaponsGroups WeaponProficiencyGroup {  get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ���������� �������� ���������� ������� �����.
		/// </summary>
		/// <param name="value">����� ���������� ������� �����.</param>
		public void SetDamageDiceCount(int value)
		{
			DamageDiceCount = value;
		}

		/// <summary>
		/// ���������� �������� ����� ��� ������.
		/// </summary>
		/// <param name="value">����� �������� �����.</param>
		public void SetDamageDiceValue(EnumDices value)
		{
			DamageDiceValue = value;
		}

		/// <summary>
		/// ���������� �������� ������������ �����.
		/// </summary>
		/// <param name="value">����� ����������� �����.</param>
		public void SetDamageModificator(int value)
		{
			DamageModificator = value;
		}

		/// <summary>
		/// ������� ��� ����� � ������.
		/// </summary>
		/// <param name="value">����� ��� �����.</param>
		public void SetDamageType(EnumItemDamageTypes value)
		{
			DamageType = value;
		}

		/// <summary>
		/// ������� �������� ������, ���� ��� ��� ���.
		/// </summary>
		/// <param name="value">�������� ������.</param>
		public void AddWeaponProperty(EnumWeaponProperties value)
		{
			if (!WeaponProperty.Contains(value))
			{
				WeaponProperty.Add(value);
			}
		}

		/// <summary>
		/// ���������� ����� ����� ������ ������.
		/// </summary>
		/// <param name="value">����� ������ ������.</param>
		public void SetWeaponGroup(EnumWeaponsGroups value)
		{
			WeaponProficiencyGroup = value;
		}

		/// <summary>
		/// ������� ����� �������� �������. 
		/// </summary>
		/// <param name="value">����� ����� ������.</param>
		public void SetWeaponConcreteProf(EnumWeaponsProficiencies value)
		{
			WeaponProficiencyConcrete = value;
		}

		#endregion

		#region ������������

		public ItemWeapon()
		{
			ItemType = EnumItemTypes.Weapon;
			Name = string.Empty;
			BaseCost = 0;
			Weight = 0;
			Rarity = EnumItemRarityTypes.Usual;
			Description = string.Empty;
			IsMagic = false;
			ItemId = 0;
			DamageDiceCount = 0;
			DamageDiceValue = EnumDices.d4;
			DamageModificator = 0;
			DamageType = EnumItemDamageTypes.Bludgeoning;
			WeaponProperty = new List<EnumWeaponProperties>();
			WeaponProficiencyConcrete = EnumWeaponsProficiencies.Club;
			WeaponProficiencyGroup = EnumWeaponsGroups.SimpleMelee;
		}

		#endregion
	}
}
