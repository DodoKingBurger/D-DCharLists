namespace D_DCharLists
{
	/// <summary>
	/// Характеристики. 
	/// </summary>
	public class AbilitiesDnd5E : SheetAbilities
	{
		#region Базовый класс
		public override int GetAbilityModificator(EnumAbilities ability)
		{
			return AbilityBonus(GetAbilityScore(ability));
		}

		public override int GetAbilityScore(EnumAbilities ability)
		{
			return Abilities[ability];
		}

		public override int AbilityBonus(int score)
		{
			return score / 2 - 5;
		}

		public override void SetAbilities(Dictionary<Enum, int> abilities)
		{
			foreach (var item in abilities)
			{
				if (Enum.TryParse<EnumAbilities>(item.Key.ToString(), out EnumAbilities result))
				{
					Abilities[result] = item.Value;
				}
			}
		}

		public override void RaiseAbilityScore(EnumAbilities abilityName)
		{
			if (Abilities[abilityName] + 1 <= 30)
			{
				Abilities[abilityName]++;
			}
		}
		public override void LowerAbilityScore(EnumAbilities abilityName)
		{
			if (Abilities[abilityName] - 1 >= 1)
			{
				Abilities[abilityName]--;
			}
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Создает список характеристик.
		/// Сила, ловкость и т.д.
		/// </summary>
		public AbilitiesDnd5E()
		{
			Abilities = new Dictionary<EnumAbilities, int>()
			{
				[EnumAbilities.Strength] = 1,
				[EnumAbilities.Agility] = 1,
				[EnumAbilities.Physique] = 1,
				[EnumAbilities.Intelligence] = 1,
				[EnumAbilities.Wisdom] = 1,
				[EnumAbilities.Charisma] = 1
			};
		}

		#endregion
	}
}