namespace D_Dlib
{
	/// <summary>
	/// ������ �����������.
	/// </summary>
	public class CombatAbilitiesDND5E : SheetCombatAbilities
	{

		#region ������� �����

		public override void ChangeStat(Enum stat, int value)
		{
			if (Enum.TryParse<EnumCombatStatsDND5e>(stat.ToString(), out EnumCombatStatsDND5e result))
			{
				CombatStats[result] = value;
			}
		}

		public override void ResetDeathSaves()
		{
			CombatStats[EnumCombatStatsDND5e.DeathFailure] = 0;
			CombatStats[EnumCombatStatsDND5e.DeathSucces] = 0;
		}

		#endregion

		#region ������������

		/// <summary>
		/// ������� ������ ������ ����������.
		/// HP, MAX HP...
		/// </summary>
		public CombatAbilitiesDND5E()
		{
			CombatStats = new Dictionary<EnumCombatStatsDND5e, int>()
			{
				[EnumCombatStatsDND5e.ArmorClass] = 0,
				[EnumCombatStatsDND5e.CurrentHitDices] = 1,
				[EnumCombatStatsDND5e.CurrentHP] = 1,
				[EnumCombatStatsDND5e.DeathFailure] = 0,
				[EnumCombatStatsDND5e.DeathSucces] = 0,
				[EnumCombatStatsDND5e.MaximumHP] = 1,
				[EnumCombatStatsDND5e.TemporaryHP] = 0,
				[EnumCombatStatsDND5e.Round] = 1
			};
		}

		#endregion
	}
}