using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность навыков персонажа.
	/// </summary>
	public abstract class SheetProficiencies
	{
		#region Поля и свойства

		/// <summary>
		/// Список навыков.
		/// </summary>
		[JsonProperty("Proficiencies")]
		public List<EnumAllDND5eProficiencies> Proficiencies {  get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Добавить навык.
		/// </summary>
		/// <param name="prof">Навык.</param>
		public abstract void AddProficiency(Enum prof);

		/// <summary>
		/// Проверить есть ли уже такой навык.
		/// </summary>
		/// <param name="prof">Проверяймый навык.</param>
		/// <returns>true, если он уже присвоен данном у персонажу, в противном случае false</returns>
		public abstract bool CheckProficiency(Enum prof);

		/// <summary>
		/// Убрать навык.
		/// </summary>
		/// <param name="prof">Убираймый навык.</param>
		public abstract void RemoveProficiency(Enum prof);

		#endregion
	}
}
