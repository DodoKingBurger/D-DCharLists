using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// ������.
	/// </summary>
	public class ItemArmor : ItemBase
	{
		#region ���� � �������� 

		/// <summary>
		/// ���������� � ����.
		/// </summary>
		[JsonProperty("StrengthRequirement")]
		public int StrengthRequirement { get; set; }

		/// <summary>
		/// ����� �����.
		/// </summary>
		[JsonProperty("ArmorClass")]
		public int ArmorClass { get; set; }

		/// <summary>
		/// ������������ ����� � ��������.
		/// </summary>
		[JsonProperty("MaxAgilityBonus")]
		public int MaxAgilityBonus { get; set; }

		/// <summary>
		/// ��� �����.
		/// </summary>
		[JsonProperty("ArmorType")]
		public EnumArmorProficiencies ArmorType { get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ��������� ���������.
		/// </summary>
		/// <param name="value"></param>
		public void SetStrengthRequirement(int value)
		{
			StrengthRequirement = value;
		}

		/// <summary>
		/// ��������� ������ �����.
		/// </summary>
		/// <param name="value">����� ����� �����.</param>
		public void SetArmorClass(int value)
		{
			ArmorClass = value;
		}

		/// <summary>
		/// ��������� ������������� ������ � ��������.
		/// </summary>
		/// <param name="value">����� ����� � ��������.</param>
		public void SetMaxAgilityBonus(int value)
		{
			MaxAgilityBonus = value;
		}

		/// <summary>
		/// ��������� ������ ���� �����.
		/// </summary>
		/// <param name="value"></param>
		public void SetArmorType(EnumArmorProficiencies value)
		{
			ArmorType = value;
		}

		#endregion 

		#region ������������ 

		public ItemArmor()
		{
			ItemType = EnumItemTypes.Armor;
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
			ArmorType = EnumArmorProficiencies.LightArmor;
		}

		#endregion

	}
}