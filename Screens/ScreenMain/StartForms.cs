using D_DCharLists.Screens.ScreenMain;

namespace D_DCharLists
{
	public partial class StartForms : Form
	{
		CreateChar createChar;

		#region Методы

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

		#endregion

		#region Конструкторы

		public StartForms()
		{
			InitializeComponent();
		}

		#endregion
	}
}
