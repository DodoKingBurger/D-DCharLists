using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// �������� ������ ����������.
	/// </summary>
	public abstract class SheetSpellsBase
	{
		#region ���� � ��������

		/// <summary>
		/// ������ ����������.
		/// </summary>
		[JsonProperty("SheetSpells")]
		public Dictionary<int, int> SheetSpells {  get; protected set; }

		#endregion

		#region ������
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		public void AddSpell(int id)
		{
			if (!SheetSpells.ContainsKey(id))
			{
				SheetSpells[id] = SpellsDataBaseDND5e.SpellsDB[id].Level;
			}
			else
			{
				throw new ArgumentException("����������� ����������");
			}
		}

		public void RemoveSpell(int id)
		{
			if (SheetSpells.ContainsKey(id))
			{
				SheetSpells.Remove(id);
			}
			else 
			{
				throw new ArgumentException("������� �������� �� ������������� ����������.");
			}
		}

		#endregion
	}
}