using Newtonsoft.Json;

namespace D_Dlib
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
		public Dictionary<EnumPersonalitiesDND5E, string> PersonalityList { get; protected set; }

		/// <summary>
		/// Изменить информацию о личности.
		/// </summary>
		/// <param name="personality">Какую часть личности хотим изменить.</param>
		/// <param name="value">Новая информация.</param>
		public abstract void AddPersonality(EnumPersonalitiesDND5E personality, string value);
	}
}
