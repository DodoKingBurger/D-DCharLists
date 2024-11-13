namespace D_DCharLists.Screens.AddingItemInInventory
{
	partial class AddingItemInventoryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingItemInventoryForm));
			panel_List_Adding_Item = new Panel();
			groupBox_List_Adding_Item = new GroupBox();
			groupBox1 = new GroupBox();
			label_List_Adding_HowItems = new Label();
			label_List_Adding_Item = new Label();
			button_Char_Adding_Item = new Button();
			numericUpDown_Item_How = new NumericUpDown();
			numericUpDown_Item_Id = new NumericUpDown();
			groupBox_Search_Item_DB = new GroupBox();
			label_List_TypeItem_Search = new Label();
			label_List_Name_Search = new Label();
			comboBox_Item_TypeItem = new ComboBox();
			textBox_Item_Name = new TextBox();
			listView_Item_DB = new ListView();
			panel_List_Adding_Item.SuspendLayout();
			groupBox_List_Adding_Item.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Item_How).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Item_Id).BeginInit();
			groupBox_Search_Item_DB.SuspendLayout();
			SuspendLayout();
			// 
			// panel_List_Adding_Item
			// 
			panel_List_Adding_Item.Controls.Add(groupBox_List_Adding_Item);
			panel_List_Adding_Item.Dock = DockStyle.Fill;
			panel_List_Adding_Item.Location = new Point(0, 0);
			panel_List_Adding_Item.Margin = new Padding(5);
			panel_List_Adding_Item.Name = "panel_List_Adding_Item";
			panel_List_Adding_Item.Size = new Size(1000, 599);
			panel_List_Adding_Item.TabIndex = 0;
			// 
			// groupBox_List_Adding_Item
			// 
			groupBox_List_Adding_Item.Controls.Add(groupBox1);
			groupBox_List_Adding_Item.Controls.Add(groupBox_Search_Item_DB);
			groupBox_List_Adding_Item.Controls.Add(listView_Item_DB);
			groupBox_List_Adding_Item.Dock = DockStyle.Fill;
			groupBox_List_Adding_Item.Location = new Point(0, 0);
			groupBox_List_Adding_Item.Margin = new Padding(5);
			groupBox_List_Adding_Item.Name = "groupBox_List_Adding_Item";
			groupBox_List_Adding_Item.Padding = new Padding(5);
			groupBox_List_Adding_Item.Size = new Size(1000, 599);
			groupBox_List_Adding_Item.TabIndex = 0;
			groupBox_List_Adding_Item.TabStop = false;
			groupBox_List_Adding_Item.Text = "Магазин";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label_List_Adding_HowItems);
			groupBox1.Controls.Add(label_List_Adding_Item);
			groupBox1.Controls.Add(button_Char_Adding_Item);
			groupBox1.Controls.Add(numericUpDown_Item_How);
			groupBox1.Controls.Add(numericUpDown_Item_Id);
			groupBox1.Location = new Point(604, 424);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(391, 167);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Добавление ";
			// 
			// label_List_Adding_HowItems
			// 
			label_List_Adding_HowItems.AutoSize = true;
			label_List_Adding_HowItems.Location = new Point(32, 85);
			label_List_Adding_HowItems.Name = "label_List_Adding_HowItems";
			label_List_Adding_HowItems.Size = new Size(151, 34);
			label_List_Adding_HowItems.TabIndex = 4;
			label_List_Adding_HowItems.Text = "Колличество";
			// 
			// label_List_Adding_Item
			// 
			label_List_Adding_Item.AutoSize = true;
			label_List_Adding_Item.Location = new Point(32, 43);
			label_List_Adding_Item.Name = "label_List_Adding_Item";
			label_List_Adding_Item.Size = new Size(154, 34);
			label_List_Adding_Item.TabIndex = 3;
			label_List_Adding_Item.Text = "ID предмета";
			// 
			// button_Char_Adding_Item
			// 
			button_Char_Adding_Item.Location = new Point(32, 127);
			button_Char_Adding_Item.Name = "button_Char_Adding_Item";
			button_Char_Adding_Item.Size = new Size(352, 34);
			button_Char_Adding_Item.TabIndex = 2;
			button_Char_Adding_Item.Text = "Добавить";
			button_Char_Adding_Item.UseVisualStyleBackColor = true;
			button_Char_Adding_Item.Click += button_Char_Adding_Item_Click;
			// 
			// numericUpDown_Item_How
			// 
			numericUpDown_Item_How.Location = new Point(204, 83);
			numericUpDown_Item_How.Name = "numericUpDown_Item_How";
			numericUpDown_Item_How.Size = new Size(180, 39);
			numericUpDown_Item_How.TabIndex = 1;
			// 
			// numericUpDown_Item_Id
			// 
			numericUpDown_Item_Id.Location = new Point(204, 38);
			numericUpDown_Item_Id.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numericUpDown_Item_Id.Name = "numericUpDown_Item_Id";
			numericUpDown_Item_Id.Size = new Size(180, 39);
			numericUpDown_Item_Id.TabIndex = 0;
			// 
			// groupBox_Search_Item_DB
			// 
			groupBox_Search_Item_DB.Controls.Add(label_List_TypeItem_Search);
			groupBox_Search_Item_DB.Controls.Add(label_List_Name_Search);
			groupBox_Search_Item_DB.Controls.Add(comboBox_Item_TypeItem);
			groupBox_Search_Item_DB.Controls.Add(textBox_Item_Name);
			groupBox_Search_Item_DB.Location = new Point(5, 424);
			groupBox_Search_Item_DB.Name = "groupBox_Search_Item_DB";
			groupBox_Search_Item_DB.Size = new Size(593, 167);
			groupBox_Search_Item_DB.TabIndex = 1;
			groupBox_Search_Item_DB.TabStop = false;
			groupBox_Search_Item_DB.Text = "Пойск предмета";
			// 
			// label_List_TypeItem_Search
			// 
			label_List_TypeItem_Search.AutoSize = true;
			label_List_TypeItem_Search.Location = new Point(27, 101);
			label_List_TypeItem_Search.Name = "label_List_TypeItem_Search";
			label_List_TypeItem_Search.Size = new Size(175, 34);
			label_List_TypeItem_Search.TabIndex = 6;
			label_List_TypeItem_Search.Text = "Тип предмета";
			// 
			// label_List_Name_Search
			// 
			label_List_Name_Search.AutoSize = true;
			label_List_Name_Search.Location = new Point(27, 46);
			label_List_Name_Search.Name = "label_List_Name_Search";
			label_List_Name_Search.Size = new Size(114, 34);
			label_List_Name_Search.TabIndex = 5;
			label_List_Name_Search.Text = "Название";
			// 
			// comboBox_Item_TypeItem
			// 
			comboBox_Item_TypeItem.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_Item_TypeItem.FormattingEnabled = true;
			comboBox_Item_TypeItem.Location = new Point(208, 101);
			comboBox_Item_TypeItem.Name = "comboBox_Item_TypeItem";
			comboBox_Item_TypeItem.Size = new Size(349, 42);
			comboBox_Item_TypeItem.TabIndex = 2;
			// 
			// textBox_Item_Name
			// 
			textBox_Item_Name.Location = new Point(206, 43);
			textBox_Item_Name.Name = "textBox_Item_Name";
			textBox_Item_Name.Size = new Size(349, 39);
			textBox_Item_Name.TabIndex = 0;
			// 
			// listView_Item_DB
			// 
			listView_Item_DB.Dock = DockStyle.Top;
			listView_Item_DB.Location = new Point(5, 37);
			listView_Item_DB.Name = "listView_Item_DB";
			listView_Item_DB.Size = new Size(990, 381);
			listView_Item_DB.TabIndex = 0;
			listView_Item_DB.UseCompatibleStateImageBehavior = false;
			// 
			// AddingItemInventoryForm
			// 
			AutoScaleDimensions = new SizeF(14F, 34F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 599);
			Controls.Add(panel_List_Adding_Item);
			Font = new Font("Monotype Corsiva", 14F, FontStyle.Italic, GraphicsUnit.Point, 204);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5);
			Name = "AddingItemInventoryForm";
			Text = "AddingItemInventoryForm";
			Load += AddingItemInventoryForm_Load;
			panel_List_Adding_Item.ResumeLayout(false);
			groupBox_List_Adding_Item.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Item_How).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Item_Id).EndInit();
			groupBox_Search_Item_DB.ResumeLayout(false);
			groupBox_Search_Item_DB.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel_List_Adding_Item;
		private GroupBox groupBox_List_Adding_Item;
		private ListView listView_Item_DB;
		private GroupBox groupBox_Search_Item_DB;
		private GroupBox groupBox1;
		private Label label_List_Adding_HowItems;
		private Label label_List_Adding_Item;
		private Button button_Char_Adding_Item;
		private NumericUpDown numericUpDown_Item_How;
		private NumericUpDown numericUpDown_Item_Id;
		private ComboBox comboBox_Item_TypeItem;
		private TextBox textBox_Item_Name;
		private Label label_List_TypeItem_Search;
		private Label label_List_Name_Search;
	}
}