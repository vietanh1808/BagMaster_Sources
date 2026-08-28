using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
using Game.ProgressPointSystem;
using Game.QuestSystem;
using Game.RewardBundle;
using Game.SevenDayQuest;
using Game.Shop;
using Game.StarBreaking;
using Game.Talent;
using UnityEngine;

namespace Game.Data
{
	[Serializable]
	public class RawDataStorage
	{
		[CompilerGenerated]
		private sealed class _003CConvertBuffData_003Ed__15 : IEnumerable<BuffPool.WeightedBuffGroup>, IEnumerable, IEnumerator<BuffPool.WeightedBuffGroup>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private BuffPool.WeightedBuffGroup _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<ExcelBuffPoolData> rawBuffPoolList;

			public IEnumerable<ExcelBuffPoolData> _003C_003E3__rawBuffPoolList;

			private IReadOnlyDictionary<int, BuffGroup> _003CbuffGroups_003E5__2;

			private IEnumerator<ExcelBuffPoolData> _003C_003E7__wrap2;

			BuffPool.WeightedBuffGroup IEnumerator<BuffPool.WeightedBuffGroup>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CConvertBuffData_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<BuffPool.WeightedBuffGroup> IEnumerable<BuffPool.WeightedBuffGroup>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public BattlePassBundleData[] BattlePassRawDatas;

		public BattlePassLevelData[] BattlePassLevelRawDatas;

		public BattlePassQuestData[] BattlePassQuestRawDatas;

		public BlackMarketShopData[] ShopBlackMarketRawDatas;

		public ExcelAscendData[] AscendRawDatas;

		public ExcelBuffData[] BuffRawDatas;

		public ExcelBuffPoolData[] BuffPoolRawDatas;

		public ExcelCampaignData[] CampaignRawDatas;

		public ExcelChainPackData[] ChainPackRawDatas;

		public ExcelCharacterSpecialUpgradeData[] CharacterSpecialUpgradeRawDatas;

		public ExcelChestData[] CombatChestRawDatas;

		public ExcelCombatChestData[] CombatShopRawDatas;

		public ExcelCombatRecycleValueData[] CombatRecycleValueRawDatas;

		public ExcelCurrencyData[] CurrencyRawDatas;

		public ExcelDailyGiftData[] DailyGiftRawDatas;

		public ExcelDialogueLocationData[] DialogueLocationRawDatas;

		public ExcelDirectPurchaseData[] DirectPurchaseRawDatas;

		public ExcelElementalData[] ElementalModRawDatas;

		public ExcelEquipmentData[] EquipmentRawDatas;

		public ExcelEquipmentPriceData[] EquipmentPriceRawDatas;

		public ExcelEquipmentUpgradeData[] EquipmentUpgradeRawDatas;

		public ExcelEventDungeonConfig[] EventDungeonRawDatas;

		public ExcelEventTicketData[] EventTicketRawDatas;

		public ExcelEventUnlockData[] EventUnlockRawDatas;

		public ExcelExpMilestoneData[] ExpMilestoneRawDatas;

		public ExcelGachaChestData[] GachaChestRawDatas;

		public ExcelGachaData[] GachaRawDatas;

		public ExcelGearData[] GearRawDatas;

		public ExcelGearMasteryData[] GearMasteryRawDatas;

		public ExcelGearMergeData[] GearMergeRawDatas;

		public ExcelGearTagData[] GearTagRawDatas;

		public ExcelGearUpgradeData[] GearUpgradeRawDatas;

		public ExcelKingdomBuildingData[] BuildingRawDatas;

		public ExcelLevelData[] LevelRawDatas;

		public ExcelMailConfigData[] MailRawDatas;

		public ExcelMonsterBehaviourData[] MonsterBehaviourRawDatas;

		public ExcelMonsterClassData[] MonsterClassRawDatas;

		public ExcelMonsterData[] MonsterRawDatas;

		public ExcelMonsterLevelData[] MonsterLevelRawDatas;

		public ExcelNewbiePackData[] NewbiePackRawDatas;

		public ExcelPatrolData[] PatrolRawDatas;

		public ExcelPvpCombatData[] PvpCombatRawDatas;

		public ExcelPvpCombatGearRelativeBuffsData[] PvpCombatGearRelativeBuffs;

		public ExcelQuestData[] QuestRawDatas;

