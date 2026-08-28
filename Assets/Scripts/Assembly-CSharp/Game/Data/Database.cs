using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Game.AFKRewardSystem;
using Game.Arena;
using Game.Combat;
using Game.Combat.SkillSystem;
using Game.DailyEvent;
using Game.DialougeSystem;
using Game.EquipmentSystem;
using Game.EventDungeon;
using Game.GearUpgrade;
using Game.MailBox;
using Game.QuestSystem;
using Game.RewardBundle;
using Game.SevenDayQuest;
using Game.Shop;
using Game.StarBreaking;
using Game.Talent;
using UnityEngine;

namespace Game.Data
{
	public static class Database
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAddressableSprite_003Ed__341 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string name;

			public CancellationToken cancellationToken;

			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetBagLayout_003Ed__338 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LayoutType> _003C_003Et__builder;

			public string bagLayoutName;

			public CancellationToken cancellationToken;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetDungeonInfoLayout_003Ed__339 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<EventDungeonInfoLayout> _003C_003Et__builder;

			public string layoutName;

			public CancellationToken cancellationToken;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetEventDungeonPageItem_003Ed__340 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PageEventDungeonListItemBase> _003C_003Et__builder;

			public string itemName;

			public CancellationToken cancellationToken;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetIconAsync_003Ed__336 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string name;

			public CancellationToken cancellationToken;

			private UniTask<UnityEngine.Object>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetInGameBackgroundAsync_003Ed__337 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			public string name;

			public CancellationToken cancellationToken;

			private UniTask<UnityEngine.Object>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static readonly Dictionary<CampaignDifficultyMode, Dictionary<int, Campaign>> CampaignMaps;

		public static readonly Dictionary<CampaignDifficultyMode, List<Campaign>> CampaignLists;

		public static IReadOnlyDictionary<int, TalentData> LastNormalTalentByLevel;

		private static bool _load;

		public static bool Initialized { get; private set; }

		[Obsolete("Use CampaignMap[CampaignMode.Normal] or CampaignLists[CampaignMode.Normal] instead")]
		public static List<Campaign> AllCampaigns { get; private set; }

		public static List<LevelData> AllLevels { get; private set; }

		public static IReadOnlyDictionary<CampaignDifficultyMode, IReadOnlyList<LevelData>> AllRewardLevels { get; private set; }

		public static IReadOnlyDictionary<int, List<SpawnData>> AllSpawns { get; private set; }

		public static IReadOnlyDictionary<int, MonsterData> AllMonsters { get; private set; }

		public static IReadOnlyDictionary<int, MonsterClassData> AllMonsterClasses { get; private set; }

		public static IReadOnlyDictionary<int, MonsterLevelData> AllMonsterLevels { get; private set; }

		public static IReadOnlyDictionary<int, List<MonsterBehaviourData>> AllMonsterBehaviours { get; private set; }

		public static IReadOnlyDictionary<int, SkillData> AllSkills { get; private set; }

		public static IReadOnlyDictionary<int, GearData> AllGears { get; private set; }

		public static IReadOnlyDictionary<int, GearMergeData> AllGearMerges { get; private set; }

		public static IReadOnlyDictionary<int, List<GearUpgradeData>> AllGearUpgrade { get; private set; }

		public static IReadOnlyDictionary<int, GearMasteryData> AllGearMasteries { get; private set; }

		public static IReadOnlyDictionary<int, ChestData> AllCombatChests { get; private set; }

		public static IReadOnlyDictionary<int, CombatChestData> AllCombatShops { get; private set; }

		public static IReadOnlyDictionary<int, BuffData> AllBuffs { get; private set; }

		public static IReadOnlyDictionary<int, Stat> AllStats { get; private set; }

		public static List<SpecialUpgradeData> AllCharacterSpecialUpgrades { get; private set; }

		public static IReadOnlyDictionary<int, AscendData> AllAscendData { get; private set; }

		public static List<EquipmentPriceData> AllEquipmentPrices { get; private set; }

		public static IReadOnlyDictionary<int, RewardPack> AllRewardPacks { get; private set; }

		public static IReadOnlyDictionary<int, RewardBundleData> AllRewardBundles { get; private set; }

		public static RerollPriceData RerollPrices { get; private set; }

		public static ElementCounterMod ElementCounterMod { get; private set; }

		public static Dictionary<int, EventUnlockData> AllEventUnlocks { get; private set; }

		public static Dictionary<int, EventTicketData> AllEventTickets { get; private set; }

		public static Dictionary<int, EventDungeonData> AllEventDungeons { get; private set; }

		public static Dictionary<int, EventDungeonUnlockViewState> EventDungeon_UnlockConfigs { get; private set; }

