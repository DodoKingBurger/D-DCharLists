namespace D_DCharLists
{
	/// <summary>
	/// ���������.
	/// </summary>
	public class Inventory : SheetInventory
	{
		#region ������� �����.

		public override void AddItem(int item)
		{
			if (Inventory.ContainsKey(item))
			{
				Inventory[item]++;
			}
			else
			{
				Inventory[item] = 1;
			}
		}

		public override void DecreaseItem(int item)
		{
			if (Inventory.ContainsKey(item))
			{
				if (Inventory[item] == 1)
				{
					Inventory.Remove(item);
				}
				else
				{
					Inventory[item]--;
				}
			}
		}

		public override void RemoveItem(int item)
		{
			if (Inventory.ContainsKey(item))
			{
				Inventory.Remove(item);
			}
		}

		#endregion

		#region �����������

		/// <summary>
		/// ������� ���������� �����.
		/// </summary>
		public Inventory()
		{
			Inventory = new Dictionary<int, int>();
		}

		#endregion
	}
}