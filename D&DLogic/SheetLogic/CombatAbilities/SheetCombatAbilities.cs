
using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность боевых параметов.
	/// </summary>
	public abstract class SheetCombatAbilities
	{
		#region Поля и свойства

		/// <summary>
		/// Статистика боевых параметров.
		/// </summary>
		[JsonProperty("CombatStats")]
		public Dictionary<EnumCombatStatsDND5e, int> CombatStats {  get; set; }

		#endregion 

		#region Методы

		/// <summary>
		/// Изменить параметр.
		/// </summary>
		/// <param name="stat">Какой парамет.</param>
		/// <param name="value">Новое значение.</param>
		public abstract void ChangeStat(Enum stat, int value);
		
		/// <summary>
		/// Сброс спасбросков.
		/// </summary>
		public abstract void ResetDeathSaves();

		#endregion
	}
}
