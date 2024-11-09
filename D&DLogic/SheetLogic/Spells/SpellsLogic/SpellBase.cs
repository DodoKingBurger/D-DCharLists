using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность заклинаний.
	/// </summary>
	public abstract class SpellBase
	{
		#region Поля и свойства

		private string name;

		/// <summary>
		/// Названия заклинания.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get { return this.name; } protected set { this.name = value; } }

		private int level;
		/// <summary>
		/// Уровень заклинания.
		/// </summary>
		[JsonProperty("Level")]
		public int Level { get { return this.level; } protected set { this.level = value; } }

		private int id;

		/// <summary>
		/// ID заклинания.
		/// </summary>
		[JsonProperty("Id")]
		public int Id { get { return this.id; } protected set { this.id = value; } }

    #endregion

    #region Методы

    /// <summary>
    /// Установить названия заклинания.
    /// </summary>
    /// <param name="name">Новое названия.</param>
    public void SetName(string name)
		{
			this.name = name;
		}

    /// <summary>
    /// Установить новый уровень для заклинания.
    /// </summary>
    /// <param name="level">Новый уровень.</param>
    public void SetLevel(int level)
		{
			this.level = level;
		}

		/// <summary>
		/// Установка ID для заклинания.
		/// </summary>
		public void SetID()
		{
			this.id = RollRandom.LetsRoll.Next(1000, 10000);
		}

		#endregion
	}
}