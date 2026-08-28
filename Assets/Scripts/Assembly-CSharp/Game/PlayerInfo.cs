using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.Combat;
using Game.Combat.SkillSystem;
using Game.Data;
using Game.EquipmentSystem;
using Game.EventDungeon;
using Game.Newbie;
using Game.Shop;
using Game.Talent;
using Newtonsoft.Json;
using R3;

namespace Game
{
	public class PlayerInfo
	{
		public delegate void SkipRollAnimationChange(bool value, bool isDungeonMode);

		[CompilerGenerated]
		private Action m_OnAFKRewardClaimedEvent;

		[CompilerGenerated]
		private Action m_ONQuickAFKRewardClaimedEvent;

		public const string KEY_FTUE_CUTSCENE = "CutScene_1";

		public const string KEY_INGAME_1 = "InGame_1";

		public const string KEY_SLOT = "Introduce_Slots";

		public const string KEY_SKILL = "Introduce_Skill";

		public const string KEY_STOW = "Introduce_Stows";

		public const string KEY_EQUIPMENT = "Equipment";

		public const string KEY_TALENT = "Talent";

		public const string KEY_DUNGEON = "Dungeon";

		public const string KEY_7DAY = "7 Days Login";

		public const string KEY_ELEMENTAL_TUTORIAL = "Elemental_Tutorial";

		private OwnedResourceEntity goldCaveCoin;

		[JsonIgnore]
		public Action OnStatChanged;

		[CompilerGenerated]
		private Action m_OnGearStatChangedEvent;

		public bool FirstIAPPurchase;

		public PlayerDataMeta PlayerDataMeta;

		public PlayerData PlayerData;

		public PlayerDataInventory PlayerDataInventory;

		public PlayerDataResources PlayerDataResources;

		public PlayerDataShop PlayerDataShop;

		public PlayerDataAFK PlayerDataAFK;

		public PlayerDataGears PlayerDataGears;

		public CombatSaveData CombatSaveData;

		public EventDungeonSaveData EventDungeonSaveData;

		public PlayerDataQuest PlayerDataQuest;

		public PlayerDataMail PlayerDataMail;

		public PlayerNewbieEventData PlayerNewbieEventData;

		public PlayerChainPackEventData PlayerChainPackEventData;

		public PlayerDataPendingRewards PlayerDataPendingRewards;

		public PlayerInfoArena PlayerInfoArena;

		public PlayerInfoBlackMarket PlayerInfoBlackMarket;

		public CombatDefeatData CombatDefeatData;

		public EventPayloadData EventPayloadData;

		[CompilerGenerated]
		private Action<int, TimeSpan> m_OnSubscribedEvent;

		[CompilerGenerated]
		private Action<int> m_OnSubscriptionDailyClaimedEvent;

		[JsonIgnore]
		private DisposableBag _disposableBag;

		[JsonIgnore]
		private bool _dontUpdateSaveInformation;

		[JsonIgnore]
		private float _lastPlayTimeUnscaled;

		[CompilerGenerated]
		private Action<CampaignDifficultyMode, int> m_CampaignProgressed;

		[CompilerGenerated]
		private Action<CampaignDifficultyMode, int> m_CampaignMilestoneRewardClaimed;

		[CompilerGenerated]
		private Action<int, int> m_OnDailyGiftClaimedEvent;

		[Obsolete]
		public DateTime LastClaimDailyRewardTime;

		[CompilerGenerated]
		private Action<string> m_OnFeatureUnlockedEvent;

		[CompilerGenerated]
		private Action<OwnedItemEntity> m_OnGearEquipped;

		[CompilerGenerated]
		private Action<OwnedItemEntity> m_OnGearUnequipped;

		[CompilerGenerated]
		private Action<int, int> m_OnGearUpgradedEvent;

		[CompilerGenerated]
		private Action<int, int> m_OnGearMasteryIncreasedEvent;

		[CompilerGenerated]
		private Action<int, int> m_OnGearMasteryLevelClaimedEvent;

		[CompilerGenerated]
		private Action<int> m_OnGearCollectionClaimedEvent;

		[JsonIgnore]
		public Action<OwnedItemEntity> OnReceivedItem;

		[JsonIgnore]
		public Action<OwnedItemEntity> OnRemoveItem;

		private List<OwnedItemEntity> _ownedItems;

		private List<OwnedItemEntity> _equippedItems;

		[CompilerGenerated]
		private Action<OwnedItemEntity> m_OnReceivedItemEvent;

		[CompilerGenerated]
		private Action<OwnedItemEntity> m_OnRemoveItemEvent;

		[CompilerGenerated]
		private Action<OwnedItemEntity> m_OnEquipmentEquippedEvent;

		[CompilerGenerated]
		private Action<OwnedItemEntity> m_OnEquipmentUnequippedEvent;

		[CompilerGenerated]
		private Action<int, int> m_OnEquipmentLevelChangedEvent;

		[CompilerGenerated]
		private Action<OwnedItemEntity[], OwnedItemEntity> m_OnEquipmentFusedEvent;

		[CompilerGenerated]
		private Action<int> m_OnMainCampaginProgressedEvent;

		[CompilerGenerated]
		private Action<int> m_OnMainCampaginMilestoneRewardClaimedEvent;

		[CompilerGenerated]
		private Action<int> m_OnCampaignCompletedFirstTimeEvent;

		[CompilerGenerated]
		private static SkipRollAnimationChange m_OnSkipRollAnimationChanged;

		[CompilerGenerated]
		private Action<int> m_OnQuestCompletedEvent;

