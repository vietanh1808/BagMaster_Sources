using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace DoorServices
{
	public static class TrackingServices
	{
		public const string MAIN_CAMPAIGN = "main_campaign";

		public const string DUNGEON = "dungeon";

		public const string ARENA = "arena";

		public const string MODE_CONTEXT_MAIN = "m";

		public const string MODE_CONTEXT_DUNGEON = "d";

		public const string MODE_CONTEXT_ARENA = "arena";

		public const string GEAR_SOURCE_ROLL = "roll";

		public const string GEAR_SOURCE_RECYCLE = "recycle";

		public const string GEAR_SOURCE_MERGE_CONSUME = "merge_consume";

		public const string GEAR_SOURCE_MERGE_RESULT = "merge_result";

		public const string GEAR_SOURCE_UPGRADE = "upgrade";

		public const string GEAR_SOURCE_START_GEAR = "start_gear";

		public const string GEAR_SOURCE_LEVEL_FINISH = "level_finish";

		public const string ShopEnterSourceShop = "shop";

		public const string ShopEnterSourcePlusButton = "plus_button";

		private static string _nextShopEnterSource;

		private static Dictionary<string, bool> _offerTracks;

		private static readonly HashSet<string> TrackedIapOffers;

		private const string HAND_USAGE_CHUNK_KEY = "hand_usage_chunk";

		private const string HAND_USAGE_LEVEL_KEY = "hand_usage_level";

		private const string CHUNK_CHUNK_KEY = "trunk_chunk_number";

		private static bool OnlyTrackFirstIapImpression => false;

		public static int HandUsageInsideChunk
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public static int HandUsageInsideLevel
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public static int ChunkChunkNumber
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public static void SendAppLoaded()
		{
		}

		public static void SendFirstIAPPurchasePurchased()
		{
		}

		public static void SendIAPPurchasePurchased(double revenue, string currencyCode, string contentId)
		{
		}

		public static void SendIAPPurchasePurchased(Product product, string receipt, string transactionID)
		{
		}

		public static void SendAdsRewardRewarded()
		{
		}

		public static void SendAdsRewardOffer(string placement)
		{
		}

		public static void ResetTrackAdsRewardOffer(string placement)
		{
		}

		public static void SendStartLevel(string mode, int level, string statsContext, string modeContext)
		{
		}

		public static void SendCompleteLevel(string mode, int level, int wave, string statsContext, string modeContext)
		{
		}

		public static void SendEndLevel(string mode, int level, int wave, bool completed, string statsContext, string modeContext)
		{
		}

		public static void SendLeaveLevel(string mode, int level, int wave, string statsContext, string modeContext)
		{
		}

		public static void SendStartLevelDungeon(string mode, int level, string statsContext, string modeContext)
		{
		}

		public static void SendCompleteLevelDungeon(string mode, int level, int wave, string statsContext, string modeContext)
		{
		}

		public static void SendEndLevelDungeon(string mode, int level, int wave, bool completed, string statsContext, string modeContext)
		{
		}

		public static void SendLeaveLevelDungeon(string mode, int level, int wave, string statsContext, string modeContext)
		{
		}

		public static void SendStartLevelArena(string mode, string statsContext, string arenaContext, string modeContext)
		{
		}

		public static void SendCompleteLevelArena(string mode, string statsContext, string arenaContext, string modeContext)
		{
		}

		public static void SendEndLevelArena(string mode, string statsContext, string arenaContext, string modeContext)
		{
		}

		public static void SendLeaveLevelArena(string mode, string statsContext, string arenaContext, string modeContext)
		{
		}

		public static void SendAbaddonLevel(string mode, int level, int wave, string statsContext, string modeContext)
		{
		}

		public static void SendTutorialStep(string tutorialName, string step)
		{
		}

		public static void SendTutorialStep(string step)
		{
		}

		public static void SendShowInter()
		{
		}

		public static void SendChunkStart(int chunkNumber, Dictionary<string, object> backpackContext, string modeContext)
		{
		}

		public static void SendChunkCompleted(int chunkNumber, Dictionary<string, object> backpackContext, string modeContext)
		{
		}

		public static void SendChunkFailed(int chunkNumber, Dictionary<string, object> backpackContext, string modeContext, string reason = "")
		{
		}

		public static void SendChunkFailed(Dictionary<string, object> backpackContext, string modeContext, string reason = "")
		{
		}

		public static void SendChunkExtraStarted(int chunkNumber, string backpackContextJson, string modeContext)
		{
		}

		public static void SendChunkExtraCompleted(int chunkNumber, int duration, string backpackContextJson, string modeContext)
		{
		}

		public static void SendChunkExtraFailed(int chunkNumber, int duration, string backpackContextJson, string modeContext, string reason = "")
		{
		}

		public static void ResetHandUsageInsideChunk()
		{
		}

		public static void ResetHandUsageInsideLevel()
		{
		}

		public static void IncrementHandUsage()
		{
		}

		public static void ResetChunk()
		{
		}

		public static void SendHardCurrency(long amount, long total, string placement)
		{
		}

		public static void SendEnergy(long amount, long total, string placement)
		{
		}

		public static void SendResourceEvent(string resourceName, long amount, long oldTotal, string placement, string extraInfo = "")
		{
		}

		public static void SendSoftCurrency(long amount, long total, string placement)
		{
		}

		public static void SendEquipmentUpgraded(int level, string equipmentId, string costJson)
		{
		}

		public static void SendEquipmentReceived(int amount, int amountBefore, string equipmentId, string source, string consumedItemsArrayJson = null)
		{
		}

		[Obsolete("Use SendEquipmentReceived with source=\"fusion\" and the consumed_items array instead.")]
		public static void SendEquipmentFused(string newEquipmentId, string consumedItemsJson)
		{
		}

		public static void SendEquipmentEquipped(string equipmentId, string slot)
		{
		}

		public static void SendEquipmentUnequipped(string equipmentId, string slot)
		{
		}

		public static void SendTalentUpgraded(int level, string talentId, string costJson)
		{
		}

		public static void SendSpecialTalentUpgraded(int level, string talentId, string costJson)
		{
		}

		public static void SendGearIncome(int gearId, int amountChange, int currentAmount, string source, string gearContext)
		{
		}

		public static void SendGearOutcome(int gearId, int amountChange, int currentAmount, string source, string gearContext)
		{
		}

		public static void SendBattlePassEvent(string eventName, string tag, long param1 = 0L, long param2 = 0L, long param3 = 0L, string extra = null)
		{
		}

		public static void SendScreenEvent(string screenName)
		{
		}

		public static void SendClickEvent(string screenName, string element)
		{
		}

		public static void SetShopEnterSource(string source)
		{
		}

		public static void ResetShopEnterSource()
		{
		}

		public static void SendShopEnterEvent()
		{
		}

		public static void SendShopEnterEvent(StoreEntryMethod storeEntryMethod, string source)
		{
		}

		public static void SendQuestsAvailable(int appearanceNumberPerCarnivalType, string carnivalType, string questName, int day)
		{
		}

		public static void SendQuestDone(int appearanceNumberPerCarnivalType, string carnivalType, int activePlayTime, string questName, int totalSteps, int questNumber, int day, int points)
		{
		}

		public static void SendQuestRewardClaimed(int appearanceNumberPerCarnivalType, string carnivalType, int activePlayTime, string questName, int totalSteps, int questNumber, int day)
		{
		}

		public static void SendQuestRedirect(int appearanceNumberPerCarnivalType, string carnivalType, string questName, int day)
		{
		}

		public static void SendQuestChestAvailable(int appearanceNumberPerCarnivalType, string carnivalType, int activePlayTime, int chestIndex, int thresholdPoints)
		{
		}

		public static void SendQuestChestClaimed(int appearanceNumberPerCarnivalType, string carnivalType, int activePlayTime, int chestIndex, int thresholdPoints, bool isPicker)
		{
		}

		public static void SendAllQuestsCompleted(int appearanceNumberPerCarnivalType, string carnivalType, int activePlayTime)
		{
		}

		public static int GetPlayingTime()
		{
			return 0;
		}

		public static void SendIapOfferImpression(string iapPackId, StoreEntryMethod storeEntryMethod, string source)
		{
		}

		public static void SendIapOfferResult(string iapPackId, StoreEntryMethod storeEntryMethod, PurchaseResult result)
		{
		}
	}
}
