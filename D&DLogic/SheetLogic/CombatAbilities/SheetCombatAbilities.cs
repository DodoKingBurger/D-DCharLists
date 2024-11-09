
using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность боевых параметров.
	/// </summary>
	public abstract class SheetCombatAbilities
	{
		#region Поля и свойства

		/// <summary>
		/// Список боевых характеристик.
		/// </summary>
		[JsonProperty("CombatStats")]
		public Dictionary<EnumCombatStats, int> CombatStats {  get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Изменить боевую харктеристики.
    /// </summary>
    /// <param name="stat">Какая боевая характеристика должна быть изменена.</param>
    /// <param name="value">Новое число для характеристики.</param>
    public abstract void ChangeStat(Enum stat, int value);
		
		/// <summary>
		/// Сбросить спасброски.
		/// </summary>
		public abstract void ResetDeathSaves();

		#endregion
	}
}
