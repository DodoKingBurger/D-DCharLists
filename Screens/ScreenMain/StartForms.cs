using D_DCharList;
using D_DCharList.Modules;
using D_DCharLists.Screens.ScreenMain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace D_DCharLists
{
	public partial class StartForms : Form
	{
		#region Поля и свойства

		/// <summary>
		/// Ининициализатор.
		/// </summary>
		Initialize initialize;

		/// <summary>
		/// Форма дял создания персонажа.
		/// </summary>
		CreateChar createChar;

		#endregion

		#region Методы

		/// <summary>
		/// Момент загрузки формы.
		/// </summary>
		/// <param name="sender">Форма.</param>
		/// <param name="e">Событие загрузки.</param>
		private void StartForms_Load(object sender, EventArgs e)
		{
			HeroDataBase.ShowHero += ShowHeroSheet;
			initialize = new Initialize();
			initialize.Start();
		}

		/// <summary>
		/// Вызывает окно создания персонажа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btCreateChar_Click(object sender, EventArgs e)
		{
			createChar = new CreateChar();
			createChar.ShowDialog();
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
		/// Загрузить выбранного в comboBox_Loading_Char персонажа 
		/// в текущего персонажа. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bt_Load_Char_Click(object sender, EventArgs e)
		{
			HeroDataBase.LoadHerosBase(comboBox_Loading_Char.SelectedItem.ToString());
		}

		/// <summary>
		/// Вывод загруженного персонажа на UI.
		/// </summary>
		private void ShowHeroSheet()
		{
			if (CurrentHeroSheet.HeroSheet != null)
			{
				PrintInfoHero();
				PrintProgression();
				PrintCombatAbilities();
				PrintHitDace();
				PrintDeathDice();
				PrintPersonality();
				PrintSkills();
				PrintCharacteristics();
				PrintAbilityModificator();
				//Навыки владения
				//Атаки и заклинания
			}
			else
			{
				throw new ArgumentNullException("Персонаж не был создан ил загружен!");
			}
		}

		/// <summary>
		/// Выводит общую информацию о персонаже.
		/// </summary>
		private void PrintInfoHero()
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
		private void PrintProgression()
		{
			if (CurrentHeroSheet.HeroSheet.SheetProgression != null)
			{
				numericUpDown_Char_Level.Value = CurrentHeroSheet.HeroSheet.SheetProgression.Level;
				label_Char_Exp.Text = $"{CurrentHeroSheet.HeroSheet.SheetProgression.Expirience}";
				label_Char_ProficiencyBonus.Text = $"{CurrentHeroSheet.HeroSheet.SheetProgression.GetProficiencyBonus}";
				checkBox_Inspiration.Checked = CurrentHeroSheet.HeroSheet.Inspiration;
			}
			else
				throw new ArgumentNullException("Информация о прогрессии у текущего персонажа отсутсвует.");
		}

		/// <summary>
		/// Выводит боевые характеристики текущего персонажа.
		/// </summary>
		private void PrintCombatAbilities()
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
		private void PrintHitDace()
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
		private void PrintDeathDice()
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
		private void PrintPersonality()
		{
			if (CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList.Count != 0)
			{
				listBox_List_Personality.Items.Clear();
				foreach (EnumPersonalities qualities in Enum.GetValues(typeof(EnumPersonalities)))
				{
					string info = CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[qualities];
					if (!string.IsNullOrEmpty(info))
						listBox_List_Personality.Items.Add($"{qualities}: {CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[qualities]}" + Environment.NewLine);
					else
						listBox_List_Personality.Items.Add($"{qualities}: Неизвестно" + Environment.NewLine);
				}
			}
			else
				throw new ArgumentException("Список Personality пуст.");
		}

		/// <summary>
		/// Выводит умения текущего персонажа.
		/// </summary>
		private void PrintSkills()
		{
			for (int i = 0; i < checkedListBox_Skills.Items.Count; i++)
			{
				checkedListBox_Skills.SetItemChecked(i, false);
			}
			if (CurrentHeroSheet.HeroSheet.SheetSkills.Skills.Count != 0)
			{
				for (int i = 0; i < checkedListBox_Skills.Items.Count; i++)
				{
					if (Enum.TryParse<EnumSkills>(checkedListBox_Skills.Items[i].ToString(), out EnumSkills result))
					{
						if (CurrentHeroSheet.HeroSheet.SheetSkills.CheckSkill(result))
						{
							checkedListBox_Skills.SetItemChecked(i, true);
						}
					}
				}
			}
			else
				throw new ArgumentException("Список Skills пуст.");
		}

		/// <summary>
		/// Выводит характеристики текущего персонажа на UI.
		/// </summary>
		private void PrintCharacteristics()
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
		private void PrintAbilityModificator()
		{
			if (CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities.Count != 0)
			{
				label_Char_Strength_Master.Text = $"+{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Strength)}";
				label_Char_Agility_Master.Text = $"+{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Agility)}";
				label_Char_Physique_Master.Text = $"+{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Physique)}";
				label_Char_Intelligence_Master.Text = $"+{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Intelligence)}";
				label_Char_Wisdom_Master.Text = $"+{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Wisdom)}";
				label_Char_Charisma_Master.Text = $"+{CurrentHeroSheet.HeroSheet.SheetAbilities.GetAbilityModificator(EnumAbilities.Charisma)}";
			}
			else
				throw new ArgumentException("Список Abilities пуст. Модификаторы получить не удалось.");
		}

		/// <summary>
		/// Сохранить персонажа .json.
		/// </summary>
		/// <param name="sender">Кнопка.</param>
		/// <param name="e">Клик.</param>
		/// <exception cref="ArgumentNullException">Персонаж не был создан или загружен.</exception>
		private void bt_SaveChar_Click(object sender, EventArgs e)
		{
			if (CurrentHeroSheet.HeroSheet != null)
				CurrentHeroSheet.SaveSheet();
			else
				throw new ArgumentNullException("Персонаж не выбран!");
		}
		#endregion

		#region Конструкторы

		public StartForms()
		{
			InitializeComponent();
		}

		#endregion
	}
}
