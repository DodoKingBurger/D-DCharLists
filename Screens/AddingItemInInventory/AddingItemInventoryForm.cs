using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using D_DCharLists;
using D_DCharLists.Modules;

namespace D_DCharLists.Screens.AddingItemInInventory
{
	/// <summary>
	/// Форма для подробного пойска и добавленнии нескольких одинаковых предметов.
	/// </summary>
	public partial class AddingItemInventoryForm : Form
	{
		#region Поля и свойства

		/// <summary>
		/// Делеагт для события обновления инветоря персонажа при добавлении нового предмета.
		/// </summary>
		public delegate void ReloadHeroInventory();

		/// <summary>
		/// Cобытия обновления инветоря персонажа при добавлении нового предмета.
		/// </summary>
		public event ReloadHeroInventory InventoryHeroReload;

		#endregion

		#region Методы

		/// <summary>
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender">AddingItemInventoryForm.</param>
		/// <param name="e">Load.</param>
		private void AddingItemInventoryForm_Load(object sender, EventArgs e)
		{
			comboBox_Item_TypeItem.DataSource = Enum.GetNames(typeof(EnumItemTypes));
			comboBox_Item_TypeItem.SelectedIndex = 0;
		}

		/// <summary>
		/// Выбор типа предмета для пойска
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchItem(object sender, EventArgs e)
		{
			PrintDBItems();
		}

