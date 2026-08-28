using System;
using System.Collections.Generic;

namespace Game
{
	public static class GlobalConfigs
	{
		public static readonly int MaxEnergyAdsReceivePerDay;

		public static readonly ResourceRequireData[] EnergyPurchaseCost;

		public static readonly RewardPack[] EnergyPurchaseRewards;

		public static readonly RewardPack[] EnergyWatchAdsRewards;

		public static readonly ResourceRequireData QuickHuntEnergyCost;

		public static readonly int QuickHuntTickNumber;

		[Obsolete("Use QuickPatrolLimitAds by StatSystem")]
		public static readonly int MaxQuickAFKRewardByWatchAdsPerDay;

		[Obsolete("Use QuickPatrolLimit by StatSystem")]
		public static readonly int MaxQuickAFKRewardBySpendEnergyPerDay;

		public static readonly ResourceRewardDataRef[] QuickPatrolFirstTime;

		public static readonly int MaxRerollCombatBuffByWatchAdsPerRun;

		[Obsolete("Use TakeAllBuffsConfigs instead")]
		public static readonly ResourceRequireData[] TakeAllCombatBuffCost;

		public const int MaxTakeAllCombatBuffByAdsPerRun = 3;

		public const int RerollCombatBuffUnlockAtChapter = 3;

		public const int TakeAllCombatBuffUnlockAtChapter = 3;

		public static readonly int GachaFixId;

		public static readonly int[] GachaFix;

		public static readonly int[] BlueChestIds;

		public static readonly int[] PurpleChestIds;

		public static readonly int[] YelloChestIds;

		public const int AdsRemoval1DurationInDays = 14;

		public const int AdsRemoval1DurationInDays_New = 9999;

		public static readonly int[] BluePrintIds;

		public static float BuySlotAdsThresold;

		public static float GearRerollAdsThresold;

		public const int PackIdCardLifeTime = 3005;

		public const int PackIdCardLifeTimeDiscount = 3010;

		public const int PackIdCardMonthly = 3006;

		public const int PackIdMidasLifeTime = 3007;

		public const int PackIdMidasLifeTimeDiscount = 3011;

		public const int PackIdMidasMonthly = 3008;

		public const int PackIdCardNMidasBundle = 3009;

		public const string MAX = "MAX";

		public static readonly ContinueFromDefeatConfig ContinueFromDefeatConfig;

		public static readonly ResourceRewardData LinkAccountReward;

		public static readonly bool IsActiveSkillAdsResetCooldown;

		public static readonly bool IsInstantActiveSkillByAds;

		public static readonly int ActiveSkillAdsGemRequired;

		public static readonly int ActiveSkillCooldownAdsThreshold;

		public static readonly int ActiveSkillCooldownAdsUnlockAtChapter;

		public static readonly int MaxActiveSkillCooldownAdsBeforeReady;

		public static readonly int RequireActiveSkillCooldownCountBefore;

		public static readonly IReadOnlyDictionary<int, ISet<int>> LevelsWithRecommendBuff;

		private static CloudSaveConfig? _cloudSaveConfig;

		public const int BlackMarketRefreshCycleHours = 6;

		public static readonly List<ResourceRequireData> BlackMarketRefreshPricing;

		private static QuickAidConfig[] _reviveConfigs;

		private static readonly QuickAidConfig[] DefaultReviveConfigs;

		private static QuickAidConfig[] _takeAllBuffsConfigs;

		private static readonly QuickAidConfig[] DefaultTakeAllBuffsConfigs;

		public static int MaxEnergyPurchasePerDay => 0;

		public static int QuickMineChapterUnlock => 0;

		public static float RevivePopupDurationInSeconds => 0f;

		public static int AdsRemovalUnlockAtChapter => 0;

		public static int AdsRemovalDiscount1AppearAtChapter => 0;

		public static int AdsRemovalDiscountCycleInDays => 0;

		public static int AdsRemovalDiscount1AppearDelayInDays => 0;

		public static int AdsRemovalDiscount1DurationInHours => 0;

		public static int AdsRemovalDiscount2AppearDelayAfter1InDays => 0;

		public static int AdsRemovalDiscount2DurationInHours => 0;

		public static int BuySlotAdsWaveUnlocked => 0;

		public static int BuySlotAdsChapterUnlocked => 0;

		public static int GearRerollAdsWaveUnlocked => 0;

		public static int GearRerollAdsChapterUnlocked => 0;

		public static RewardPack[] GearCollectionItemReward => null;

		public static int PackCardLifeTimeDiscountAfterDays => 0;

		public static int PackMidasLifeTimeDiscountAfterDays => 0;

		public static int PackCardLifeTimeDiscountDurationInHours => 0;

		public static int PackMidasLifeTimeDiscountDurationInHours => 0;

		public static int SubscriptionCapMaxStackDailyClaim => 0;

		public static bool PackCardLifeTimeDiscountActive => false;

		public static bool PackMidasLifeTimeDiscountActive => false;

		public static float EquipmentSTierStatScale => 0f;

		public static int SevenDayChallangeDurationInDay => 0;

		public static int SevenDayLegacyTimelineCapDay => 0;

		public static int AdsRemovalRepeatOfferAfterInterCount => 0;

		public static bool IsDeveloperMode => false;

		public static int DailyGiftCycleDurationInHours => 0;

		public static bool ProductLogEnabled => false;

		public static int InterAdsWaveInterval => 0;

		public static int MonsterLevelVariant => 0;

		public static int EnergyRefillDuration => 0;

		public static int NewbiePackUnlockCampaignId => 0;

		public static CloudSaveConfig CloudSaveConfig => default;

		public static bool IsHardHellModeEnabled => false;

		public static bool IsElementalIconEnabled => false;

		public static int RewardConfigVariant => 0;

		public static int LevelConfigVariant => 0;

		public static int MaxRevivePerRun => 0;

		public static IReadOnlyList<QuickAidConfig> ReviveConfigs => null;

		public static IReadOnlyList<QuickAidConfig> TakeAllBuffsConfigs => null;

		public static int MaxTakeAllCombatBuffByPurchasePerRun => 0;

		public static string BattlePassLocalizeExtraTitle(bool maximumLevel)
		{
			return null;
		}

		private static T GetConfigFromJson<T>(ref T config, string json, T defaultValue)
		{
			return default;
		}
	}
}