		public ExcelRerollPriceData[] RerollPriceRawDatas;

		public ExcelRewardBundleData[] RewardBundleRawDatas;

		public ExcelRewardData[] RewardRawDatas;

		public ExcelSevenDayBundleData[] Bundle7DaysRawDatas;

		public ExcelSevenDayEventConfig[] SevenDayEventRawDatas;

		public ExcelSevenDayQuestData[] Quest7DaysRawDatas;

		public ExcelSevenDaysBundleProgressData[] SevenDaysBundleProgressRawDatas;

		public ExcelSevenDaysProgressData[] SevenDaysProgressRawDatas;

		public ExcelShopData[] ShopRawDatas;

		public ExcelSkillData[] SkillRawDatas;

		public ExcelSlotPriceData[] SlotPriceRawDatas;

		public ExcelSpawnData[] SpawnRawDatas;

		public ExcelStarBreakData[] StarBreakRawDatas;

		public ExcelStatData[] StatRawDatas;

		public ExcelTalentData[] TalentRawDatas;

		public ExelPlayerExpData[] PlayerExpRawDatas;

		public GeneralPackData[] GeneralPackRawDatas;

		public PvpBotData[] PvpBotRawDatas;

		public PvpBotName[] PvpBotNameRawDatas;

		public PvpGroupData[] PvpGroupRawDatas;

		public PvpPointData[] PvpPointRawDatas;

		public PvpRewardData[] PvpRewardRawDatas;

		public PvpTicketBuyData[] PvpTicketBuyRawDatas;

		public VendorBundleData[] VendorBundleRawDatas;

		public VendorTabData[] VendorTabRawDatas;

		public bool IsFallback;

		public ExcelEventDungeonData[] DungeonRawDatas;

		public ExcelEventDungeonUnlockData[] DungeonUnlockRawDatas;

		public BattlePassBundleData[] GetBattlePassDatas()
		{
			return null;
		}

		public Dictionary<int, List<BattlePassLevelData>> GetBattlePassLevelData(bool isExtraReward)
		{
			return null;
		}

		public Dictionary<int, List<BattlePassQuestData>> GetBattlePassQuestData()
		{
			return null;
		}

		public Dictionary<int, List<BlackMarketShopData>> GetDictionaryBlackMarket()
		{
			return null;
		}

		public Dictionary<int, AscendData> GetAscendDatas()
		{
			return null;
		}

		public Dictionary<int, BuffData> GetBuffDatas()
		{
			return null;
		}

		public Dictionary<int, BuffGroup> GetAllBuffGroups()
		{
			return null;
		}

