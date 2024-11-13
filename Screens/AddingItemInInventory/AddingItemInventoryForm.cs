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
	public partial class AddingItemInventoryForm : Form
	{
		#region Методы

		/// <summary>
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender">AddingItemInventoryForm.</param>
		/// <param name="e">Load.</param>
		private void AddingItemInventoryForm_Load(object sender, EventArgs e)
		{
			comboBox_Item_TypeItem.DataSource = Enum.GetNames(typeof(EnumItemTypes));
			comboBox_Item_TypeItem.Text = comboBox_Item_TypeItem.Items[0].ToString();
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
					if (!CurrentHeroSheet.HeroSheet.SheetInventory.Inventory.ContainsKey(IDitem))
						CurrentHeroSheet.HeroSheet.SheetInventory.Inventory.Add(IDitem, HowMany);
					else
						CurrentHeroSheet.HeroSheet.SheetInventory.AddItem(IDitem, HowMany);
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
