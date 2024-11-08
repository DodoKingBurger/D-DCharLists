
using Newtonsoft.Json;

namespace D_DCharLists
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
		public EnumClasses Name { get; set; }

		/// <summary>
		/// Кость хитов. 
		/// </summary>
		[JsonProperty("HitDice")]
		public EnumDices HitDice {  get; set; }

		/// <summary>
		/// Список основных характеристик. 
		/// </summary>
		[JsonProperty("SaveThrows")]
		public List<EnumAbilities> SaveThrows {  get; set; }
	}
}