		public static List<EventDungeonViewState> EventDungeon_DungeonConfigs { get; private set; }

		public static IReadOnlyDictionary<int, ShopPackData> AllShopPacks { get; private set; }

		public static IReadOnlyDictionary<string, ShopPackData> ShopPackByIapMap { get; private set; }

		public static IReadOnlyDictionary<int, ShopPackData> SubscriptionShopPacks { get; private set; }

		public static IReadOnlyDictionary<int, ShopPackData> SevenDayBundleShopPacks { get; private set; }

		public static List<TalentData> AllTalents { get; private set; }

		public static PlayerExpData PlayerExp { get; private set; }

		public static IReadOnlyDictionary<int, ResourceEntity> AllResources { get; private set; }

		public static IReadOnlyDictionary<int, EquipmentData> AllEquipments { get; private set; }

		public static IReadOnlyDictionary<int, EquipmentUpgradeData> AllEquipmentUpgradeDatas { get; private set; }

		public static IReadOnlyCollection<int> AllGearCards { get; private set; }

		public static SlotPrice SlotPrice { get; private set; }

		public static IReadOnlyCollection<GachaData> GachaDatas { get; private set; }

		public static IReadOnlyDictionary<int, List<GachaChestData>> GachaChestDatas { get; private set; }

		public static RecycleValues RecycleValues { get; private set; }

		public static IReadOnlyDictionary<string, GearTagData> AllGearTags { get; private set; }

		public static List<PatrolData> AllPatrols { get; private set; }

		public static IReadOnlyDictionary<int, KingdomBuildingData> AllKingdomBuildingDatas { get; private set; }

		public static IReadOnlyDictionary<int, QuestData> AllQuestDatas { get; private set; }

		public static IReadOnlyCollection<SevenDayQuestData> AllSevenDayQuestDatas { get; private set; }

		public static IReadOnlyCollection<SevenDayBundleData> AllSevenDayBundleDatas { get; private set; }

		public static IReadOnlyList<SevenDaysProgressData> AllSevenDaysProgressDatas { get; private set; }

		public static IReadOnlyList<SevenDaysProgressData> AllSevenDaysBundleProgressDatas { get; private set; }

		public static IReadOnlyList<SevenDayEventConfig> AllSevenDayEventConfigs { get; private set; }

		public static IReadOnlyCollection<DialogueLocationData> AllDialogueDatas { get; private set; }

		public static IReadOnlyCollection<BattlePassBundleData> AllBattlePassBundleData { get; private set; }

		public static Dictionary<int, List<BattlePassQuestData>> AllBattlePassQuestData { get; private set; }

		public static Dictionary<int, List<BattlePassLevelData>> AllBattlePassLevelData { get; private set; }

		public static Dictionary<int, List<BattlePassLevelData>> AllBattlePassExtraLevelData { get; private set; }

		public static Dictionary<int, List<NewbiePackData>> AllNewbiePackData { get; private set; }

		public static Dictionary<GeneralFeature, List<GeneralPackData>> AllGeneralPackData { get; private set; }

		public static Dictionary<int, List<ChainPackConfig>> AllChainPacks { get; private set; }

		public static IReadOnlyDictionary<int, DailyGiftData> AllDailyGifts { get; private set; }

		public static IReadOnlyDictionary<int, MailConfigData> AllMailConfigs { get; private set; }

		public static IReadOnlyDictionary<int, BuffGroup> AllBuffGroups { get; private set; }

		public static IReadOnlyDictionary<int, BuffPool> AllBuffPools { get; private set; }

		public static IReadOnlyDictionary<int, ExpMilestoneGroup> AllExpMilestoneGroups { get; private set; }

		public static IReadOnlyDictionary<int, List<ArenaCombatData>> AllPvpCombatGroups { get; private set; }

		public static IReadOnlyDictionary<RankType, PvpGroupData> AllPvpGroups { get; private set; }

		public static IReadOnlyDictionary<RankType, List<PvpBotData>> AllPvpBot { get; private set; }

		public static List<string> AllPvpBotName { get; private set; }

		public static IReadOnlyDictionary<RankType, Dictionary<int, PvpBotData>> AllPvpBot2 { get; private set; }

		public static IReadOnlyDictionary<string, List<PvpRewardData>> AllPvpReward { get; private set; }

		public static IReadOnlyList<PvpPointData> AllPvpPoints { get; private set; }

		public static IReadOnlyList<int> AllPvpTicketStepPrice { get; private set; }

		public static IReadOnlyDictionary<ArenaSubTabType, VendorTabData> AllVendorTabs { get; private set; }

