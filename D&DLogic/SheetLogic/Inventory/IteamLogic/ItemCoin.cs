using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Монетка.
	/// </summary>
	public class ItemCoin : ItemBase
	{
		#region Поля и свойства

		/// <summary>
		/// Тип монеты.
		/// </summary>
		[JsonProperty("CoinType")]
		public EnumCoinsType CoinType { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установить тип монеты.
		/// </summary>
		/// <param name="type">Новый тип монеты.</param>
		public void SetCoinType(EnumCoinsType type)
		{
			CoinType = type;
		}

		#endregion

		#region Конструкторы

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