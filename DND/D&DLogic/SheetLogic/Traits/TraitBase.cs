using Newtonsoft.Json;

namespace D_DCharLists
{
	/// <summary>
	/// �������� �������.
	/// </summary>
	public abstract class TraitBase
	{
		#region ���� � ��������
		/// <summary>
		/// ��������.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; protected set; }

		/// <summary>
		/// ��������.
		/// </summary>
		[JsonProperty("Source")]
		public string Source { get; protected set; }

		/// <summary>
		/// ��������.
		/// </summary>
		[JsonProperty("Description")]
		public string Description { get; protected set; }

		/// <summary>
		/// ID �����.
		/// </summary>
		[JsonProperty("Id")]
		public int Id { get; protected set; }

		/// <summary>
		/// ������� ���������.
		/// </summary>
		[JsonProperty("LevelGained")]
		public int LevelGained { get; protected set; }

		#endregion

		#region ������

		/// <summary>
		/// ���������� ID.
		/// </summary>
		public void SetID()
		{
			this.Id = RollRandom.LetsRoll.Next(1000, 10000);
		}

		/// <summary>
		/// ���������� ���.
		/// </summary>
		/// <param name="name">���.</param>
		public void SetName(string name)
		{
			this.Name = name;
		}

		/// <summary>
		/// ���������� ��������.
		/// </summary>
		/// <param name="description">����� ��������.</param>
		public void SetDescription(string description)
		{
			this.Description = description;
		}

		/// <summary>
		/// ���������� �������� �������.
		/// </summary>
		/// <param name="source">�������� �������.</param>
		public void SetSource(string source)
		{
			this.Source = source;
		}

		/// <summary>
		/// ���������� �������.
		/// </summary>
		/// <param name="level">����� �������.</param>
		public void SetLevel(int level)
		{
			this.LevelGained = level;
		}

		#endregion
	}
}