		public static IReadOnlyDictionary<int, List<VendorBundleData>> AllVendorBundles { get; private set; }

		public static IReadOnlyDictionary<int, int[]> AllPvpCombatGearRelativeBuffs { get; private set; }

		public static IReadOnlyDictionary<int, List<BlackMarketShopData>> AllBlackMarket { get; private set; }

		public static IReadOnlyDictionary<int, CurrencyData> AllCurrencyData { get; private set; }

		public static IReadOnlyDictionary<int, DirectPurchaseData> AllDirectPurchases { get; private set; }

		public static IReadOnlyDictionary<int, StarBreakPackData> AllStarBreakPacks { get; private set; }

		public static DirectPurchaseData GetDirectPurchase(int resourceId)
		{
			return null;
		}

		public static bool FindBattlePassBundleData(int eventId, out BattlePassBundleData data)
		{
			data = default;
			return false;
		}

		public static void Initialize()
		{
		}

		private static IReadOnlyDictionary<CampaignDifficultyMode, IReadOnlyList<LevelData>> GetRewardLevels()
		{
			return null;
		}

		private static void ReadCampaignData(RawDataStorage storage)
		{
		}

		private static void InitializeResources(RawDataStorage storage)
		{
		}

		private static void InitializeShopPacks()
		{
		}

		public static Sprite GetIcon(string name)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetIconAsync_003Ed__336))]
		public static Task<Sprite> GetIconAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetInGameBackgroundAsync_003Ed__337))]
		public static Task<GameObject> GetInGameBackgroundAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetBagLayout_003Ed__338))]
		public static Task<LayoutType> GetBagLayout(string bagLayoutName, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetDungeonInfoLayout_003Ed__339))]
		public static Task<EventDungeonInfoLayout> GetDungeonInfoLayout(string layoutName, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetEventDungeonPageItem_003Ed__340))]
		public static Task<PageEventDungeonListItemBase> GetEventDungeonPageItem(string itemName, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAddressableSprite_003Ed__341))]
		public static Task<Sprite> GetAddressableSprite(string name, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public static ResourceEntity GetResource(int id)
		{
			return null;
		}

		public static T GetResource<T>(int id) where T : ResourceEntity
		{
			return null;
		}

		public static GearData GetGearResource(int id)
		{
			return null;
		}

		public static T GetGearResource<T>(int id) where T : GearData
		{
			return null;
		}

		public static T GetGearUpgradeResource<T>(int id) where T : GearUpgradeData
		{
			return null;
		}

		public static List<MonsterBehaviourData> GetMonsterBehaviourDatas(int id)
		{
			return null;
		}

		public static SkillData GetSkillData(int id)
		{
			return null;
		}

		public static Stat GetStat(StatName statName)
		{
			return null;
		}

		public static EquipmentUpgradeData GetEquipmentUpgradeData(int id)
		{
			return null;
		}

		public static RewardBundleData GetRewardBundle(int id)
		{
			return null;
		}

		public static RewardPack GetRewardPack(int id)
		{
			return null;
		}

		public static IEnumerable<EventDungeonUnlockViewState> GetEventDungeonUnlockViewStates()
		{
			return null;
		}

		public static EventDungeonUnlockViewState GetEventDungeonUnlockViewState(int id)
		{
			return null;
		}

		public static IEnumerable<EventDungeonViewState> GetEventDungeonViewStates(int eventDungeonId)
		{
			return null;
		}

		public static EventDungeonViewState GetEventDungeonViewState(int eventDungeonId, int dungeonLevel)
		{
			return null;
		}

		public static CombatChestData GetCombatChestData(int id)
		{
			return null;
		}

		public static IEnumerable<LevelData> GetLevels(int levelId)
		{
			return null;
		}

		public static List<SpawnData> GetSpawnData(int id)
		{
			return null;
		}

		public static float GetTotalLevelMonsterHp(int levelId)
		{
			return 0f;
		}

		public static Campaign GetCampaign(int id)
		{
			return null;
		}

		public static bool TryGetCampaign(int id, out Campaign campaign)
		{
			campaign = null;
			return false;
		}

		public static Campaign GetEventDungeonUnlockCampaign()
		{
			return null;
		}

		public static BuffData GetBuff(int id)
		{
			return null;
		}

		public static bool IsResourceItem(int id)
		{
			return false;
		}

		public static bool IsRewardBundle(int id)
		{
			return false;
		}

		public static bool IsRewardBundle(List<ResourceRewardData> rewards)
		{
			return false;
		}

		private static IReadOnlyDictionary<string, ShopPackData> GetShopPackByIapMap(IEnumerable<ShopPackData> shopPacks)
		{
			return null;
		}
	}
}
