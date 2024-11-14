namespace D_DCharLists.Screens
{
	partial class AddingSpellDBForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingSpellDBForm));
			groupBox_List_AddingInfoGroup = new GroupBox();
			button_Create_Spell = new Button();
			textBox_DamageType_Spell = new TextBox();
			label_List_DamageType_Spell = new Label();
			label_List_AdditionalModifiers_Spell = new Label();
			numericUpDown_AdditionalModifiers_Spell = new NumericUpDown();
			checkBox_UseMasterBonus_Spell = new CheckBox();
			label_List_FromСharacteristic_Spell = new Label();
			comboBox_FromСharacteristic_Spell = new ComboBox();
			label_List_Name_Spell = new Label();
			textBox_Name_Spell = new TextBox();
			groupBox_List_AddingInfoGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_AdditionalModifiers_Spell).BeginInit();
			SuspendLayout();
			// 
			// groupBox_List_AddingInfoGroup
			// 
			groupBox_List_AddingInfoGroup.Controls.Add(button_Create_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(textBox_DamageType_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(label_List_DamageType_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(label_List_AdditionalModifiers_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(numericUpDown_AdditionalModifiers_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(checkBox_UseMasterBonus_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(label_List_FromСharacteristic_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(comboBox_FromСharacteristic_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(label_List_Name_Spell);
			groupBox_List_AddingInfoGroup.Controls.Add(textBox_Name_Spell);
			groupBox_List_AddingInfoGroup.Dock = DockStyle.Fill;
			groupBox_List_AddingInfoGroup.Location = new Point(0, 0);
			groupBox_List_AddingInfoGroup.Name = "groupBox_List_AddingInfoGroup";
			groupBox_List_AddingInfoGroup.Size = new Size(972, 511);
			groupBox_List_AddingInfoGroup.TabIndex = 0;
			groupBox_List_AddingInfoGroup.TabStop = false;
			groupBox_List_AddingInfoGroup.Text = "Открываем новое заклинание";
			// 
			// button_Create_Spell
			// 
			button_Create_Spell.Location = new Point(563, 450);
			button_Create_Spell.Name = "button_Create_Spell";
			button_Create_Spell.Size = new Size(375, 49);
			button_Create_Spell.TabIndex = 9;
			button_Create_Spell.Text = "Создать";
			button_Create_Spell.UseVisualStyleBackColor = true;
			button_Create_Spell.Click += button_Create_Spell_Click;
			// 
			// textBox_DamageType_Spell
			// 
			textBox_DamageType_Spell.Location = new Point(36, 396);
			textBox_DamageType_Spell.Name = "textBox_DamageType_Spell";
			textBox_DamageType_Spell.Size = new Size(902, 48);
			textBox_DamageType_Spell.TabIndex = 8;
			// 
			// label_List_DamageType_Spell
			// 
			label_List_DamageType_Spell.AutoSize = true;
			label_List_DamageType_Spell.Location = new Point(36, 336);
			label_List_DamageType_Spell.Name = "label_List_DamageType_Spell";
			label_List_DamageType_Spell.Size = new Size(156, 44);
			label_List_DamageType_Spell.TabIndex = 7;
			label_List_DamageType_Spell.Text = "Урон/Вид";
			// 
			// label_List_AdditionalModifiers_Spell
			// 
			label_List_AdditionalModifiers_Spell.AutoSize = true;
			label_List_AdditionalModifiers_Spell.Location = new Point(36, 271);
			label_List_AdditionalModifiers_Spell.Name = "label_List_AdditionalModifiers_Spell";
			label_List_AdditionalModifiers_Spell.Size = new Size(279, 44);
			label_List_AdditionalModifiers_Spell.TabIndex = 6;
			label_List_AdditionalModifiers_Spell.Text = "Доп. модификатор";
			// 
			// numericUpDown_AdditionalModifiers_Spell
			// 
			numericUpDown_AdditionalModifiers_Spell.Location = new Point(563, 267);
			numericUpDown_AdditionalModifiers_Spell.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDown_AdditionalModifiers_Spell.Name = "numericUpDown_AdditionalModifiers_Spell";
			numericUpDown_AdditionalModifiers_Spell.Size = new Size(180, 48);
			numericUpDown_AdditionalModifiers_Spell.TabIndex = 5;
			// 
			// checkBox_UseMasterBonus_Spell
			// 
			checkBox_UseMasterBonus_Spell.AutoSize = true;
			checkBox_UseMasterBonus_Spell.Location = new Point(773, 147);
			checkBox_UseMasterBonus_Spell.Name = "checkBox_UseMasterBonus_Spell";
			checkBox_UseMasterBonus_Spell.Size = new Size(165, 92);
			checkBox_UseMasterBonus_Spell.TabIndex = 4;
			checkBox_UseMasterBonus_Spell.Text = "Бонус \r\nвладения";
			checkBox_UseMasterBonus_Spell.UseVisualStyleBackColor = true;
			// 
			// label_List_FromСharacteristic_Spell
			// 
			label_List_FromСharacteristic_Spell.AutoSize = true;
			label_List_FromСharacteristic_Spell.Location = new Point(36, 147);
			label_List_FromСharacteristic_Spell.Name = "label_List_FromСharacteristic_Spell";
			label_List_FromСharacteristic_Spell.Size = new Size(293, 88);
			label_List_FromСharacteristic_Spell.TabIndex = 3;
			label_List_FromСharacteristic_Spell.Text = "Характеристика\r\nот которой зависит\r\n";
			// 
			// comboBox_FromСharacteristic_Spell
			// 
			comboBox_FromСharacteristic_Spell.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_FromСharacteristic_Spell.FormattingEnabled = true;
			comboBox_FromСharacteristic_Spell.Items.AddRange(new object[] { "Без характеристкии", "Strength", "Agility", "Physique", "Intelligence", "Wisdom", "Charisma" });
			comboBox_FromСharacteristic_Spell.Location = new Point(472, 167);
			comboBox_FromСharacteristic_Spell.Name = "comboBox_FromСharacteristic_Spell";
			comboBox_FromСharacteristic_Spell.Size = new Size(271, 52);
			comboBox_FromСharacteristic_Spell.TabIndex = 2;
			// 
			// label_List_Name_Spell
			// 
			label_List_Name_Spell.AutoSize = true;
			label_List_Name_Spell.Location = new Point(36, 70);
			label_List_Name_Spell.Name = "label_List_Name_Spell";
			label_List_Name_Spell.Size = new Size(312, 44);
			label_List_Name_Spell.TabIndex = 1;
			label_List_Name_Spell.Text = "Название заклинания";
			// 
			// textBox_Name_Spell
			// 
			textBox_Name_Spell.Location = new Point(361, 67);
			textBox_Name_Spell.Name = "textBox_Name_Spell";
			textBox_Name_Spell.Size = new Size(382, 48);
			textBox_Name_Spell.TabIndex = 0;
			// 
			// AddingSpellDBForm
			// 
			AutoScaleDimensions = new SizeF(18F, 44F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(972, 511);
			Controls.Add(groupBox_List_AddingInfoGroup);
			Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(6);
			Name = "AddingSpellDBForm";
			Text = "AddingSpellDB";
			Load += AddingSpellDBForm_Load;
			groupBox_List_AddingInfoGroup.ResumeLayout(false);
			groupBox_List_AddingInfoGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_AdditionalModifiers_Spell).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_List_AddingInfoGroup;
		private Label label_List_Name_Spell;
		private TextBox textBox_Name_Spell;
		private CheckBox checkBox_UseMasterBonus_Spell;
		private Label label_List_FromСharacteristic_Spell;
		private ComboBox comboBox_FromСharacteristic_Spell;
		private Label label_List_AdditionalModifiers_Spell;
		private NumericUpDown numericUpDown_AdditionalModifiers_Spell;
		private TextBox textBox_DamageType_Spell;
		private Label label_List_DamageType_Spell;
		private Button button_Create_Spell;
	}
}