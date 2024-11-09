namespace D_DCharLists
{
	/// <summary>
	/// Прогрессия.
	/// </summary>
	public class Progression : SheetProgression
	{
		#region Базовый класс

		public override void GainExpirience(int exp)
		{
      this.Expirience += exp;
			CalculateLevel();
		}

		public override int GetProficiencyBonus()
		{
			if (this.Level <= 4)
				return 2;
			else if (this.Level <= 8)
				return 3;
			else if (this.Level <= 12)
				return 4;
			else if (this.Level <= 16)
				return 5;
			else
				return 6;
		}

		public override void LowerExpirience(int exp)
		{
			if (this.Expirience - exp < 0)
			{
        this.Expirience = 0;
			}
			else
			{
        this.Expirience -= exp;
			}

			CalculateLevel();
		}

		public override void CalculateLevel()
		{
			if (this.Expirience <= 299)
        this.Level = 1;
			else if (this.Expirience <= 899)
        this.Level = 2;
			else if (this.Expirience <= 2699)
        this.Level = 3;
			else if (this.Expirience <= 6499)
        this.Level = 4;
			else if (this.Expirience <= 13999)
        this.Level = 5;
			else if (this.Expirience <= 22999)
        this.Level = 6;
			else if (this.Expirience <= 33999)
        this.Level = 7;
			else if (this.Expirience <= 47999)
        this.Level = 8;
			else if (this.Expirience <= 63999)
        this.Level = 9;
			else if (this.Expirience <= 84999)
        this.Level = 10;
			else if (this.Expirience <= 99999)
        this.Level = 11;
			else if (this.Expirience <= 119999)
        this.Level = 12;
			else if (this.Expirience <= 139999)
        this.Level = 13;
			else if (this.Expirience <= 164999)
        this.Level = 14;
			else if (this.Expirience <= 194999)
        this.Level = 15;
			else if (this.Expirience <= 224999)
        this.Level = 16;
			else if (this.Expirience <= 264999)
        this.Level = 17;
			else if (this.Expirience <= 304999)
        this.Level = 18;
			else if (this.Expirience <= 354999)
        this.Level = 19;
			else if (this.Expirience >= 355000)
        this.Level = 20;
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Создаёт стартовую позицию по прогрессии.
		/// уровень 1, опыта 0
		/// </summary>
		public Progression()
		{
      this.Expirience = 0;
      this.Level = 1;
		}

		#endregion
	}
}