namespace D_DCharLists
{
	/// <summary>
	/// Инвентарь.
	/// </summary>
	public class Inventory : SheetInventory
	{
		#region Поля и свойства

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

		#region Конструкторы

		/// <summary>
		/// Создаёт инвентарь.
		/// </summary>
		public Inventory()
		{
			Inventory = new Dictionary<int, int>();
		}

		#endregion
	}
}