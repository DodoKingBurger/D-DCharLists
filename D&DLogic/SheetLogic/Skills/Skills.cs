namespace D_DCharLists
{
	/// <summary>
	/// Скилы.
	/// </summary>
	public class Skills : SheetSkills
	{
		#region Базовый класс

		public override bool CheckSkill(EnumSkills skill)
		{
			return Skills.Contains(skill);
		}

		public override void AddSkill(EnumSkills skill)
		{
			if (!Skills.Contains(skill))
			{
				Skills.Add(skill);
			}
		}

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

		public override void RemoveSkill(EnumSkills skill)
		{
			if (Skills.Contains(skill))
			{
				Skills.Remove(skill);
			}
			else
			{
				throw new ArgumentException("Данный навык не представлен в списке.");
			}
		}

    #endregion

    #region Констуркторы

    /// <summary>
    /// Создает список скилов.
    /// </summary>
    public Skills()
		{
			Skills = new List<EnumSkills>();
		}

		#endregion
	}
}