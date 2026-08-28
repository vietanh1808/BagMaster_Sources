using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelCurrencyData
	{
		public int Id;

		public string NameKey;

		public string DescKey;

		public string Icon;

		public int Limit;

		public int Default;

		public int AutoRefillTime;

		public int RefillValue;

		public string Rarity;

		public bool DisplayOwned;

		public bool IsCombatCurrency;
	}
}
