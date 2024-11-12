using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace D_DCharLists.Screens.CreateItem
{
	public partial class CreateItemForm : Form
	{

		#region Поля и свойства

		/// <summary>
		/// Делегат для события обновления базы данных на экарне.
		/// </summary>
		public delegate void DBItemReload();

		/// <summary>
		/// Обновление базы данных предметов на главном экране.
		/// </summary>
		public event DBItemReload? Notify;

		#endregion

		#region Методы

		/// <summary>
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender">CreateItemForm.</param>
		/// <param name="e">Load.</param>
		private void CreateItemForm_Load(object sender, EventArgs e)
		{
			checkedListBox_Weapon_WeaponProperty.DataSource = Enum.GetNames(typeof(EnumWeaponProperties));
		}

		#region Кнопки создания предметов

		/// <summary>
		/// Создание оружия.
		/// </summary>
		/// <param name="sender">button_Create_Weapon.</param>
		/// <param name="e">Click.</param>
		private void button_Create_Weapon_Click(object sender, EventArgs e)
		{
			try
			{
				List<EnumWeaponProperties> WeaponPropertyList = new List<EnumWeaponProperties>();
				foreach (var property in checkedListBox_Weapon_WeaponProperty.SelectedItems)
				{
					if (Enum.TryParse<EnumWeaponProperties>(property.ToString(), out EnumWeaponProperties result))
					{
						WeaponPropertyList.Add(result);
					}
				}
				ItemWeapon item = new ItemWeapon()
				{
					Name = textBox_Weapon_Name.Text,
					Rarity = Enum.Parse<EnumItemRarityTypes>(comboBox_Weapon_Rarity.SelectedItem.ToString()),
					BaseCost = (float)numericUpDown_Weapon_BaseCost.Value,
					Weight = (float)numericUpDown_Weapon_Weight.Value,
					IsMagic = checkBox_Weapon_IsMagic.Checked,
					Description = textBox_Weapon_Description.Text,

					DamageDiceValue = Enum.Parse<EnumDices>(comboBox_Weapon_DamageDiceValue.SelectedItem.ToString()),
					DamageDiceCount = (int)numericUpDown_Weapon_DamageDiceCount.Value,
					DamageType = Enum.Parse<EnumItemDamageTypes>(comboBox_Weapon_DamageType.SelectedItem.ToString()),
					DamageModificator = (int)numericUpDown_Char_DamageModificator.Value,
					WeaponProficiencyConcrete = Enum.Parse<EnumWeaponsProficiencies>(comboBox_Weapon_WeaponProficiencyConcrete.SelectedItem.ToString()),
					WeaponProficiencyGroup = Enum.Parse<EnumWeaponsGroups>(comboBox_Char_WeaponProficiencyGroup.SelectedItem.ToString()),
					WeaponProperty = WeaponPropertyList
				};
				item.SetItemId();
				ItemsDataBase.AddItem(item);
				Notify();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Создание доспехов.
		/// </summary>
		/// <param name="sender">button_Create_Armor.</param>
		/// <param name="e">Click.</param>
		private void button_Create_Armor_Click(object sender, EventArgs e)
		{
			try
			{
				ItemArmor item = new ItemArmor()
				{
					Name = textBox_Armor_Name.Text,
					Rarity = Enum.Parse<EnumItemRarityTypes>(comboBox_Armor_Rarity.SelectedItem.ToString()),
					BaseCost = (float)numericUpDown_Armor_BaseCost.Value,
					Weight = (float)numericUpDown_Armor_Weight.Value,
					IsMagic = checkBox_Armor_IsMagic.Checked,
					Description = textBox_Armor_Description.Text,

					StrengthRequirement = (int)numericUpDown_Armor_StrengthRequirement.Value,
					ArmorClass = (int)numericUpDown_Armor_ArmorClass.Value,
					MaxAgilityBonus = (int)numericUpDown_Armor_MaxAgilityBonus.Value,
					ArmorType = Enum.Parse<EnumArmorProficiencies>(comboBox_Armor_ArmorType.SelectedItem.ToString()),
				};
				item.SetItemId();
				ItemsDataBase.AddItem(item);
				Notify();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Создания предмета.
		/// </summary>
		/// <param name="sender">button_Create_Item.</param>
		/// <param name="e">Click.</param>
		private void button_Create_Item_Click(object sender, EventArgs e)
		{
			try
			{
				ItemRegular item = new ItemRegular()
				{
					Name = textBox_Item_Name.Text,
					Rarity = Enum.Parse<EnumItemRarityTypes>(comboBox_Item_Rarity.SelectedItem.ToString()),
					BaseCost = (float)numericUpDown_Item_BaseCost.Value,
					Weight = (float)numericUpDown_Item_Weight.Value,
					IsMagic = checkBox_Item_IsMagic.Checked,
					Description = textBox_Item_Description.Text
				};
				item.SetItemId();
				ItemsDataBase.AddItem(item);
				Notify();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region Методы для заполнения ComboBox

		/// <summary>
		/// Создает список для заполнения comboBox с редкостями.
		/// </summary>
		/// <param name="sender">ComboboxRarities.</param>
		/// <param name="e">Click.</param>
		private void FillingComboboxRarities_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
			switch (comboBox.Name)
			{
				case "comboBox_Weapon_DamageDiceValue":
					comboBox.DataSource = Enum.GetNames(typeof(EnumDices));
					break;
				case "comboBox_Weapon_Rarity":
					comboBox.DataSource = Enum.GetNames(typeof(EnumItemRarityTypes));
					break;
				case "comboBox_Armor_Rarity":
					comboBox.DataSource = Enum.GetNames(typeof(EnumItemRarityTypes));
					break;
				case "comboBox_Item_Rarity":
					comboBox.DataSource = Enum.GetNames(typeof(EnumItemRarityTypes));
					break;
				case "comboBox_Weapon_WeaponProficiencyConcrete":
					comboBox.DataSource = Enum.GetNames(typeof(EnumWeaponsProficiencies));
					break;
				case "comboBox_Char_WeaponProficiencyGroup":
					comboBox.DataSource = Enum.GetNames(typeof(EnumWeaponsGroups));
					break;
				case "comboBox_Weapon_DamageType":
					comboBox.DataSource = Enum.GetNames(typeof(EnumItemDamageTypes));
					break;
				case "comboBox_Armor_ArmorType":
					comboBox.DataSource = Enum.GetNames(typeof(EnumArmorProficiencies));
					break;
			}
		}

		#endregion

		#endregion

		#region Конструкторы

		/// <summary>
		/// Создаем окно для создания предмета.
		/// </summary>
		public CreateItemForm()
		{
			InitializeComponent();
		}

		#endregion
	}
}
