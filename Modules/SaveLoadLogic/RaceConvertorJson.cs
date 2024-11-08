using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace D_DCharLists
{
	/// <summary>
	/// Распознователь контракта рассы для сериализации.
	/// </summary>
	public class RaceSpecifiedConcreteClassConverter : DefaultContractResolver
	{
		protected override JsonConverter ResolveContractConverter(Type objectType)
		{
			if (typeof(SheetRaceBase).IsAssignableFrom(objectType) && !objectType.IsAbstract)
			{
				return null;
			}

			return base.ResolveContractConverter(objectType);
		}
	}

	/// <summary>
	/// Конвектер для расс.
	/// </summary>
	public class RaceConvertorJson : JsonConverter
	{
		#region Базовый класс

		static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new RaceSpecifiedConcreteClassConverter() };

		public override bool CanConvert(Type objectType)
		{
			return (objectType == typeof(SheetRaceBase));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jo = JObject.Load(reader);
			switch (jo["Name"].Value<int>())
			{
				case 0:
					return JsonConvert.DeserializeObject<GnomeRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 1:
					return JsonConvert.DeserializeObject<DwarfRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 2:
					return JsonConvert.DeserializeObject<DragonbornRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 3:
					return JsonConvert.DeserializeObject<HalforcRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 4:
					return JsonConvert.DeserializeObject<HalflingRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 5:
					return JsonConvert.DeserializeObject<HalfelfRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 6:
					return JsonConvert.DeserializeObject<TieflingRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 7:
					return JsonConvert.DeserializeObject<HumanRace>(jo.ToString(), SpecifiedSubclassConversion);

				case 8:
					return JsonConvert.DeserializeObject<ElfRace>(jo.ToString(), SpecifiedSubclassConversion);

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