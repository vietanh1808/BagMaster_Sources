using System;

namespace Game
{
	[Serializable]
	public struct LogPurchaseShopPackData
	{
		public long LastPurchaseTime;

		public int PackId;

		public int GroupId;

		public int TotalPurchase;

		public bool IsDataValid()
		{
			return false;
		}
	}
}
