using System;

namespace Game.Shop
{
	[Serializable]
	public class ShopItemPurchaseCount
	{
		public int PackId;

		public int GroupId;

		public int PurchaseCount;

		public ShopItemPurchaseCount(int packId, int groupId = 0)
		{
		}

		public void IncrementPurchaseCount()
		{
		}

		public void ResetPurchaseCount()
		{
		}
	}
}
