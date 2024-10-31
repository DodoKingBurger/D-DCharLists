using Newtonsoft.Json;

namespace D_Dlib
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
		public EnumRacesDnd5E Name { get; protected set; }

		/// <summary>
		/// Скорость рассы.
		/// </summary>
		[JsonProperty("Speed")]
		public int Speed { get; protected set; }

		/// <summary>
		/// Средние размеры рассы.
		/// </summary>
		[JsonProperty("Size")]
		public EnumCreaturesSizesDND5e Size { get; protected set; }

		#endregion
	}
}