using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace D_DCharLists
{
	/// <summary>
	/// Распознователь контракта талантов для сериализации.
	/// </summary>
	public class TraitSpecifiedConcreteClassConverter : DefaultContractResolver
	{
		protected override JsonConverter ResolveContractConverter(Type objectType)
		{
			if (typeof(TraitBase).IsAssignableFrom(objectType) && !objectType.IsAbstract)
			{
				return null;
			}

			return base.ResolveContractConverter(objectType);
		}
	}

	/// <summary>
	/// Конвектор для талантов.
	/// </summary>
	public class TraitConvertorJson : JsonConverter
	{
		#region Базвый класс

		static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new TraitSpecifiedConcreteClassConverter() };

		public override bool CanConvert(Type objectType)
		{
			return (objectType == typeof(TraitBase));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jo = JObject.Load(reader);
			return JsonConvert.DeserializeObject<Trait>(jo.ToString(), SpecifiedSubclassConversion);
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