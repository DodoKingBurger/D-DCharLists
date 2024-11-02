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
			button_Save_Char = new Button();
			tabControlCreateChar.SuspendLayout();
			tabPage_Name.SuspendLayout();
			tabPage_Race.SuspendLayout();
			panel_ChoiceRace.SuspendLayout();
			tabPage_Class.SuspendLayout();
			panel_ChoiceClass.SuspendLayout();
			tabPage_Skill.SuspendLayout();
			panel_ChoiceSkill.SuspendLayout();
			SuspendLayout();
			// 
			// tabControlCreateChar
			// 
			tabControlCreateChar.Controls.Add(tabPage_Name);
			tabControlCreateChar.Controls.Add(tabPage_Race);
			tabControlCreateChar.Controls.Add(tabPage_Class);
			tabControlCreateChar.Controls.Add(tabPage_Skill);
			tabControlCreateChar.Dock = DockStyle.Top;
			tabControlCreateChar.Location = new Point(0, 0);
			tabControlCreateChar.Name = "tabControlCreateChar";
			tabControlCreateChar.SelectedIndex = 0;
			tabControlCreateChar.Size = new Size(620, 916);
			tabControlCreateChar.TabIndex = 0;
			// 
			// tabPage_Name
			// 
			tabPage_Name.BackgroundImageLayout = ImageLayout.Center;
			tabPage_Name.Controls.Add(label_Name_Name);
			tabPage_Name.Controls.Add(textBox_NameChar);
			tabPage_Name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tabPage_Name.Location = new Point(4, 34);
			tabPage_Name.Name = "tabPage_Name";
			tabPage_Name.Padding = new Padding(3);
			tabPage_Name.Size = new Size(612, 878);
			tabPage_Name.TabIndex = 0;
			tabPage_Name.Text = "Имя";
			tabPage_Name.UseVisualStyleBackColor = true;
			// 
			// label_Name_Name
			// 
			label_Name_Name.AutoSize = true;
			label_Name_Name.Location = new Point(17, 16);
			label_Name_Name.Name = "label_Name_Name";
			label_Name_Name.Size = new Size(429, 48);
			label_Name_Name.TabIndex = 1;
			label_Name_Name.Text = "Введите имя персонажа:";
			// 
			// textBox_NameChar
			// 
			textBox_NameChar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			textBox_NameChar.Location = new Point(17, 76);
			textBox_NameChar.Name = "textBox_NameChar";
			textBox_NameChar.Size = new Size(429, 55);
			textBox_NameChar.TabIndex = 0;
			textBox_NameChar.TextChanged += textBox_NameChar_TextChanged;
			// 
			// tabPage_Race
			// 
			tabPage_Race.BackgroundImageLayout = ImageLayout.Center;
			tabPage_Race.Controls.Add(panel_ChoiceRace);
			tabPage_Race.Controls.Add(label_Race_Race);
			tabPage_Race.Location = new Point(4, 34);
			tabPage_Race.Name = "tabPage_Race";
			tabPage_Race.Padding = new Padding(3);
			tabPage_Race.Size = new Size(612, 878);
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
			panel_ChoiceRace.Location = new Point(3, 73);
			panel_ChoiceRace.Name = "panel_ChoiceRace";
			panel_ChoiceRace.Size = new Size(606, 802);
			panel_ChoiceRace.TabIndex = 10;
			// 
			// radioButton_Elf
			// 
			radioButton_Elf.AutoSize = true;
			radioButton_Elf.Font = new Font("Segoe UI", 18F);
			radioButton_Elf.Location = new Point(23, 493);
			radioButton_Elf.Name = "radioButton_Elf";
			radioButton_Elf.Size = new Size(83, 52);
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
			radioButton_HalfElf.Location = new Point(23, 319);
			radioButton_HalfElf.Name = "radioButton_HalfElf";
			radioButton_HalfElf.Size = new Size(148, 52);
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
			radioButton_Tiefling.Location = new Point(23, 377);
			radioButton_Tiefling.Name = "radioButton_Tiefling";
			radioButton_Tiefling.Size = new Size(162, 52);
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
			radioButton_Halfling.Location = new Point(23, 257);
			radioButton_Halfling.Name = "radioButton_Halfling";
			radioButton_Halfling.Size = new Size(168, 52);
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
			radioButton_Human.Location = new Point(23, 435);
			radioButton_Human.Name = "radioButton_Human";
			radioButton_Human.Size = new Size(160, 52);
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
			radioButton_Halforc.Location = new Point(23, 199);
			radioButton_Halforc.Name = "radioButton_Halforc";
			radioButton_Halforc.Size = new Size(160, 52);
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
			radioButton_Dragonborn.Location = new Point(23, 141);
			radioButton_Dragonborn.Name = "radioButton_Dragonborn";
			radioButton_Dragonborn.Size = new Size(238, 52);
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
			radioButton_Dwarf.Location = new Point(23, 83);
			radioButton_Dwarf.Name = "radioButton_Dwarf";
			radioButton_Dwarf.Size = new Size(138, 52);
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
			radioButton_Gnom.Location = new Point(23, 25);
			radioButton_Gnom.Name = "radioButton_Gnom";
			radioButton_Gnom.Size = new Size(142, 52);
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
			label_Race_Race.Location = new Point(8, 22);
			label_Race_Race.Name = "label_Race_Race";
			label_Race_Race.Size = new Size(460, 48);
			label_Race_Race.TabIndex = 9;
			label_Race_Race.Text = "Выберите рассу из списка:";
			// 
			// tabPage_Class
			// 
			tabPage_Class.BackgroundImageLayout = ImageLayout.Center;
			tabPage_Class.Controls.Add(label_Class_Class);
			tabPage_Class.Controls.Add(panel_ChoiceClass);
			tabPage_Class.Location = new Point(4, 34);
			tabPage_Class.Name = "tabPage_Class";
			tabPage_Class.Size = new Size(612, 878);
			tabPage_Class.TabIndex = 2;
			tabPage_Class.Text = "Класс";
			tabPage_Class.UseVisualStyleBackColor = true;
			// 
			// label_Class_Class
			// 
			label_Class_Class.AutoSize = true;
			label_Class_Class.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Class_Class.Location = new Point(8, 17);
			label_Class_Class.Name = "label_Class_Class";
			label_Class_Class.Size = new Size(459, 48);
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
			panel_ChoiceClass.Location = new Point(0, 68);
			panel_ChoiceClass.Name = "panel_ChoiceClass";
			panel_ChoiceClass.Size = new Size(612, 810);
			panel_ChoiceClass.TabIndex = 11;
			// 
			// radioButton_Wizard
			// 
			radioButton_Wizard.AutoSize = true;
			radioButton_Wizard.Font = new Font("Segoe UI", 18F);
			radioButton_Wizard.Location = new Point(23, 667);
			radioButton_Wizard.Name = "radioButton_Wizard";
			radioButton_Wizard.Size = new Size(156, 52);
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
			radioButton_Warlock.Location = new Point(23, 609);
			radioButton_Warlock.Name = "radioButton_Warlock";
			radioButton_Warlock.Size = new Size(174, 52);
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
			radioButton_Sorcerer.Location = new Point(23, 551);
			radioButton_Sorcerer.Name = "radioButton_Sorcerer";
			radioButton_Sorcerer.Size = new Size(179, 52);
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
			radioButton_Rogue.Location = new Point(23, 493);
			radioButton_Rogue.Name = "radioButton_Rogue";
			radioButton_Rogue.Size = new Size(147, 52);
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
			radioButton_Monk.Location = new Point(23, 319);
			radioButton_Monk.Name = "radioButton_Monk";
			radioButton_Monk.Size = new Size(136, 52);
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
			radioButton_Paladin.Location = new Point(23, 377);
			radioButton_Paladin.Name = "radioButton_Paladin";
			radioButton_Paladin.Size = new Size(159, 52);
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
			radioButton_Fighter.Location = new Point(23, 257);
			radioButton_Fighter.Name = "radioButton_Fighter";
			radioButton_Fighter.Size = new Size(157, 52);
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
			radioButton_Ranger.Location = new Point(23, 435);
			radioButton_Ranger.Name = "radioButton_Ranger";
			radioButton_Ranger.Size = new Size(158, 52);
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
			radioButton_Druid.Location = new Point(23, 199);
			radioButton_Druid.Name = "radioButton_Druid";
			radioButton_Druid.Size = new Size(133, 52);
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
			radioButton_Cleric.Location = new Point(23, 141);
			radioButton_Cleric.Name = "radioButton_Cleric";
			radioButton_Cleric.Size = new Size(134, 52);
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
			radioButton_Bard.Location = new Point(23, 83);
			radioButton_Bard.Name = "radioButton_Bard";
			radioButton_Bard.Size = new Size(118, 52);
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
			radioButton_Barbarian.Location = new Point(23, 25);
			radioButton_Barbarian.Name = "radioButton_Barbarian";
			radioButton_Barbarian.Size = new Size(196, 52);
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
			tabPage_Skill.Location = new Point(4, 34);
			tabPage_Skill.Name = "tabPage_Skill";
			tabPage_Skill.Size = new Size(612, 878);
			tabPage_Skill.TabIndex = 3;
			tabPage_Skill.Text = "Скилы";
			tabPage_Skill.UseVisualStyleBackColor = true;
			// 
			// label_Skill_Skill
			// 
			label_Skill_Skill.AutoSize = true;
			label_Skill_Skill.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label_Skill_Skill.Location = new Point(8, 9);
			label_Skill_Skill.Name = "label_Skill_Skill";
			label_Skill_Skill.Size = new Size(493, 48);
			label_Skill_Skill.TabIndex = 14;
			label_Skill_Skill.Text = "Выберите навыки из списка:";
			// 
			// panel_ChoiceSkill
			// 
			panel_ChoiceSkill.Controls.Add(checkedListBox_Skills);
			panel_ChoiceSkill.Dock = DockStyle.Bottom;
			panel_ChoiceSkill.Location = new Point(0, 68);
			panel_ChoiceSkill.Name = "panel_ChoiceSkill";
			panel_ChoiceSkill.Size = new Size(612, 810);
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
			checkedListBox_Skills.Name = "checkedListBox_Skills";
			checkedListBox_Skills.Size = new Size(612, 810);
			checkedListBox_Skills.TabIndex = 0;
			checkedListBox_Skills.SelectedIndexChanged += checkedListBox_Skills_SelectedIndexChanged;
			// 
			// button_Save_Char
			// 
			button_Save_Char.Dock = DockStyle.Bottom;
			button_Save_Char.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button_Save_Char.Location = new Point(0, 918);
			button_Save_Char.Name = "button_Save_Char";
			button_Save_Char.Size = new Size(620, 54);
			button_Save_Char.TabIndex = 1;
			button_Save_Char.Text = "Сохранить персонажа";
			button_Save_Char.UseVisualStyleBackColor = true;
			button_Save_Char.Click += button_Save_Char_Click;
			// 
			// CreateChar
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(620, 972);
			Controls.Add(button_Save_Char);
			Controls.Add(tabControlCreateChar);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
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
	}
}