namespace D_DCharLists
{
  /// <summary>
  /// БД заклинаний.
  /// </summary>
  public class SpellsDataBase
  {
    #region Поля и свойства

    /// <summary>
    /// Список заклинаний.
    /// </summary>
    public static Dictionary<int, SpellBase> SpellsDB = new Dictionary<int, SpellBase>();

    /// <summary>
    /// Информация о папке.
    /// </summary>
    private static DirectoryInfo folderInfo = new DirectoryInfo(String.Join("\\",
      AppDomain.CurrentDomain.BaseDirectory.Split('\\')
      [0..(AppDomain.CurrentDomain.BaseDirectory.Split('\\').Count() - 4)])
      + "\\Data\\DND\\DataBases");

    #endregion

    #region Методы

    /// <summary>
    /// Загрузка БД.
    /// </summary>
    public static void LoadDB()
    {
      foreach (var item in folderInfo.GetFiles())
      {
        if (item.Name == "DNDSpellsDB.json")
        {
          JsonSaveLoad.JsonLoad(@"Data\DND\DataBases\DNDSpellsDB.json", ref SpellsDB);
        }
      }
    }

    /// <summary>
    /// Добавить заклинания.
    /// </summary>
    /// <param name="spell">Добавляймое заклинания.</param>
    public static void AddSpell(SpellBase spell)
    {
      SpellsDB[spell.Id] = spell;
    }

    /// <summary>
    /// Сохранить БД заклинаний.
    /// </summary>
    public static void SaveDB()
    {
      JsonSaveLoad.JsonSave("DNDSpellsDB", SpellsDB, @"Data\DND\DataBases\");
    }

    #endregion
  }
}