namespace D_DCharLists.Screens.ScreenMain
{
	partial class CreateChar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChar));
			tabControlCreateChar = new TabControl();
			tabPage_Name = new TabPage();
			label_Name_Name = new Label();
			textBox_NameChar = new TextBox();
			tabPage_Race = new TabPage();
			panel_ChoiceRace = new Panel();
			radioButton_Elf = new RadioButton();
			radioButton_HalfElf = new RadioButton();
			radioButton_Tiefling = new RadioButton();
			radioButton_Halfling = new RadioButton();
			radioButton_Human = new RadioButton();
			radioButton_Halforc = new RadioButton();
			radioButton_Dragonborn = new RadioButton();
			radioButton_Dwarf = new RadioButton();
			radioButton_Gnom = new RadioButton();
			label_Race_Race = new Label();
			tabPage_Class = new TabPage();
			label_Class_Class = new Label();
			panel_ChoiceClass = new Panel();
			radioButton_Wizard = new RadioButton();
			radioButton_Warlock = new RadioButton();
			radioButton_Sorcerer = new RadioButton();
			radioButton_Rogue = new RadioButton();
			radioButton_Monk = new RadioButton();
			radioButton_Paladin = new RadioButton();
			radioButton_Fighter = new RadioButton();
			radioButton_Ranger = new RadioButton();
			radioButton_Druid = new RadioButton();
			radioButton_Cleric = new RadioButton();
			radioButton_Bard = new RadioButton();
			radioButton_Barbarian = new RadioButton();
			tabPage_Skill = new TabPage();
			label_Skill_Skill = new Label();
			panel_ChoiceSkill = new Panel();
			checkedListBox_Skills = new CheckedListBox();
			tabPage_Abilities = new TabPage();
			label_Abilities_Abilities = new Label();
			panel_Abilities = new Panel();
			numericUpDown_Charisma = new NumericUpDown();
			numericUpDown_Wisdom = new NumericUpDown();
			numericUpDown_Intelligence = new NumericUpDown();
			numericUpDown_Agility = new NumericUpDown();
			numericUpDown_Physique = new NumericUpDown();
			numericUpDown_Strength = new NumericUpDown();
			label_Charisma = new Label();
			label_Wisdom = new Label();
			label_Intelligence = new Label();
			label_Physique = new Label();
			label_Agility = new Label();
			label_Strength = new Label();
			button_Save_Char = new Button();
			tabControlCreateChar.SuspendLayout();
			tabPage_Name.SuspendLayout();
			tabPage_Race.SuspendLayout();
			panel_ChoiceRace.SuspendLayout();
			tabPage_Class.SuspendLayout();
			panel_ChoiceClass.SuspendLayout();
			tabPage_Skill.SuspendLayout();
			panel_ChoiceSkill.SuspendLayout();
			tabPage_Abilities.SuspendLayout();
			panel_Abilities.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Charisma).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Wisdom).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Intelligence).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Agility).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Physique).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Strength).BeginInit();
			SuspendLayout();
			// 
			// tabControlCreateChar
			// 
			tabControlCreateChar.Controls.Add(tabPage_Name);
			tabControlCreateChar.Controls.Add(tabPage_Race);
			tabControlCreateChar.Controls.Add(tabPage_Class);
			tabControlCreateChar.Controls.Add(tabPage_Skill);
			tabControlCreateChar.Controls.Add(tabPage_Abilities);
			tabControlCreateChar.Dock = DockStyle.Top;
			tabControlCreateChar.Location = new Point(0, 0);
			tabControlCreateChar.Margin = new Padding(2);
			tabControlCreateChar.Name = "tabControlCreateChar";
			tabControlCreateChar.SelectedIndex = 0;
			tabControlCreateChar.Size = new Size(434, 550);
			tabControlCreateChar.TabIndex = 0;
			// 
			// tabPage_Name
			// 
			tabPage_Name.BackgroundImageLayout = ImageLayout.Center;
			tabPage_Name.Controls.Add(label_Name_Name);
			tabPage_Name.Controls.Add(textBox_NameChar);
			tabPage_Name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tabPage_Name.Location = new Point(4, 24);
			tabPage_Name.Margin = new Padding(2);
			tabPage_Name.Name = "tabPage_Name";
			tabPage_Name.Padding = new Padding(2);
			tabPage_Name.Size = new Size(426, 522);
			tabPage_Name.TabIndex = 0;
			tabPage_Name.Text = "Имя";
			tabPage_Name.UseVisualStyleBackColor = true;
			// 
			// label_Name_Name
			// 
			label_Name_Name.AutoSize = true;
			label_Name_Name.Location = new Point(12, 10);
			label_Name_Name.Margin = new Padding(2, 0, 2, 0);
			label_Name_Name.Name = "label_Name_Name";
			label_Name_Name.Size = new Size(288, 32);
			label_Name_Name.TabIndex = 1;
			label_Name_Name.Text = "Введите имя персонажа:";
			// 
			// textBox_NameChar
			// 
			textBox_NameChar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBox_NameChar.Location = new Point(12, 46);
			textBox_NameChar.Margin = new Padding(2);
			textBox_NameChar.Name = "textBox_NameChar";
			textBox_NameChar.Size = new Size(302, 39);
			textBox_NameChar.TabIndex = 0;
			textBox_NameChar.TextChanged += textBox_NameChar_TextChanged;
			// 
			// tabPage_Race
			// 
			tabPage_Race.BackgroundImageLayout = ImageLayout.Center;
			tabPage_Race.Controls.Add(panel_ChoiceRace);
			tabPage_Race.Controls.Add(label_Race_Race);
			tabPage_Race.Location = new Point(4, 24);
			tabPage_Race.Margin = new Padding(2);
			tabPage_Race.Name = "tabPage_Race";
			tabPage_Race.Padding = new Padding(2);
			tabPage_Race.Size = new Size(426, 522);
			tabPage_Race.TabIndex = 1;
			tabPage_Race.Text = "Расса";
			tabPage_Race.UseVisualStyleBackColor = true;
			// 
			// panel_ChoiceRace
			// 
			panel_ChoiceRace.Controls.Add(radioButton_Elf);
			panel_ChoiceRace.Controls.Add(radioButton_HalfElf);
			panel_ChoiceRace.Controls.Add(radioButton_Tiefling);
			panel_ChoiceRace.Controls.Add(radioButton_Halfling);
			panel_ChoiceRace.Controls.Add(radioButton_Human);
			panel_ChoiceRace.Controls.Add(radioButton_Halforc);
			panel_ChoiceRace.Controls.Add(radioButton_Dragonborn);
			panel_ChoiceRace.Controls.Add(radioButton_Dwarf);
			panel_ChoiceRace.Controls.Add(radioButton_Gnom);
			panel_ChoiceRace.Dock = DockStyle.Bottom;
			panel_ChoiceRace.Location = new Point(2, 39);
			panel_ChoiceRace.Margin = new Padding(2);
			panel_ChoiceRace.Name = "panel_ChoiceRace";
			panel_ChoiceRace.Size = new Size(422, 481);
			panel_ChoiceRace.TabIndex = 10;
			// 
			// radioButton_Elf
			// 
			radioButton_Elf.AutoSize = true;
			radioButton_Elf.Font = new Font("Segoe UI", 18F);
			radioButton_Elf.Location = new Point(16, 296);
			radioButton_Elf.Margin = new Padding(2);
			radioButton_Elf.Name = "radioButton_Elf";
			radioButton_Elf.Size = new Size(58, 36);
			radioButton_Elf.TabIndex = 17;
			radioButton_Elf.TabStop = true;
			radioButton_Elf.Text = "Elf";
			radioButton_Elf.UseVisualStyleBackColor = true;
			radioButton_Elf.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_HalfElf
			// 
			radioButton_HalfElf.AutoSize = true;
			radioButton_HalfElf.Font = new Font("Segoe UI", 18F);
			radioButton_HalfElf.Location = new Point(16, 191);
			radioButton_HalfElf.Margin = new Padding(2);
			radioButton_HalfElf.Name = "radioButton_HalfElf";
			radioButton_HalfElf.Size = new Size(102, 36);
			radioButton_HalfElf.TabIndex = 16;
			radioButton_HalfElf.TabStop = true;
			radioButton_HalfElf.Text = "Halfelf";
			radioButton_HalfElf.UseVisualStyleBackColor = true;
			radioButton_HalfElf.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Tiefling
			// 
			radioButton_Tiefling.AutoSize = true;
			radioButton_Tiefling.Font = new Font("Segoe UI", 18F);
			radioButton_Tiefling.Location = new Point(16, 226);
			radioButton_Tiefling.Margin = new Padding(2);
			radioButton_Tiefling.Name = "radioButton_Tiefling";
			radioButton_Tiefling.Size = new Size(112, 36);
			radioButton_Tiefling.TabIndex = 15;
			radioButton_Tiefling.TabStop = true;
			radioButton_Tiefling.Text = "Tiefling";
			radioButton_Tiefling.UseVisualStyleBackColor = true;
			radioButton_Tiefling.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Halfling
			// 
			radioButton_Halfling.AutoSize = true;
			radioButton_Halfling.Font = new Font("Segoe UI", 18F);
			radioButton_Halfling.Location = new Point(16, 154);
			radioButton_Halfling.Margin = new Padding(2);
			radioButton_Halfling.Name = "radioButton_Halfling";
			radioButton_Halfling.Size = new Size(115, 36);
			radioButton_Halfling.TabIndex = 14;
			radioButton_Halfling.TabStop = true;
			radioButton_Halfling.Text = "Halfling";
			radioButton_Halfling.UseVisualStyleBackColor = true;
			radioButton_Halfling.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Human
			// 
			radioButton_Human.AutoSize = true;
			radioButton_Human.Font = new Font("Segoe UI", 18F);
			radioButton_Human.Location = new Point(16, 261);
			radioButton_Human.Margin = new Padding(2);
			radioButton_Human.Name = "radioButton_Human";
			radioButton_Human.Size = new Size(110, 36);
			radioButton_Human.TabIndex = 13;
			radioButton_Human.TabStop = true;
			radioButton_Human.Text = "Human";
			radioButton_Human.UseVisualStyleBackColor = true;
			radioButton_Human.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Halforc
			// 
			radioButton_Halforc.AutoSize = true;
			radioButton_Halforc.Font = new Font("Segoe UI", 18F);
			radioButton_Halforc.Location = new Point(16, 119);
			radioButton_Halforc.Margin = new Padding(2);
			radioButton_Halforc.Name = "radioButton_Halforc";
			radioButton_Halforc.Size = new Size(108, 36);
			radioButton_Halforc.TabIndex = 12;
			radioButton_Halforc.TabStop = true;
			radioButton_Halforc.Text = "Halforc";
			radioButton_Halforc.UseVisualStyleBackColor = true;
			radioButton_Halforc.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Dragonborn
			// 
			radioButton_Dragonborn.AutoSize = true;
			radioButton_Dragonborn.Font = new Font("Segoe UI", 18F);
			radioButton_Dragonborn.Location = new Point(16, 85);
			radioButton_Dragonborn.Margin = new Padding(2);
			radioButton_Dragonborn.Name = "radioButton_Dragonborn";
			radioButton_Dragonborn.Size = new Size(161, 36);
			radioButton_Dragonborn.TabIndex = 11;
			radioButton_Dragonborn.TabStop = true;
			radioButton_Dragonborn.Text = "Dragonborn";
			radioButton_Dragonborn.UseVisualStyleBackColor = true;
			radioButton_Dragonborn.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Dwarf
			// 
			radioButton_Dwarf.AutoSize = true;
			radioButton_Dwarf.Font = new Font("Segoe UI", 18F);
			radioButton_Dwarf.Location = new Point(16, 50);
			radioButton_Dwarf.Margin = new Padding(2);
			radioButton_Dwarf.Name = "radioButton_Dwarf";
			radioButton_Dwarf.Size = new Size(94, 36);
			radioButton_Dwarf.TabIndex = 10;
			radioButton_Dwarf.TabStop = true;
			radioButton_Dwarf.Text = "Dwarf";
			radioButton_Dwarf.UseVisualStyleBackColor = true;
			radioButton_Dwarf.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// radioButton_Gnom
			// 
			radioButton_Gnom.AutoSize = true;
			radioButton_Gnom.Font = new Font("Segoe UI", 18F);
			radioButton_Gnom.Location = new Point(16, 15);
			radioButton_Gnom.Margin = new Padding(2);
			radioButton_Gnom.Name = "radioButton_Gnom";
			radioButton_Gnom.Size = new Size(97, 36);
			radioButton_Gnom.TabIndex = 9;
			radioButton_Gnom.TabStop = true;
			radioButton_Gnom.Text = "Gnom";
			radioButton_Gnom.UseVisualStyleBackColor = true;
			radioButton_Gnom.CheckedChanged += radioButton_ChoiceRace_CheckedChanged;
			// 
			// label_Race_Race
			// 
			label_Race_Race.AutoSize = true;
			label_Race_Race.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Race_Race.Location = new Point(6, 13);
			label_Race_Race.Margin = new Padding(2, 0, 2, 0);
			label_Race_Race.Name = "label_Race_Race";
			label_Race_Race.Size = new Size(308, 32);
			label_Race_Race.TabIndex = 9;
			label_Race_Race.Text = "Выберите рассу из списка:";
			// 
			// tabPage_Class
			// 
			tabPage_Class.BackgroundImageLayout = ImageLayout.Center;
			tabPage_Class.Controls.Add(label_Class_Class);
			tabPage_Class.Controls.Add(panel_ChoiceClass);
			tabPage_Class.Location = new Point(4, 24);
			tabPage_Class.Margin = new Padding(2);
			tabPage_Class.Name = "tabPage_Class";
			tabPage_Class.Size = new Size(426, 522);
			tabPage_Class.TabIndex = 2;
			tabPage_Class.Text = "Класс";
			tabPage_Class.UseVisualStyleBackColor = true;
			// 
			// label_Class_Class
			// 
			label_Class_Class.AutoSize = true;
			label_Class_Class.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Class_Class.Location = new Point(6, 10);
			label_Class_Class.Margin = new Padding(2, 0, 2, 0);
			label_Class_Class.Name = "label_Class_Class";
			label_Class_Class.Size = new Size(307, 32);
			label_Class_Class.TabIndex = 12;
			label_Class_Class.Text = "Выберите класс из списка:";
			// 
			// panel_ChoiceClass
			// 
			panel_ChoiceClass.Controls.Add(radioButton_Wizard);
			panel_ChoiceClass.Controls.Add(radioButton_Warlock);
			panel_ChoiceClass.Controls.Add(radioButton_Sorcerer);
			panel_ChoiceClass.Controls.Add(radioButton_Rogue);
			panel_ChoiceClass.Controls.Add(radioButton_Monk);
			panel_ChoiceClass.Controls.Add(radioButton_Paladin);
			panel_ChoiceClass.Controls.Add(radioButton_Fighter);
			panel_ChoiceClass.Controls.Add(radioButton_Ranger);
			panel_ChoiceClass.Controls.Add(radioButton_Druid);
			panel_ChoiceClass.Controls.Add(radioButton_Cleric);
			panel_ChoiceClass.Controls.Add(radioButton_Bard);
			panel_ChoiceClass.Controls.Add(radioButton_Barbarian);
			panel_ChoiceClass.Dock = DockStyle.Bottom;
			panel_ChoiceClass.Location = new Point(0, 36);
			panel_ChoiceClass.Margin = new Padding(2);
			panel_ChoiceClass.Name = "panel_ChoiceClass";
			panel_ChoiceClass.Size = new Size(426, 486);
			panel_ChoiceClass.TabIndex = 11;
			// 
			// radioButton_Wizard
			// 
			radioButton_Wizard.AutoSize = true;
			radioButton_Wizard.Font = new Font("Segoe UI", 18F);
			radioButton_Wizard.Location = new Point(16, 400);
			radioButton_Wizard.Margin = new Padding(2);
			radioButton_Wizard.Name = "radioButton_Wizard";
			radioButton_Wizard.Size = new Size(105, 36);
			radioButton_Wizard.TabIndex = 20;
			radioButton_Wizard.TabStop = true;
			radioButton_Wizard.Text = "Wizard";
			radioButton_Wizard.UseVisualStyleBackColor = true;
			radioButton_Wizard.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Warlock
			// 
			radioButton_Warlock.AutoSize = true;
			radioButton_Warlock.Font = new Font("Segoe UI", 18F);
			radioButton_Warlock.Location = new Point(16, 365);
			radioButton_Warlock.Margin = new Padding(2);
			radioButton_Warlock.Name = "radioButton_Warlock";
			radioButton_Warlock.Size = new Size(116, 36);
			radioButton_Warlock.TabIndex = 19;
			radioButton_Warlock.TabStop = true;
			radioButton_Warlock.Text = "Warlock";
			radioButton_Warlock.UseVisualStyleBackColor = true;
			radioButton_Warlock.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Sorcerer
			// 
			radioButton_Sorcerer.AutoSize = true;
			radioButton_Sorcerer.Font = new Font("Segoe UI", 18F);
			radioButton_Sorcerer.Location = new Point(16, 331);
			radioButton_Sorcerer.Margin = new Padding(2);
			radioButton_Sorcerer.Name = "radioButton_Sorcerer";
			radioButton_Sorcerer.Size = new Size(120, 36);
			radioButton_Sorcerer.TabIndex = 18;
			radioButton_Sorcerer.TabStop = true;
			radioButton_Sorcerer.Text = "Sorcerer";
			radioButton_Sorcerer.UseVisualStyleBackColor = true;
			radioButton_Sorcerer.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Rogue
			// 
			radioButton_Rogue.AutoSize = true;
			radioButton_Rogue.Font = new Font("Segoe UI", 18F);
			radioButton_Rogue.Location = new Point(16, 296);
			radioButton_Rogue.Margin = new Padding(2);
			radioButton_Rogue.Name = "radioButton_Rogue";
			radioButton_Rogue.Size = new Size(100, 36);
			radioButton_Rogue.TabIndex = 17;
			radioButton_Rogue.TabStop = true;
			radioButton_Rogue.Text = "Rogue";
			radioButton_Rogue.UseVisualStyleBackColor = true;
			radioButton_Rogue.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Monk
			// 
			radioButton_Monk.AutoSize = true;
			radioButton_Monk.Font = new Font("Segoe UI", 18F);
			radioButton_Monk.Location = new Point(16, 191);
			radioButton_Monk.Margin = new Padding(2);
			radioButton_Monk.Name = "radioButton_Monk";
			radioButton_Monk.Size = new Size(94, 36);
			radioButton_Monk.TabIndex = 16;
			radioButton_Monk.TabStop = true;
			radioButton_Monk.Text = "Monk";
			radioButton_Monk.UseVisualStyleBackColor = true;
			radioButton_Monk.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Paladin
			// 
			radioButton_Paladin.AutoSize = true;
			radioButton_Paladin.Font = new Font("Segoe UI", 18F);
			radioButton_Paladin.Location = new Point(16, 226);
			radioButton_Paladin.Margin = new Padding(2);
			radioButton_Paladin.Name = "radioButton_Paladin";
			radioButton_Paladin.Size = new Size(108, 36);
			radioButton_Paladin.TabIndex = 15;
			radioButton_Paladin.TabStop = true;
			radioButton_Paladin.Text = "Paladin";
			radioButton_Paladin.UseVisualStyleBackColor = true;
			radioButton_Paladin.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Fighter
			// 
			radioButton_Fighter.AutoSize = true;
			radioButton_Fighter.Font = new Font("Segoe UI", 18F);
			radioButton_Fighter.Location = new Point(16, 154);
			radioButton_Fighter.Margin = new Padding(2);
			radioButton_Fighter.Name = "radioButton_Fighter";
			radioButton_Fighter.Size = new Size(107, 36);
			radioButton_Fighter.TabIndex = 14;
			radioButton_Fighter.TabStop = true;
			radioButton_Fighter.Text = "Fighter";
			radioButton_Fighter.UseVisualStyleBackColor = true;
			radioButton_Fighter.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Ranger
			// 
			radioButton_Ranger.AutoSize = true;
			radioButton_Ranger.Font = new Font("Segoe UI", 18F);
			radioButton_Ranger.Location = new Point(16, 261);
			radioButton_Ranger.Margin = new Padding(2);
			radioButton_Ranger.Name = "radioButton_Ranger";
			radioButton_Ranger.Size = new Size(107, 36);
			radioButton_Ranger.TabIndex = 13;
			radioButton_Ranger.TabStop = true;
			radioButton_Ranger.Text = "Ranger";
			radioButton_Ranger.UseVisualStyleBackColor = true;
			radioButton_Ranger.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Druid
			// 
			radioButton_Druid.AutoSize = true;
			radioButton_Druid.Font = new Font("Segoe UI", 18F);
			radioButton_Druid.Location = new Point(16, 119);
			radioButton_Druid.Margin = new Padding(2);
			radioButton_Druid.Name = "radioButton_Druid";
			radioButton_Druid.Size = new Size(91, 36);
			radioButton_Druid.TabIndex = 12;
			radioButton_Druid.TabStop = true;
			radioButton_Druid.Text = "Druid";
			radioButton_Druid.UseVisualStyleBackColor = true;
			radioButton_Druid.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Cleric
			// 
			radioButton_Cleric.AutoSize = true;
			radioButton_Cleric.Font = new Font("Segoe UI", 18F);
			radioButton_Cleric.Location = new Point(16, 85);
			radioButton_Cleric.Margin = new Padding(2);
			radioButton_Cleric.Name = "radioButton_Cleric";
			radioButton_Cleric.Size = new Size(91, 36);
			radioButton_Cleric.TabIndex = 11;
			radioButton_Cleric.TabStop = true;
			radioButton_Cleric.Text = "Cleric";
			radioButton_Cleric.UseVisualStyleBackColor = true;
			radioButton_Cleric.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Bard
			// 
			radioButton_Bard.AutoSize = true;
			radioButton_Bard.Font = new Font("Segoe UI", 18F);
			radioButton_Bard.Location = new Point(16, 50);
			radioButton_Bard.Margin = new Padding(2);
			radioButton_Bard.Name = "radioButton_Bard";
			radioButton_Bard.Size = new Size(80, 36);
			radioButton_Bard.TabIndex = 10;
			radioButton_Bard.TabStop = true;
			radioButton_Bard.Text = "Bard";
			radioButton_Bard.UseVisualStyleBackColor = true;
			radioButton_Bard.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// radioButton_Barbarian
			// 
			radioButton_Barbarian.AutoSize = true;
			radioButton_Barbarian.Font = new Font("Segoe UI", 18F);
			radioButton_Barbarian.Location = new Point(16, 15);
			radioButton_Barbarian.Margin = new Padding(2);
			radioButton_Barbarian.Name = "radioButton_Barbarian";
			radioButton_Barbarian.Size = new Size(132, 36);
			radioButton_Barbarian.TabIndex = 9;
			radioButton_Barbarian.TabStop = true;
			radioButton_Barbarian.Text = "Barbarian";
			radioButton_Barbarian.UseVisualStyleBackColor = true;
			radioButton_Barbarian.CheckedChanged += radioButton_ChoiceClass_CheckedChanged;
			// 
			// tabPage_Skill
			// 
			tabPage_Skill.Controls.Add(label_Skill_Skill);
			tabPage_Skill.Controls.Add(panel_ChoiceSkill);
			tabPage_Skill.Location = new Point(4, 24);
			tabPage_Skill.Margin = new Padding(2);
			tabPage_Skill.Name = "tabPage_Skill";
			tabPage_Skill.Size = new Size(426, 522);
			tabPage_Skill.TabIndex = 3;
			tabPage_Skill.Text = "Скилы";
			tabPage_Skill.UseVisualStyleBackColor = true;
			// 
			// label_Skill_Skill
			// 
			label_Skill_Skill.AutoSize = true;
			label_Skill_Skill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Skill_Skill.Location = new Point(6, 5);
			label_Skill_Skill.Margin = new Padding(2, 0, 2, 0);
			label_Skill_Skill.Name = "label_Skill_Skill";
			label_Skill_Skill.Size = new Size(330, 32);
			label_Skill_Skill.TabIndex = 14;
			label_Skill_Skill.Text = "Выберите навыки из списка:";
			// 
			// panel_ChoiceSkill
			// 
			panel_ChoiceSkill.Controls.Add(checkedListBox_Skills);
			panel_ChoiceSkill.Dock = DockStyle.Bottom;
			panel_ChoiceSkill.Location = new Point(0, 36);
			panel_ChoiceSkill.Margin = new Padding(2);
			panel_ChoiceSkill.Name = "panel_ChoiceSkill";
			panel_ChoiceSkill.Size = new Size(426, 486);
			panel_ChoiceSkill.TabIndex = 13;
			// 
			// checkedListBox_Skills
			// 
			checkedListBox_Skills.CheckOnClick = true;
			checkedListBox_Skills.Dock = DockStyle.Fill;
			checkedListBox_Skills.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
			checkedListBox_Skills.FormattingEnabled = true;
			checkedListBox_Skills.Items.AddRange(new object[] { "Athletics", "Acrobatics", "Agulity", "Stealth", "Arcana", "History", "Investigation", "Nature", "Religion", "Animal", "Insight", "Medicine", "Perception", "Surival", "Deception", "Intimidation", "Perfomance", "Persuasion" });
			checkedListBox_Skills.Location = new Point(0, 0);
			checkedListBox_Skills.Margin = new Padding(2);
			checkedListBox_Skills.Name = "checkedListBox_Skills";
			checkedListBox_Skills.Size = new Size(426, 486);
			checkedListBox_Skills.TabIndex = 0;
			checkedListBox_Skills.SelectedIndexChanged += checkedListBox_Skills_SelectedIndexChanged;
			// 
			// tabPage_Abilities
			// 
			tabPage_Abilities.Controls.Add(label_Abilities_Abilities);
			tabPage_Abilities.Controls.Add(panel_Abilities);
			tabPage_Abilities.Location = new Point(4, 24);
			tabPage_Abilities.Margin = new Padding(2);
			tabPage_Abilities.Name = "tabPage_Abilities";
			tabPage_Abilities.Size = new Size(426, 522);
			tabPage_Abilities.TabIndex = 4;
			tabPage_Abilities.Text = "Характеристики";
			tabPage_Abilities.UseVisualStyleBackColor = true;
			// 
			// label_Abilities_Abilities
			// 
			label_Abilities_Abilities.AutoSize = true;
			label_Abilities_Abilities.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Abilities_Abilities.Location = new Point(6, 7);
			label_Abilities_Abilities.Margin = new Padding(2, 0, 2, 0);
			label_Abilities_Abilities.Name = "label_Abilities_Abilities";
			label_Abilities_Abilities.Size = new Size(278, 32);
			label_Abilities_Abilities.TabIndex = 15;
			label_Abilities_Abilities.Text = "Укажите характеристки:";
			// 
			// panel_Abilities
			// 
			panel_Abilities.Controls.Add(numericUpDown_Charisma);
			panel_Abilities.Controls.Add(numericUpDown_Wisdom);
			panel_Abilities.Controls.Add(numericUpDown_Intelligence);
			panel_Abilities.Controls.Add(numericUpDown_Agility);
			panel_Abilities.Controls.Add(numericUpDown_Physique);
			panel_Abilities.Controls.Add(numericUpDown_Strength);
			panel_Abilities.Controls.Add(label_Charisma);
			panel_Abilities.Controls.Add(label_Wisdom);
			panel_Abilities.Controls.Add(label_Intelligence);
			panel_Abilities.Controls.Add(label_Physique);
			panel_Abilities.Controls.Add(label_Agility);
			panel_Abilities.Controls.Add(label_Strength);
			panel_Abilities.Dock = DockStyle.Bottom;
			panel_Abilities.Location = new Point(0, 41);
			panel_Abilities.Margin = new Padding(2);
			panel_Abilities.Name = "panel_Abilities";
			panel_Abilities.Size = new Size(426, 481);
			panel_Abilities.TabIndex = 0;
			// 
			// numericUpDown_Charisma
			// 
			numericUpDown_Charisma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown_Charisma.Location = new Point(144, 318);
			numericUpDown_Charisma.Margin = new Padding(2);
			numericUpDown_Charisma.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown_Charisma.Name = "numericUpDown_Charisma";
			numericUpDown_Charisma.Size = new Size(45, 33);
			numericUpDown_Charisma.TabIndex = 17;
			numericUpDown_Charisma.ValueChanged += numericUpDown_ValueChanged;
			// 
			// numericUpDown_Wisdom
			// 
			numericUpDown_Wisdom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown_Wisdom.Location = new Point(144, 253);
			numericUpDown_Wisdom.Margin = new Padding(2);
			numericUpDown_Wisdom.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown_Wisdom.Name = "numericUpDown_Wisdom";
			numericUpDown_Wisdom.Size = new Size(45, 33);
			numericUpDown_Wisdom.TabIndex = 16;
			numericUpDown_Wisdom.ValueChanged += numericUpDown_ValueChanged;
			// 
			// numericUpDown_Intelligence
			// 
			numericUpDown_Intelligence.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown_Intelligence.Location = new Point(144, 187);
			numericUpDown_Intelligence.Margin = new Padding(2);
			numericUpDown_Intelligence.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown_Intelligence.Name = "numericUpDown_Intelligence";
			numericUpDown_Intelligence.Size = new Size(45, 33);
			numericUpDown_Intelligence.TabIndex = 15;
			numericUpDown_Intelligence.ValueChanged += numericUpDown_ValueChanged;
			// 
			// numericUpDown_Agility
			// 
			numericUpDown_Agility.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown_Agility.Location = new Point(144, 71);
			numericUpDown_Agility.Margin = new Padding(2);
			numericUpDown_Agility.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown_Agility.Name = "numericUpDown_Agility";
			numericUpDown_Agility.Size = new Size(45, 33);
			numericUpDown_Agility.TabIndex = 14;
			numericUpDown_Agility.ValueChanged += numericUpDown_ValueChanged;
			// 
			// numericUpDown_Physique
			// 
			numericUpDown_Physique.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown_Physique.Location = new Point(144, 127);
			numericUpDown_Physique.Margin = new Padding(2);
			numericUpDown_Physique.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown_Physique.Name = "numericUpDown_Physique";
			numericUpDown_Physique.Size = new Size(45, 33);
			numericUpDown_Physique.TabIndex = 13;
			numericUpDown_Physique.ValueChanged += numericUpDown_ValueChanged;
			// 
			// numericUpDown_Strength
			// 
			numericUpDown_Strength.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			numericUpDown_Strength.Location = new Point(144, 21);
			numericUpDown_Strength.Margin = new Padding(2);
			numericUpDown_Strength.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDown_Strength.Name = "numericUpDown_Strength";
			numericUpDown_Strength.Size = new Size(45, 33);
			numericUpDown_Strength.TabIndex = 12;
			numericUpDown_Strength.ValueChanged += numericUpDown_ValueChanged;
			// 
			// label_Charisma
			// 
			label_Charisma.AutoSize = true;
			label_Charisma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Charisma.Location = new Point(28, 320);
			label_Charisma.Name = "label_Charisma";
			label_Charisma.Size = new Size(91, 25);
			label_Charisma.TabIndex = 11;
			label_Charisma.Text = "Charisma";
			// 
			// label_Wisdom
			// 
			label_Wisdom.AutoSize = true;
			label_Wisdom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Wisdom.Location = new Point(28, 255);
			label_Wisdom.Name = "label_Wisdom";
			label_Wisdom.Size = new Size(81, 25);
			label_Wisdom.TabIndex = 10;
			label_Wisdom.Text = "Wisdom";
			// 
			// label_Intelligence
			// 
			label_Intelligence.AutoSize = true;
			label_Intelligence.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Intelligence.Location = new Point(28, 189);
			label_Intelligence.Name = "label_Intelligence";
			label_Intelligence.Size = new Size(110, 25);
			label_Intelligence.TabIndex = 9;
			label_Intelligence.Text = "Intelligence";
			// 
			// label_Physique
			// 
			label_Physique.AutoSize = true;
			label_Physique.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Physique.Location = new Point(28, 129);
			label_Physique.Name = "label_Physique";
			label_Physique.Size = new Size(88, 25);
			label_Physique.TabIndex = 8;
			label_Physique.Text = "Physique";
			// 
			// label_Agility
			// 
			label_Agility.AutoSize = true;
			label_Agility.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Agility.Location = new Point(28, 73);
			label_Agility.Name = "label_Agility";
			label_Agility.Size = new Size(65, 25);
			label_Agility.TabIndex = 7;
			label_Agility.Text = "Agility";
			// 
			// label_Strength
			// 
			label_Strength.AutoSize = true;
			label_Strength.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Strength.Location = new Point(28, 23);
			label_Strength.Name = "label_Strength";
			label_Strength.Size = new Size(83, 25);
			label_Strength.TabIndex = 6;
			label_Strength.Text = "Strength";
			// 
			// button_Save_Char
			// 
			button_Save_Char.Dock = DockStyle.Bottom;
			button_Save_Char.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button_Save_Char.Location = new Point(0, 551);
			button_Save_Char.Margin = new Padding(2);
			button_Save_Char.Name = "button_Save_Char";
			button_Save_Char.Size = new Size(434, 32);
			button_Save_Char.TabIndex = 1;
			button_Save_Char.Text = "Сохранить персонажа";
			button_Save_Char.UseVisualStyleBackColor = true;
			button_Save_Char.Click += button_Save_Char_Click;
			// 
			// CreateChar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(434, 583);
			Controls.Add(button_Save_Char);
			Controls.Add(tabControlCreateChar);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			Name = "CreateChar";
			Text = "CreateChar";
			Load += CreateChar_Load;
			tabControlCreateChar.ResumeLayout(false);
			tabPage_Name.ResumeLayout(false);
			tabPage_Name.PerformLayout();
			tabPage_Race.ResumeLayout(false);
			tabPage_Race.PerformLayout();
			panel_ChoiceRace.ResumeLayout(false);
			panel_ChoiceRace.PerformLayout();
			tabPage_Class.ResumeLayout(false);
			tabPage_Class.PerformLayout();
			panel_ChoiceClass.ResumeLayout(false);
			panel_ChoiceClass.PerformLayout();
			tabPage_Skill.ResumeLayout(false);
			tabPage_Skill.PerformLayout();
			panel_ChoiceSkill.ResumeLayout(false);
			tabPage_Abilities.ResumeLayout(false);
			tabPage_Abilities.PerformLayout();
			panel_Abilities.ResumeLayout(false);
			panel_Abilities.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Charisma).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Wisdom).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Intelligence).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Agility).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Physique).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Strength).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControlCreateChar;
		private TabPage tabPage_Name;
		private TabPage tabPage_Race;
		private TextBox textBox_NameChar;
		private Label label_Name_Name;
		private TabPage tabPage_Class;
		private Button button_Save_Char;
		private Panel panel_ChoiceRace;
		private RadioButton radioButton_Elf;
		private RadioButton radioButton_HalfElf;
		private RadioButton radioButton_Tiefling;
		private RadioButton radioButton_Halfling;
		private RadioButton radioButton_Human;
		private RadioButton radioButton_Halforc;
		private RadioButton radioButton_Dragonborn;
		private RadioButton radioButton_Dwarf;
		private RadioButton radioButton_Gnom;
		private Label label_Race_Race;
		private Label label_Class_Class;
		private Panel panel_ChoiceClass;
		private RadioButton radioButton_Rogue;
		private RadioButton radioButton_Monk;
		private RadioButton radioButton_Paladin;
		private RadioButton radioButton_Fighter;
		private RadioButton radioButton_Ranger;
		private RadioButton radioButton_Druid;
		private RadioButton radioButton_Cleric;
		private RadioButton radioButton_Bard;
		private RadioButton radioButton_Barbarian;
		private RadioButton radioButton_Sorcerer;
		private RadioButton radioButton_Wizard;
		private RadioButton radioButton_Warlock;
		private TabPage tabPage_Skill;
		private Label label_Skill_Skill;
		private Panel panel_ChoiceSkill;
		private CheckedListBox checkedListBox_Skills;
		private TabPage tabPage_Abilities;
		private Label label_Abilities_Abilities;
		private Panel panel_Abilities;
		private Label label_Charisma;
		private Label label_Wisdom;
		private Label label_Intelligence;
		private Label label_Physique;
		private Label label_Agility;
		private Label label_Strength;
		private NumericUpDown numericUpDown_Charisma;
		private NumericUpDown numericUpDown_Wisdom;
		private NumericUpDown numericUpDown_Intelligence;
		private NumericUpDown numericUpDown_Agility;
		private NumericUpDown numericUpDown_Physique;
		private NumericUpDown numericUpDown_Strength;
	}
}