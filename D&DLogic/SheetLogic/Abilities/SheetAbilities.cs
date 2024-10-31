
using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность характеристик.
	/// </summary>
	public abstract class SheetAbilities
	{

		#region Поля и свойства

		/// <summary>
		/// Список характеристик.
		/// </summary>
		[JsonProperty("Abilities")]
		public Dictionary<EnumAbilitiesDnd5E, int> Abilities { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Получить модификатор характеристик.
		/// </summary>
		/// <param name="ability">Способность.</param>
		/// <returns>Значения модификатор</returns>
		public abstract int GetAbilityModificator(EnumAbilitiesDnd5E ability);

		/// <summary>
		/// Получить значение значения характеристик.
		/// </summary>
		/// <param name="ability">Название способности.</param>
		/// <returns>Значение модификатора.</returns>
		public abstract int GetAbilityScore(EnumAbilitiesDnd5E ability);

		/// <summary>
		/// Рассчитать модификатор характеристики.
		/// </summary>
		/// <param name="score">Значение характеристики.</param>
		/// <returns>Модификатор характеристики.Округление в меньшую сторону.</returns>
		public abstract int AbilityBonus(int score);

		/// <summary>
		/// Установка новых значений характеристик.
		/// </summary>
		/// <param name="abilities">Список характеристик с новыми присвоенными значениями.</param>
		public abstract void SetAbilities(Dictionary<Enum, int> abilities);

		/// <summary>
		/// Повышение характеристики +1.
		/// </summary>
		/// <param name="abilityName">Название характеристики.</param>
		public abstract void RaiseAbilityScore(EnumAbilitiesDnd5E abilityName);

		/// <summary>
		/// Понижение характеристик -1.
		/// </summary>
		/// <param name="abilityName">Название характеристики.</param>
		public abstract void LowerAbilityScore(EnumAbilitiesDnd5E abilityName);

		#endregion

	}
}
