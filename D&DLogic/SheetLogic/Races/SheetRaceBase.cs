using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность расы.
	/// </summary>
	public abstract class SheetRaceBase
	{
		#region Поля и свойства

		/// <summary>
		/// Раса персонажа.
		/// </summary>
		[JsonProperty("Name")]
		public EnumRaces Name { get; protected set; }

		/// <summary>
		/// Скорость расы.
		/// </summary>
		[JsonProperty("Speed")]
		public int Speed { get; protected set; }

		/// <summary>
		/// Размеры расы.
		/// </summary>
		[JsonProperty("Size")]
		public EnumCreaturesSizes Size { get; protected set; }

		#endregion
	}
}