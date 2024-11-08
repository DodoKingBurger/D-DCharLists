using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность рассы.
	/// </summary>
	public abstract class SheetRaceBase
	{
		#region Поля и свойства

		/// <summary>
		/// Название рассы.
		/// </summary>
		[JsonProperty("Name")]
		public EnumRaces Name { get; protected set; }

		/// <summary>
		/// Скорость рассы.
		/// </summary>
		[JsonProperty("Speed")]
		public int Speed { get; protected set; }

		/// <summary>
		/// Средние размеры рассы.
		/// </summary>
		[JsonProperty("Size")]
		public EnumCreaturesSizes Size { get; protected set; }

		#endregion
	}
}