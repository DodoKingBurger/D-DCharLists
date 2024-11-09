namespace D_DCharLists
{
	/// <summary>
	/// Список характеристик предмета.
	/// </summary>
	public enum EnumItemStats
	{
		/// <summary>
		/// Название.
		/// </summary>
		Name,

		/// <summary>
		/// Стоимость.
		/// </summary>
		BaseCost,

		/// <summary>
		/// Вес.
		/// </summary>
		Weight,

		/// <summary>
		/// Редкость.
		/// </summary>
		Rarity,

		/// <summary>
		/// Описание.
		/// </summary>
		Description,

		/// <summary>
		/// Магический ли предмет?
		/// </summary>
		IsMagic,

		/// <summary>
		/// ID предмета.
		/// </summary>
		ItemId,

		/// <summary>
		/// Тип предмета.
		/// </summary>
		ItemType,

    /// <summary>
    /// Количество кубиков урона.
    /// </summary>
    DamageDiceCount,

    /// <summary>
    /// Значение урона в кубиках.
    /// </summary>
    DamageDiceValue,

    /// <summary>
    /// Модификатор урона.
    /// </summary>
    DamageModificator,

		/// <summary>
		/// Тип урона.
		/// </summary>
		DamageType,

    /// <summary>
    /// Требования к силе.
    /// </summary>
    StrengthRequirement,

    /// <summary>
    /// Класс брони.
    /// </summary>
    ArmorClass,

    /// <summary>
    /// Максимальный бонус к ловкости.
    /// </summary>
    MaxAgilityBonus,

    /// <summary>
    /// Собственность оружия.
    /// </summary>
    WeaponProperty,

    /// <summary>
    /// Тип брони.
    /// </summary>
    ArmorType,

		/// <summary>
		/// Навык владение оружием.
		/// </summary>
		WeaponProficiencyConcrete,

    /// <summary>
    /// Навык владение группы оружия.
    /// </summary>
    WeaponProficiencyGroup,

    /// <summary>
    /// Тип монеты.
    /// </summary>
    CoinType
  }
}