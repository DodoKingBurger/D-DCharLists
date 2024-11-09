
using Newtonsoft.Json;

namespace D_DCharLists
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
		public Dictionary<EnumAbilities, int> Abilities { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Изменить значение характеристики.
		/// </summary>
		/// <param name="ability">Изменяемая характеристика.</param>
		/// <param name="value">Новое значение характеристики.</param>
		public abstract void ChangeAbilityScore(EnumAbilities ability, int value);

    /// <summary>
    /// Получить модификатор характеристик.
    /// </summary>
    /// <param name="ability">Способность.</param>
    /// <returns>Значения модификатор</returns>
    public abstract int GetAbilityModificator(EnumAbilities ability);

		/// <summary>
		/// Получить значение значения характеристик.
		/// </summary>
		/// <param name="ability">Название способности.</param>
		/// <returns>Значение модификатора.</returns>
		public abstract int GetAbilityScore(EnumAbilities ability);

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
		public abstract void RaiseAbilityScore(EnumAbilities abilityName);

		/// <summary>
		/// Понижение характеристик -1.
		/// </summary>
		/// <param name="abilityName">Название характеристики.</param>
		public abstract void LowerAbilityScore(EnumAbilities abilityName);

		#endregion

	}
}
