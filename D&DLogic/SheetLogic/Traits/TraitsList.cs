namespace D_DCharLists
{
	/// <summary>
	/// Лист талантов персонажа.
	/// </summary>
	public class TraitsList : TraitsListBase
	{
		/// <summary>
		/// Обозначает таланты героя.
		/// </summary>
		public TraitsList()
		{
			TraitsList = new Dictionary<int, int>();
		}
	}
}