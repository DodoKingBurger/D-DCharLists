using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Сущность способностей.
	/// </summary>
	public abstract class SheetSkills
	{
		#region Поля и свойства

		/// <summary>
		/// Список навыков.
		/// </summary>
		[JsonProperty("Skills")]
		public List<EnumSkills> Skills { get; protected set; }

		#endregion

		#region Методы

		/// <summary>
		/// Существует ли такой скилл.
		/// </summary>
		/// <param name="skill">Название навыка.</param>
		/// <returns>True, если навык уже записан, иначе False</returns>
		public abstract bool CheckSkill(EnumSkills skill);

		/// <summary>
		/// Добавить в список навык.
		/// </summary>
		/// <param name="skill">Название навыка.</param>
		public abstract void AddSkill(EnumSkills skill);

		/// <summary>
		/// Убрать навык из списка.
		/// </summary>
		/// <param name="skill">Название скила.</param>
		public abstract void RemoveSkill(EnumSkills skill);
   
    /// <summary>
    /// Определяет от какой характеристики зависит навык.
    /// </summary>
    /// <param name="skill">НАзвание способности.</param>
    /// <returns>Характеристику, от которой зависит навык.</returns>
    public abstract EnumAbilities SkillAbilityName(EnumSkills skill);

		#endregion
	}
}