		[CompilerGenerated]
		private Action<OwnedResourceEntity, int> m_OnResourceChangedEvent;

		[CompilerGenerated]
		private Action<OwnedResourceEntity, int, string> m_OnResourceChangedWithPlacementEvent;

		[CompilerGenerated]
		private Action<RewardPack> m_OnRewardReceive;

		[CompilerGenerated]
		private static Action<(int rewardId, int rewardValue)> m_OnRewardReceivedGlobal;

		[CompilerGenerated]
		private Action m_OnAdsRemovalPurchasedEvent;

		[CompilerGenerated]
		private Action<int> m_OnGachaPityChangeEvent;

		[JsonIgnore]
		public Action<int> OnTalentUpgraded;

		[JsonIgnore]
		public Action<int> OnPlayerLevelUp;

		[JsonIgnore]
		public OwnedResourceEntity GoldCaveGoldCoin => null;

		[JsonIgnore]
		public OwnedResourceEntity CombatGold => null;

		[JsonIgnore]
		public OwnedResourceEntity CombatExp => null;

		[JsonIgnore]
		public OwnedResourceEntity Energy => null;

		[JsonIgnore]
		public List<PlayerSkillData> PlayerPassives { get; }

		[JsonIgnore]
		public List<Stat> Stats { get; private set; }

		public GenericStringKeySaveListService StringKeySaveService { get; private set; }

		public bool IsNewDaySession { get; private set; }

		public int SubscriptionIdCardLifeTime { get; private set; }

		public int SubscriptionIdCardMonthly { get; private set; }

		public int SubscriptionIdMidasLifeTime { get; private set; }

		public int SubscriptionIdMidasMonthly { get; private set; }

		[JsonIgnore]
		public ShopRefreshTime ShopRefreshTimeByDay { get; private set; }

		[JsonIgnore]
		public ShopRefreshTime ShopRefreshTimeByWeek { get; private set; }

		[JsonIgnore]
		public ShopRefreshTime ShopRefreshTimeByMonth { get; private set; }

		[JsonIgnore]
		public OwnedResourceEntity Exp => null;

		[JsonIgnore]
		public int PlayerLevelIndex { get; private set; }

		[JsonIgnore]
		public int PlayerLevel => 0;

		public event Action OnAFKRewardClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action ONQuickAFKRewardClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnGearStatChangedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, TimeSpan> OnSubscribedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnSubscriptionDailyClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CampaignDifficultyMode, int> CampaignProgressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<CampaignDifficultyMode, int> CampaignMilestoneRewardClaimed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> OnDailyGiftClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnFeatureUnlockedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity> OnGearEquipped
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity> OnGearUnequipped
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> OnGearUpgradedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> OnGearMasteryIncreasedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> OnGearMasteryLevelClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnGearCollectionClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity> OnReceivedItemEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity> OnRemoveItemEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity> OnEquipmentEquippedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity> OnEquipmentUnequippedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> OnEquipmentLevelChangedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedItemEntity[], OwnedItemEntity> OnEquipmentFusedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Use CampaignProgressed event instead")]
		public event Action<int> OnMainCampaginProgressedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Obsolete("Use CampaignMilestoneRewardClaimed event instead")]
		public event Action<int> OnMainCampaginMilestoneRewardClaimedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnCampaignCompletedFirstTimeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event SkipRollAnimationChange OnSkipRollAnimationChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnQuestCompletedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedResourceEntity, int> OnResourceChangedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OwnedResourceEntity, int, string> OnResourceChangedWithPlacementEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<RewardPack> OnRewardReceive
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<(int rewardId, int rewardValue)> OnRewardReceivedGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnAdsRemovalPurchasedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnGachaPityChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void InitializeAFKReward()
		{
		}

		public void ResetAFKStartTime()
		{
		}

		public void AddAFKReward(int id, int value)
		{
		}

		public IReadOnlyCollection<ResourceRewardDataRef> GetAFKRewards()
		{
			return null;
		}

		public DateTime GetAFKStartTime()
		{
			return default;
		}

		public DateTime GetAFKLastCheckTime()
		{
			return default;
		}

		public void AddTimeToAFKLastCheckTime(double timeInMinute)
		{
		}

		public void InvokeClaimReward()
		{
		}

		public bool HasQuickAFKRewards()
		{
			return false;
		}

		public IReadOnlyCollection<ResourceRewardDataRef> GetQuickRewards()
		{
			return null;
		}

		public void AddQuickAFKReward(int id, int value)
		{
		}

		public void ClearQuickRewards()
		{
		}

		public void CheckAndResetQuickAFKRewardCounts()
		{
		}

		public void IncreaseQuickAFKRewardCount()
		{
		}

		public void IncreaseQuickAFKRewardByWatchAdsCount()
		{
		}

		public void IncreaseQuickAFKRewardBySpendEnergyCount()
		{
		}

		public int GetQuickAFKRewardBySpendEnergyCount()
		{
			return 0;
		}

		public int GetQuickAFKRewardByWatchAdsCount()
		{
			return 0;
		}

		public int GetRemainQuickAFKByWatchAdsToday()
		{
			return 0;
		}

		public int GetRemainQuickAFKBySpendEnergyToday()
		{
			return 0;
		}

		public void InvokeClaimQuickReward()
		{
		}

		private void AddAFKRewards(List<ResourceRewardDataRef> rewards, int id, int amount)
		{
		}

		public void SavePlayerAfk()
		{
		}

		public bool IsFTUECompleted(string key)
		{
			return false;
		}

		public void SetFTUECompleted(string key)
		{
		}

