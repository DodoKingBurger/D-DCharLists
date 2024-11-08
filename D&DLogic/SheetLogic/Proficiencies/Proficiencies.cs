namespace D_DCharLists
{
	/// <summary>
	/// ������ ���������.
	/// </summary>
	public class Proficiencies : SheetProficiencies
	{
		#region ������� �����

		public override void AddProficiency(Enum prof)
		{
			if (Enum.TryParse<EnumAllProficiencies>(prof.ToString(), out EnumAllProficiencies result))
			{
				if (Proficiencies.Contains(result) == false)
				{
					Proficiencies.Add(result);
				}
			}

		}

		public override bool CheckProficiency(Enum prof)
		{
			if (Enum.TryParse<EnumAllProficiencies>(prof.ToString(), out EnumAllProficiencies result))
			{
				if (Proficiencies.Contains(result))
				{
					return true;
				}
			}

			return false;
		}

		public override void RemoveProficiency(Enum prof)
		{
			if (Enum.TryParse<EnumAllProficiencies>(prof.ToString(), out EnumAllProficiencies result))
			{
				if (Proficiencies.Contains(result))
				{
					Proficiencies.Remove(result);
				}
			}
		}

		#endregion

		#region ���������

		/// <summary>
		/// ������ ���������.
		/// </summary>
		public Proficiencies()
		{
			Proficiencies = new List<EnumAllProficiencies>();
		}

		#endregion
	}
}