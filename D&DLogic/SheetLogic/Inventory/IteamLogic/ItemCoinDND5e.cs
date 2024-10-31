using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Монетка.
	/// </summary>
	public class ItemCoinDND5e : ItemBaseDND5e
	{
		#region Поля и свойства

		/// <summary>
		/// Тип монеты.
		/// </summary>
		[JsonProperty("CoinType")]
		public EnumCoinsTypeDND5e CoinType { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установить тип монеты.
		/// </summary>
		/// <param name="type">Новый тип монеты.</param>
		public void SetCoinType(EnumCoinsTypeDND5e type)
		{
			CoinType = type;
		}

		#endregion

		#region Конструкторы

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