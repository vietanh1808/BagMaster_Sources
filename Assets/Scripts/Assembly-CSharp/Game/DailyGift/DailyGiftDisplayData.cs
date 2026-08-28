using Game.Data;

namespace Game.DailyGift
{
	public class DailyGiftDisplayData
	{
		public enum State
		{
			Claimable = 0,
			AdsRequire = 1,
			Claimed = 2,
			Locked = 3
		}

		public readonly DailyGiftData Data;

		public readonly int Progress;

		public readonly int TotalAdsRequire;

		public readonly int ClaimedCount;

		public readonly State CurrentState;

		public DailyGiftDisplayData(DailyGiftData data, int progress, int claimedCount, bool locked, int totalAdsRequire)
		{
		}
	}
}
