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

		#endregion

		#region Конструкторы

		public StartForms()
		{
			InitializeComponent();
		}

		#endregion
	}
}
