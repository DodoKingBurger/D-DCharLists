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
		public List<EnumSkillsDnd5E> Skills { get; protected set; }

		#endregion

		#region Методы

		/// <summary>
		/// Существует ли такой скилл.
		/// </summary>
		/// <param name="skill">Название навыка.</param>
		/// <returns>True, если навык уже записан, иначе False</returns>
		public abstract bool CheckSkill(EnumSkillsDnd5E skill);

		/// <summary>
		/// Добавить в список навык.
		/// </summary>
		/// <param name="skill">Название навыка.</param>
		public abstract void AddSkill(EnumSkillsDnd5E skill);

		/// <summary>
		/// Убрать навык из списка.
		/// </summary>
		/// <param name="skill">Название скила.</param>
		public abstract void RemoveSkill(EnumSkillsDnd5E skill);

		/// <summary>
		/// Определяет от какой характеристики зависит навык.
		/// </summary>
		/// <param name="skill">НАзвание способности.</param>
		/// <returns>Характеристику, от которой зависит навык.</returns>
		public abstract EnumAbilitiesDnd5E SkillAbilityName(EnumSkillsDnd5E skill);

		#endregion
	}
}
