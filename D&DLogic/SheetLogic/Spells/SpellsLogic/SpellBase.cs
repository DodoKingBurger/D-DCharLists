using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// �������� ����������.
	/// </summary>
	public abstract class SpellBase
	{
		#region ���� � ��������

		private string name;

		/// <summary>
		/// �������� ����������.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get { return this.name; } protected set { this.name = value; } }

		private int level;
		/// <summary>
		/// ������� ����������.
		/// </summary>
		[JsonProperty("Level")]
		public int Level { get { return this.level; } protected set { this.level = value; } }

		private int id;

		/// <summary>
		/// ID ����������.
		/// </summary>
		[JsonProperty("Id")]
		public int Id { get { return this.id; } protected set { this.id = value; } }

		#endregion

		#region ������

		/// <summary>
		/// ���������� ����� ��������.
		/// </summary>
		/// <param name="name">����� ��������.</param>
		public void SetName(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// ���������� ����� �������.
		/// </summary>
		/// <param name="level">����� �������.</param>
		public void SetLevel(int level)
		{
			this.level = level;
		}

		/// <summary>
		/// ��������� ID.
		/// </summary>
		public void SetID()
		{
			this.id = RollRandom.LetsRoll.Next(1000, 10000);
		}

		#endregion
	}
}