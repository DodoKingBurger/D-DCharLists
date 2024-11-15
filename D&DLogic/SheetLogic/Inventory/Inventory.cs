namespace D_DCharLists
{
	/// <summary>
	/// Инвентарь.
	/// </summary>
	public class Inventory : SheetInventory
	{
		#region Базовый класс

		public override void AddItem(int item)
		{
			if (this.Inventory.ContainsKey(item))
			{
				this.Inventory[item]++;
			}
			else
			{
				this.Inventory[item] = 1;
			}
		}

		public override void AddItem(int item, int HowMany)
		{
			if (this.Inventory.ContainsKey(item))
			{
				this.Inventory[item]+= HowMany;
			}
			else
			{
				this.Inventory[item] = HowMany;
			}
		}


		public override void DecreaseItem(int item)
		{
			if (this.Inventory.ContainsKey(item))
			{
				if (this.Inventory[item] == 1)
				{
					this.Inventory.Remove(item);
				}
				else
				{
					this.Inventory[item]--;
				}
			}
		}

		public override void RemoveItem(int item)
		{
			if (this.Inventory.ContainsKey(item))
			{
				this.Inventory.Remove(item);
			}
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Создаёт инвентарь.
		/// </summary>
		public Inventory()
		{
			this.Inventory = new Dictionary<int, int>();
		}

		#endregion
	}
}