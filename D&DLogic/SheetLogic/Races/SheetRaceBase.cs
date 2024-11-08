using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������� �����.
	/// </summary>
	public abstract class SheetRaceBase
	{
		#region ���� � ��������

		/// <summary>
		/// �������� �����.
		/// </summary>
		[JsonProperty("Name")]
		public EnumRaces Name { get; protected set; }

		/// <summary>
		/// �������� �����.
		/// </summary>
		[JsonProperty("Speed")]
		public int Speed { get; protected set; }

		/// <summary>
		/// ������� ������� �����.
		/// </summary>
		[JsonProperty("Size")]
		public EnumCreaturesSizes Size { get; protected set; }

		#endregion
	}
}