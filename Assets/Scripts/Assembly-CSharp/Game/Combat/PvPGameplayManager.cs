using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Arena;
using Game.AssetManager;
using Game.CodedAnimation;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class PvPGameplayManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass79_0
		{
			public PvPGameplayManager _003C_003E4__this;

			public int player1Point;

			public int player2Point;

			public int player1PointNew;

			public int player2PointNew;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CChooseBuffs_003Ed__68 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CClearPostRound_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CCountDownFight_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

			private int _003Ccount_003E5__2;

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
		private struct _003CFight_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CIntro_003Ed__58 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

			private ArenaCombatData _003CcombatData_003E5__2;

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
		private struct _003CIntroGear_003Ed__73 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CIntroGear_003Ed__74 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int startIndex;

			public GearOrganizer gearOrganizer;

			public PvPGearAppearAnimator animator;

			private int _003Ci_003E5__2;

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
		private struct _003CRevivePlayers_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CRun_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CRunRoundTimer_003Ed__90 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

			private float _003CstartTime_003E5__2;

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
		private struct _003CSetupBag_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

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
		private struct _003CShowResult_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass79_0 _003C_003E8__1;

			private bool _003Cvictory_003E5__2;

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

		private static readonly int Intro1;

		private static readonly int EndRound;

		[Header("Config")]
		[SerializeField]
		private int _victoryScore;

		[SerializeField]
		private float _roundMaxDuration;

		[Header("UI")]
		[SerializeField]
		private TextMeshProUGUI _roundTimerText;

		[SerializeField]
		private CanvasGroup _combatUi;

		[SerializeField]
		private PvPGameplayPlayerUI _playerUILeft;

		[SerializeField]
		private PvPGameplayPlayerUI _playerUIRight;

		[SerializeField]
		private PvPGameplayScoreUI _scoreUI;

		[SerializeField]
		private TextMeshProUGUI _roundText;

		[Header("References")]
		[SerializeField]
		private GearAnalysisUI _gearAnalysisUI;

		[SerializeField]
		private PvPGameplayRoundResult _roundResultUI;

		[SerializeField]
		private PvPGearAppearAnimator _gearAppearAnimator1;

		[SerializeField]
		private PvPGearAppearAnimator _gearAppearAnimator2;

		[Header("Intro Animation")]
		[SerializeField]
		private float _cameraOrthographicSize0;

		[SerializeField]
		private float _cameraOrthographicSize1;

		[SerializeField]
		private float _cameraZoomDuration;

		[SerializeField]
		private EaseOrAnimationCurve _cameraZoomEase;

		[SerializeField]
		private float _delayPlayerAppear;

		[SerializeField]
		private GameObject _playerAppearVfx;

		[SerializeField]
		private float _playerIntroScaleDuration;

		[SerializeField]
		private EaseOrAnimationCurve _playerIntroScaleEase;

		[SerializeField]
		private Animator _playerAppearAnimator;

		[Header("CountDown Animation")]
		[SerializeField]
		private TextMeshProUGUI _countText;

		[SerializeField]
		private float _countTextScale0;

		[SerializeField]
		private float _countTextScale1;

		[SerializeField]
		private float _countTextScaleDuration;

		[SerializeField]
		private EaseOrAnimationCurve _countTextEase;

		[SerializeField]
		private MMF_Player _startRoundFeedback;

		[SerializeField]
		private Animator _scoreAnimator;

		[Header("Events")]
		public UnityEvent OnEnterPreparePhaseEvent;

		public UnityEvent OnExitPreparePhaseEvent;

		[Header("Runtime")]
		[SerializeField]
		private int _currentRoundIndex;

		[SerializeField]
		private int _latestWonPlayerIndex;

		[SerializeField]
		private int[] _playerScores;

		[SerializeField]
		private bool _roundTimedOut;

		private PlayerProfile[] _players;

		private Camera _camera;

		private List<SpriteAddressable> _spriteAddressables;

		private int _spriteAddressableIndex;

		private GearOrganizer _player1GearOrganizer;

		private GearOrganizer _player2GearOrganizer;

		private bool _werePlayersAppeared;

		private PvPGearRollerService _gearRollerService;

		private HashSet<int> _player1GearBuffs;

		private HashSet<int> _player2GearBuffs;

		private int _player1GearStartIndex;

		private int _player2GearStartIndex;

		private CanvasGroup _scoreCanvasGroup;

		private List<float> _damageLogs;

		private List<Gear> _p1RandomGears;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LoadPlayers()
		{
		}

		private string GetPlayer1Name()
		{
			return null;
		}

		private string GetPlayer2Name()
		{
			return null;
		}

		private void LoadGears()
		{
		}

		[AsyncStateMachine(typeof(_003CRun_003Ed__57))]
		private UniTask Run()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CIntro_003Ed__58))]
		private UniTask Intro()
		{
			return default;
		}

		private void ScalePlayerModel(PlayerUnit playerUnit)
		{
		}

		private void DisableAllRendererOfGearOrganizer(GearOrganizer gearOrganizer, int startIndex)
		{
		}

		[AsyncStateMachine(typeof(_003CRevivePlayers_003Ed__61))]
		private UniTask RevivePlayers()
		{
			return default;
		}

		private void RestorePlayer(PlayerProfile playerProfile, List<PlayerSkillData> playerSkillData)
		{
		}

		private List<PlayerSkillData> GetPlayerSkillData(ArenaCombatData arenaCombatData, PlayerInfo playerInfo, int[] additionalIds)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSetupBag_003Ed__64))]
		private UniTask SetupBag()
		{
			return default;
		}

		private List<Gear> CreateGears(PlayerProfile player, List<LevelStartGear> startGears, HashSet<int> gearBuffs)
		{
			return null;
		}

		private List<Gear> CreateGears(PlayerProfile player, int[] gearIds, HashSet<int> gearBuffs)
		{
			return null;
		}

		private void ReapplyGearDamageLogs()
		{
		}

		[AsyncStateMachine(typeof(_003CChooseBuffs_003Ed__68))]
		private UniTask ChooseBuffs()
		{
			return default;
		}

		private void ActiveBuffIds(PlayerProfile playerProfile, IEnumerable<int> buffIds)
		{
		}

		private void PrepareRound()
		{
		}

		[AsyncStateMachine(typeof(_003CCountDownFight_003Ed__71))]
		private UniTask CountDownFight()
		{
			return default;
		}

		private void PrepareFight()
		{
		}

		[AsyncStateMachine(typeof(_003CIntroGear_003Ed__73))]
		private UniTask IntroGear()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CIntroGear_003Ed__74))]
		private UniTask IntroGear(GearOrganizer gearOrganizer, int startIndex, PvPGearAppearAnimator animator)
		{
			return default;
		}

		private void DoCountTextAnimation()
		{
		}

		[AsyncStateMachine(typeof(_003CFight_003Ed__76))]
		private UniTask Fight()
		{
			return default;
		}

		private void CacheDamageLogs()
		{
		}

		[AsyncStateMachine(typeof(_003CClearPostRound_003Ed__78))]
		private UniTask ClearPostRound()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CShowResult_003Ed__79))]
		private UniTask ShowResult()
		{
			return default;
		}

		private void ActivateAllGearActiveSkills(IEnumerable<Gear> gears)
		{
		}

		private void DeactivateAllGearActiveSkills(IEnumerable<Gear> gears)
		{
		}

		private void GainStatShield(Unit unit)
		{
		}

		private void CheckScore()
		{
		}

		private void OnPlayerDead(Health health)
		{
		}

		private ArenaCombatData GetCurrentCombatData()
		{
			return null;
		}

		private void BuildPvPArenaContext()
		{
		}

		private void FillPvPArenaResult(int trophiesAfter)
		{
		}

		private bool InProgress()
		{
			return false;
		}

		private bool HasRoundEnded()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CRunRoundTimer_003Ed__90))]
		private UniTask RunRoundTimer()
		{
			return default;
		}

		private Gear CreateStartGear(PlayerProfile player, int gearId, Vector2Int position, HashSet<int> gearBuffs)
		{
			return null;
		}

		private void CacheSprite(string spritePath)
		{
		}
	}
}
