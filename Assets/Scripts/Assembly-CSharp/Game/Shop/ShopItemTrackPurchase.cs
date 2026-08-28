using System;

namespace Game.Shop
{
	[Serializable]
	public class ShopItemTrackPurchase
	{
		public int[] PurchaseNoPityCounts;

		public int Id { get; private set; }

		public DateTime LastDayPurchase { get; private set; }

		public ShopItemTrackPurchase(int id)
		{
		}

		public void TrackPurchaseDay()
		{
		}

		public int GetNoPityCount(int pityIndex)
		{
			return 0;
		}

		public void IncrementNoPityCount(int pityIndex)
		{
		}

		public void ResetNoPityCount(int pityIndex)
		{
		}
	}
}
