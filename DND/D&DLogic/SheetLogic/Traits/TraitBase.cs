using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность таланта.
	/// </summary>
	public abstract class TraitBase
	{
		#region Поля и свойства
		/// <summary>
		/// Навзание.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; protected set; }

		/// <summary>
		/// Источник.
		/// </summary>
		[JsonProperty("Source")]
		public string Source { get; protected set; }

		/// <summary>
		/// Описание.
		/// </summary>
		[JsonProperty("Description")]
		public string Description { get; protected set; }

		/// <summary>
		/// ID черты.
		/// </summary>
		[JsonProperty("Id")]
		public int Id { get; protected set; }

		/// <summary>
		/// Уровень получения.
		/// </summary>
		[JsonProperty("LevelGained")]
		public int LevelGained { get; protected set; }

		#endregion

		#region Методы

		/// <summary>
		/// Установить ID.
		/// </summary>
		public void SetID()
		{
			this.Id = RollRandom.LetsRoll.Next(1000, 10000);
		}

		/// <summary>
		/// Установить имя.
		/// </summary>
		/// <param name="name">Имя.</param>
		public void SetName(string name)
		{
			this.Name = name;
		}

		/// <summary>
		/// Установить описание.
		/// </summary>
		/// <param name="description">текст описания.</param>
		public void SetDescription(string description)
		{
			this.Description = description;
		}

		/// <summary>
		/// Установить источник таланта.
		/// </summary>
		/// <param name="source">Источник таланта.</param>
		public void SetSource(string source)
		{
			this.Source = source;
		}

		/// <summary>
		/// Установить уровень.
		/// </summary>
		/// <param name="level">Новый уровень.</param>
		public void SetLevel(int level)
		{
			this.LevelGained = level;
		}

		#endregion
	}
}