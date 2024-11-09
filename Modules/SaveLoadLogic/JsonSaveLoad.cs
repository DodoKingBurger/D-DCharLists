using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// Класс для сохранения и загрузки в БД.
	/// </summary>
	public class JsonSaveLoad
	{
		/// <summary>
		/// Сохранить в формате .json
		/// </summary>
		/// <typeparam name="T">Какого типа будет передаваться сохраняймый файл.</typeparam>
		/// <param name="fileName">Название файла.</param>
		/// <param name="savingFile">Сохраняймый файл.</param>
		/// <param name="pathSave">Путь где будет соранен файл.</param>
		public static void JsonSave<T>(string fileName, T savingFile, string pathSave)
		{
			string savedFile = JsonConvert.SerializeObject(savingFile, Formatting.Indented);
			File.WriteAllText($"{pathSave}\\{fileName}.json", savedFile);
		}

		/// <summary>
		/// Загрузить файл формата .json
		/// </summary>
		/// <typeparam name="T">Загружаймый класс.</typeparam>
		/// <param name="pathLoad">Путь для загрузки.</param>
		/// <param name="sheet">Куда будут загружены данные.</param>
		public static void JsonLoad<T>(string pathLoad, ref T sheet)
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
			jsonSerializerSettings.Converters.Add(new RaceConvertorJson());
			jsonSerializerSettings.Converters.Add(new ClassConvertorJson());
			jsonSerializerSettings.Converters.Add(new TraitConvertorJson());
			jsonSerializerSettings.Converters.Add(new ItemsConverter());
			jsonSerializerSettings.Converters.Add(new SpellsConvertorJson());
			sheet = JsonConvert.DeserializeObject<T>(File.ReadAllText(pathLoad), jsonSerializerSettings);
    }
	}
}