		public bool IsFTUECutsceneCompleted()
		{
			return false;
		}

		public void SetFTUECutsceneCompleted()
		{
		}

		public void SaveFtue()
		{
		}

		~PlayerInfo()
		{
		}

		public void Initialize()
		{
		}

		private void ApplyDeveloperMode()
		{
		}

		public void InitializeStats()
		{
		}

		private void InitializeEquipmentInventory()
		{
		}

		private void InitializeFirstGears()
		{
		}

		private void InitializeSubscriptions()
		{
		}

		public int GetCombatSpeedLevel()
		{
			return 0;
		}

		public void SetCombatSpeedLevel(int newLevel)
		{
		}

		public Stat GetStat(int id)
		{
			return null;
		}

		public int GetQuickPatrolLimitPerDay()
		{
			return 0;
		}

		public int GetQuickPatrolLimitAdsPerDay()
		{
			return 0;
		}

		public void TriggerStatChanged()
		{
		}

		public void TriggerGearStatChanged()
		{
		}

		public long GetTimeNowInLong()
		{
			return 0L;
		}

		public long GetTimeNowSub1DayInLong()
		{
			return 0L;
		}

		public void ResyncMetaData()
		{
		}

		private void UpdateSaveInformation()
		{
		}

		private void AccumulatePlayTime()
		{
		}

		public void Save(string fileName, object objectToSave)
		{
		}

		public void SavePlayerData()
		{
		}

		public void SaveCombatSaveData()
		{
		}

		public void SaveDefeatData()
		{
		}

		public void SaveEventDungeonProgress()
		{
		}

		public void SaveMail()
		{
		}

		public void SaveEventPayload()
		{
		}

		public void SaveAll()
		{
		}

		public void RemoveCombatSaveData()
		{
		}

		public void CheckIn()
		{
		}

		public int GetCheckInDay()
		{
			return 0;
		}

		private void LogErrorTest(string msg)
		{
		}

		private void CheckRecyclePremium()
		{
		}

		public bool IsRecyclePremium()
		{
			return false;
		}

		public void SetRecyclePremium(bool enable)
		{
		}

		private void CheckBenchPremium()
		{
		}

		public bool IsBenchPremium()
		{
			return false;
		}

		public void SetBenchPremium(bool enable)
		{
		}

		public int GetConsecutiveLosesCount()
		{
			return 0;
		}

		public void IncreaseConsecutiveLosesCount()
		{
		}

		public void ResetConsecutiveLosesCount()
		{
		}

		public bool HasPurchaseAnyIap()
		{
			return false;
		}

		public void SetPurchasedAnyIap()
		{
		}

		public bool WasSubscriptionShown()
		{
			return false;
		}

		public void SetSubscriptionShown()
		{
		}

		public void FetchSubscriptions()
		{
		}

		public void AddSubscription(int subscriptionId, TimeSpan duration)
		{
		}

		public TimeSpan GetSubcriptionRemainDuration(int subscriptionId)
		{
			return default;
		}

		private TimeSpan GetSubcriptionRemainDuration(SubscriptionData data)
		{
			return default;
		}

		private TimeSpan GetSubscriptionPassedTime(SubscriptionData data)
		{
			return default;
		}

		public bool IsSubscribed(int subscriptionId)
		{
			return false;
		}

		private SubscriptionData GetSubscriptionData(int subscriptionId)
		{
			return null;
		}

		public bool IsSubscriptionDailyClaimable(int subscriptionId, out bool isClaimedToday, out int dayPassed)
		{
			isClaimedToday = default;
			dayPassed = default;
			return false;
		}

		public void SetSubscriptionDailyClaimTimeNow(int subscriptionId)
		{
		}

		public bool InMidasSubscription()
		{
			return false;
		}

		public void GetSubscriptionInfo(int subscriptionId, out bool isSubscribed, out TimeSpan timePassed)
		{
			isSubscribed = default;
			timePassed = default;
		}

		public bool IsSubscriptionCardDiscountShown()
		{
			return false;
		}

		public bool IsSubscriptionMidasDiscountShown()
		{
			return false;
		}

		public TimeSpan GetSubscriptionCardDiscountShownTimePassed()
		{
			return default;
		}

		public TimeSpan GetSubscriptionMidasDiscountShownTimePassed()
		{
			return default;
		}

		public void SetSubscriptionCardDiscountShowTimeNow()
		{
		}

		public void SetSubscriptionMidasDiscountShowTimeNow()
		{
		}

		public bool IsLinkAccountRewardClaimed()
		{
			return false;
		}

		public void SetLinkAccountRewardClaimed()
		{
		}

		public void SaveArena()
		{
		}

		public void SaveBlackMarket()
		{
		}

		public bool IsBuffUnlocked(int buffId)
		{
			return false;
		}

		public void UnlockBuff(int buffId)
		{
		}

		public bool HasPlayedNewestCampaign(CampaignDifficultyMode campaignMode)
		{
			return false;
		}

		public int GetProgress(CampaignDifficultyMode mode)
		{
			return 0;
		}

		public OwnedResourceEntity GetProgressEntity(CampaignDifficultyMode mode)
		{
			return null;
		}

		public void IncreaseCampaignProgress(CampaignDifficultyMode mode)
		{
		}

		public void InvokeCampaignProgressedEvent(CampaignDifficultyMode mode)
		{
		}

		public void ClaimCampaignMilestoneReward(CampaignDifficultyMode mode, int rewardId)
		{
		}

		public bool IsCampaignRewardClaimed(int rewardId)
		{
			return false;
		}

		public int GetWaveReached(int campaignId)
		{
			return 0;
		}

