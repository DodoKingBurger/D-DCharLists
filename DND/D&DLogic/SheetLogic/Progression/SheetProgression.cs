using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность прогрессии.
	/// </summary>
	public abstract class SheetProgression
	{
		#region Поля и свойства

		/// <summary>
		/// Опыт.
		/// </summary>
		[JsonProperty("Expirience")]
		public int Expirience {  get; set; }
		
		/// <summary>
		/// Уровень.
		/// </summary>
		[JsonProperty("Level")]
		public int Level {  get; protected set; }

		#endregion

		#region Методы 

		/// <summary>
		/// Получение опыта.
		/// </summary>
		/// <param name="exp">Количество полученного опыта.</param>
		public abstract void GainExpirience(int exp);

		/// <summary>
		/// Получения бонуса за мастерство.
		/// </summary>
		/// <returns>Бонус мастерства.</returns>
		public abstract int GetProficiencyBonus();

		/// <summary>
		/// Потеря опыта.
		/// </summary>
		/// <param name="exp">Количетсво утраченого опыта.</param>
		public abstract void LowerExpirience(int exp);

		/// <summary>
		/// Рассчитать уровень.
		/// </summary>
		public abstract void CalculateLevel();

		#endregion
	}
}
