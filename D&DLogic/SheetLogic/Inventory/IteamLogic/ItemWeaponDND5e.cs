using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Оружие.
	/// </summary>
	public class ItemWeaponDND5e : ItemBaseDND5e
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
		public EnumItemDamageTypesDND5e DamageType {  get; set; }

		/// <summary>
		/// Свойства оружия.
		/// </summary>
		[JsonProperty("WeaponProperty")]
		public List<EnumWeaponPropertiesDND5e> WeaponProperty {  get; set; }

		/// <summary>
		/// Владение оружием.
		/// </summary>
		[JsonProperty("WeaponProficiencyConcrete")]
		public EnumWeaponsProficienciesDND5E WeaponProficiencyConcrete {  get; set; }

		/// <summary>
		/// Навыки группы оружия.
		/// </summary>
		[JsonProperty("WeaponProficiencyGroup")]
		public EnumWeaponsGroupsDND5E WeaponProficiencyGroup {  get; set; }

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
		public void SetDamageType(EnumItemDamageTypesDND5e value)
		{
			DamageType = value;
		}

		/// <summary>
		/// Добавит свойства оружия, если его еще нет.
		/// </summary>
		/// <param name="value">Свойство оружия.</param>
		public void AddWeaponProperty(EnumWeaponPropertiesDND5e value)
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
		public void SetWeaponGroup(EnumWeaponsGroupsDND5E value)
		{
			WeaponProficiencyGroup = value;
		}

		/// <summary>
		/// Сменить навык владения оружием. 
		/// </summary>
		/// <param name="value">Новый навык оружия.</param>
		public void SetWeaponConcreteProf(EnumWeaponsProficienciesDND5E value)
		{
			WeaponProficiencyConcrete = value;
		}

		#endregion

		#region Конструкторы

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
