using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность предмета.
	/// </summary>
	public abstract class ItemBase
	{
		#region Поля и свойства

		/// <summary>
		/// Названия предмета.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; set; }

		/// <summary>
		/// Базовая стоймость.
		/// </summary>
		[JsonProperty("BaseCost")]
		public float BaseCost { get; set; }

		/// <summary>
		/// Масса.
		/// </summary>
		[JsonProperty("Weight")]
		public float Weight { get; set; }

		/// <summary>
		/// Редкость.
		/// </summary>
		[JsonProperty("Rarity")]
		public EnumItemRarityTypes Rarity { get; set; }

		/// <summary>
		/// Описание.
		/// </summary>
		[JsonProperty("Description")]
		public string Description { get; set; }

		/// <summary>
		/// Магический ли предмет.
		/// </summary>
		[JsonProperty("IsMagic")]
		public bool IsMagic { get; set; }

		/// <summary>
		/// ID предмета.
		/// </summary>
		[JsonProperty("ItemId")]
		public int ItemId { get; set; }

		/// <summary>
		/// Тип предмета.
		/// </summary>
		[JsonProperty("ItemType")]
		public EnumItemTypes ItemType { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установить ID предмету.
		/// </summary>
		public void SetItemId()
		{
			ItemId = RollRandom.LetsRoll.Next(1000, 10000);
		}

		/// <summary>
		/// Назвать предмет.
		/// </summary>
		/// <param name="value">Названия предмета.</param>
		public void SetName(string value)
		{
			Name = value;
		}

		/// <summary>
		/// Установиь базовую стоймость предмета.
		/// </summary>
		/// <param name="value"></param>
		public void SetBaseCost(float value)
		{
			BaseCost = value;
		}

		/// <summary>
		/// Установить вес предмета.
		/// </summary>
		/// <param name="value">Вес предмета.</param>
		public void SetWeight(float value)
		{
			Weight = value;
		}

		/// <summary>
		/// Установить редкость для предмета.
		/// </summary>
		/// <param name="value"></param>
		public void SetRarity(EnumItemRarityTypes value)
		{
			Rarity = value;
		}

		/// <summary>
		/// Установить описания предмета.
		/// </summary>
		/// <param name="value"></param>
		public void SetDescription(string value)
		{
			Description = value;
		}

		/// <summary>
		/// Изменения магического свойства предмета.
		/// </summary>
		/// <param name="value">true, если предмет магический, false если нет.</param>
		public void SetIsMagic(bool value)
		{
			IsMagic = value;
		}

		#endregion
	}
}