		public void ChainPackInitialize(int groupId, int duration)
		{
		}

		public long ChainPackGetRemainingTime()
		{
			return 0L;
		}

		public long ChainPackGetRemainingTimeByGroup(int groupId)
		{
			return 0L;
		}

		public bool ChainPackContainsGroup(int groupId)
		{
			return false;
		}

		public bool IsChainPackExpired()
		{
			return false;
		}

		public bool HasUnclaimedChainPack()
		{
			return false;
		}

		public bool IsChainPackEnableNotify()
		{
			return false;
		}

		public void ChainPackClaimItem(int groupId, int level)
		{
		}

		public bool ChainPackFindByIndex(int index, out int groupId)
		{
			groupId = default;
			return false;
		}

		public int GetChainPackCount()
		{
			return 0;
		}

		public int GetChainPackLevel(int groupId)
		{
			return 0;
		}

		public bool CheckChainPackExpired()
		{
			return false;
		}

		public void SaveChainPack()
		{
		}

		public static void DeleteChainPackEvent()
		{
		}

		public PlayerDataDailyGift GetDailyGiftSaveData()
		{
			return null;
		}

		public void StartNewDailyGiftCycle()
		{
		}

		public DateTime GetDailyGiftCycleStartTime()
		{
			return default;
		}

		public bool IsDailyGiftCycleExpired()
		{
			return false;
		}

		public TimeSpan GetDailyGiftRemainTimeUntilNextRefresh()
		{
			return default;
		}

		public IReadOnlyList<int> GetDailyGiftOfferIds()
		{
			return null;
		}

		public void AddDailyGiftOffers(List<DailyGiftData> giftDatas)
		{
		}

		public bool IsDailyGiftEmpty()
		{
			return false;
		}

		public void GetDailyGiftOfferStatus(int giftId, out int progress, out int claimed)
		{
			progress = default;
			claimed = default;
		}

		public int GetDailyGiftOfferProgress(int giftId)
		{
			return 0;
		}

		public int IncreaseDailyGiftOfferProgress(int giftId)
		{
			return 0;
		}

		public int GetDailyGiftOfferClaimedCount(int giftId)
		{
			return 0;
		}

		public int IncreaseDailyGiftClaimedCount(int giftId)
		{
			return 0;
		}

		private bool TryGetDailyGiftOfferProgress(int giftId, out DailyGiftProgress giftProgress)
		{
			giftProgress = null;
			return false;
		}

		private void SaveDailyGift()
		{
		}

		public DateTime GetDailyLoginLastClaimedTime()
		{
			return default;
		}

		public bool IsDailyLoginFirstClaim()
		{
			return false;
		}

		public bool WasDailyLoginClaimedToday()
		{
			return false;
		}

		public void UpdateDailyLoginLastClaimedTime()
		{
		}

		public int GetDailyLoginDay()
		{
			return 0;
		}

		public void IncreaseDailyLoginDay()
		{
		}

		public void SaveDailyLogin()
		{
		}

		public void CheatDailyLoginTimeByDay()
		{
		}

		public bool IsDailyLoginAllClaimed()
		{
			return false;
		}

		public void ClearDailyLoginSave()
		{
		}

		public void IncreaseDailyEnergyPurchaseCount()
		{
		}

		public void IncreaseDailyEnergyAdsRewardCount()
		{
		}

		public int GetDailyEnergyPurchaseCountToday()
		{
			return 0;
		}

		public int GetDailyEnergyAdsRewardCountToday()
		{
			return 0;
		}

		public bool CheckAndResetEnergyCounts()
		{
			return false;
		}

		public bool CanPurchaseEnergy()
		{
			return false;
		}

		public bool CanReceiveEnergyFromAds()
		{
			return false;
		}

		public void SaveDailyEnergy()
		{
		}

		public void ClearAllEventDungeonTickets()
		{
		}

		public void GiveDailyFreeTicket()
		{
		}

		public void RefreshEventTickets()
		{
		}

		public bool ShouldRefreshEventDungeonData()
		{
			return false;
		}

		public void CheckAndRefreshEventDungeonData()
		{
		}

		public void CompleteEventDungeonLevel(int eventDungeonId, int level)
		{
		}

		public EventDungeonProgressData CreateNewEventDungeonProgressData(EventDungeonUnlockViewState config)
		{
			return null;
		}

		public bool IsEventDungeonLevelCompleted(int dungeonId, int dungeonLevel)
		{
			return false;
		}

		public bool IsEventDungeonUnlocked(int dungeonId)
		{
			return false;
		}

		public bool IsFeatureUnlocked(string featureName)
		{
			return false;
		}

		public void SetUnlockFeature(string featureName)
		{
		}

		public bool IsFeatureShopUnlocked()
		{
			return false;
		}

		public bool IsFeatureMineUnlocked()
		{
			return false;
		}

		public bool IsAnyChaperPackOfferAvailable()
		{
			return false;
		}

		public bool IsEventDungeonUnlocked()
		{
			return false;
		}

		public bool IsSevenDayChallengeUnlocked()
		{
			return false;
		}

		public bool IsEquipmentUnlocked()
		{
			return false;
		}

		public bool IsTalentUnlocked()
		{
			return false;
		}

		public bool IsWishingPacksUnlocked()
		{
			return false;
		}

		public bool IsDailyGiftUnlocked()
		{
			return false;
		}

		public void InitializeGear()
		{
		}

		public IReadOnlyCollection<OwnedItemEntity> GetEquippedGears()
		{
			return null;
		}

		public IReadOnlyCollection<int> GetAppearedGearIds()
		{
			return null;
		}

