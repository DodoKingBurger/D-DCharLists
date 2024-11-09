using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность личных качеств.
	/// </summary>
	public abstract class SheetPersonality
	{
		/// <summary>
		/// Список личных качеств.
		/// </summary>
		[JsonProperty("PersonalityList")]
		public Dictionary<EnumPersonalities, string> PersonalityList { get; protected set; }

		/// <summary>
		/// Добавляет личные качества.
		/// </summary>
		/// <param name="personality">Личное качество из списка.</param>
		/// <param name="value">Информация.</param>
		public abstract void AddPersonality(EnumPersonalities personality, string value);
	}
}
