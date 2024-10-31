namespace D_Dlib
{
	/// <summary>
	/// Характеристики.
	/// </summary>
	public class AbilitiesDnd5E : SheetAbilities
	{
		#region Базовый класс
		public override int GetAbilityModificator(EnumAbilitiesDnd5E ability)
		{
			return AbilityBonus(GetAbilityScore(ability));
		}

		public override int GetAbilityScore(EnumAbilitiesDnd5E ability)
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
				if (Enum.TryParse<EnumAbilitiesDnd5E>(item.Key.ToString(), out EnumAbilitiesDnd5E result))
				{
					Abilities[result] = item.Value;
				}
			}
		}

		public override void RaiseAbilityScore(EnumAbilitiesDnd5E abilityName)
		{
			if (Abilities[abilityName] + 1 <= 30)
			{
				Abilities[abilityName]++;
			}
		}
		public override void LowerAbilityScore(EnumAbilitiesDnd5E abilityName)
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
			Abilities = new Dictionary<EnumAbilitiesDnd5E, int>()
			{
				[EnumAbilitiesDnd5E.Strength] = 1,
				[EnumAbilitiesDnd5E.Agility] = 1,
				[EnumAbilitiesDnd5E.Physique] = 1,
				[EnumAbilitiesDnd5E.Intelligence] = 1,
				[EnumAbilitiesDnd5E.Wisdom] = 1,
				[EnumAbilitiesDnd5E.Charisma] = 1
			};
		}

		#endregion
	}
}