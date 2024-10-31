namespace D_Dlib
{
	/// <summary>
	/// Лист талантов персонажа.
	/// </summary>
	public class TraitsListDND5e : TraitsListBase
	{
		/// <summary>
		/// Обозначает таланты героя.
		/// </summary>
		public TraitsListDND5e()
		{
			TraitsList = new Dictionary<int, int>();
		}
	}
}