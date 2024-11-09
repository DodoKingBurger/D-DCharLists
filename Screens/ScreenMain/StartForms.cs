using D_DCharList;
using D_DCharList.Modules;
using D_DCharLists.Screens.ScreenMain;
using static System.Windows.Forms.CheckedListBox;
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
      if (comboBox_Loading_Char.SelectedItem != null)
        HeroDataBase.LoadHerosBase(comboBox_Loading_Char.SelectedItem.ToString());
      else
        MessageBox.Show("Выберите или создайте персонажа!");
    }

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

    /// <summary>
    /// Повышение или понижение уровня персонажа.
    /// </summary>
    /// <param name="sender">numericUpDown_Char_Level.</param>
    /// <param name="e">Изменение Value у numericUpDown</param>
    private void numericUpDown_Char_Level_ValueChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Изменение параметров персонажа.
    /// </summary>
    /// <param name="sender">NumericUpDown.</param>
    /// <param name="e">Событие по изменению параметра.</param>
    private void numericUpDown_Char_Characteristics_ValueChanged(object sender, EventArgs e)
    {
      NumericUpDown numericUpDown = (NumericUpDown)sender;
      CurrentHeroSheet.HeroSheet.SheetAbilities.ChangeAbilityScore(FabricEnumAbilities(numericUpDown), (int)numericUpDown.Value);
      ShowHeroSheet();
    }

    /// <summary>
    /// Событие на изменения статуса у checkedBox входящего в checkedListBox_Skills
    /// </summary>
    /// <param name="sender">checkedListBox_Skills.</param>
    /// <param name="e">SelectedItem.</param>
    private void checkedListBox_Skills_SelectedIndexChanged(object sender, EventArgs e)
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

    /// <summary>
    /// Возвращает от переданного TrackBar за какую боевую характеристику он отвечает.
    /// </summary>
    /// <param name="numericUpDown">TrackBar.</param>
    /// <returns>Боевую характеристику из списка.</returns>
    /// <exception cref="NotImplementedException">Такой боевой характеристики не представлено в списке.</exception>
    private EnumCombatStats FabricCombatStats(System.Windows.Forms.TrackBar TrackBar)
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


    /// <summary>
    /// По названию NumericUpDown возвращает за какую характеристику он отвечает.
    /// </summary>
    /// <param name="nameNumericUpDown">NumericUpDown.</param>
    /// <returns>за какую характеристику NumericUpDown.</returns>
    /// <exception cref="NotImplementedException"></exception>
    private EnumAbilities FabricEnumAbilities(NumericUpDown nameNumericUpDown)
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
        if (CurrentHeroSheet.HeroSheet != null)
        {
          PrintInfoHero();
          PrintProgression();
          PrintCombatAbilities();
          PrintHitDace();
          PrintDeathDice();
          PrintPersonality();
          PrintCheckSkills();
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
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
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
        label_Char_ProficiencyBonus.Text = $"+{CurrentHeroSheet.HeroSheet.SheetProgression.GetProficiencyBonus()}";
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
    private void PrintCheckSkills()
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

    #endregion

    #region Конструкторы

    public StartForms()
    {
      InitializeComponent();
    }

    #endregion
  }
}
