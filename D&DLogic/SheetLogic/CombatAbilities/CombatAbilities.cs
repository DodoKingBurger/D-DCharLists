namespace D_DCharLists
{
	/// <summary>
	/// Боевые характеристики.
	/// </summary>
	public class CombatAbilities : SheetCombatAbilities
	{

		#region Поля свойства

		public override void ChangeStat(Enum stat, int value)
		{
			if (Enum.TryParse<EnumCombatStats>(stat.ToString(), out EnumCombatStats result))
			{
				CombatStats[result] = value;
			}
		}

		public override void ResetDeathSaves()
		{
			CombatStats[EnumCombatStats.DeathFailure] = 0;
			CombatStats[EnumCombatStats.DeathSucces] = 0;
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Заполняет список боевых параметров.
		/// HP, MAX HP...
		/// </summary>
		public CombatAbilities()
		{
			CombatStats = new Dictionary<EnumCombatStats, int>()
			{
				[EnumCombatStats.ArmorClass] = 0,
				[EnumCombatStats.CurrentHitDices] = 1,
				[EnumCombatStats.CurrentHP] = 1,
				[EnumCombatStats.DeathFailure] = 0,
				[EnumCombatStats.DeathSucces] = 0,
				[EnumCombatStats.MaximumHP] = 1,
				[EnumCombatStats.TemporaryHP] = 0,
				[EnumCombatStats.Round] = 1,
			};
		}

		#endregion
	}
}