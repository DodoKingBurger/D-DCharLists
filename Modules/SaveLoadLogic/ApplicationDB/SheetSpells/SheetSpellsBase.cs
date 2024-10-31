using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// Сущность списка заклинания.
	/// </summary>
	public abstract class SheetSpellsBase
	{
		#region Поля и свойства

		/// <summary>
		/// Список заклинаний.
		/// </summary>
		[JsonProperty("SheetSpells")]
		public Dictionary<int, int> SheetSpells {  get; protected set; }

		#endregion

		#region Методы
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
				throw new ArgumentException("Неизвестное заклинание");
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
				throw new ArgumentException("Попытка удалении не существуещего заклинания.");
			}
		}

		#endregion
	}
}