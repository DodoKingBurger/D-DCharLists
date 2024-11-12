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
			listView1 = new ListView();
			panel_List_Adding_Item.SuspendLayout();
			groupBox_List_Adding_Item.SuspendLayout();
			SuspendLayout();
			// 
			// panel_List_Adding_Item
			// 
			panel_List_Adding_Item.Controls.Add(groupBox_List_Adding_Item);
			panel_List_Adding_Item.Dock = DockStyle.Fill;
			panel_List_Adding_Item.Location = new Point(0, 0);
			panel_List_Adding_Item.Margin = new Padding(5, 5, 5, 5);
			panel_List_Adding_Item.Name = "panel_List_Adding_Item";
			panel_List_Adding_Item.Size = new Size(1456, 486);
			panel_List_Adding_Item.TabIndex = 0;
			// 
			// groupBox_List_Adding_Item
			// 
			groupBox_List_Adding_Item.Controls.Add(listView1);
			groupBox_List_Adding_Item.Dock = DockStyle.Fill;
			groupBox_List_Adding_Item.Location = new Point(0, 0);
			groupBox_List_Adding_Item.Margin = new Padding(5, 5, 5, 5);
			groupBox_List_Adding_Item.Name = "groupBox_List_Adding_Item";
			groupBox_List_Adding_Item.Padding = new Padding(5, 5, 5, 5);
			groupBox_List_Adding_Item.Size = new Size(1456, 486);
			groupBox_List_Adding_Item.TabIndex = 0;
			groupBox_List_Adding_Item.TabStop = false;
			groupBox_List_Adding_Item.Text = "groupBox1";
			// 
			// listView1
			// 
			listView1.Dock = DockStyle.Top;
			listView1.Location = new Point(5, 37);
			listView1.Name = "listView1";
			listView1.Size = new Size(1446, 146);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// AddingItemInventoryForm
			// 
			AutoScaleDimensions = new SizeF(14F, 34F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1456, 486);
			Controls.Add(panel_List_Adding_Item);
			Font = new Font("Monotype Corsiva", 14F, FontStyle.Italic, GraphicsUnit.Point, 204);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 5, 5, 5);
			Name = "AddingItemInventoryForm";
			Text = "AddingItemInventoryForm";
			panel_List_Adding_Item.ResumeLayout(false);
			groupBox_List_Adding_Item.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel_List_Adding_Item;
		private GroupBox groupBox_List_Adding_Item;
		private ListView listView1;
	}
}