using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// ������.
	/// </summary>
	public class ItemWeaponDND5e : ItemBaseDND5e
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
		public EnumItemDamageTypesDND5e DamageType {  get; set; }

		/// <summary>
		/// �������� ������.
		/// </summary>
		[JsonProperty("WeaponProperty")]
		public List<EnumWeaponPropertiesDND5e> WeaponProperty {  get; set; }

		/// <summary>
		/// �������� �������.
		/// </summary>
		[JsonProperty("WeaponProficiencyConcrete")]
		public EnumWeaponsProficienciesDND5E WeaponProficiencyConcrete {  get; set; }

		/// <summary>
		/// ������ ������ ������.
		/// </summary>
		[JsonProperty("WeaponProficiencyGroup")]
		public EnumWeaponsGroupsDND5E WeaponProficiencyGroup {  get; set; }

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
		public void SetDamageType(EnumItemDamageTypesDND5e value)
		{
			DamageType = value;
		}

		/// <summary>
		/// ������� �������� ������, ���� ��� ��� ���.
		/// </summary>
		/// <param name="value">�������� ������.</param>
		public void AddWeaponProperty(EnumWeaponPropertiesDND5e value)
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
		public void SetWeaponGroup(EnumWeaponsGroupsDND5E value)
		{
			WeaponProficiencyGroup = value;
		}

		/// <summary>
		/// ������� ����� �������� �������. 
		/// </summary>
		/// <param name="value">����� ����� ������.</param>
		public void SetWeaponConcreteProf(EnumWeaponsProficienciesDND5E value)
		{
			WeaponProficiencyConcrete = value;
		}

		#endregion

		#region ������������

		public ItemWeaponDND5e()
		{
			ItemType = EnumItemTypesDND5e.Weapon;
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
			DamageType = EnumItemDamageTypesDND5e.Bludgeoning;
			WeaponProperty = new List<EnumWeaponPropertiesDND5e>();
			WeaponProficiencyConcrete = EnumWeaponsProficienciesDND5E.Club;
			WeaponProficiencyGroup = EnumWeaponsGroupsDND5E.SimpleMelee;
		}

		#endregion
	}
}