		public List<GearData> GetAppearedGearsLv1()
		{
			return null;
		}

		public void AddGear(int gearId)
		{
		}

		public void EquipGear(OwnedItemEntity item)
		{
		}

		public void UnEquipGear(OwnedItemEntity item)
		{
		}

		public bool IsEquippedGear(OwnedItemEntity item)
		{
			return false;
		}

		public bool IsEquippedGear(int id)
		{
			return false;
		}

		public bool WasGearShowedInCombat(int gearId)
		{
			return false;
		}

		public void AddShowedGearInCombat(int gearId)
		{
		}

		public int GetGearUpgradeLevel(int upgradeId)
		{
			return 0;
		}

		public void IncreaseGearUpgradeLevel(int upgradeId)
		{
		}

		public int GetGearMasteryPoint(int id)
		{
			return 0;
		}

		public int GetGearMasteryLevelClaimed(int id)
		{
			return 0;
		}

		public void IncreaseGearMasteryPoint(int id, int value)
		{
		}

		public void MarkMasteryLevelClaimed(int id, int level)
		{
		}

		private GearUpgradeLevelProgress FindGearUpgradeProgress(int id)
		{
			return null;
		}

		private GearUpgradeLevelProgress AddNewGearUpgradeProgress(int id)
		{
			return null;
		}

		private GearMasteryProgress FindGearMasteryProgress(int id)
		{
			return null;
		}

		private GearMasteryProgress AddNewGearMasteryProgress(int id)
		{
			return null;
		}

		public bool WasGearCollectionClaimed(int gearId)
		{
			return false;
		}

		public void MarkGearCollectionClaimed(int gearId)
		{
		}

		public void SaveGears()
		{
		}

		public OwnedItemEntity GetItem(int itemId)
		{
			return null;
		}

		public OwnedItemEntity ReceiveItem(int itemId, string source)
		{
			return null;
		}

		private int CountEquipmentItems(OwnedItemEntity exclude)
		{
			return 0;
		}

		private void TrackEquipmentReceived(OwnedItemEntity item, string source)
		{
		}

		public OwnedItemEntity[] ReceiveManyItems(int itemId, int amount, string source)
		{
			return null;
		}

		[Obsolete]
		public OwnedItemEntity ReceiveItem(int itemId)
		{
			return null;
		}

		[Obsolete]
		public OwnedItemEntity[] ReceiveManyItems(int itemId, int amount)
		{
			return null;
		}

		public bool RemoveItem(OwnedItemEntity item)
		{
			return false;
		}

		public void InvokeEquipmentFused(OwnedItemEntity[] materials, OwnedItemEntity result)
		{
		}

		private void TrackEquipmentFused(OwnedItemEntity[] materials, OwnedItemEntity result)
		{
		}

		public RewardPack ExecuteRevert(OwnedItemEntity item)
		{
			return null;
		}

		public IReadOnlyCollection<OwnedItemEntity> GetAllOwnedItems()
		{
			return null;
		}

		public IReadOnlyCollection<OwnedItemEntity> GetEquippedEquipments()
		{
			return null;
		}

		public bool IsItemEquipped(OwnedItemEntity item)
		{
			return false;
		}

		public void EquipItem(OwnedItemEntity item)
		{
		}

		public void EquipItemBot(OwnedItemEntity item)
		{
		}

		private void TrackEquipmentEquipped(OwnedItemEntity item)
		{
		}

		public void UnequipItem(OwnedItemEntity item)
		{
		}

		private void TrackEquipmentUnequipped(OwnedItemEntity item)
		{
		}

		public int GetEquipmentLevel(EquipmentData equipmentData)
		{
			return 0;
		}

		public int GetEquipmentLevel(OwnedItemEntity ownedEquipment)
		{
			return 0;
		}

		public int GetEquipmentLevel(int levelId)
		{
			return 0;
		}

		public EquipmentLevelData GetEquipmentLevelData(EquipmentData equipmentData)
		{
			return null;
		}

		public EquipmentLevelData GetEquipmentLevelData(OwnedItemEntity equipment)
		{
			return null;
		}

		public void IncreaseEquipmentLevel(OwnedItemEntity ownedEquipment, int amount = 1)
		{
		}

		private void TrackEquipmentUpgraded(OwnedItemEntity ownedEquipment, int newLevel, int previousLevel)
		{
		}

		public void IncreaseEquipmentLevelBot(OwnedItemEntity ownedEquipment, int amount = 1)
		{
		}

		public int GetLevelIdOfEquipment(EquipmentData equipmentData)
		{
			return 0;
		}

		public int GetLevelIdOfItem(OwnedItemEntity ownedEquipment)
		{
			return 0;
		}

		private OwnedResourceEntity FindLevelResource(int levelId)
		{
			return null;
		}

		private void ApplyAllItemStat(OwnedItemEntity item)
		{
		}

		private void ApplyMainStat(OwnedItemEntity item)
		{
		}

		private void ApplySkillToStat(SkillData skillData, object source)
		{
		}

		private void ApplyStatEffect(EffectData effectData, object source)
		{
		}

		private void RemoveAllItemStat(OwnedItemEntity item)
		{
		}

		public bool HasOwnedAnyItemWithId(int itemId)
		{
			return false;
		}

		public bool IsOwnedAnyEquipmentOfPart(EquipmentPart part)
		{
			return false;
		}

		public bool HasAnyEquipmentEquippedAtPart(EquipmentPart part)
		{
			return false;
		}

		public OwnedItemEntity GetEquippmentEquippedAtPart(EquipmentPart part)
		{
			return null;
		}

