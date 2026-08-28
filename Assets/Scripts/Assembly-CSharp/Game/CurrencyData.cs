namespace Game
{
	public class CurrencyData : ResourceEntityHasVisual
	{
		public int Limit;

		public int Default;

		public int AutoRefillTime;

		public int RefillValue;

		public bool IsCombatCurrency;

		public bool Refillable => false;

		public CurrencyData(int id)
			: base(0)
		{
		}

		public int GetLimit()
		{
			return 0;
		}
	}
}
