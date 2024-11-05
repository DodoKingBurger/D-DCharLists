namespace D_DCharLists
{
	partial class StartForms
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForms));
			groupBoxMenu = new GroupBox();
			btCreateChar = new Button();
			groupBoxMenu.SuspendLayout();
			SuspendLayout();
			// 
			// groupBoxMenu
			// 
			groupBoxMenu.Controls.Add(btCreateChar);
			groupBoxMenu.Dock = DockStyle.Left;
			groupBoxMenu.Location = new Point(0, 0);
			groupBoxMenu.Name = "groupBoxMenu";
			groupBoxMenu.Size = new Size(421, 1002);
			groupBoxMenu.TabIndex = 0;
			groupBoxMenu.TabStop = false;
			groupBoxMenu.Text = "Главное меню";
			// 
			// btCreateChar
			// 
			btCreateChar.Location = new Point(12, 76);
			btCreateChar.Name = "btCreateChar";
			btCreateChar.Size = new Size(235, 34);
			btCreateChar.TabIndex = 0;
			btCreateChar.Text = "Создать персонажа";
			btCreateChar.UseVisualStyleBackColor = true;
			btCreateChar.Click += btCreateChar_Click;
			// 
			// StartForms
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1422, 1002);
			Controls.Add(groupBoxMenu);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "StartForms";
			Text = "D&DCharList";
			groupBoxMenu.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxMenu;
		private Button btCreateChar;
	}
}