		public bool IsEquipmentBetterThanEquipped(EquipmentData data)
		{
			return false;
		}

		public bool HasAnyEquippedEquipmentUpgradeable()
		{
			return false;
		}

		public bool HasBetterEquippableEquipment()
		{
			return false;
		}

		public bool HasAnyEmptyEquipSlotEquippable()
		{
			return false;
		}

		public Dictionary<EquipmentPart, (OwnedItemEntity, EquipmentData)> GetEquippedEquipmentInPartTable()
		{
			return null;
		}

		public bool HasAnyMergeableEquipments()
		{
			return false;
		}

		private void CheckQuickEquipItem(OwnedItemEntity newOne)
		{
		}

		public void SaveItems()
		{
		}

		private MailSaveData GetMail(int id)
		{
			return null;
		}

		public long GetMailSentEpoch(int id)
		{
			return 0L;
		}

		public void RemoveMailById(int id)
		{
		}

		public IReadOnlyCollection<MailSaveData> GetAllMails()
		{
			return null;
		}

		public void AddMail(int id, List<ResourceRewardData> rewards)
		{
		}

		public void AddMail(int uniqueId, int mailConfigId, List<ResourceRewardData> rewards)
		{
		}

		public void AddMail(MailSaveData mail)
		{
		}

		public void SetMailRead(int id)
		{
		}

		public void SetAllMailRead()
		{
		}

		public void SetMailClaimed(int id)
		{
		}

		public void SetAllMailClaimed()
		{
		}

		public void DeleteMail(int id)
		{
		}

		public void DeleteAllReadMail()
		{
		}

		public bool HasMail(int id)
		{
			return false;
		}

		public bool HasUnreadMails()
		{
			return false;
		}

		public int GetUnreadCount()
		{
			return 0;
		}

		public void ResetMailBox()
		{
		}

		[Obsolete("Use GetProgress(CampaignDifficultyMode.Normal) instead")]
		public int GetMainCampaignProgress()
		{
			return 0;
		}

		public int GetMainCampaignIndex(int offset = 0)
		{
			return 0;
		}

		[Obsolete("Use IncreaseCampaignProgress(CampaignDifficultyMode.Normal) instead")]
		public void IncreaseMainCampaignProgress()
		{
		}

		[Obsolete("Use InvokeCampaignProgressedEvent(CampaignDifficultyMode.Normal) instead")]
		public void InvokeIncreaseMainCampaginProgress()
		{
		}

		[Obsolete("Use GetProgressEntity(CampaignMode.Normal) instead")]
		public OwnedResourceEntity GetMainCampaignProgressEntity()
		{
			return null;
		}

		[Obsolete("Use CompleteCampaign() and use campagin id instead level id")]
		public void CompleteLevel(int levelId)
		{
		}

		public void CompleteCampaign(int campaignId)
		{
		}

		public void VerifyCompletedCampaignData()
		{
		}

		public bool IsCampaignCompleted(int campaignId)
		{
			return false;
		}

		public bool IsLevelCompleted(int levelId)
		{
			return false;
		}

		[Obsolete("Use IsCampaignRewardClaimed instead")]
		public bool IsMainCampaginRewardClaimed(int rewardId)
		{
			return false;
		}

		public LevelData GetNextMainCampaginRewardLevelData(out Campaign campaign)
		{
			campaign = null;
			return null;
		}

		public int GetWaveReachedOfMainCampagin(int campaignId)
		{
			return 0;
		}

		public int GetWaveReachedInCurrentMainCampagin()
		{
			return 0;
		}

		public int GetNextMainCampaginProgress()
		{
			return 0;
		}

		public void UpdateNextMainCampaginProgress()
		{
		}

		public bool IsFirstMainCampaginReward()
		{
			return false;
		}

		public void SetClaimedMainCampaignReward(int rewardId)
		{
		}

		public void SetWaveReachInCurrentMainCampaign(int wave)
		{
		}

		public void UpdateMainCampaignProgress(int campaignId, int waveReached)
		{
		}

		public void ClearClaimedCampaginRewards()
		{
		}

		public void SaveMainProgress()
		{
		}

		public bool IsNewbieUnlocked(int groupId)
		{
			return false;
		}

		public void NewbieTriggerUnlock()
		{
		}

		public bool IsNewbieEnableNotify()
		{
			return false;
		}

		public bool IsNewbieExpired()
		{
			return false;
		}

		public bool HasAnyUnpurchasedNewbiePack()
		{
			return false;
		}

		public bool TryGetFirstUnpurchasedNewbiePack(out NewbieTabType tab)
		{
			tab = default;
			return false;
		}

		public bool HasClaimableRewardByTab(NewbieTabType tab)
		{
			return false;
		}

		public bool IsNewbieDone()
		{
			return false;
		}

		public int NewbieGetRemainingTime()
		{
			return 0;
		}

		public bool NewbieFindByGroupId(int groupId, out NewbieData newbieData)
		{
			newbieData = null;
			return false;
		}

		public bool NewbieFindByIndex(int index, out NewbieData newbieData)
		{
			newbieData = null;
			return false;
		}

		public bool IsNewbieExistByIndex(int index)
		{
			return false;
		}

		public void NewbieUnlockGroup(int groupId, int duration)
		{
		}

		public void SaveNewbie()
		{
		}

		public static void DeleteNewbieEvent()
		{
		}

		public void SetSkipRollAnimation(bool skip, bool isDungeonMode)
		{
		}

		public void SavePendingRewards()
		{
		}

