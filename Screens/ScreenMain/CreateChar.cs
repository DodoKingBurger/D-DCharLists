using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using D_DCharList.Modules;
using D_DCharLists;

namespace D_DCharLists.Screens.ScreenMain
{
	public partial class CreateChar : Form
	{
		#region Поля и свойства

		/// <summary>
		/// Фабрика расс.
		/// </summary>
		private SheetRaceFactory sheetRaceFactory;

		/// <summary>
		/// Фабрика классов.
		/// </summary>
		private SheetClassFactory sheetClassFactory;

		#endregion

		#region Методы

		/// <summary>
		/// Нарекание имени.
		/// </summary>
		/// <param name="sender">Текст бокс с именем.</param>
		/// <param name="e">Событие.</param>
		private void textBox_NameChar_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox_NameChar.Text))
				CurrentHeroSheet.HeroSheet.Name = textBox_NameChar.Text;
		}

		/// <summary>
		/// Выбор рассы.
		/// </summary>
		/// <param name="sender">RadioButton который вызвал событие.</param>
		/// <param name="e">Событие.</param>
		private void radioButton_ChoiceRace_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			CurrentHeroSheet.HeroSheet.SetUpRace(
			sheetRaceFactory.CreateSheetRace(radioButton.Text));
		}

		/// <summary>
		/// Выбор класса.
		/// </summary>
		/// <param name="sender">RadioButton который вызвал событие.</param>
		/// <param name="e">Событие.</param>
		private void radioButton_ChoiceClass_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			CurrentHeroSheet.HeroSheet.SetUpClass(
			sheetClassFactory.CreateSheetClass(radioButton.Text));
		}

		/// <summary>
		/// Сохранение скилов у персонажа.
		/// </summary>
		/// <param name="sender">Кто создал событие.</param>
		/// <param name="e">Событие.</param>
		private void checkedListBox_Skills_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckedListBox checkedListBox = (CheckedListBox)sender;
			if (checkedListBox.CheckedItems.Count >= 0)
			{
				CurrentHeroSheet.HeroSheet.SheetSkills.Skills.Clear();
				for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
				{
					EnumSkillsDnd5E skill = (EnumSkillsDnd5E)Enum.Parse(typeof(EnumSkillsDnd5E), checkedListBox.CheckedItems[i].ToString());
					CurrentHeroSheet.HeroSheet.SheetSkills.AddSkill(skill);
				}
			}
		}

		/// <summary>
		/// Сохранить созданного персонажа.
		/// </summary>
		/// <param name="sender">Кнопка сохранить.</param>
		/// <param name="e">Событие.</param>
		private void button_Save_Char_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e">Событие.</param>
		private void CreateChar_Load(object sender, EventArgs e)
		{
			sheetRaceFactory = new SheetRaceFactory();
			sheetClassFactory = new SheetClassFactory();
		}

		#endregion

		#region Конструкторы

		public CreateChar()
		{
			InitializeComponent();
		}

		#endregion
	}
}