		/// <summary>
		/// Выводит список предметов по требуемым параметрам из comboBox_Item_TypeItem и textBox_Item_Name.
		/// </summary>
		public void PrintDBItems()
		{
			listView_Item_DB.Items.Clear();
			listView_Item_DB.Items.Add(new ListViewItem(""));
			try
			{
				if (Enum.TryParse<EnumItemTypes>(comboBox_Item_TypeItem.SelectedIndex.ToString(), out EnumItemTypes result))
				{
					List<ItemBase> items = ItemsDataBase.ItemsDB.Values.Where((row) =>
								row.ItemType == result &&
								row.Name.ToLower().Contains((textBox_Item_Name.Text).ToLower()))
									.ToList();
					ColumsHeadedCreating(result);
					PrintArmorItem(items);
				}
				else
				{
					throw new Exception("Неизвестный тип предмета");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Создает колоники и выводит искомыйе предметы исходя от типа предмета.
		/// </summary>
		private void PrintArmorItem(List<ItemBase> items)
		{
			foreach (ItemBase item in items)
			{
				string[] rowStart =
						[
							item.ItemId.ToString(),
							item.Name.ToString(),
							item.Rarity.ToString(),
							item.IsMagic.ToString()
						];
				List<string> rowMid = new List<string>();
				switch (items[0].ItemType)
				{
					case EnumItemTypes.Armor:
						ItemArmor armor = (ItemArmor)item;
						rowMid.Add(armor.StrengthRequirement.ToString());
						rowMid.Add(armor.ArmorClass.ToString());
						rowMid.Add(armor.MaxAgilityBonus.ToString());
						rowMid.Add(armor.ArmorType.ToString());
						break;
					case EnumItemTypes.Weapon:
						ItemWeapon weapon = (ItemWeapon)item;
						rowMid.Add(weapon.DamageDiceCount.ToString());
						rowMid.Add(weapon.DamageDiceValue.ToString());
						rowMid.Add(weapon.DamageModificator.ToString());
						rowMid.Add(weapon.DamageType.ToString());
						rowMid.Add(string.Join("\n", weapon.WeaponProperty));
						rowMid.Add(weapon.WeaponProficiencyConcrete.ToString());
						rowMid.Add(weapon.WeaponProficiencyGroup.ToString());
						break;
					case EnumItemTypes.Coin:
						ItemCoin coin = (ItemCoin)item;
						rowMid.Add(coin.CoinType.ToString());
						break;
					case EnumItemTypes.Item:
						break;
				}
				string[] rowsEnd =
					[
					item.BaseCost.ToString(),
					item.Weight.ToString(),
					item.Description.ToString()
					];
				var row = rowStart.Concat(rowMid).Concat(rowsEnd).ToArray();
				listView_Item_DB.Items.Add(new ListViewItem(row));
			}
		}

		/// <summary>
		/// Создает нужные для listview колонки зависит от типа предмета который передали.
		/// </summary>
		/// <param name="type">Тип предмета для которого будут созданны колонки.</param>
		private void ColumsHeadedCreating(EnumItemTypes type)
		{
			listView_Item_DB.Columns.Clear();
			listView_Item_DB.Columns.Add(new ColumnHeader());
			listView_Item_DB.Columns[0].Text = "ItemId";
			listView_Item_DB.Columns[0].Width = 100;
			listView_Item_DB.Columns.Add(new ColumnHeader());
			listView_Item_DB.Columns[1].Text = "Name";
			listView_Item_DB.Columns[1].Width = 100;
			listView_Item_DB.Columns.Add(new ColumnHeader());
			listView_Item_DB.Columns[2].Text = "Rarity";
			listView_Item_DB.Columns[2].Width = 100;
			listView_Item_DB.Columns.Add(new ColumnHeader());
			listView_Item_DB.Columns[3].Text = "IsMagic";
			listView_Item_DB.Columns[3].Width = 100;
			switch (type)
			{
				case EnumItemTypes.Armor:
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[4].Text = "StrengthRequirement";
					listView_Item_DB.Columns[4].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[5].Text = "ArmorClass";
					listView_Item_DB.Columns[5].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[6].Text = "MaxAgilityBonus";
					listView_Item_DB.Columns[6].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[7].Text = "ArmorType";
					listView_Item_DB.Columns[7].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());

					listView_Item_DB.Columns[8].Text = "BaseCost";
					listView_Item_DB.Columns[8].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[9].Text = "Weight";
					listView_Item_DB.Columns[9].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[10].Text = "Description";
					listView_Item_DB.Columns[10].Width = 100;
					break;
				case EnumItemTypes.Weapon:
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[4].Text = "DamageDiceCount";
					listView_Item_DB.Columns[4].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[5].Text = "DamageDiceValue";
					listView_Item_DB.Columns[5].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[6].Text = "DamageModificator";
					listView_Item_DB.Columns[6].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[7].Text = "DamageType";
					listView_Item_DB.Columns[7].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[8].Text = "WeaponProperty";
					listView_Item_DB.Columns[8].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[9].Text = "WeaponProficiencyConcrete";
					listView_Item_DB.Columns[9].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[10].Text = "WeaponProficiencyGroup";
					listView_Item_DB.Columns[10].Width = 100;

					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[11].Text = "BaseCost";
					listView_Item_DB.Columns[11].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[12].Text = "Weight";
					listView_Item_DB.Columns[12].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[13].Text = "Description";
					listView_Item_DB.Columns[13].Width = 100;
					break;
				case EnumItemTypes.Item:
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[4].Text = "BaseCost";
					listView_Item_DB.Columns[4].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[5].Text = "Weight";
					listView_Item_DB.Columns[5].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[6].Text = "Description";
					listView_Item_DB.Columns[6].Width = 100;
					break;
				case EnumItemTypes.Coin:
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[4].Text = "CoinType";
					listView_Item_DB.Columns[4].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[5].Text = "BaseCost";
					listView_Item_DB.Columns[5].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[6].Text = "Weight";
					listView_Item_DB.Columns[6].Width = 100;
					listView_Item_DB.Columns.Add(new ColumnHeader());
					listView_Item_DB.Columns[7].Text = "Description";
					listView_Item_DB.Columns[7].Width = 100;
					break;
			}
		}

		/// <summary>
		/// Добавляет предмет в инвентарь персонажу.
		/// </summary>
		/// <param name="sender">button_Char_Adding_Item.</param>
		/// <param name="e">Click.</param>
		private void button_Char_Adding_Item_Click(object sender, EventArgs e)
		{
			int IDitem = (int)numericUpDown_Item_Id.Value;
			int HowMany = (int)numericUpDown_Item_How.Value;
			try
			{
				if (ItemsDataBase.ItemsDB.ContainsKey(IDitem))
				{
					CurrentHeroSheet.HeroSheet.SheetInventory.AddItem(IDitem, HowMany);
					InventoryHeroReload();
				}
				else
					throw new ArgumentException("ID предмета не найден");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion

		#region Конструкторы

		public AddingItemInventoryForm()
		{
			this.InitializeComponent();
		}

		#endregion
	}
}
