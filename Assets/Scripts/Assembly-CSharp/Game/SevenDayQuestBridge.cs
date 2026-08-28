using System;
using System.Collections.Generic;
using Game.ProgressPointSystem;
using Game.QuestSystem;
using Game.SevenDayQuest;
using UnityEngine;

namespace Game
{
	public class SevenDayQuestBridge
	{
		public class SevenDayQuestDataProvider : IDataProvider
		{
			private readonly int _eventId;

			private SevenDayEventConfig _config;

			private int _questProgressCurrencyId;

			private int _bundleProgressCurrencyId;

			private int _firstEventId;

			public bool IsInitialized => false;

			public PlayerInfo PInfo => null;

			public int EventId => 0;

			private int TimelineOffset => 0;

			public static IReadOnlyList<SevenDayEventConfig> GetRunningEventConfigs()
			{
				return null;
			}

			public static IReadOnlyList<SevenDayEventConfig> GetComingSoonEventConfigs()
			{
				return null;
			}

			public static IReadOnlyList<SevenDayEventConfig> GetRunningEventConfigsWithPendingPopup()
			{
				return null;
			}

			public static bool IsRunning(SevenDayEventConfig config)
			{
				return false;
			}

			private static bool IsEventComingSoon(int eventId)
			{
				return false;
			}

			private int GetFirstEventId()
			{
				return 0;
			}

			public SevenDayQuestDataProvider(int eventId)
			{
			}

			public int GetLoginDays()
			{
				return 0;
			}

			public int GetFirstEventLoginDay()
			{
				return 0;
			}

			public void SetQuestProgress(int questId, int progress)
			{
			}

			public int GetQuestProgress(int questId)
			{
				return 0;
			}

			public string GetChestKey(ProgressData data)
			{
				return null;
			}

			public string GetQuestDoneKey(SevenDayQuestData data)
			{
				return null;
			}

			public int GetCarnivalAppearanceNumber()
			{
				return 0;
			}

			public int GetSecondsFromQuestAvailable()
			{
				return 0;
			}

			public int GetSecondsFromQuestDone(SevenDayQuestData data)
			{
				return 0;
			}

			public int GetSecondsFromQuestChestAvailable(ProgressData data)
			{
				return 0;
			}

			public int GetMilestonePoints(SevenDayQuestData data)
			{
				return 0;
			}

			public bool IsProgressRewardPicker(ProgressData data)
			{
				return false;
			}

			public IReadOnlyCollection<SevenDayQuestData> GetAllDatas()
			{
				return null;
			}

			public IReadOnlyDictionary<int, QuestData> GetAllQuestDatas()
			{
				return null;
			}

			public IReadOnlyCollection<SevenDayBundleData> GetAllBundleDatas()
			{
				return null;
			}

			public DateTime GetTimeNow()
			{
				return default;
			}

			public IReadOnlyList<ProgressData> GetProgressBarDatasForQuest()
			{
				return null;
			}

			public IReadOnlyList<ProgressData> GetProgressBarDatasForBundle()
			{
				return null;
			}

			public int GetProgressTokenIdOfQuest()
			{
				return 0;
			}

			public int GetProgressTokenIdOfBundle()
			{
				return 0;
			}

			public int GetProgressCurrentPointOfQuest()
			{
				return 0;
			}

			public int GetProgressCurrentPointOfBundle()
			{
				return 0;
			}

			public int GetProgressClaimedLevelOfQuest()
			{
				return 0;
			}

			public int GetProgressClaimedLevelOfBundle()
			{
				return 0;
			}

			public string GetProgressRewardPlacementOfQuest()
			{
				return null;
			}

			public string GetProgressRewardPlacementOfBundle()
			{
				return null;
			}

			public void SetProgressClaimedLevelOfQuest(int level)
			{
			}

			public void SetProgressClaimedLevelOfBundle(int level)
			{
			}

			public void OnClaimProgressReward(List<RewardData> rewards, string placement)
			{
			}

			public bool HasSevenDaysChallengeExpired()
			{
				return false;
			}

			public int GetRefreshDay()
			{
				return 0;
			}

			public bool IsBundleClaimable(SevenDayBundleData bundleData)
			{
				return false;
			}

			public bool IsBundleClaimed(SevenDayBundleData bundleData)
			{
				return false;
			}

			public string GetTranslation(string key, params string[] objects)
			{
				return null;
			}

			private int GetEventDuration()
			{
				return 0;
			}

			public SevenDayEventConfig GetEventConfig()
			{
				return null;
			}

			public DateTime GetCurrentLoopStartTime()
			{
				return default;
			}

			public bool IsLoopable()
			{
				return false;
			}

			public bool IsInLoopInterval()
			{
				return false;
			}

			public bool ShouldStartNewLoop()
			{
				return false;
			}

			public void OnNewLoopStarted(IReadOnlyCollection<SevenDayQuestData> allQuestDatas)
			{
			}

			private void ResetProgressCurrencies()
			{
			}

			private void ResetQuestProgress()
			{
			}

			public bool IsBundleClaimedInLoop(SevenDayBundleData bundleData)
			{
				return false;
			}

			public void MarkBundleClaimedInLoop(SevenDayBundleData bundleData)
			{
			}

			public bool IsLoopPopupPending()
			{
				return false;
			}

			public void SetLoopPopupPending(bool pending)
			{
			}

			public bool IsExpiredMailSent()
			{
				return false;
			}

			public void SetExpiredMailSent()
			{
			}

			public void SendExpiredRewardsToMail()
			{
			}

			public void IncreaseQuickPatrolLimit()
			{
			}

			public void RemoveQuickPatrolLimitBoost()
			{
			}

			public void SetDungeonRewardBoost(bool value)
			{
			}

			public bool IsEligibleToStart()
			{
				return false;
			}

			public void ActivateEvent()
			{
			}

			public bool IsEventOneDayLeft()
			{
				return false;
			}

			public TimeSpan GetTimeUntilStart()
			{
				return default;
			}

			private void Log(string message)
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
