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
		public string Name { get { return this.name; }  set { this.name = value; } }

		private int level;
		/// <summary>
		/// Уровень заклинания.
		/// </summary>
		[JsonProperty("Level")]
		public int Level { get { return this.level; }  set { this.level = value; } }

		private int id;

		/// <summary>
		/// ID заклинания.
		/// </summary>
		[JsonProperty("Id")]
		public int Id { get { return this.id; }  set { this.id = value; } }

		private string? fromСharacteristic;

		/// <summary>
		/// От какой характеристики заклинание зависит, если пустое, то без характеристки.
		/// </summary>
		[JsonProperty("FromСharacteristic")]
		public string? FromСharacteristic { get { return this.fromСharacteristic; } 
			 set 
			{
				if (!string.IsNullOrEmpty(value))
					this.fromСharacteristic = " ";
				else
					this.fromСharacteristic = $"{value}";
			} 
		}

		/// <summary>
		/// Влияет ли на заклинание бонус владения.
		/// </summary>
		[JsonProperty("UseMasterBonus")]
		public bool UseMasterBonus { get;  set; }

		/// <summary>
		/// Вид/урон заклинание.
		/// </summary>
		[JsonProperty("DamageType")]
		public string? DamageType { get;  set; }

		/// <summary>
		/// Дополнительный модификатор.
		/// </summary>
		[JsonProperty("AdditionalModifiers")]
		public int AdditionalModifiers { get;  set; }

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
			this.id = RollRandom.LetsRoll.Next(1, 10000);
		}

		#endregion
	}
}