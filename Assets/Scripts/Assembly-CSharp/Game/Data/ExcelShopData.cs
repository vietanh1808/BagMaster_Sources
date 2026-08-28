using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelShopData
	{
		public bool Active;

		public int Id;

		public int GroupId;

		public string Name;

		public string Description;

		public string Icon;

		public string Category;

		public string PurchaseMax;

		public string PurchaseMaxInDay;

		public string IngameCurrencyCost;

		public string Reward;

		public int GachaChestId;

		public string RefreshType;

		public string FakeMultipeValue;

		public int AdsPurchasePerDay;

		public int FreePurchasePerDay;

		public int UnlockAtChapter;

		public string ProductType;

		public bool IsIap;

		public string IapProductId;

		public int Duration;

		public string DailyBonus;

		public string SubscriptionIds;
	}
}
