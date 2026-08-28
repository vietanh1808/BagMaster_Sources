using System;
using System.Collections.Generic;

namespace Game.Data
{
	[Serializable]
	public struct BlackMarketShopData
	{
		public int Id;

		public int GroupId;

		public int Weight;

		public int LimitPurchase;

		public int OriginalCurrency;

		public int MostDealPack;

		public string FakeMultipleValueVisual;

		public static BlackMarketShopData Pick(List<BlackMarketShopData> items)
		{
			return default;
		}
	}
}
