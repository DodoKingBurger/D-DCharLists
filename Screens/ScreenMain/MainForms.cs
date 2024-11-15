using D_DCharLists;
using D_DCharLists.Modules;
using D_DCharLists.Screens;
using D_DCharLists.Screens.AddingItemInInventory;
using D_DCharLists.Screens.CreateItem;
using D_DCharLists.Screens.ScreenMain;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace D_DCharLists
{
	/// <summary>
	/// Главный экран.
	/// </summary>
	public partial class StartForms : Form
	{
		#region Поля и свойства

		/// <summary>
		/// Ининициализатор.
		/// </summary>
		private Initialize initialize;

		/// <summary>
		/// Форма для создания персонажа.
		/// </summary>
		private CreateCharForm createChar;

		/// <summary>
		/// Форма для создания предмета.
		/// </summary>
		private CreateItemForm createItem;

		/// <summary>
		/// Форма для подробного пойска и добавленнии нескольких одинаковых предметов.
		/// </summary>
		private AddingItemInventoryForm addingItem;

		/// <summary>
		/// Форма для создания заклинаний.
		/// </summary>
		private AddingSpellDBForm addingSpellDB;
		
		#endregion

		#region Методы

		/// <summary>
		/// Момент загрузки главной формы.
		/// </summary>
		/// <param name="sender">Форма.</param>
		/// <param name="e">Событие загрузки.</param>
		private void StartForms_Load(object sender, EventArgs e)
		{
			HeroDataBase.ShowHero += ShowHeroSheet;
			this.initialize = new Initialize();
			this.addingItem = new AddingItemInventoryForm();
			this.addingSpellDB = new AddingSpellDBForm();
			this.initialize.Start();
			comboBox_TypeItemForSearch.SelectedIndex = 0;
			ShowDBItems();
			PrintDBSpell(SpellsDataBase.SpellsDB.Values.ToList());
		}

		/// <summary>
		/// Момент закрытие главной формы.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StartForms_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Закрыть?\nВы уверенны что хотите завершить работу программы?", "WHY DO YOU CALL?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
			{
				if (CurrentHeroSheet.HeroSheet != null && !string.IsNullOrEmpty(CurrentHeroSheet.HeroSheet.Name))
					CurrentHeroSheet.SaveSheet();
				ItemsDataBase.SaveDB();
				SpellsDataBase.SaveDB();
				this.addingItem.Close();
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}

		/// <summary>
		/// Вызывает окно создания персонажа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btCreateChar_Click(object sender, EventArgs e)
		{
			this.createChar = new CreateCharForm();
			this.createChar.ShowDialog();
		}

		/// <summary>
		/// Загрузить в комбобокс всех загруженных персонажей.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox_Loading_Char_Click(object sender, EventArgs e)
		{
			comboBox_Loading_Char.Items.Clear();
			comboBox_Loading_Char.Items.AddRange(HeroDataBase.CharactersAvailableForDownload());
		}

		/// <summary>
		/// Сохранить персонажа .json.
		/// </summary>
		/// <param name="sender">Кнопка.</param>
		/// <param name="e">Клик.</param>
		/// <exception cref="ArgumentNullException">Персонаж не был создан или загружен.</exception>
		private void bt_SaveChar_Click(object sender, EventArgs e)
		{
			try
			{
				CurrentHeroSheet.SaveSheet();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Загрузить выбранного в comboBox_Loading_Char персонажа 
		/// в текущего персонажа. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bt_Load_Char_Click(object sender, EventArgs e)
		{
			if (comboBox_Loading_Char.SelectedItem != null)
				HeroDataBase.LoadHerosBase(comboBox_Loading_Char.SelectedItem.ToString());
			else
				MessageBox.Show("Выберите или создайте персонажа!");
		}

		#region Методы работы с заклинаниями

		/// <summary>
		/// Вызов окна где создаються заклинания для базы данных.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_Create_Spell_Click(object sender, EventArgs e)
		{
			addingSpellDB.OnReloadSpellDB += PrintDBSpell;
			addingSpellDB.Show();
		}

		/// <summary>
		/// Добавляет заклинание в список заклинаний пероснажа.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_Char_Add_AttacksAndSpells_Click(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					int IDSpell = (int)numericUpDown_Spell_ID.Value;
					if (SpellsDataBase.SpellsDB.ContainsKey(IDSpell))
					{
						CurrentHeroSheet.HeroSheet.SheetSpells.AddSpell(IDSpell);
					}
					else
						throw new Exception("неизвестное заклинание!");
				}
				else
					throw new Exception("Создайте или загрузите персонажа!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Удаление заклинания
		/// </summary>
		/// <param name="sender"> button_Remove_Spell.</param>
		/// <param name="e">Click</param>
		private void button_Remove_Spell_Click(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					int IDSpell = (int)numericUpDown_Spell_ID.Value;
					if (SpellsDataBase.SpellsDB.ContainsKey(IDSpell) &&
						CurrentHeroSheet.HeroSheet.SheetSpells.SheetSpells.ContainsKey(IDSpell))
					{
						CurrentHeroSheet.HeroSheet.SheetSpells.RemoveSpell(IDSpell);
					}
					else
						throw new Exception("неизвестное заклинание!");
				}
				else
					throw new Exception("Создайте или загрузите персонажа!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Пойсковик для базы данных заклинаний
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox_Name_Spell_TextChanged(object sender, EventArgs e)
		{
			List<SpellBase> list = SpellsDataBase.SpellsDB.Values.Where((row) =>
			row.Name.ToLower().Contains(textBox_Name_Spell.Text.ToLower())).ToList();
			PrintDBSpell(list);
		}

		#endregion

		#region Методы работы с предметами

		/// <summary>
		/// Выводит окно создания пероснажа.
		/// </summary>
		/// <param name="sender">button_Create_Item.</param>
		/// <param name="e">Click.</param>
		private void button_Create_Item_Click(object sender, EventArgs e)
		{
			this.createItem = new CreateItemForm();
			this.createItem.Notify += ShowDBItems;
			this.createItem.ShowDialog();
		}

		/// <summary>
		/// Добавляет по ID предмет в инвентарь.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_Char_Add_Item_Click(object sender, EventArgs e)
		{
			try
			{
				int IDitem = (int)numericUpDown_ID_For_Adding_Item.Value;
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					if (IDitem > 0 &&
						ItemsDataBase.ItemsDB.ContainsKey(IDitem))
					{
						CurrentHeroSheet.HeroSheet.SheetInventory.AddItem(IDitem);
						PrintHeroInventory();
					}
					else
						MessageBox.Show("Педмет не найден!");
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
		}

		/// <summary>
		/// Удаляет предмет.
		/// </summary>
		/// <param name="sender">button_Inventary_Item_Remove.</param>
		/// <param name="e">Click.</param>
		private void button_Inventary_Item_Remove_Click(object sender, EventArgs e)
		{
			try
			{
				int IDitem = (int)numericUpDown_ID_For_Adding_Item.Value;
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					if (IDitem > 0 && ItemsDataBase.ItemsDB.ContainsKey(IDitem) &&
				CurrentHeroSheet.HeroSheet.SheetInventory.Inventory.ContainsKey(IDitem))
					{
						CurrentHeroSheet.HeroSheet.SheetInventory.DecreaseItem(IDitem);
						PrintHeroInventory();
					}
					else
						MessageBox.Show("Педмет не найден!");
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Пойсковик предметов
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Search_DBItem(object sender, EventArgs e)
		{
			ShowDBItems();
		}

		/// <summary>
		/// Призывает окно справочника для добавления и пойска предмета со всеми характеристиками.
		/// </summary>
		/// <param name="sender">button_Summon_AddingItemInventoryForm.</param>
		/// <param name="e">Click.</param>
		private void button_Summon_AddingItemInventoryForm_Click(object sender, EventArgs e)
		{
			addingItem.InventoryHeroReload += PrintHeroInventory;
			addingItem.Show();
		}

		#endregion

		#region Методы связанные с изменениями параметровов персонажа

		/// <summary>
		/// Изменяет наличие у персонажа вдохновения.
		/// </summary>
		/// <param name="sender">checkBox_Inspiration.</param>
		/// <param name="e">Изменение статуса чек бокс.</param>
		private void checkBox_Inspiration_CheckedChanged(object sender, EventArgs e)
		{
			CurrentHeroSheet.HeroSheet.Inspiration = checkBox_Inspiration.Checked;
		}

		/// <summary>
		/// Изменения класса защиты.
		/// </summary>
		/// <param name="sender">numericUpDown_Char_ArmorClass.</param>
		/// <param name="e">ValueChanged.</param>
		private void Changed_Char_CombatAbilities_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					switch (sender.GetType().Name)
					{
						case "TrackBar":
							System.Windows.Forms.TrackBar trackBar = (System.Windows.Forms.TrackBar)sender;
							CurrentHeroSheet.HeroSheet.SheetCombatAbilities.ChangeStat(FabricCombatStats(trackBar), trackBar.Value);
							break;
						case "NumericUpDown":
							NumericUpDown numeric = (NumericUpDown)sender;
							CurrentHeroSheet.HeroSheet.SheetCombatAbilities.ChangeStat(FabricCombatStats(numeric), (int)numeric.Value);
							break;
					}
					ShowHeroSheet();
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Повышение или понижение уровня персонажа.
		/// </summary>
		/// <param name="sender">numericUpDown_Char_Level.</param>
		/// <param name="e">Изменение Value у numericUpDown</param>
		private void numericUpDown_Char_Level_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					NumericUpDown numeric = (NumericUpDown)sender;
					CurrentHeroSheet.HeroSheet.SheetProgression.Level = (int)numeric.Value;
					ShowHeroSheet();
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Добавить опыт персонажу.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bt_Add_Exp_Click(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					if (CurrentHeroSheet.HeroSheet.SheetProgression.Expirience >= 0 && (CurrentHeroSheet.HeroSheet.SheetProgression.Expirience - (int)numericUpDown_Char_Exp_Calculations.Value) >= 0)
					{
						CurrentHeroSheet.HeroSheet.SheetProgression.GainExpirience((int)numericUpDown_Char_Exp_Calculations.Value);
					}
					else
					{
						CurrentHeroSheet.HeroSheet.SheetProgression.Expirience = 0;
						CurrentHeroSheet.HeroSheet.SheetProgression.Level = 1;
					}
					ShowHeroSheet();
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Изменение параметров персонажа.
		/// </summary>
		/// <param name="sender">NumericUpDown.</param>
		/// <param name="e">Событие по изменению параметра.</param>
		private void numericUpDown_Char_Characteristics_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					NumericUpDown numericUpDown = (NumericUpDown)sender;
					CurrentHeroSheet.HeroSheet.SheetAbilities.ChangeAbilityScore(FabricEnumAbilities(numericUpDown), (int)numericUpDown.Value);
					ShowHeroSheet();
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Событие на изменения статуса у checkedBox входящего в checkedListBox_Skills
		/// </summary>
		/// <param name="sender">checkedListBox_Skills.</param>
		/// <param name="e">SelectedItem.</param>
		private void checkedListBox_Skills_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					CheckedListBox checkedListBox = (CheckedListBox)sender;
					//ItemCheckedEventArgs args = (ItemCheckedEventArgs)e;
					if (Enum.TryParse<EnumSkills>(checkedListBox.SelectedItem.ToString(), out EnumSkills skill))
					{
						if (checkedListBox.CheckedItems.Contains(checkedListBox.SelectedItem))
						{
							CurrentHeroSheet.HeroSheet.SheetSkills.AddSkill(skill);
						}
						else
						{
							CurrentHeroSheet.HeroSheet.SheetSkills.RemoveSkill(skill);
						}
					}
					ShowHeroSheet();
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Событие на изменения статуса у checkedBox входящего в checkedListBox_Char_SkillsPossession
		/// </summary>
		/// <param name="sender">checkedListBox_Char_SkillsPossession.</param>
		/// <param name="e">SelectedItem.</param>
		private void checkedListBox_Char_SkillsPossession_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					CheckedListBox checkedListBox = (CheckedListBox)sender;
					//ItemCheckedEventArgs args = (ItemCheckedEventArgs)e;
					if (Enum.TryParse<EnumAllProficiencies>(checkedListBox.SelectedItem.ToString(), out EnumAllProficiencies skill))
					{
						if (checkedListBox.CheckedItems.Contains(checkedListBox.SelectedItem))
						{
							CurrentHeroSheet.HeroSheet.SheetProficiencies.AddProficiency(skill);
						}
						else
						{
							CurrentHeroSheet.HeroSheet.SheetProficiencies.RemoveProficiency(skill);
						}
						ShowHeroSheet();
					}
					else
					{
						MessageBox.Show("Неизвестный навык владения!");
					}
				}
				else
				{
					throw new Exception("Создайте или загрузите персонажа!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region Фабрики

		/// <summary>
		/// Возвращает от переданного numericUpDown за какую боевую характеристику он отвечает.
		/// </summary>
		/// <param name="numericUpDown">NumericUpDown.</param>
		/// <returns>Боевую характеристику из списка.</returns>
		/// <exception cref="NotImplementedException">Такой боевой характеристики не представлено в списке.</exception>
		private EnumCombatStats FabricCombatStats(NumericUpDown numericUpDown)
		{
			if(numericUpDown != null)
			{
				switch (numericUpDown.Name)
				{
					case "numericUpDown_Char_ArmorClass":
						return EnumCombatStats.ArmorClass;
					case "numericUpDown_Char_NowHP":
						return EnumCombatStats.CurrentHP;
					case "numericUpDown_Char_MaxHP":
						return EnumCombatStats.MaximumHP;
					case "numericUpDown_Char_TempHP":
						return EnumCombatStats.TemporaryHP;
					case "numericUpDown_Char_HowHitDice":
						return EnumCombatStats.CurrentHitDices;
					default:
						throw new NotImplementedException("Такой CombatStats не указано!");
				}
			}
			else
			{
				throw new ArgumentNullException("NumericUpDown был равен null");
			}
		}

		/// <summary>
		/// Возвращает от переданного TrackBar за какую боевую характеристику он отвечает.
		/// </summary>
		/// <param name="numericUpDown">TrackBar.</param>
		/// <returns>Боевую характеристику из списка.</returns>
		/// <exception cref="NotImplementedException">Такой боевой характеристики не представлено в списке.</exception>
		private EnumCombatStats FabricCombatStats(System.Windows.Forms.TrackBar TrackBar)
		{
			if(TrackBar != null)
			{
				switch (TrackBar.Name)
				{
					case "trackBar_Char_DeathSucces":
						return EnumCombatStats.DeathSucces;
					case "trackBar_Char_DeathFailure":
						return EnumCombatStats.DeathFailure;
					default:
						throw new NotImplementedException("Такой CombatStats не указано!");
				}
			}
			else
			{
				throw new ArgumentNullException("TrackBar был равен null");
			}
		}

		/// <summary>
		/// По названию NumericUpDown возвращает за какую характеристику он отвечает.
		/// </summary>
		/// <param name="nameNumericUpDown">NumericUpDown.</param>
		/// <returns>за какую характеристику NumericUpDown.</returns>
		/// <exception cref="NotImplementedException"></exception>
		private EnumAbilities FabricEnumAbilities(NumericUpDown nameNumericUpDown)
		{
			if(nameNumericUpDown != null)
			{
				switch (nameNumericUpDown.Name)
				{
					case "numericUpDown_Char_Strength":
						return EnumAbilities.Strength;
					case "numericUpDown_Char_Agility":
						return EnumAbilities.Agility;
					case "numericUpDown_Char_Physique":
						return EnumAbilities.Physique;
					case "numericUpDown_Char_Intelligence":
						return EnumAbilities.Intelligence;
					case "numericUpDown_Char_Wisdom":
						return EnumAbilities.Wisdom;
					case "numericUpDown_Char_Charisma":
						return EnumAbilities.Charisma;
					default:
						throw new NotImplementedException("Такой Abilities не указано!");
				}
			}
			else
			{
				throw new ArgumentNullException("NumericUpDown был равен null");
			}
		}

		/// <summary>
		/// Определяет в какой Label записывать полученный модификатор на скилл.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private void FabricPrintSkillsModification(EnumSkills skill, int ModificatoryAbiliti)
		{
			switch (skill)
			{
				case EnumSkills.Athletics:
					label_Char_Skills_Athletics.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Acrobatics:
					label_Char_Skills_Acrobatics.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Agulity:
					label_Char_Skills_Agulity.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Stealth:
					label_Char_Skills_Stealth.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Arcana:
					label_Char_Skills_Arcana.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.History:
					label_Char_Skills_History.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Investigation:
					label_Char_Skills_Investigation.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Nature:
					label_Char_Skills_Nature.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Religion:
					label_Char_Skills_Religion.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Animal:
					label_Char_Skills_Animal.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Insight:
					label_Char_Skills_Insight.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Medicine:
					label_Char_Skills_Medicine.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Perception:
					label_Char_Skills_Perception.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Surival:
					label_Char_Skills_Surival.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Deception:
					label_Char_Skills_Deception.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Intimidation:
					label_Char_Skills_Intimidation.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Perfomance:
					label_Char_Skills_Perfomance.Text = $"{ModificatoryAbiliti}";
					break;
				case EnumSkills.Persuasion:
					label_Char_Skills_Perception.Text = $"{ModificatoryAbiliti}";
					break;
			}
		}

		#endregion

		#region Методы для вывода информации

		/// <summary>
		/// Вывод загруженного персонажа на UI.
		/// </summary>
		private void ShowHeroSheet()
		{
			try
			{
				if (CurrentHeroSheet.HeroSheet.SheetRace != null || CurrentHeroSheet.HeroSheet.SheetRace != null)
				{
					PrintHeroInfo();
					PrintHeroProgression();
					PrintHeroCombatAbilities();
					PrintHeroHitDace();
					PrintHeroDeathDice();
					PrintHeroPersonality();
					PrintHeroCheckSkills();
					PrintHeroCharacteristics();
					PrintHeroAbilityModificator();
					PrintHeroSkillsPossession();
					PrintHeroSpell();
					PrintHeroInventory();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Выводит общую информацию о персонаже.
		/// </summary>
		private void PrintHeroInfo()
		{
			if (CurrentHeroSheet.HeroSheet != null)
			{
				label_Char_Name.Text = CurrentHeroSheet.HeroSheet.Name;
				label_Char_Race.Text = CurrentHeroSheet.HeroSheet.SheetRace.Name.ToString();
				label_Char_Class.Text = CurrentHeroSheet.HeroSheet.SheetClass.Name.ToString();
				label_Char_Background.Text = CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[EnumPersonalities.Background];
				label_Char_Alignment.Text = CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[EnumPersonalities.Alignment];
			}
			else
				throw new ArgumentNullException("Не выбран или не создан никакой персонаж.");
		}

		/// <summary>
		/// Выводит информацию о прогрессии текущего персонажа.
		/// </summary>
		private void PrintHeroProgression()
		{
			if (CurrentHeroSheet.HeroSheet.SheetProgression != null)
			{
				numericUpDown_Char_Level.Value = CurrentHeroSheet.HeroSheet.SheetProgression.Level;
				label_Char_Exp.Text = $"{CurrentHeroSheet.HeroSheet.SheetProgression.Expirience}";
				label_Char_ProficiencyBonus.Text = $"+{CurrentHeroSheet.HeroSheet.SheetProgression.GetProficiencyBonus()}";
				checkBox_Inspiration.Checked = CurrentHeroSheet.HeroSheet.Inspiration;
			}
			else
				throw new ArgumentNullException("Информация о прогрессии у текущего персонажа отсутсвует.");
		}

		/// <summary>
		/// Выводит боевые характеристики текущего персонажа.
		/// </summary>
		private void PrintHeroCombatAbilities()
		{
			if (CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats.Count != 0)
			{
				//Боевые харктеристики
				numericUpDown_Char_MaxHP.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.MaximumHP];
				numericUpDown_Char_NowHP.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.CurrentHP];
				numericUpDown_Char_TempHP.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.TemporaryHP];
				label_Char_Speed.Text = $"{CurrentHeroSheet.HeroSheet.SheetRace.Speed}";
				numericUpDown_Char_ArmorClass.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.ArmorClass];
			}
			else
				throw new ArgumentException("Списко CombatAbilities пуст.");
		}

		/// <summary>
		/// Выводит информацию о кости хитов. 
		/// </summary>
		private void PrintHeroHitDace()
		{
			if (CurrentHeroSheet.HeroSheet.SheetClass != null)
			{
				label_Char_HitDice.Text = $"{CurrentHeroSheet.HeroSheet.SheetClass.HitDice}";
				numericUpDown_Char_HowHitDice.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.CurrentHitDices];
			}
			else
				throw new ArgumentException("Класс у текущего персонажа не выбран.");
		}

		/// <summary>
		/// Выводит информацию о спасбросках. 
		/// </summary>
		private void PrintHeroDeathDice()
		{
			if (CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats.Count != 0)
			{
				trackBar_Char_DeathSucces.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.DeathSucces];
				trackBar_Char_DeathFailure.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStats.DeathFailure];
			}
			else
				throw new ArgumentException("Список CombatStats пуст.");
		}

		/// <summary>
		/// Выводит личные качества текущего персонажа.
		/// </summary>
		private void PrintHeroPersonality()
		{
			if (CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList.Count != 0)
			{
				listBox_List_Personality.Items.Clear();
				foreach (EnumPersonalities qualities in Enum.GetValues(typeof(EnumPersonalities)))
				{
					if (qualities!= EnumPersonalities.Background && qualities != EnumPersonalities.Alignment)
					{
            string info = CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[qualities];
            if (!string.IsNullOrEmpty(info))
              listBox_List_Personality.Items.Add($"{qualities}: {CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[qualities]}" + Environment.NewLine);
            else
              listBox_List_Personality.Items.Add($"{qualities}: Неизвестно" + Environment.NewLine);
          }
				}
			}
			else
				throw new ArgumentException("Список Personality пуст.");
		}

		/// <summary>
		/// Выводит умения текущего персонажа.
		/// </summary>
		private void PrintHeroCheckSkills()
		{
			for (int i = 0; i < checkedListBox_Skills.Items.Count; i++)
			{
				checkedListBox_Skills.SetItemChecked(i, false);
			}
			int ModificatoryAbiliti = 0;
			for (int i = 0; i < checkedListBox_Skills.Items.Count; i++)
			{
				if (Enum.TryParse<EnumSkills>(checkedListBox_Skills.Items[i].ToString(), out EnumSkills skill))
				{
					ModificatoryAbiliti = CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(CurrentHeroSheet.HeroSheet.SheetSkills.SkillAbilityName(skill));
					if (CurrentHeroSheet.HeroSheet.SheetSkills.CheckSkill(skill))
					{
						checkedListBox_Skills.SetItemChecked(i, true);
						ModificatoryAbiliti += 2;
					}
				}
				FabricPrintSkillsModification(skill, ModificatoryAbiliti);
			}
		}

		/// <summary>
		/// Выводит характеристики текущего персонажа на UI.
		/// </summary>
		private void PrintHeroCharacteristics()
		{
			if (CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities.Count != 0)
			{
				numericUpDown_Char_Strength.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilities.Strength];
				numericUpDown_Char_Agility.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilities.Agility];
				numericUpDown_Char_Physique.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilities.Physique];
				numericUpDown_Char_Intelligence.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilities.Intelligence];
				numericUpDown_Char_Wisdom.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilities.Wisdom];
				numericUpDown_Char_Charisma.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilities.Charisma];
			}
			else
				throw new ArgumentException("Список Abilities пуст.");
		}

		/// <summary>
		/// Выводит модификаторы текущего персонажа.
		/// </summary>
		private void PrintHeroAbilityModificator()
		{
			if (CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities.Count != 0)
			{
				label_Char_Strength_Master.Text = $"{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Strength)}";
				label_Char_Agility_Master.Text = $"{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Agility)}";
				label_Char_Physique_Master.Text = $"{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Physique)}";
				label_Char_Intelligence_Master.Text = $"{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Intelligence)}";
				label_Char_Wisdom_Master.Text = $"{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Wisdom)}";
				label_Char_Charisma_Master.Text = $"{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Charisma)}";
			}
			else
				throw new ArgumentException("Список Abilities пуст. Модификаторы получить не удалось.");
		}

		/// <summary>
		/// Заполняет список навыками владения загруженного персонажа.
		/// </summary>
		private void PrintHeroSkillsPossession()
		{
			for (int i = 0; i < checkedListBox_Char_SkillsPossession.Items.Count; i++)
			{
				checkedListBox_Char_SkillsPossession.SetItemChecked(i, false);
			}
			checkedListBox_Char_SkillsPossession.DataSource = Enum.GetNames(typeof(EnumAllProficiencies));
			for (int i = 0; i < checkedListBox_Char_SkillsPossession.Items.Count; i++)
			{
				if (Enum.TryParse<EnumAllProficiencies>(checkedListBox_Char_SkillsPossession.Items[i].ToString(), out EnumAllProficiencies skill) &&
					CurrentHeroSheet.HeroSheet.SheetProficiencies.CheckProficiency(skill))
				{
					checkedListBox_Char_SkillsPossession.SetItemChecked(i, true);
				}
			}
		}

		/// <summary>
		/// Выводит инвентарь перснонажа.
		/// </summary>
		private void PrintHeroInventory()
		{
			listView_Char_inventory_Weapon.Items.Clear();
			listView_Char_inventory_Armor.Items.Clear();
			listView_Char_inventory_item.Items.Clear();
			foreach (var item in CurrentHeroSheet.HeroSheet.SheetInventory.Inventory)
			{
				string[] row;
				if (ItemsDataBase.ItemsDB.ContainsKey(item.Key) && ItemsDataBase.ItemsDB.TryGetValue(item.Key, out ItemBase Item))
				{
					if (EnumItemTypes.Weapon.Equals(Item.ItemType))
					{
						ItemWeapon weapon = (ItemWeapon)Item;
						row = new string[]
						{
							weapon.Name,
							Enum.GetName(weapon.Rarity),
							weapon.DamageType.ToString(),
							weapon.DamageDiceCount.ToString() + Enum.GetName(weapon.DamageDiceValue)
							+ "+" + weapon.DamageModificator.ToString(),
							weapon.BaseCost.ToString(),
							weapon.IsMagic.ToString()
						};
						listView_Char_inventory_Weapon.Items.Add(new ListViewItem(row));
					}
					if (EnumItemTypes.Armor.Equals(Item.ItemType))
					{
						ItemArmor armor = (ItemArmor)Item;
						row = new string[]
						{
							armor.Name,
							Enum.GetName(armor.Rarity),
							Enum.GetName(armor.ArmorType),
							armor.ArmorClass.ToString(),
							armor.StrengthRequirement.ToString(),
							armor.MaxAgilityBonus.ToString(),
							armor.BaseCost.ToString(),
							armor.IsMagic.ToString()
						};
						listView_Char_inventory_Armor.Items.Add(new ListViewItem(row));
					}
					if (EnumItemTypes.Item.Equals(Item.ItemType))
					{
						ItemRegular regular = (ItemRegular)Item;
						row = new string[]
						{
							regular.Name,
							Enum.GetName(regular.Rarity),
							regular.BaseCost.ToString(),
							regular.IsMagic.ToString()
						};
						listView_Char_inventory_item.Items.Add(new ListViewItem(row));
					}
				}
				else
				{
					MessageBox.Show("В инвенторе найден не существующий предмет, он будет удален");
					CurrentHeroSheet.HeroSheet.SheetInventory.Inventory.Remove(item.Key);
				}
			}
		}

		/// <summary>
		/// Выводит базу данных предметов.
		/// </summary>
		private void ShowDBItems()
		{
			List<ItemBase> list = new List<ItemBase>();
			if (comboBox_TypeItemForSearch.Text != "All" || textBox_Name_ItemForSearch.Text.Length > 0)
			{
				if (Enum.TryParse<EnumItemTypes>(comboBox_TypeItemForSearch.Text, out EnumItemTypes type1) && textBox_Name_ItemForSearch.Text.Length > 0)
				{
					list = ItemsDataBase.ItemsDB.Values.Where((row) =>
					row.ItemType == type1 &&
					row.Name.ToLower().Contains((textBox_Name_ItemForSearch.Text).ToLower()))
						.ToList();
				}
				else if (Enum.TryParse<EnumItemTypes>(comboBox_TypeItemForSearch.Text, out EnumItemTypes type2))
				{
					list = ItemsDataBase.ItemsDB.Values.Where((row) =>
						row.ItemType == type1)
							.ToList();
				}
				else if (textBox_Name_ItemForSearch.Text.Length > 0)
				{
					list = ItemsDataBase.ItemsDB.Values.Where((row) =>
						row.Name.ToLower().Contains((textBox_Name_ItemForSearch.Text).ToLower()))
							.ToList();
				}
				PrintDBItems(list);
			}
			else
			{
				list = ItemsDataBase.ItemsDB.Values.ToList();
				PrintDBItems(list);
			}
		}

		/// <summary>
		/// Выводит переданный список предметов.
		/// </summary>
		/// <param name="items">Списиок предметов.</param>
		public void PrintDBItems(List<ItemBase> items)
		{
			listView_DB_inventory.Items.Clear();
			listView_DB_inventory.Items.Add(new ListViewItem(""));
			foreach (ItemBase item in items)
			{
				string[] row =
				{
					item.ItemId.ToString(),
					item.Name.ToString(),
					item.ItemType.ToString()
				};
				listView_DB_inventory.Items.Add(new ListViewItem(row));
			}
		}

		/// <summary>
		/// Выводит список атак и заклинаний.
		/// </summary>
		/// <exception cref="ArgumentException"></exception>
		private void PrintHeroSpell()
		{
			listView_Char_AttacksAndSpells.Clear();
			listView_Char_AttacksAndSpells.Items.Add(new ListViewItem(""));
			string[] row;
			try
			{
				foreach (var spellID in CurrentHeroSheet.HeroSheet.SheetSpells.SheetSpells.Keys)
				{
					if (SpellsDataBase.SpellsDB.ContainsKey(spellID))
					{
						if (SpellsDataBase.SpellsDB.TryGetValue(spellID, out SpellBase spell))
						{
							int BonusAtack;
							if (Enum.TryParse<EnumAbilities>(spell.FromСharacteristic, out EnumAbilities abiliti))
								BonusAtack = CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(abiliti);
							else
								BonusAtack = 0;
							if (spell.UseMasterBonus)
								BonusAtack += CurrentHeroSheet.HeroSheet.SheetProgression.GetProficiencyBonus();
							row =
							[
								spell.Id.ToString(),
								spell.Name,
								$"{spell.AdditionalModifiers + BonusAtack}",
								spell.DamageType
							];
							listView_Char_AttacksAndSpells.Items.Add(new ListViewItem(row));
						}
						else
						{
							throw new ArgumentException("С заклинанием что то не так!");
						}
					}
					else
					{
						throw new ArgumentException("Такого заклинание еще нету в БД");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Выводит базу с заклинаниями.
		/// </summary>
		private void PrintDBSpell(List<SpellBase> spells)
		{
			if (spells.Any())
			{
				listView_SpellDB.Items.Clear();
				listView_SpellDB.Items.Add(new ListViewItem(""));
				foreach (var spell in spells)
				{
					string[] row =
						[
						spell.Id.ToString(),
						spell.Name,
						spell.Level.ToString(),
						spell.DamageType
						];
					listView_SpellDB.Items.Add(new ListViewItem(row));
				}
			}
		}

		#endregion

		#endregion

		#region Конструкторы

		public StartForms()
		{
			InitializeComponent();
		}

		#endregion
	}
}
