using Newtonsoft.Json;

namespace D_DCharLists
{
  /// <summary>
  /// Cущность листа таланта персонажа.
  /// </summary>
  public abstract class TraitsListBase
  {
    #region Поля и свойства

    /// <summary>
    /// Список талантов персонажа.
    /// </summary>
    [JsonProperty("TraitsList")]
    public Dictionary<int, int> TraitsList { get; protected set; }

    #endregion

    #region Методы

    /// <summary>
    /// Добавить талант по ID.
    /// </summary>
    /// <param name="traitId">ID таланта.</param>
    public void AddTrait(int traitId)
    {
      if (!TraitsList.ContainsKey(traitId))
      {
        TraitsList[traitId] = TraitsDataBase.TraitsDB[traitId].LevelGained;
      }
      else
      {
        throw new ArgumentException("Такая черта уже добавлена.");
      }
    }

    /// <summary>
    /// Удалить талант по ID.
    /// </summary>
    /// <param name="traitId">ID таланта.</param>
    public void RemoveTrait(int traitId)
    {
      if (TraitsList.ContainsKey(traitId))
      {
        TraitsList.Remove(traitId);
      }
      else
      {
        throw new ArgumentException("Такой черты нету у перснажа.");
      }
    }

    #endregion
  }
}