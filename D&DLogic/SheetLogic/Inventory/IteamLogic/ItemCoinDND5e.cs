using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// �������.
	/// </summary>
	public class ItemCoinDND5e : ItemBaseDND5e
	{
		#region ���� � ��������

		/// <summary>
		/// ��� ������.
		/// </summary>
		[JsonProperty("CoinType")]
		public EnumCoinsTypeDND5e CoinType { get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ���������� ��� ������.
		/// </summary>
		/// <param name="type">����� ��� ������.</param>
		public void SetCoinType(EnumCoinsTypeDND5e type)
		{
			CoinType = type;
		}

		#endregion

		#region ������������

		public ItemCoinDND5e()
		{
			ItemType = EnumItemTypesDND5e.Coin;
			Name = string.Empty;
			BaseCost = 0;
			Weight = 0.02f;
			Rarity = EnumItemRarityTypes.Usual;
			Description = string.Empty;
			IsMagic = false;
			ItemId = 0;
			CoinType = EnumCoinsTypeDND5e.Copper;
		}

		#endregion
	}
}