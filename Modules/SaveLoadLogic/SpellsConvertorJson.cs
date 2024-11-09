using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace D_DCharLists
{
  /// <summary>
  /// Распознователь контракта заклинания для сериализации.
  /// </summary>
  public class SpellsSpecifiedConcreteClassConverter : DefaultContractResolver
  {
    protected override JsonConverter ResolveContractConverter(Type objectType)
    {
      if (typeof(SpellBase).IsAssignableFrom(objectType) && !objectType.IsAbstract)
      {
        return null;
      }

      return base.ResolveContractConverter(objectType);
    }
  }

  /// <summary>
  /// Конвектер для заклинаний.
  /// </summary>
  public class SpellsConvertorJson : JsonConverter
  {
    #region Базовый класс

    static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new SpellsSpecifiedConcreteClassConverter() };

    public override bool CanConvert(Type objectType)
    {
      return (objectType == typeof(SpellBase));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      JObject jo = JObject.Load(reader);
      return JsonConvert.DeserializeObject<Spell>(jo.ToString(), SpecifiedSubclassConversion);
    }

    public override bool CanWrite
    {
      get { return false; }
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}