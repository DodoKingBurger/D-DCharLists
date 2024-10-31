
using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// �������� ������.
	/// </summary>
	public abstract class SheetClassBase
	{
		/// <summary>
		/// �������� ������.
		/// </summary>
		[JsonProperty("Name")]
		public EnumClassesDnd5E Name { get; set; }

		/// <summary>
		/// ����� �����.
		/// </summary>
		[JsonProperty("HitDice")]
		public EnumDices HitDice {  get; set; }

		/// <summary>
		/// ������ �������� �������������.
		/// </summary>
		[JsonProperty("SaveThrows")]
		public List<EnumAbilitiesDnd5E> SaveThrows {  get; set; }
	}
}