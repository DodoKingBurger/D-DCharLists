using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������.
	/// </summary>
	public class ItemCoin : ItemBase
	{
		#region ���� � ��������

		/// <summary>
		/// ��� ������.
		/// </summary>
		[JsonProperty("CoinType")]
		public EnumCoinsType CoinType { get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ���������� ��� ������.
		/// </summary>
		/// <param name="type">����� ��� ������.</param>
		public void SetCoinType(EnumCoinsType type)
		{
			CoinType = type;
		}

		#endregion

		#region ������������

		public ItemCoin()
		{
			ItemType = EnumItemTypes.Coin;
			Name = string.Empty;
			BaseCost = 0;
			Weight = 0.02f;
			Rarity = EnumItemRarityTypes.Usual;
			Description = string.Empty;
			IsMagic = false;
			ItemId = 0;
			CoinType = EnumCoinsType.Copper;
		}

		#endregion
	}
}