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
		/// Указания характеристик у персонажа.
		/// </summary>
		/// <param name="sender">NumericUpDown на вкладке.</param>
		/// <param name="e">Событие.</param>
		private void numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(NumericUpDown))
			{
				Dictionary<Enum, int> ListAbilities = new Dictionary<Enum, int>()
				{
					{ EnumAbilitiesDnd5E.Strength, (int)numericUpDown_Strength.Value },
					{ EnumAbilitiesDnd5E.Agility, (int)numericUpDown_Agility.Value  },
					{ EnumAbilitiesDnd5E.Physique, (int)numericUpDown_Physique.Value },
					{ EnumAbilitiesDnd5E.Intelligence, (int)numericUpDown_Intelligence.Value  },
					{ EnumAbilitiesDnd5E.Wisdom, (int)numericUpDown_Wisdom.Value },
					{ EnumAbilitiesDnd5E.Charisma, (int)numericUpDown_Charisma.Value  },
				};
				CurrentHeroSheet.HeroSheet.SheetAbilities.SetAbilities(ListAbilities);
			}
			else
			{
				throw new Exception("Событие вызвано не тем контроллером.");
			}
		}

		/// <summary>
		/// Добавления навыков персонажа.
		/// </summary>
		/// <param name="sender">Список с навыками персонажа.</param>
		/// <param name="e">Событие.</param>
		private void checkedListBox_Proficiencies_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> checkedListBox = new List<string>();
			CurrentHeroSheet.HeroSheet.SheetProficiencies.Proficiencies.Clear();
			foreach (object item in checkedListBox_ArmorProficiencies.CheckedItems)
			{
				if (item != null)
					checkedListBox.Add(item.ToString());
			}
			foreach (object item in checkedListBox_WeaponsProficiencies.CheckedItems)
			{
				if (item != null)
					checkedListBox.Add(item.ToString());
			}
			foreach (object item in checkedListBox_WeaponsGroups.CheckedItems)
			{
				if (item != null)
					checkedListBox.Add(item.ToString());
			}
			foreach (object item in checkedListBox_MusicalInstrumentProficiencies.CheckedItems)
			{
				if (item != null)
					checkedListBox.Add(item.ToString());
			}
			foreach (object item in checkedListBox_GamingSetProficiencies.CheckedItems)
			{
				if (item != null)
					checkedListBox.Add(item.ToString());
			}
			foreach (object item in checkedListBox_InstrumentsProficiencies.CheckedItems)
			{
				if (item != null)
					checkedListBox.Add(item.ToString());
			}

			if (checkedListBox.Count >= 0)
			{
				foreach (var str in checkedListBox)
				{
					EnumAllDND5eProficiencies Proficiencies = (EnumAllDND5eProficiencies)Enum.Parse(typeof(EnumAllDND5eProficiencies), str);
					CurrentHeroSheet.HeroSheet.SheetProficiencies.AddProficiency(Proficiencies);
				}
			}
		}

		/// <summary>
		/// Проверка на ввод числа.
		/// </summary>
		/// <param name="sender">Текст бокс с текстом.</param>
		/// <param name="e">События ввод в страку.</param>
		private void textBox_Validation_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			if (!int.TryParse(textBox.Text, out int age) || age < 0)
			{
				MessageBox.Show("Это поле должно быть в введен в формате - \"12\".");
			}
		}

		/// <summary>
		/// Сохранить созданного персонажа.
		/// </summary>
		/// <param name="sender">Кнопка сохранить.</param>
		/// <param name="e">Событие.</param>
		private void button_Save_Char_Click(object sender, EventArgs e)
		{
			if(CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities.TryGetValue(EnumAbilitiesDnd5E.Physique, out int Physique)&& 
				CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities.TryGetValue(EnumAbilitiesDnd5E.Agility, out int Agility) && CurrentHeroSheet.HeroSheet.SheetClass!= null)
			{
				foreach (var item in Enum.GetNames(typeof(EnumPersonalitiesDND5E)))
				{
					if (Enum.TryParse<EnumPersonalitiesDND5E>(item, out EnumPersonalitiesDND5E result))
					{
						string value = string.Empty;
						switch (result)
						{
							case EnumPersonalitiesDND5E.Background:
								value = textBox_Background.Text;
								break;
							case EnumPersonalitiesDND5E.Alignment:
								value = textBox_Alignment.Text;
								break;
							case EnumPersonalitiesDND5E.PersonalityTraits:
								value = textBox_PersonalityTraits.Text;
								break;
							case EnumPersonalitiesDND5E.Ideals:
								value = textBox_Ideals.Text;
								break;
							case EnumPersonalitiesDND5E.Bonds:
								value = textBox_Bonds.Text;
								break;
							case EnumPersonalitiesDND5E.Flaws:
								value = textBox_Flaws.Text;
								break;
							case EnumPersonalitiesDND5E.Age:
								value = textBox_Age.Text;
								break;
							case EnumPersonalitiesDND5E.Height:
								value = textBox_Height.Text;
								break;
							case EnumPersonalitiesDND5E.Weight:
								value = textBox_Weight.Text;
								break;
							case EnumPersonalitiesDND5E.Eyes:
								value = textBox_Eyes.Text;
								break;
							case EnumPersonalitiesDND5E.Skin:
								value = textBox_Skin.Text;
								break;
							case EnumPersonalitiesDND5E.Hair:
								value = textBox_Hair.Text;
								break;
						}
						CurrentHeroSheet.HeroSheet.SheetPersonality.AddPersonality(result, value);
					}
				}

				//Указание HP
				CurrentHeroSheet.HeroSheet.SheetCombatAbilities.ChangeStat(EnumCombatStatsDND5e.MaximumHP, 
					((int)CurrentHeroSheet.HeroSheet.SheetClass.HitDice + CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilitiesDnd5E.Physique)));
				CurrentHeroSheet.HeroSheet.SheetCombatAbilities.ChangeStat(EnumCombatStatsDND5e.CurrentHP, 
					CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.MaximumHP]);

				//Указание базового КД (без брони)
				CurrentHeroSheet.HeroSheet.SheetCombatAbilities.ChangeStat(EnumCombatStatsDND5e.ArmorClass, 
					10 + CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilitiesDnd5E.Agility));

				//Указание кости хитов
				CurrentHeroSheet.HeroSheet.SheetCombatAbilities.ChangeStat(EnumCombatStatsDND5e.CurrentHitDices, 
					CurrentHeroSheet.HeroSheet.SheetProgression.Level);

				//Указание спасбросков
				CurrentHeroSheet.HeroSheet.SheetSaveThrows.SetSaveTrows(CurrentHeroSheet.HeroSheet.SheetClass.Name);

				CurrentHeroSheet.SaveSheet();
			}
			else
			{
				MessageBox.Show("Лист персонаа не заполнен!");
			}
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
