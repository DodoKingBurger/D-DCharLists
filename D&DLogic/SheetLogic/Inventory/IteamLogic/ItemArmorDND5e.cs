using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Доспех.
	/// </summary>
	public class ItemArmorDND5e : ItemBaseDND5e
	{
		#region Поля и свойства 

		/// <summary>
		/// Требования к силе.
		/// </summary>
		[JsonProperty("StrengthRequirement")]
		public int StrengthRequirement { get; set; }

		/// <summary>
		/// Класс брони.
		/// </summary>
		[JsonProperty("ArmorClass")]
		public int ArmorClass { get; set; }

		/// <summary>
		/// Максимальный бонус к ловкости.
		/// </summary>
		[JsonProperty("MaxAgilityBonus")]
		public int MaxAgilityBonus { get; set; }

		/// <summary>
		/// Тип брони.
		/// </summary>
		[JsonProperty("ArmorType")]
		public EnumArmorProficienciesDND5E ArmorType { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установка прочности.
		/// </summary>
		/// <param name="value"></param>
		public void SetStrengthRequirement(int value)
		{
			StrengthRequirement = value;
		}

		/// <summary>
		/// Установка класса брони.
		/// </summary>
		/// <param name="value">Новый класс брони.</param>
		public void SetArmorClass(int value)
		{
			ArmorClass = value;
		}

		/// <summary>
		/// Установка максимального бонуса к ловкости.
		/// </summary>
		/// <param name="value">Новый бонус к ловкости.</param>
		public void SetMaxAgilityBonus(int value)
		{
			MaxAgilityBonus = value;
		}

		/// <summary>
		/// Установка нового типа брони.
		/// </summary>
		/// <param name="value"></param>
		public void SetArmorType(EnumArmorProficienciesDND5E value)
		{
			ArmorType = value;
		}

		#endregion 

		#region Конструкторы 

		public ItemArmorDND5e()
		{
			ItemType = EnumItemTypesDND5e.Armor;
			Name = string.Empty;
			BaseCost = 0;
			Weight = 0;
			Rarity = EnumItemRarityTypes.Usual;
			Description = string.Empty;
			IsMagic = false;
			ItemId = 0;
			StrengthRequirement = 0;
			ArmorClass = 0;
			MaxAgilityBonus = 0;
			ArmorType = EnumArmorProficienciesDND5E.LightArmor;
		}

		#endregion

	}
}