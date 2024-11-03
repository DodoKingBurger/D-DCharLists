namespace D_DCharLists
{
	/// <summary>
	/// Способности.
	/// </summary>
	public class SkillsDnd5E : SheetSkills
	{
		#region Методы

		/// <summary>
		/// Записан ли уже этот навык.
		/// </summary>
		/// <param name="skill">Скилл.</param>
		/// <returns>True, если уже записан в список скилов, в противном случае false.</returns>
		public override bool CheckSkill(EnumSkillsDnd5E skill)
		{
			return Skills.Contains(skill);
		}

		/// <summary>
		/// Добавить скилл в список.
		/// </summary>
		/// <param name="skill">Скилл.</param>
		public override void AddSkill(EnumSkillsDnd5E skill)
		{
			if (!Skills.Contains(skill))
			{
				Skills.Add(skill);
			}
		}

		/// <summary>
		/// Возвращает характеристики от которых завист скилл.
		/// </summary>
		/// <param name="skill">Скилл.</param>
		/// <returns>Возвращает характеристики от которых завист скилл, иначе вернет характеристику силы.</returns>
		public override EnumAbilitiesDnd5E SkillAbilityName(EnumSkillsDnd5E skill)
		{
			switch (skill)
			{
				case EnumSkillsDnd5E.Athletics:
					return EnumAbilitiesDnd5E.Strength;

				case EnumSkillsDnd5E.Acrobatics:
				case EnumSkillsDnd5E.Agulity:
				case EnumSkillsDnd5E.Stealth:
					return EnumAbilitiesDnd5E.Agility;

				case EnumSkillsDnd5E.Arcana:
				case EnumSkillsDnd5E.History:
				case EnumSkillsDnd5E.Investigation:
				case EnumSkillsDnd5E.Nature:
				case EnumSkillsDnd5E.Religion:
					return EnumAbilitiesDnd5E.Intelligence;

				case EnumSkillsDnd5E.Animal:
				case EnumSkillsDnd5E.Insight:
				case EnumSkillsDnd5E.Medicine:
				case EnumSkillsDnd5E.Perception:
				case EnumSkillsDnd5E.Surival:
					return EnumAbilitiesDnd5E.Wisdom;

				case EnumSkillsDnd5E.Deception:
				case EnumSkillsDnd5E.Intimidation:
				case EnumSkillsDnd5E.Perfomance:
				case EnumSkillsDnd5E.Persuasion:
					return EnumAbilitiesDnd5E.Charisma;

				default:
					return EnumAbilitiesDnd5E.Strength;
			}
		}

		/// <summary>
		/// Удаляет скилл из списка скилов.
		/// </summary>
		/// <param name="skill">Скилл</param>
		/// <exception cref="ArgumentException">Скилл в списке отсутствет.</exception>
		public override void RemoveSkill(EnumSkillsDnd5E skill)
		{
			if (Skills.Contains(skill))
			{
				Skills.Remove(skill);
			}
			else
			{
				throw new ArgumentException("Переданный навык отсутсвует в списке");
			}
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Создает список способностей.
		/// </summary>
		public SkillsDnd5E()
		{
			Skills = new List<EnumSkillsDnd5E>();
		}

		#endregion
	}
}