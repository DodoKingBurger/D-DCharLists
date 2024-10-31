namespace D_Dlib
{
	/// <summary>
	/// Список действий с заклинаниями.
	/// </summary>
	public enum EnumWorkWithSpells
	{
		/// <summary>
		/// Список заклинаний.
		/// </summary>
		ListOfSpells,

		/// <summary>
		/// Отсутсвует заклинания в листе.
		/// </summary>
		NoSpellsInSheet,

		/// <summary>
		/// Контроль.
		/// </summary>
		Control,

		/// <summary>
		/// Описание заклинания.
		/// </summary>
		SpellDescription,

		/// <summary>
		/// Лист заклинаний.
		/// </summary>
		SpellsListSheet,

		/// <summary>
		/// БД заклинаний.
		/// </summary>
		SpellsListDB,

		/// <summary>
		/// Нет спылов в БД.
		/// </summary>
		NoSpellsInDB
	}
}