		public Dictionary<int, BuffPool> GetBuffPools()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CConvertBuffData_003Ed__15))]
		private IEnumerable<BuffPool.WeightedBuffGroup> ConvertBuffData(IEnumerable<ExcelBuffPoolData> rawBuffPoolList)
		{
			return null;
		}

		public List<Campaign> GetCampaignDatas()
		{
			return null;
		}

		private int CampaignCompare(Campaign a, Campaign b)
		{
			return 0;
		}

		private string GetBackgroundPath(string background)
		{
			return null;
		}

		private CampaignDifficultyMode ParseDifficultyMode(string mode)
		{
			return CampaignDifficultyMode.Normal;
		}

		public Dictionary<int, List<ChainPackConfig>> GetChainPackData()
		{
			return null;
		}

		public List<SpecialUpgradeData> GetCharacterSpecialUpgradeDatas()
		{
			return null;
		}

		public Dictionary<int, ChestData> GetCombatChestDatas()
		{
			return null;
		}

		public Dictionary<int, CombatChestData> GetCombatShopDatas()
		{
			return null;
		}

		public RecycleValues GetCombatRecycleValue()
		{
			return null;
		}

		public Dictionary<int, CurrencyData> GetCurrencyDatas()
		{
			return null;
		}

		private static int GetAutoRefillTime(in ExcelCurrencyData rawData)
		{
			return 0;
		}

		public Dictionary<int, DailyGiftData> GetDailyGiftDatas()
		{
			return null;
		}

		public List<DialogueLocationData> GetDialogueLocationDatas()
		{
			return null;
		}

		public Dictionary<int, DirectPurchaseData> GetDirectPurchaseDatas()
		{
			return null;
		}

		public ElementCounterMod GetElementalCounterMod()
		{
			return null;
		}

		public Dictionary<int, EquipmentData> GetEquipmentDatas()
		{
			return null;
		}

		private int[] GetListFusionIds(string rawData)
		{
			return null;
		}

		private SkillData GetSkills(int id)
		{
			return null;
		}

		public List<EquipmentPriceData> GetEquipmentPriceDatas()
		{
			return null;
		}

		public Dictionary<int, EquipmentUpgradeData> GetUpgradeDatas()
		{
			return null;
		}

		public Dictionary<int, EventDungeonData> GetEventDungeonDatas()
		{
			return null;
		}

		public Dictionary<int, EventTicketData> GetEventTicketDatas()
		{
			return null;
		}

		private List<ResourceRequireData> ConvertCost(string rawData)
		{
			return null;
		}

		public Dictionary<int, EventUnlockData> GetEventUnlockDatas()
		{
			return null;
		}

		public Dictionary<int, ExpMilestoneGroup> GetExpMilestoneGroups()
		{
			return null;
		}

		public Dictionary<int, List<GachaChestData>> GetGachaChestDatas()
		{
			return null;
		}

		public List<GachaData> GetGachaDatas()
		{
			return null;
		}

		private List<ItemData> GetGachaChestItemDataByGroupId(int chestId, int groupId = -1)
		{
			return null;
		}

		private void CreatePityData(string description, int attempt, int groupId, int chestId, List<PityData> pityPool)
		{
		}

		public Dictionary<int, GearData> GetGearDatas()
		{
			return null;
		}

		private SkillData[] GetPassiveSkills(string rawData)
		{
			return null;
		}

		private string[] GetTags(string tags, params string[] param)
		{
			return null;
		}

		private Elemental AutoElemental(string[] tags)
		{
			return Elemental.Physical;
		}

		private bool IsElemental(string str, Elemental elemental)
		{
			return false;
		}

		public Dictionary<int, GearMasteryData> GetGearMasteryDatas()
		{
			return null;
		}

		public Dictionary<int, GearMergeData> GetGearMergeDatas()
		{
			return null;
		}

		private void SetWeightDataToGears(Dictionary<string, string[]> dict, List<GearData> gears, int gearMergeId)
		{
		}

		private List<WeightData> GetWeightData(Dictionary<string, string[]> dict, int index)
		{
			return null;
		}

		private void SetValueMergeToNFromOfGear(List<GearData> gears, int gearMergeId)
		{
		}

		private List<GearData> GetListGears(Dictionary<string, string[]> dict, int index)
		{
			return null;
		}

		public Dictionary<string, GearTagData> GetGearTagDatas()
		{
			return null;
		}

		public Dictionary<int, List<GearUpgradeData>> GetGearUpgradeDatas(out IReadOnlyCollection<int> gearCardIds)
		{
			gearCardIds = null;
			return null;
		}

		private int SortByLevel(GearUpgradeData x, GearUpgradeData y)
		{
			return 0;
		}

		public Dictionary<int, KingdomBuildingData> GetKingdomBuildingDatas()
		{
			return null;
		}

		public List<LevelData> GetLevelRawDatas()
		{
			return null;
		}

		private void AddLevelData(List<LevelData> result, ExcelLevelData rawData)
		{
		}

		private RewardPack[] ConvertRewardIdsStringToRewardPack(string ids)
		{
			return null;
		}

		private List<LevelStartGear> GetListStartGears(string data)
		{
			return null;
		}

		public Dictionary<int, MailConfigData> GetMailConfigDatas()
		{
			return null;
		}

		public Dictionary<int, List<MonsterBehaviourData>> GetMonsterBehaviourDatas()
		{
			return null;
		}

		private int SortByPiority(MonsterBehaviourData a, MonsterBehaviourData b)
		{
			return 0;
		}

		public Dictionary<int, MonsterClassData> GetMonsterClassDatas()
		{
			return null;
		}

		public Dictionary<int, MonsterData> GetMonsterRawDatas()
		{
			return null;
		}

		public List<DefaultSoundConfig.SoundData> GetDeathSfxs(string rawData)
		{
			return null;
		}

		public Dictionary<int, MonsterLevelData> GetMonsterLevelDatas()
		{
			return null;
		}

		private void Load(Dictionary<int, MonsterLevelData> result, int variantId)
		{
		}

		public Dictionary<int, List<NewbiePackData>> GetNewbiePackData()
		{
			return null;
		}

		public List<PatrolData> GetPatrolDatas()
		{
			return null;
		}

		private List<int> GetRewardPackIds(string rewardIds)
		{
			return null;
		}

		public Dictionary<int, List<ArenaCombatData>> GetPvpCombatGroupedDatas()
		{
			return null;
		}

		public IReadOnlyDictionary<int, int[]> GetPvpCombatGearRelativeBuffsDatas()
		{
			return null;
		}

		public Dictionary<int, QuestData> GetQuestDatas()
		{
			return null;
		}

		public RerollPriceData GetRerollPriceDatas()
		{
			return null;
		}

		public Dictionary<int, RewardBundleData> GetRewardBundleDatas()
		{
			return null;
		}

		public Dictionary<int, RewardPack> GetRewardDatas()
		{
			return null;
		}

		public List<SevenDayBundleData> GetSevenDayBundleDatas()
		{
			return null;
		}

		public List<SevenDayEventConfig> GetSevenDayEventConfigs()
		{
			return null;
		}

		public List<SevenDayQuestData> GetDailyQuestDatas()
		{
			return null;
		}

		private int SortDailyQuestData(SevenDayQuestData x, SevenDayQuestData y)
		{
			return 0;
		}

		public List<SevenDaysProgressData> GetSevenDaysBundleProgressDatas()
		{
			return null;
		}

		public List<SevenDaysProgressData> GetSevenDaysProgressDatas()
		{
			return null;
		}

		private List<RewardData> ParseRewards(string rewardsString)
		{
			return null;
		}

		public Dictionary<int, ShopPackData> GetShopDatas()
		{
			return null;
		}

		public Dictionary<int, SkillData> GetSkillDatas()
		{
			return null;
		}

		public static List<EffectData> GetEffectDatas(string rawData)
		{
			return null;
		}

		private ValueParams ConvertOptions(string rawData)
		{
			return null;
		}

		private List<Vector2Int> GetNearbyPositions(string rawData)
		{
			return null;
		}

		public SlotPrice GetSlotPrice()
		{
			return null;
		}

		public Dictionary<int, List<SpawnData>> GetSpawnDatas()
		{
			return null;
		}

		public Dictionary<int, StarBreakPackData> GetStarBreakDatas()
		{
			return null;
		}

		public Dictionary<int, Stat> GetStatDatas()
		{
			return null;
		}

		public List<TalentData> GetTalentDatas(out Dictionary<int, TalentData> lastTalentAtLevel)
		{
			lastTalentAtLevel = null;
			return null;
		}

		private List<TalentStatData> GetTalentStatDatas(float[] stats)
		{
			return null;
		}

		private List<TalentUpgradeCostData> GetTalentUpgradeCostData(int[] costs)
		{
			return null;
		}

		public PlayerExpData GetPlayerExpDatas()
		{
			return null;
		}

		public Dictionary<GeneralFeature, List<GeneralPackData>> GetGeneralPackData()
		{
			return null;
		}

		public Dictionary<RankType, List<PvpBotData>> GetPvpBotRawDatas()
		{
			return null;
		}

		public Dictionary<RankType, Dictionary<int, PvpBotData>> GetPvpBotRawDatas2()
		{
			return null;
		}

		public List<string> AllPvpBotNames()
		{
			return null;
		}

		public Dictionary<RankType, PvpGroupData> GetPvpGroupRawDatas()
		{
			return null;
		}

		public Dictionary<string, List<PvpRewardData>> GetPvpRewardRawDatas()
		{
			return null;
		}

		public List<int> GetPvpTicketStepPrice()
		{
			return null;
		}

		public Dictionary<int, List<VendorBundleData>> GetVendorBundleDatas()
		{
			return null;
		}

		public Dictionary<ArenaSubTabType, VendorTabData> GetVendorTabData()
		{
			return null;
		}

		public void Initialize()
		{
		}

		private static string GetBaseConfigName(string fileName)
		{
			return null;
		}

		private static string CombineJsonArrays(List<TextAsset> configs)
		{
			return null;
		}

		private static string ExtractArrayBody(string arrayJson)
		{
			return null;
		}

		public List<EventDungeonViewState> GetEventDungeonConfig()
		{
			return null;
		}

		public Dictionary<int, EventDungeonUnlockViewState> GetEventDungeonUnlockConfig()
		{
			return null;
		}
	}
}
