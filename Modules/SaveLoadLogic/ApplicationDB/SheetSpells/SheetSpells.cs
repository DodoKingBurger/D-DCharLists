namespace D_DCharLists
{
  /// <summary>
  /// Заклинание.
  /// </summary>
  public class SheetSpells : SheetSpellsBase
  {
    /// <summary>
    /// Список заклинаний героя.
    /// </summary>
    public SheetSpells()
    {
			this.SheetSpells = new Dictionary<int, int>();
    }
  }
}