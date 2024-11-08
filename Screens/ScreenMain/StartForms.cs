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
		/// 
		/// </summary>
		Initialize initialize;

		/// <summary>
		/// Форма создания персонажа.
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
		/// Вывод загруженного персонажа на UI.
		/// </summary>
		public void ShowHeroSheet()
		{
			if (CurrentHeroSheet.HeroSheet != null)
			{
				//Персонаж
				label_Char_Name.Text = CurrentHeroSheet.HeroSheet.Name;
				label_Char_Race.Text = CurrentHeroSheet.HeroSheet.SheetRace.Name.ToString();
				label_Char_Class.Text = CurrentHeroSheet.HeroSheet.SheetClass.Name.ToString();
				label_Char_Background.Text = CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[EnumPersonalitiesDND5E.Background];
				label_Char_Alignment.Text = CurrentHeroSheet.HeroSheet.SheetPersonality.PersonalityList[EnumPersonalitiesDND5E.Alignment];
				//Прогрессия
				numericUpDown_Char_Level.Value = CurrentHeroSheet.HeroSheet.SheetProgression.Level;
				label_Char_Exp.Text = $"{CurrentHeroSheet.HeroSheet.SheetProgression.Expirience}";
				label_Char_ProficiencyBonus.Text = $"{CurrentHeroSheet.HeroSheet.SheetProgression.GetProficiencyBonus}";
				checkBox_Inspiration.Checked = CurrentHeroSheet.HeroSheet.Inspiration;
				//Боевые харктеристики
				numericUpDown_Char_MaxHP.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.MaximumHP];
				numericUpDown_Char_NowHP.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.CurrentHP];
				numericUpDown_Char_TempHP.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.TemporaryHP];
				label_Char_Speed.Text = $"{CurrentHeroSheet.HeroSheet.SheetRace.Speed}";
				numericUpDown_Char_ArmorClass.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.ArmorClass];
				//Кости хитов.
				label_Char_HitDice.Text = $"{CurrentHeroSheet.HeroSheet.SheetClass.HitDice}";
				numericUpDown_Char_HowHitDice.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.CurrentHitDices];
				//Характеристики.
				numericUpDown_Char_Strength.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilitiesDnd5E.Strength];
				numericUpDown_Char_Agility.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilitiesDnd5E.Agility];
				numericUpDown_Char_Physique.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilitiesDnd5E.Physique];
				numericUpDown_Char_Intelligence.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilitiesDnd5E.Intelligence];
				numericUpDown_Char_Wisdom.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilitiesDnd5E.Wisdom];
				numericUpDown_Char_Charisma.Value = CurrentHeroSheet.HeroSheet.SheetAbilities.Abilities[EnumAbilitiesDnd5E.Charisma];
				//Спасброски
				trackBar_Char_DeathSucces.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.DeathSucces];
				trackBar_Char_DeathFailure.Value = CurrentHeroSheet.HeroSheet.SheetCombatAbilities.CombatStats[EnumCombatStatsDND5e.DeathFailure];
			}
			else
			{
				throw new ArgumentNullException("Персонаж не был создан ил загружен!");
			}
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
