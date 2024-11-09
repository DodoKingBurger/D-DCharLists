using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace D_DCharLists
{
  /// <summary>
  /// Распознователь контрактов класса для сериализации.
  /// </summary>
  public class ClassSpecifiedConcreteClassConverter : DefaultContractResolver
  {
    protected override JsonConverter ResolveContractConverter(Type objectType)
    {
      if (typeof(SheetClassBase).IsAssignableFrom(objectType) && !objectType.IsAbstract)
      {
        return null;
      }

      return base.ResolveContractConverter(objectType);
    }
  }

  /// <summary>
  /// Конвертер классов.
  /// </summary>
  public class ClassConvertorJson : JsonConverter
  {
    #region Базовый класс

    static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new ClassSpecifiedConcreteClassConverter() };

    public override bool CanConvert(Type objectType)
    {
      return (objectType == typeof(SheetClassBase));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      JObject jo = JObject.Load(reader);
      switch (jo["Name"].Value<int>())
      {
        case 0:
          return JsonConvert.DeserializeObject<BardClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 1:
          return JsonConvert.DeserializeObject<BarbarianClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 2:
          return JsonConvert.DeserializeObject<FighterClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 3:
          return JsonConvert.DeserializeObject<WizardClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 4:
          return JsonConvert.DeserializeObject<DruidClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 5:
          return JsonConvert.DeserializeObject<ClericClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 6:
          return JsonConvert.DeserializeObject<WarlockClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 7:
          return JsonConvert.DeserializeObject<MonkClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 8:
          return JsonConvert.DeserializeObject<PaladinClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 9:
          return JsonConvert.DeserializeObject<RogueClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 10:
          return JsonConvert.DeserializeObject<RangerClass>(jo.ToString(), SpecifiedSubclassConversion);

        case 11:
          return JsonConvert.DeserializeObject<SorcererClass>(jo.ToString(), SpecifiedSubclassConversion);

        default:
          throw new Exception();
      }
      throw new NotImplementedException();
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