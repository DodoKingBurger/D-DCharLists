using Newtonsoft.Json;

namespace D_Dlib
{
	/// <summary>
	/// �������� ��������.
	/// </summary>
	public abstract class ItemBaseDND5e
	{
		#region ���� � ��������

		/// <summary>
		/// �������� ��������.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; set; }

		/// <summary>
		/// ������� ���������.
		/// </summary>
		[JsonProperty("BaseCost")]
		public float BaseCost { get; set; }

		/// <summary>
		/// �����.
		/// </summary>
		[JsonProperty("Weight")]
		public float Weight { get; set; }

		/// <summary>
		/// ��������.
		/// </summary>
		[JsonProperty("Rarity")]
		public EnumItemRarityTypes Rarity { get; set; }

		/// <summary>
		/// ��������.
		/// </summary>
		[JsonProperty("Description")]
		public string Description { get; set; }

		/// <summary>
		/// ���������� �� �������.
		/// </summary>
		[JsonProperty("IsMagic")]
		public bool IsMagic { get; set; }

		/// <summary>
		/// ID ��������.
		/// </summary>
		[JsonProperty("ItemId")]
		public int ItemId { get; set; }

		/// <summary>
		/// ��� ��������.
		/// </summary>
		[JsonProperty("ItemType")]
		public EnumItemTypesDND5e ItemType { get; set; }

		#endregion

		#region ������

		/// <summary>
		/// ���������� ID ��������.
		/// </summary>
		public void SetItemId()
		{
			ItemId = RollRandom.LetsRoll.Next(1000, 10000);
		}

		/// <summary>
		/// ������� �������.
		/// </summary>
		/// <param name="value">�������� ��������.</param>
		public void SetName(string value)
		{
			Name = value;
		}

		/// <summary>
		/// ��������� ������� ��������� ��������.
		/// </summary>
		/// <param name="value"></param>
		public void SetBaseCost(float value)
		{
			BaseCost = value;
		}

		/// <summary>
		/// ���������� ��� ��������.
		/// </summary>
		/// <param name="value">��� ��������.</param>
		public void SetWeight(float value)
		{
			Weight = value;
		}

		/// <summary>
		/// ���������� �������� ��� ��������.
		/// </summary>
		/// <param name="value"></param>
		public void SetRarity(EnumItemRarityTypes value)
		{
			Rarity = value;
		}

		/// <summary>
		/// ���������� �������� ��������.
		/// </summary>
		/// <param name="value"></param>
		public void SetDescription(string value)
		{
			Description = value;
		}

		/// <summary>
		/// ��������� ����������� �������� ��������.
		/// </summary>
		/// <param name="value">true, ���� ������� ����������, false ���� ���.</param>
		public void SetIsMagic(bool value)
		{
			IsMagic = value;
		}

		#endregion
	}
}