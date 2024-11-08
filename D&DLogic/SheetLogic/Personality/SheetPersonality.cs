using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность личности.
	/// </summary>
	public abstract class SheetPersonality
	{
		/// <summary>
		/// Информация о личности.
		/// </summary>
		[JsonProperty("PersonalityList")]
		public Dictionary<EnumPersonalities, string> PersonalityList { get; protected set; }

		/// <summary>
		/// Изменить информацию о личности.
		/// </summary>
		/// <param name="personality">Какую часть личности хотим изменить.</param>
		/// <param name="value">Новая информация.</param>
		public abstract void AddPersonality(EnumPersonalities personality, string value);
	}
}