		public void AddPendingReward(string id, List<ItemDefine> items, string placement, bool isIap, string context = "")
		{
		}

		public IReadOnlyList<PendingRewardEntry> GetPendingRewardEntries()
		{
			return null;
		}

		public void RemovePendingReward(string id)
		{
		}

		public int GetQuestProgress(int questId)
		{
			return 0;
		}

		public Action<int> GetQuestProgressSetter(int questId)
		{
			return null;
		}

		public void SetQuestProgress(int questId, int value)
		{
		}

		public void RemoveQuestProgress(Predicate<int> questIdMatch)
		{
		}

		public void CompleteQuest(int questId)
		{
		}

		public void ResetQuestCompletedTime(int questId)
		{
		}

		public bool IsQuestCompletedToday(int questId)
		{
			return false;
		}

		public bool IsQuestEverCompleted(int questId)
		{
			return false;
		}

		public DateTime GetLatestQuestCompletedTime(int questId)
		{
			return default;
		}

		public bool IsNewDailyQuestDay()
		{
			return false;
		}

		public void UpdateLatestDailyQuestCheckinTime()
		{
		}

		private PlayerDataQuestProgress FindExisting(int questId)
		{
			return null;
		}

		public void SaveQuest()
		{
		}

		private void InitializeAutoRefillUpdate()
		{
		}

		public void ReceiveResource(int id, int amount, string source, bool isIap = false, string context = "")
		{
		}

		public void ReceiveResource(OwnedResourceEntity resource, int amount, string source, bool isIap = false, string context = "")
		{
		}

		[Obsolete("Use ReceiveResource() with placement")]
		public void ReceiveResource(int id, int amount)
		{
		}

		[Obsolete("Use ReceiveResource() with placement")]
		public void ReceiveResource(OwnedResourceEntity resource, int amount)
		{
		}

		public bool HasResource(int key, int value)
		{
			return false;
		}

		public OwnedResourceEntity GetResource(int id)
		{
			return null;
		}

		public int GetCurrentAdsTicket()
		{
			return 0;
		}

		public void CostAdsTicket(string placement = "")
		{
		}

		public bool TryUsingAdsTicket(string placement = "")
		{
			return false;
		}

		public int GetOwnedResourceValue(int id)
		{
			return 0;
		}

		public TimeSpan GetCurrencyRefillRemainTime(int id)
		{
			return default;
		}

		public IReadOnlyCollection<OwnedResourceEntity> GetAllOwnedResources()
		{
			return null;
		}

		public void InvokeRewardReceivedEvent(RewardPack rewardPack)
		{
		}

		public void SaveResources()
		{
		}

		private static void SendTrackResourceChanges(int id, int amount, int currentOwned, string placement, bool isIap, string context = "")
		{
		}

		private SevenDayEventSaveData GetOrCreateSevenDayEventSaveData(int eventId)
		{
			return null;
		}

		public long GetSevenDaysChallengeCheckInDays(int eventId)
		{
			return 0L;
		}

		public DateTime GetSevendaysChallengeUnlockedTime(int eventId)
		{
			return default;
		}

		public bool HasSevenDaysChallengeExpired(int eventId, int durationInDay)
		{
			return false;
		}

		public int GetSevenDaysProgressClaimedLevelOfQuest(int eventId)
		{
			return 0;
		}

		public void SetSevenDaysProgressClaimedLevelOfQuest(int eventId, int level)
		{
		}

		public int GetSevenDaysProgressClaimedLeveOfBundle(int eventId)
		{
			return 0;
		}

		public void SetSevenDaysProgressClaimedLevelOfBundle(int eventId, int level)
		{
		}

		public long GetSevenDaysCurrentLoopStartTime(int eventId)
		{
			return 0L;
		}

		public void SetSevenDaysCurrentLoopStartTime(int eventId, long epochTime)
		{
		}

		public int GetSevenDaysCurrentLoopIndex(int eventId)
		{
			return 0;
		}

		public void SetSevenDaysCurrentLoopIndex(int eventId, int index)
		{
		}

		public void AdvanceSevenDaysLoop(int eventId, long newLoopStartEpoch)
		{
		}

		public long GetSevenDaysLoopCheckInDays(int eventId)
		{
			return 0L;
		}

		public List<int> GetSevenDaysClaimedBundleIdsInLoop(int eventId)
		{
			return null;
		}

		public void AddSevenDaysClaimedBundleInLoop(int eventId, int bundleId)
		{
		}

		public void ClearSevenDaysClaimedBundlesInLoop(int eventId)
		{
		}

		public bool IsSevenDaysLoopPopupPending(int eventId)
		{
			return false;
		}

		public void SetSevenDaysLoopPopupPending(int eventId, bool pending)
		{
		}

		public bool IsSevenDaysExpiredMailSent(int eventId)
		{
			return false;
		}

		public void SetSevenDaysExpiredMailSent(int eventId)
		{
		}

		public bool TryMarkSevenDaysQuestAvailableFired(int eventId)
		{
			return false;
		}

		public void SetQuestAvailableTime(int eventId)
		{
		}

		public int GetSecondsFromQuestAvailable(int eventId)
		{
			return 0;
		}

		public bool TryMarkSevenDaysQuestDoneFired(int eventId, string key)
		{
			return false;
		}

		public bool TryMarkSevenDaysAllQuestsCompletedFired(int eventId)
		{
			return false;
		}

		public int GetSecondsFromQuestDone(int eventId, string key)
		{
			return 0;
		}

		public bool TryMarkQuestChestAvailableFired(int eventId, string key)
		{
			return false;
		}

		public int GetSecondsFromQuestChestAvailable(int eventId, string key)
		{
			return 0;
		}

