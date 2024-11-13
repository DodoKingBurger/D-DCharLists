namespace D_DCharLists
{
	/// <summary>
	/// Заклинание.
	/// </summary>
	public class Spell : SpellBase
	{
		public Spell()
		{
			this.Name = string.Empty;
			this.Level = 0;
			this.Id = 1001;
			this.FromСharacteristic = " ";
			this.UseMasterBonus = false;
			this.DamageType = "";
			this.AdditionalModifiers = 0;
		}
	}
}