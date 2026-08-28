using System;
using System.Collections.Generic;
using Game.Shop;

namespace Game
{
	[Serializable]
	public class PlayerDataAFK
	{
		public bool HadAFKReward;

		public long AFKStartTime;

		public long AFKLastCheckTime;

		public List<ResourceRewardDataRef> AFKRewards;

		public List<ResourceRewardDataRef> QuickAFKRewards;

		public ShopRefreshTime QuickAFKRewardChanceRefreshTime;

		public int QuickAFKRewardBySpendEnergyCountToday;

		public int QuickAFKRewardByWatchAdsCountToday;

		public int QuickAFKRewardedCount;
	}
}
