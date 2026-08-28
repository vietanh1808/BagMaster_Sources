using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelDirectPurchaseData
	{
		public int CurrencyID;

		public string Step_Cost;

		public int Quantity;

		public int Buy_Limit;
	}
}
