namespace D_Dlib
{
	/// <summary>
	/// Таланты и возможные с ним действия. 
	/// </summary>
	public enum EnumTraitsText
	{
		/// <summary>
		/// Список талантов.
		/// </summary>
		TraitsListSheet,
		
		/// <summary>
		/// Описания таланта.
		/// </summary>
		TraitDescription,

		/// <summary>
		/// Нет черт в листе.
		/// </summary>
		NoTraitsInSheet,

		/// <summary>
		/// Выбрать имя.
		/// </summary>
		ChooseName,

		/// <summary>
		/// Выбрать источник.
		/// </summary>
		ChooseSource,

		/// <summary>
		/// Выберите уровень получения.
		/// </summary>
		ChooseLevelObtained,

		/// <summary>
		/// Изменить описания.
		/// </summary>
		ChooseDescription,

		/// <summary>
		/// Новый талант.
		/// </summary>
		ThisIsNewTrait,

		/// <summary>
		/// Новое ID для таланта.
		/// </summary>
		NewIdTrait,

		/// <summary>
		/// Источник.
		/// </summary>
		Source,

		/// <summary>
		/// Такого таланта нету в БД.
		/// </summary>
		NoTraitsInDB,

		/// <summary>
		/// Список талантов в БД.
		/// </summary>
		TraitsListInDB
	}
}