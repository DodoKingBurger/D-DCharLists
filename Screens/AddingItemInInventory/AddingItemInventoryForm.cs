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
using D_DCharLists.Enums.DNDEnums;

namespace D_DCharLists.Screens.AddingItemInInventory
{
	public partial class AddingItemInventoryForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox_Item_TypeItem_Click(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			comboBox.DataSource = Enum.GetNames(typeof(EnumItems));
		}
	
	
	}
}
