using Newtonsoft.Json;

namespace D_DCharLists
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
    public Dictionary<int, int> SheetSpells { get; protected set; }

    #endregion

    #region Методы
    /// <summary>
    /// Добавить заклинание в БД.
    /// </summary>
    /// <param name="id"></param>
    public void AddSpell(int id)
    {
      if (this.SheetSpells != null) 
      {
        if (!SheetSpells.ContainsKey(id))
        {
          SheetSpells[id] = SpellsDataBase.SpellsDB[id].Level;
        }
        else
        {
          throw new ArgumentException("Уже известное заклинание!");
        }
      }
      else
      {
        throw new ArgumentNullException("База заклинаний не создана, скорее всего пероснаж не загружен или не создан!");
      }
    }

    /// <summary>
    /// Удалить заклинание из БД.
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="ArgumentException"></exception>
    public void RemoveSpell(int id)
    {
			if (this.SheetSpells != null)
			{
				if (SheetSpells.ContainsKey(id))
				{
					SheetSpells.Remove(id);
				}
				else
				{
					throw new ArgumentException("Попытка удалении заклинания которого не знает персонаж.");
				}
			}
			else
			{
				throw new ArgumentNullException("База заклинаний не создана, скорее всего пероснаж не загружен или не создан!");
			}
		}

    #endregion

  }
}