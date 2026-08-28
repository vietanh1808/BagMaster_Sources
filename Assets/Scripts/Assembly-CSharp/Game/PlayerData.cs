using System;
using System.Collections.Generic;
using Game.Shop;

namespace Game
{
	[Serializable]
	public class PlayerData
	{
		public string Version;

		public long TotalPlayTimeSeconds;

		public int CheckinDay;

		public long LatestCheckinDay;

		public long DailyLoginLastClaimedTime;

		public short DailyLoginDay;

		public int DailyEnergyPurchaseCount;

		public int DailyEnergyAdsRewardCount;

		public ShopRefreshTime EnergyPurchaseTime;

		public List<int> UnlockedFeatures;

		public List<FTUEData> FtueDatas;

		public int TalentProgress0;

		public int TalentProgress1;

		public OwnedResourceEntity MainCampaginProgress;

		public int NextChapterCheckVar;

		public List<CampaignProgressData> CampaignProgressDatas;

		public OwnedResourceEntity HardModeProgress;

		public OwnedResourceEntity HellModeProgress;

		public CampaignDifficultyMode LastPlayedCampaignMode;

		[Obsolete("Use CompletedCampaignIds instead")]
		public List<int> CompletedLevelIds;

		public List<int> CompletedCampaignIds;

		public int WaveReachedInCurrentCampaign;

		public List<int> ClaimedCampaignRewards;

		public bool HasPurchaseAnyIap;

		public int AdsRemovalLastOfferType;

		public long AdsRemovalAppearTime;

		public long FirstSubscriptionShownTime;

		public long LatestSubscriptionShownTime;

		public List<SubscriptionData> Subscriptions;

		public long LatestSubscriptionCardDiscountShownTime;

		public long LatestSubscriptionMidasDiscountShownTime;

		public int RecycleTier;

		public int BenchTier;

		public List<int> UnlockedBuffIds;

		public long SevenDaysUnlockedTime;

		public int SevenDaysProgressQuestClaimedLevel;

		public int SevenDaysProgressBundleClaimedLevel;

		public List<SevenDayEventSaveData> SevenDayEvents;

		public bool SevenDaysTimelineCapped;

		public int SevenDaysTimelineDayOffset;

		public int CombatSpeedLevel;

		public PlayerDataDailyGift DailyGift;

		public bool LinkAccountRewardClaimed;

		public SkipRollAnimation SkipRollAnim { get; set; }
	}
}
