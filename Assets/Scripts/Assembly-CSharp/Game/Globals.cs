using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DoorServices;
using Game.Arena;
using Game.Combat;
using Game.Combat.SkillSystem;
using Game.Constant;
using Game.EventDungeon;
using Game.QuestSystem;
using MoreMountains.Tools;
using R3;
using Solo.MOST_IN_ONE;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public static class Globals
	{
		public struct DamageCalculationVariables
		{
			public float Skill;

			public float GearPower;

			public float Attack;

			public float DamageMultiplier;

			public float ElementalCounter;

			public float ElementalReduction;

			public float ElementalPenetration;

			public float ElementalDamageMultiplier;

			public float Intensity;

			public static DamageCalculationVariables Default => default;
		}

		public struct DamageCalculationOutput
		{
			public float Damage;

			public bool IsEffective;

			public bool IsImmue;
		}

		public struct HealCalculationVariables
		{
			public float Skill;

			public float GearPower;

			public float Attack;

			public float Proficiency;

			public float MaxHp;

			public float MaxHpPercent;

			public float Intensity;

			public static HealCalculationVariables Default => default;
		}

		public struct HealCalculationOuput
		{
			public float Amount;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass137_0
		{
			public RewardPhase rewardPhase;

			internal bool _003CCheatInstantWin_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass192_0
		{
			public UINagivator nav;

			internal bool _003CShowLockedMessageAfterOpen_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheatInstantWin_003Ed__137 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private _003C_003Ec__DisplayClass137_0 _003C_003E8__1;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003CGoToEquipmentGachaChest_003Ed__193 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public string source;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003CGoToShop_003Ed__186 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public string source;

			public string shopPartName;

			public CancellationToken cancellationToken;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003COpenEventDungeonInfoAtFloor_003Ed__191 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonUnlockViewState dungeon;

			public int floor;

			private UniTask.Awaiter _003C_003Eu__1;

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
		private struct _003CShowLockedMessageAfterOpen_003Ed__192 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			private _003C_003Ec__DisplayClass192_0 _003C_003E8__1;

			public string lockedMessage;

			private UniTask.Awaiter _003C_003Eu__1;

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

		public static readonly MMAdditiveSceneLoadingManagerSettings LoadSceneSetting;

		public static int InterAdsCount;

		public static bool ShouldShowStrongerRecommendPopup;

		public static List<int> NewGearThisWave;

		public static Subject<int> OnNextWave;

		public static Rect GameplayScreen;

		public static List<ResourceRewardData> TotalWaveRewardeds;

		public static List<ResourceRewardData> WinWaveRewards;

		public static float GameplayRewardMultiplier;

		public static bool IgnoreResourceGainInstant;

		public static bool FreeNewSlotUnlock;

		public static bool IgnoreTraitShop;

		public static bool IgnoreGearChest;

		public static bool IgnoreGearChestRestock;

		public static bool AutoNextWaveIfDefeated;

		public static bool ResetShieldNextWave;

		public static bool DungeonRewardBoost;

		public static ResourceRequireData OverrideTakeAllBuffCost;

		private static int? _arenaFightNumber;

		public static bool DontSave;

		public static Stat MaxCombatSpeedLevel;

		private static GamePhase _gamePhase;

		private static LevelData[] _levels;

		private static Dictionary<int, PlayerProfile> _players;

		private static float _chunkStartTime;

		private static Dictionary<int, List<ResourceReturnUI>> _currencyBarPositions;

		private static List<ResourceReturnUI> _equipmentStoragePositions;

		public static PlayerInfo PlayerInfo { get; private set; }

		public static CampaignMode CurrentCampaignMode { get; private set; }

		public static bool IsEventDungeonCampaign => false;

		public static int EventDungeonLevel { get; private set; }

		public static Campaign EventDungeonCampaign { get; private set; }

		public static Campaign Campaign { get; private set; }

		public static int LevelCount => 0;

		public static int Wave { get; private set; }

		public static LevelData Level => null;

		public static LevelData NextLevel => null;

		public static bool IsLastLevel => false;

		public static OwnedResourceEntity ProgressResource { get; set; }

		[Obsolete("Use GetPlayer().IsAlive")]
		public static bool PlayerAlive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static IReadOnlyList<ArenaCombatData> ArenaCombatData { get; private set; }

		public static PlayerInfo PlayerInfo2 { get; private set; }

		public static int PvPOpponentUserId { get; private set; }

		public static ArenaContextData PvPArenaContext { get; set; }

		public static int PvPCurrentRound { get; set; }

		public static Dictionary<Team, List<SkillData>> MonsterBuffs { get; }

		public static GamePhase GamePhase
		{
			get
			{
				return GamePhase.Prepare;
			}
			set
			{
			}
		}

		public static int CombatSpeedLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static QuestSystemManager QuestManager => null;

		public static string TrackingModeName => null;

		public static int TrackingLevel => 0;

		public static bool ShouldTrackLevel { get; private set; }

		public static string RewardPlacement { get; private set; }

		public static BenchSlot BenchSlot { get; set; }

		public static bool InCombat { get; set; }

		public static bool ScreenShakeOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool HapticOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool MasterSoundOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool MusicOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SoundOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string Language
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static void LoadPlayerInfo()
		{
		}

		private static int GetArenaFightNumber()
		{
			return 0;
		}

		public static void IncreaseWave()
		{
		}

		public static Campaign GetCurrentCampaign()
		{
			return null;
		}

		public static void SetCampaign(Campaign campaign, int wave, bool isContinuing = false)
		{
		}

		public static void SetEventDungeonCampaign(Campaign campaign, int level, int wave, bool isContinuing = false)
		{
		}

		public static void SetPvPCampaign(Campaign campaign, LevelData[] levelData, PlayerInfo playerInfo2, int opponentUserId, List<ArenaCombatData> arenaCombatData)
		{
		}

		public static string GetRewardPlacementOfDungeon(int dungeonId)
		{
			return null;
		}

		public static void AddPlayerBuff(SkillData skillData, object source)
		{
		}

		public static void AddMonsterBuff(SkillData skillData, Team team)
		{
		}

		public static void ClearAllBuff()
		{
		}

		public static void ClaimWinWaveRewardPack()
		{
		}

		public static bool IsAdsRemoval1OfferAvailable()
		{
			return false;
		}

		public static void CheckShowInterAdsWhenBossDied(Action goHome)
		{
		}

		public static void CheckShowInterAdsOnWaveEnd(Action doneCallback = null)
		{
		}

		public static void CheckShowInterAdsOnWaveEnd(Campaign campaign, LevelData levelData, Action doneCallback = null)
		{
		}

		public static void CheckShowInterAdsWhenLeaveGameplay(string placement, Action goHome, int levelOffet = 0)
		{
		}

		public static void NextCombatWave()
		{
		}

		public static void SendEventResourceChanges(int id, int changesAmount, string placement)
		{
		}

		public static void TrackGearIncome(int gearId, int amountChange, string source)
		{
		}

		public static void TrackGearOutcome(int gearId, int amountChange, string source)
		{
		}

		[AsyncStateMachine(typeof(_003CCheatInstantWin_003Ed__137))]
		public static void CheatInstantWin()
		{
		}

		public static void TrackLevelStart()
		{
		}

		public static void TrackLevelGearOutcome()
		{
		}

		public static void TrackLevelGearOutcome(CombatSaveData combatSaveData)
		{
		}

		public static void TrackLevelCompleted()
		{
		}

		public static void TrackLevelFailed()
		{
		}

		public static void TrackLevelLeft()
		{
		}

		public static void TrackChunk1Start()
		{
		}

		public static void TrackChunk2Start()
		{
		}

		public static void TrackChunk1End()
		{
		}

		public static void TrackChunk2End(float? power = null)
		{
		}

		public static void TrackChunkFail(int condition = 0, ChunkFailReason reason = ChunkFailReason.None)
		{
		}

		public static string GetModeContext(int chunk)
		{
			return null;
		}

		public static void TrackHandUsage()
		{
		}

		public static void ResetChunk()
		{
		}

		public static int GetChunk1Number()
		{
			return 0;
		}

		public static int GetChunk2Number()
		{
			return 0;
		}

		public static void CreatePlayer(int id, string playerTemplate, Bag bag)
		{
		}

		public static void CreatePlayer(int id, PlayerUnit playerUnit, Bag bag)
		{
		}

		public static void AddPlayer(PlayerProfile profile)
		{
		}

		public static void RemovePlayer(int id)
		{
		}

		public static void RemoveAllPlayers()
		{
		}

		public static IReadOnlyCollection<PlayerProfile> GetAllPlayers()
		{
			return null;
		}

		public static bool HasPlayer(int playerId = 1)
		{
			return false;
		}

		public static PlayerProfile GetPlayer(int playerId = 1)
		{
			return null;
		}

		public static Game.Combat.Unit GetPlayerUnit(int playerId = 1)
		{
			return null;
		}

		public static Bag GetBag(int playerId = 1)
		{
			return null;
		}

		public static PlayerPassiveManager GetPassiveManager(int playerId = 1)
		{
			return null;
		}

		public static void AddCurrencyBarPosition(int currencyId, ResourceReturnUI returnUi)
		{
		}

		public static void RemoveCurrencyBarPosition(int currencyId, ResourceReturnUI returnUi)
		{
		}

		public static void AddEquipmentStoragePosition(ResourceReturnUI returnUi)
		{
		}

		public static void RemoveEquipmentStoragePosition(ResourceReturnUI returnUi)
		{
		}

		public static bool TryGetCurrencyBarPosition(int currencyId, out ResourceReturnUI returnUI)
		{
			returnUI = null;
			return false;
		}

		public static bool TryGetEquipmentStoragePosition(out ResourceReturnUI returnUI)
		{
			returnUI = null;
			return false;
		}

		public static void CreateResourceIconThatFlyToBar(int resourceId, int amount, Vector3 spawnCenterPosition, float duration, float delay, float delayIncrease, Action flyHitCallback, bool ignoreTimescale = false)
		{
		}

		public static void ShowCurrencyFloatingText(Vector3 position, int id, int amount, float scale = 1f)
		{
		}

		public static void DoGameplayCameraUIShake(float duration = 0.3f, float amplitude = 0.4f, float frequency = 60f)
		{
		}

		public static bool IsGameplayNow()
		{
			return false;
		}

		public static bool IsCampaignGameplayNow()
		{
			return false;
		}

		public static bool IsDungeonGameplayNow()
		{
			return false;
		}

		public static bool IsPvpGameplayNow()
		{
			return false;
		}

		public static bool IsHomeNow()
		{
			return false;
		}

		public static void GoToBattleScreen()
		{
		}

		public static void GoToInventory()
		{
		}

		public static void GoToEquipmentFuse()
		{
		}

		public static void GoToTalent()
		{
		}

		[AsyncStateMachine(typeof(_003CGoToShop_003Ed__186))]
		public static UniTaskVoid GoToShop(string shopPartName = null, string source = "shop", CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private static float CalculateScrollToChildPosition(ScrollRect scrollRect, RectTransform child)
		{
			return 0f;
		}

		public static bool GoToEventDungeon(string lockedMessage = "Dungeon haven't been unlocked yet", string category = null)
		{
			return false;
		}

		public static bool TryGoToEventDungeonForResource(int resourceId, string lockedMessage = "Dungeon haven't been unlocked yet")
		{
			return false;
		}

		private static bool TryFindFloorDropsResource(EventDungeonViewState floor, int resourceId)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003COpenEventDungeonInfoAtFloor_003Ed__191))]
		private static UniTaskVoid OpenEventDungeonInfoAtFloor(EventDungeonUnlockViewState dungeon, int floor)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CShowLockedMessageAfterOpen_003Ed__192))]
		private static UniTaskVoid ShowLockedMessageAfterOpen(string lockedMessage)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGoToEquipmentGachaChest_003Ed__193))]
		public static UniTaskVoid GoToEquipmentGachaChest(string source = "shop", CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		public static void NavigateTo(FeatureNavigationType type, string extraData = null, string source = null)
		{
		}

		public static List<DTO_GoToFunctionData> GetCurrencyObtainSources(int resourceId)
		{
			return null;
		}

		public static DamageCalculationOutput CalculateDamage(DamageCalculationVariables variables)
		{
			return default;
		}

		public static HealCalculationOuput CalculateHeal(HealCalculationVariables variables)
		{
			return default;
		}

		public static HealCalculationOuput CalculateShield(HealCalculationVariables variables)
		{
			return default;
		}

		public static string FormatStatValue(float value, bool precent, bool hasPrefix)
		{
			return null;
		}

		public static string FormatStatValue1(float value, bool precent, bool hasPrefix)
		{
			return null;
		}

		public static string FormatStatPercent(float statMultiplier)
		{
			return null;
		}

		public static RewardPack GenerateLootRewards()
		{
			return null;
		}

		public static void CheckSkipStarBreakReward(IEnumerable<ResourceRewardData> rewardDatas)
		{
		}

		public static void AddMail(int id, List<ResourceRewardData> rewards)
		{
		}

		public static string GetSystemSaveKey(string key)
		{
			return null;
		}

		public static int GetSavedSystemInt(string key, int @default)
		{
			return 0;
		}

		public static void SaveSystemInt(string key, int value)
		{
		}

		public static void LoadAudioSettings()
		{
		}

		public static void ChangeLanguage(string languageCode)
		{
		}

		public static void Vibrate(MOST_HapticFeedback.HapticTypes type, float cooldown = 0.01f)
		{
		}

		public static void VibrateButton()
		{
		}

		public static void TrackFTUEStep(string stepKey)
		{
		}

		public static string GetTranslation(string key)
		{
			return null;
		}

		public static string ReplaceTranslationSlotParam(string text)
		{
			return null;
		}

		public static string GetTranslation(string key, params string[] objects)
		{
			return null;
		}

		public static void SetLocalization(GameObject text, string key)
		{
		}

		public static void ApplyTranslationParam(GameObject obj, params string[] objects)
		{
		}

		public static void ApplyTranslationParam(Component obj, params string[] objects)
		{
		}

		public static string GetRarityName(Rarity rarity)
		{
			return null;
		}

		public static float GetDungeonRewardMultiplier()
		{
			return 0f;
		}

		public static void LogErrorTest(string message)
		{
		}
	}
}
