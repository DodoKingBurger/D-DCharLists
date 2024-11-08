namespace D_DCharLists
{
	/// <summary>
	/// Способности.
	/// </summary>
	public class Skills : SheetSkills
	{
		#region Методы

		/// <summary>
		/// Записан ли уже этот навык.
		/// </summary>
		/// <param name="skill">Скилл.</param>
		/// <returns>True, если уже записан в список скилов, в противном случае false.</returns>
		public override bool CheckSkill(EnumSkills skill)
		{
			return Skills.Contains(skill);
		}

		/// <summary>
		/// Добавить скилл в список.
		/// </summary>
		/// <param name="skill">Скилл.</param>
		public override void AddSkill(EnumSkills skill)
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
		public override EnumAbilities SkillAbilityName(EnumSkills skill)
		{
			switch (skill)
			{
				case EnumSkills.Athletics:
					return EnumAbilities.Strength;

				case EnumSkills.Acrobatics:
				case EnumSkills.Agulity:
				case EnumSkills.Stealth:
					return EnumAbilities.Agility;

				case EnumSkills.Arcana:
				case EnumSkills.History:
				case EnumSkills.Investigation:
				case EnumSkills.Nature:
				case EnumSkills.Religion:
					return EnumAbilities.Intelligence;

				case EnumSkills.Animal:
				case EnumSkills.Insight:
				case EnumSkills.Medicine:
				case EnumSkills.Perception:
				case EnumSkills.Surival:
					return EnumAbilities.Wisdom;

				case EnumSkills.Deception:
				case EnumSkills.Intimidation:
				case EnumSkills.Perfomance:
				case EnumSkills.Persuasion:
					return EnumAbilities.Charisma;

				default:
					return EnumAbilities.Strength;
			}
		}

		/// <summary>
		/// Удаляет скилл из списка скилов.
		/// </summary>
		/// <param name="skill">Скилл</param>
		/// <exception cref="ArgumentException">Скилл в списке отсутствет.</exception>
		public override void RemoveSkill(EnumSkills skill)
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
		public Skills()
		{
			Skills = new List<EnumSkills>();
		}

		#endregion
	}
}