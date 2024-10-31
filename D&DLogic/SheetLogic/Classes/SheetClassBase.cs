
using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность класса.
	/// </summary>
	public abstract class SheetClassBase
	{
		/// <summary>
		/// Название класса.
		/// </summary>
		[JsonProperty("Name")]
		public EnumClassesDnd5E Name { get; set; }

		/// <summary>
		/// Кость хитов.
		/// </summary>
		[JsonProperty("HitDice")]
		public EnumDices HitDice {  get; set; }

		/// <summary>
		/// Список основных характеристик.
		/// </summary>
		[JsonProperty("SaveThrows")]
		public List<EnumAbilitiesDnd5E> SaveThrows {  get; set; }
	}
}