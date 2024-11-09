namespace D_DCharLists
{
	/// <summary>
	/// Îñíîâíûå õàðàêòåðèñòèêè çàâèùÿùèå îò êëàññà.
	/// </summary>
	public class SaveThrows : SheetSaveThrows
	{
		#region Áàçîâûé êëàññ

		public override void SetSaveTrows(EnumClasses className)
		{
			switch (className)
			{
				case EnumClasses.Bard:
					SaveThrows.Add(EnumAbilities.Agility);
					SaveThrows.Add(EnumAbilities.Charisma);
					break;

				case EnumClasses.Barbarian:
				case EnumClasses.Fighter:
					SaveThrows.Add(EnumAbilities.Strength);
					SaveThrows.Add(EnumAbilities.Physique);
					break;

				case EnumClasses.Wizard:
				case EnumClasses.Druid:
					SaveThrows.Add(EnumAbilities.Intelligence);
					SaveThrows.Add(EnumAbilities.Wisdom);
					break;

				case EnumClasses.Cleric:
				case EnumClasses.Warlock:
				case EnumClasses.Paladin:
					SaveThrows.Add(EnumAbilities.Wisdom);
					SaveThrows.Add(EnumAbilities.Charisma);
					break;

				case EnumClasses.Monk:
				case EnumClasses.Ranger:
					SaveThrows.Add(EnumAbilities.Strength);
					SaveThrows.Add(EnumAbilities.Agility);
					break;

				case EnumClasses.Rogue:
					SaveThrows.Add(EnumAbilities.Agility);
					SaveThrows.Add(EnumAbilities.Intelligence);
					break;

				case EnumClasses.Sorcerer:
					SaveThrows.Add(EnumAbilities.Physique);
					SaveThrows.Add(EnumAbilities.Charisma);
					break;
			}
		}

		public override bool CheckSaveThrow(EnumAbilities saveTrow)
		{
			return SaveThrows.Contains(saveTrow);
		}

		#endregion

		#region Êîíñòðóêòîðû 

		/// <summary>
		/// Ñîçàäåò ñïèñîê îñíîâíûõ õàðàêòåðèñòèê, êîòîðûå çàâèÿñò îò êëàññà. 
		/// </summary>
		public SaveThrows()
		{
			SaveThrows = new List<EnumAbilities>();
		}

		#endregion
	}
}