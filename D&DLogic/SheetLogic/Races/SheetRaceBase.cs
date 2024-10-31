using Newtonsoft.Json;

namespace D_Dlib
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
		public EnumRacesDnd5E Name { get; protected set; }

		/// <summary>
		/// �������� �����.
		/// </summary>
		[JsonProperty("Speed")]
		public int Speed { get; protected set; }

		/// <summary>
		/// ������� ������� �����.
		/// </summary>
		[JsonProperty("Size")]
		public EnumCreaturesSizesDND5e Size { get; protected set; }

		#endregion
	}
}