using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace D_DCharLists
{
	/// <summary>
	/// Ðàñïîçíîâàòåëü êîíòðàêòà íà ïðåäìåò äëÿ ñåðèàëèçàöèè.
	/// </summary>
	public class ItemsSpecifiedConcreteClassConverter : DefaultContractResolver
	{
		protected override JsonConverter ResolveContractConverter(Type objectType)
		{
			if (typeof(ItemBase).IsAssignableFrom(objectType) && !objectType.IsAbstract)
			{
				return null;
			}

			return base.ResolveContractConverter(objectType);
		}
	}

	/// <summary>
	/// Êîíâåðòåð ïðåäìåòîâ.
	/// </summary>
	public class ItemsConverter : JsonConverter
	{
		#region Áàçîâûé êëàññ

		static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new ItemsSpecifiedConcreteClassConverter() };

		public override bool CanConvert(Type objectType)
		{
			return (objectType == typeof(ItemBase));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jo = JObject.Load(reader);
			switch (jo["ItemType"].Value<int>())
			{
				case 0:
					return JsonConvert.DeserializeObject<ItemArmor>(jo.ToString(), SpecifiedSubclassConversion);

				case 1:
					return JsonConvert.DeserializeObject<ItemWeapon>(jo.ToString(), SpecifiedSubclassConversion);

				case 2:
					return JsonConvert.DeserializeObject<ItemRegular>(jo.ToString(), SpecifiedSubclassConversion);

				case 3:
					return JsonConvert.DeserializeObject<ItemCoin>(jo.ToString(), SpecifiedSubclassConversion);

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