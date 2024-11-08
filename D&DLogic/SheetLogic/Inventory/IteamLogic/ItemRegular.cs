namespace D_DCharLists
{
	/// <summary>
	/// ������� �������.
	/// </summary>
	public class ItemRegular : ItemBase
	{
		public ItemRegular()
		{
			ItemType = EnumItemTypes.Item;
			Name = string.Empty;
			BaseCost = 0;
			Weight = 0;
			Rarity = EnumItemRarityTypes.Usual;
			Description = string.Empty;
			IsMagic = false;
			ItemId = 0;
		}
	}
}