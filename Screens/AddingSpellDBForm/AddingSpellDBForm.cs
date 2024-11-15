using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_DCharLists.Screens
{
	/// <summary>
	/// Форма для создания заклинаний.
	/// </summary>
	public partial class AddingSpellDBForm : Form
	{
		#region Поля и свойства

		/// <summary>
		/// Делегат для создания события по обновлению Бестиария с заклианиямиями
		/// </summary>
		public delegate void ReloadSpellDB(List<SpellBase> spells);
		
		/// <summary>
		/// Событие по обновлению Бестиария с заклинаниями.
		/// </summary>
		public event ReloadSpellDB OnReloadSpellDB;

		#endregion

		#region Методы

		/// <summary>
		/// Загрзука формы.
		/// </summary>
		/// <param name="sender">AddingSpellDBForm.</param>
		/// <param name="e">Load.</param>
		public void AddingSpellDBForm_Load(object sender, EventArgs e)
		{
			comboBox_FromСharacteristic_Spell.SelectedIndex = 0;
		}

		/// <summary>
		/// Создание заклинания и запись его в бд
		/// </summary>
		/// <param name="sender">button_Create_Spell.</param>
		/// <param name="e">Click.</param>
		public void button_Create_Spell_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Name_Spell.Text.Length > 0)
				{
					SpellBase spell = new Spell()
					{
						Name = textBox_Name_Spell.Text,
						FromСharacteristic = comboBox_FromСharacteristic_Spell.SelectedText,
						UseMasterBonus = checkBox_UseMasterBonus_Spell.Checked,
						AdditionalModifiers = (int)numericUpDown_AdditionalModifiers_Spell.Value,
						DamageType = textBox_DamageType_Spell.Text
					}; 
					SpellsDataBase.AddSpell(spell);
					this.OnReloadSpellDB(SpellsDataBase.SpellsDB.Values.ToList());
				}
				else
				{
					MessageBox.Show("Введите название заклинания!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region Конструкторы

		public AddingSpellDBForm()
		{
			InitializeComponent();
		}

		#endregion
	}
}
