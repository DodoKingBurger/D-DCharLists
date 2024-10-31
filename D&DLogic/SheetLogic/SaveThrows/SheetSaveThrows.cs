using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность характеристики завищящие от класса.
	/// </summary>
	public abstract class SheetSaveThrows
	{
		#region Поля и свойства

		/// <summary>
		/// Сохраненные характеристики.
		/// </summary>
		[JsonProperty("SaveThrows")]
		public List<EnumAbilitiesDnd5E> SaveThrows { get; protected set; }

		#endregion

		#region Методы.

		/// <summary>
		/// Установка списка основных характеристик.
		/// </summary>
		/// <param name="className">Класс.</param>
		public abstract void SetSaveTrows(EnumClassesDnd5E className);


		/// <summary>
		/// Проверка сохранен ли список характеристик.
		/// </summary>
		/// <param name="saveTrow">Список характеристик.</param>
		/// <returns></returns>
		public abstract bool CheckSaveThrow(EnumAbilitiesDnd5E saveTrow);

		#endregion
	}
}
