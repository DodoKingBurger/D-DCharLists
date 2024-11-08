using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Оружие.
	/// </summary>
	public class ItemWeapon : ItemBase
	{
		#region Поля и свойства

		/// <summary>
		/// Количество кубиков урона.
		/// </summary>
		[JsonProperty("DamageDiceCount")]
		public int DamageDiceCount { get; set; }

		/// <summary>
		/// Значение урона в кубиках.
		/// </summary>
		[JsonProperty("DamageDiceValue")]
		public EnumDices DamageDiceValue {  get; set; }

		/// <summary>
		/// Модификатор урона.
		/// </summary>
		[JsonProperty("DamageModificator")]
		public int DamageModificator {  get; set; }

		/// <summary>
		/// Тип урона.
		/// </summary>
		[JsonProperty("DamageType")]
		public EnumItemDamageTypes DamageType {  get; set; }

		/// <summary>
		/// Свойства оружия.
		/// </summary>
		[JsonProperty("WeaponProperty")]
		public List<EnumWeaponProperties> WeaponProperty {  get; set; }

		/// <summary>
		/// Владение оружием.
		/// </summary>
		[JsonProperty("WeaponProficiencyConcrete")]
		public EnumWeaponsProficiencies WeaponProficiencyConcrete {  get; set; }

		/// <summary>
		/// Навыки группы оружия.
		/// </summary>
		[JsonProperty("WeaponProficiencyGroup")]
		public EnumWeaponsGroups WeaponProficiencyGroup {  get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установить значения количество кубиков урона.
		/// </summary>
		/// <param name="value">Новое количество кубиков урона.</param>
		public void SetDamageDiceCount(int value)
		{
			DamageDiceCount = value;
		}

		/// <summary>
		/// Установить значение урона для оружия.
		/// </summary>
		/// <param name="value">Новое значение урона.</param>
		public void SetDamageDiceValue(EnumDices value)
		{
			DamageDiceValue = value;
		}

		/// <summary>
		/// Установить значения модификатора урона.
		/// </summary>
		/// <param name="value">Новый модификатор урона.</param>
		public void SetDamageModificator(int value)
		{
			DamageModificator = value;
		}

		/// <summary>
		/// Сменить тип урона у оружия.
		/// </summary>
		/// <param name="value">Новый тип урона.</param>
		public void SetDamageType(EnumItemDamageTypes value)
		{
			DamageType = value;
		}

		/// <summary>
		/// Добавит свойства оружия, если его еще нет.
		/// </summary>
		/// <param name="value">Свойство оружия.</param>
		public void AddWeaponProperty(EnumWeaponProperties value)
		{
			if (!WeaponProperty.Contains(value))
			{
				WeaponProperty.Add(value);
			}
		}

		/// <summary>
		/// Установить новый навык группы оружия.
		/// </summary>
		/// <param name="value">Навык группы оружия.</param>
		public void SetWeaponGroup(EnumWeaponsGroups value)
		{
			WeaponProficiencyGroup = value;
		}

		/// <summary>
		/// Сменить навык владения оружием. 
		/// </summary>
		/// <param name="value">Новый навык оружия.</param>
		public void SetWeaponConcreteProf(EnumWeaponsProficiencies value)
		{
			WeaponProficiencyConcrete = value;
		}

		#endregion

		#region Конструкторы

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
