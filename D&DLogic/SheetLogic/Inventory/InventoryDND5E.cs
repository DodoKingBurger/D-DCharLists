namespace D_Dlib
{
	/// <summary>
	/// Инвентарь.
	/// </summary>
	public class InventoryDND5E : SheetInventory
	{
		#region Базовый класс.

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

		#region Конструторы

		/// <summary>
		/// Создате инвернтарь героя.
		/// </summary>
		public InventoryDND5E()
		{
			Inventory = new Dictionary<int, int>();
		}

		#endregion
	}
}