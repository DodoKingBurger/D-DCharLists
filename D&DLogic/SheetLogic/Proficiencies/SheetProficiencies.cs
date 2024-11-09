using Newtonsoft.Json;

namespace D_DCharLists
{
  /// <summary>
  /// Сущность навыков владения персонажа.
  /// </summary>
  public abstract class SheetProficiencies
	{
		#region Поля и свойства

		/// <summary>
		///Список навыков владения персонажа.
		/// </summary>
		[JsonProperty("Proficiencies")]
		public List<EnumAllProficiencies> Proficiencies {  get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Добавить умения навыком владения.
		/// </summary>
		/// <param name="prof">Навык владения.</param>
		public abstract void AddProficiency(Enum prof);

		/// <summary>
		/// Есть ли уже в списке такой навык владения.
		/// </summary>
		/// <param name="prof">Навык владения.</param>
		/// <returns>true, если представлен в списке уже такой навык владения, в противном случае false</returns>
		public abstract bool CheckProficiency(Enum prof);

		/// <summary>
		/// Удаляет навык владения из списка.
		/// </summary>
		/// <param name="prof">Навык владения.</param>
		public abstract void RemoveProficiency(Enum prof);

		#endregion
	}
}
