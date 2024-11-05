using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// C������� ����� ������� ���������.
	/// </summary>
	public abstract class TraitsListBase
	{
		#region ���� � ��������

		/// <summary>
		/// ������ �������� ���������.
		/// </summary>
		[JsonProperty("TraitsList")]
		public Dictionary<int, int> TraitsList { get; protected set; }

		#endregion

		#region ������

		/// <summary>
		/// �������� ������ �� ID.
		/// </summary>
		/// <param name="traitId">ID �������.</param>
		public void AddTrait(int traitId)
		{
			if (!TraitsList.ContainsKey(traitId))
			{
				TraitsList[traitId] = TraitsDataBaseDND5e.TraitsDB[traitId].LevelGained;
			}
			else
			{
				throw new ArgumentException("����� ����� ��� ���������.");
			}
		}

		/// <summary>
		/// ������� ������ �� ID.
		/// </summary>
		/// <param name="traitId">ID �������.</param>
		public void RemoveTrait(int traitId)
		{
			if (TraitsList.ContainsKey(traitId))
			{
				TraitsList.Remove(traitId);
			}
			else
			{
				throw new ArgumentException("����� ����� ���� � ��������.");
			}
		}

		#endregion
	}
}