		public bool IsSevenDaysEventStarted(int eventId)
		{
			return false;
		}

		public void ActivateSevenDaysEvent(int eventId, long startEpoch, long loopStartEpoch)
		{
		}

		public void TryCapLegacyTimeline(int firstEventId)
		{
		}

		public int GetSevenDaysTimelineDayOffset()
		{
			return 0;
		}

		private void SaveCarnival()
		{
		}

		public long GetSevenDaysChallengeCheckInDays()
		{
			return 0L;
		}

		public DateTime GetSevendaysChallengeUnlockedTime()
		{
			return default;
		}

		public bool HasSevenDaysChallengeExpired(int durationInDay)
		{
			return false;
		}

		public int GetSevenDaysProgressClaimedLevelOfQuest()
		{
			return 0;
		}

		public void SetSevenDaysProgressClaimedLevelOfQuest(int level)
		{
		}

		public int GetSevenDaysProgressClaimedLeveOfBundle()
		{
			return 0;
		}

		public void SetSevenDaysProgressClaimedLevelOfBundle(int level)
		{
		}

		public int GetShopPackClaimCount(int packId)
		{
			return 0;
		}

		public int GetShopPackTotalClaimCount(int packId)
		{
			return 0;
		}

		public bool CanPurchaseShopPackToday(int packId, int maxPurchaseInDay, int maxPurchaseTotal)
		{
			return false;
		}

		public DateTime GetShopPackLatestClaimTime(int packId)
		{
			return default;
		}

		public void CheckResetClaimCountNextDay(int packId)
		{
		}

		public void IncreaseShopPackClaimCount(int packId)
		{
		}

		public void ResetShopPackClaimCount(int packId)
		{
		}

		public void ResetShopPackTotalClaimCount(int packId)
		{
		}

		public void UpdateShopPackLatestClaimTime(int packId)
		{
		}

		private bool TryGetShopPackHistory(int packId, out PlayerDataShopPack history)
		{
			history = null;
			return false;
		}

		private PlayerDataShopPack GetOrAddShopPackHistory(int packId)
		{
			return null;
		}

		public int GetGachaDrawCount(int gachaId)
		{
			return 0;
		}

		public int GetGachaAdsDrawCount(int gachaId)
		{
			return 0;
		}

		public DateTime GetFreeDrawLatestTime(int gachaId)
		{
			return default;
		}

		public int GetGachaPityCount(int gachaId, int index)
		{
			return 0;
		}

		public void IncreaseGachaDrawCount(int gachaId)
		{
		}

		public void IncreaseGachaAdsDrawCount(int gachaId)
		{
		}

		public void UpdateGachaAdsDrawRefreshTime(int gachaId)
		{
		}

		public TimeSpan GetGachaAdsDrawRemainTime(int gachaId)
		{
			return default;
		}

		public void UpdateGachaFreeDrawLatestTime(int gachaId)
		{
		}

		public void IncreaseGachaPityCount(int gachaId, int index)
		{
		}

		public void ResetGachaPityCount(int gachaId, int index)
		{
		}

		public void SyncGachaBannerPityCounts()
		{
		}

		public void SyncAllShopBannerPityFrom(int sourceGachaId)
		{
		}

		private bool TryGetGachaHistoryById(int gachaId, out PlayerDataGacha history)
		{
			history = null;
			return false;
		}

		private PlayerDataGacha GetOrAddGachaHistory(int gachaId)
		{
			return null;
		}

		public bool InAdsRemoval1()
		{
			return false;
		}

		public TimeSpan GetRemainDurationAdsRemoval1()
		{
			return default;
		}

		public bool IsAdsRemoval1Pack(ShopPackData pack, out PlayerDataShopPack history)
		{
			history = null;
			return false;
		}

		public int GetAdsRemoval1OfferType()
		{
			return 0;
		}

		public void SetAdsRemovalOfferState(int type)
		{
		}

		[Obsolete]
		public TimeSpan GetTimeSpanFromAdsRemoval1Discount1Appear()
		{
			return default;
		}

		public bool ShouldShowAdsRemoval1Discount2()
		{
			return false;
		}

		public TimeSpan GetAdsRemovalDiscountRemainTime(int offerType)
		{
			return default;
		}

		public string GetAdsRemoval1ProductIdFromDiscount(int discount)
		{
			return null;
		}

		public void InvokeAdsRemovalPurchasedEvent()
		{
		}

		public void SaveShop()
		{
		}

		private void InitializeTalents()
		{
		}

		public int GetTalent0Progress()
		{
			return 0;
		}

		public int GetTalent1Progress()
		{
			return 0;
		}

		public void IncreaseTalent0Progress()
		{
		}

		private void TrackTalent0Upgraded(TalentData currentTalent)
		{
		}

		public void IncreaseTalent1Progress()
		{
		}

		private void TrackTalent1Upgraded(TalentData currentTalent)
		{
		}

		private string ParseTalentIdToJson(TalentData talentData)
		{
			return null;
		}

		private string ParseTalentUpgradeCostToJson(TalentData talentData)
		{
			return null;
		}

		private void SaveTalent()
		{
		}

		public void ApplyTalentNormalEffect(TalentDataNormal talentData)
		{
		}

		public void ApplyTalentSpecialEffect(TalentDataSpecial talentData)
		{
		}

		public bool HasTalentUpgrade()
		{
			return false;
		}

		private void InitializeLevel()
		{
		}

		private void ListenResourceChangedOfLevel(int value)
		{
		}

		public void LevelUp()
		{
		}
	}
}
