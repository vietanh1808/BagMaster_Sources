using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	[DefaultExecutionOrder(1)]
	public class RewardPhaseGearChest : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass77_0
		{
			public List<Transform> listItems;

			internal bool _003COpen_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass86_0
		{
			public Gear gear;

			internal bool _003CTutorialRestockAnimation_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass95_0
		{
			public Gear gear;

			internal bool _003CRestockAnimation_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CCloseToast_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeDelay;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CCloseToast_003Ed__89(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CForceGearRefreshPos_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CForceGearRefreshPos_003Ed__97(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CForceGearScale_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CForceGearScale_003Ed__96(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CHintMergeableAllGears_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CHintMergeableAllGears_003Ed__103(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003COpen_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseGearChest _003C_003E4__this;

			public RewardPack reward;

			private _003C_003Ec__DisplayClass77_0 _003C_003E8__1;

			private bool _003ChasDelayEnterCombat_003E5__2;

			private bool _003CrecycleUnlocked_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003COpen_003Ed__77(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReceiveFreeRerollFromRecycle_003Ed__99 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RewardPhaseGearChest _003C_003E4__this;

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

		[CompilerGenerated]
		private sealed class _003CRestockAnimation_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseGearChest _003C_003E4__this;

			public float delay;

			public List<Gear> gears;

			private _003C_003Ec__DisplayClass95_0 _003C_003E8__1;

			private List<Vector3> _003CtargetPositions_003E5__2;

			private List<Gear>.Enumerator _003C_003E7__wrap2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CRestockAnimation_003Ed__95(int _003C_003E1__state)
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
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowBuffEffect_003Ed__98 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RewardPhaseGearChest _003C_003E4__this;

			private Gear[] _003Cgears_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private RewardPhaseTraitShop.SelectedBuffData[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

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

		[CompilerGenerated]
		private sealed class _003CTutorialRestockAnimation_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseGearChest _003C_003E4__this;

			public float delay;

			public List<Gear> gears;

			private _003C_003Ec__DisplayClass86_0 _003C_003E8__1;

			private List<Gear>.Enumerator _003C_003E7__wrap1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CTutorialRestockAnimation_003Ed__86(int _003C_003E1__state)
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
		}

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private string _hideTrigger;

		[SerializeField]
		private GearRerollView _gearRerollView;

		[SerializeField]
		private BuySlotView _buySlotView;

		[SerializeField]
		private float _buttonCooldown;

		[SerializeField]
		private EnterBattleView _enterBattleView;

		[SerializeField]
		private BagNewSlotManager _bagNewSlotManager;

		[SerializeField]
		private GameplayGearManager _gameplayGearManager;

		[SerializeField]
		[Obsolete("Logic relocated to BuySlotView.cs")]
		private Button _slotBuyBtn;

		[SerializeField]
		[Obsolete("Logic relocated to BuySlotView.cs")]
		private GameObject _slotBuyUI;

		[SerializeField]
		[Obsolete("Logic relocated to BuySlotView.cs")]
		private TextMeshProUGUI _slotBuyTxt;

		[SerializeField]
		[Obsolete("Logic relocated to BuySlotView.cs")]
		private GameObject _slotBuyIcon;

		[SerializeField]
		[Obsolete("Logic relocated to BuySlotView.cs")]
		private GameObject _slotBuyMax;

		[SerializeField]
		private ButtonCTA _buttonCTA;

		[SerializeField]
		private WorldUI _worldUI;

		[SerializeField]
		private GameObject _goldSupplyPopup;

		[SerializeField]
		private MMF_Player _openFeedback;

		[SerializeField]
		private MMF_Player _closeFeedback;

		[SerializeField]
		private MMF_Player _firstSpawnGearFeedback;

		[SerializeField]
		private bool _pushMoreGoldIfNotEnough;

		private bool _initialized;

		private int _rerollCount;

		private int _rerollPriceIndex;

		private int _freeReroll;

		private bool _firstOpen;

		private List<GearData> notAddedYetGear;

		[SerializeField]
		private float waitForGearRecycle;

		[SerializeField]
		private float gearVelocity;

		[SerializeField]
		private RewardPhaseTraitShop _traitShop;

		[SerializeField]
		private float _delayShowBuffEffect;

		[SerializeField]
		private float _delayEnterCombatIfHasRecycle;

		public bool LockRestockOnce;

		private RecyleDropArea _recycleArea;

		private int _adsRerollUsedCount;

		private int _adsSlotBuyUsedCount;

		private bool _readyToUpdateReroll;

		public bool DontShowButton;

		private bool _isGeneratingNewGears;

		[SerializeField]
		private bool dontSaveProgress;

		[SerializeField]
		private bool doNotLoadSave;

		[SerializeField]
		private float _delayReceiveFreeReroll;

		private Coroutine forcingScaleCoroutine;

		private Coroutine restockAnimation;

		private Coroutine refreshPositionCoroutine;

		public static RewardPhaseGearChest Instance { get; private set; }

		private PlayerInfo PInfo => null;

		private OwnedResourceEntity Gold => null;

		private RerollPriceData RerollPrices => null;

		private LevelData CurrentLevel => null;

		private int RerollPrice => 0;

		public int FreeReroll => 0;

		public int RerollCount => 0;

		public int RerollPriceIndex => 0;

		public int LastFirstSpawnWave { get; private set; }

		public int AdsRerollUsedCount => 0;

		public int AdsSlotBuyUsedCount => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize()
		{
		}

		protected virtual void SaveProgress()
		{
		}

		[IteratorStateMachine(typeof(_003COpen_003Ed__77))]
		public IEnumerator Open(ChestData chestData, RewardPack reward)
		{
			return null;
		}

		private void AnimRecycleGear(List<Transform> recycleGears)
		{
		}

		private void RecycleGear(List<Transform> recycleGears)
		{
		}

		private void UpdateRerollLogic()
		{
		}

		private void OnGoldValueChanged(int newValue)
		{
		}

		private void Reroll()
		{
		}

		private void RerollByAds()
		{
		}

		public void TutorialRerollGiveEpicShortSword()
		{
		}

		private void TutorialRestockGiveEpicShortSword()
		{
		}

		[IteratorStateMachine(typeof(_003CTutorialRestockAnimation_003Ed__86))]
		private IEnumerator TutorialRestockAnimation(List<Gear> gears, float delay)
		{
			return null;
		}

		private void AddGearToBag()
		{
		}

		private void SlotBuy()
		{
		}

		[IteratorStateMachine(typeof(_003CCloseToast_003Ed__89))]
		private IEnumerator CloseToast(float timeDelay)
		{
			return null;
		}

		private void ToggleRecycleArea(bool active)
		{
		}

		private bool EnoughSlotGold()
		{
			return false;
		}

		private void Restock()
		{
		}

		[IteratorStateMachine(typeof(_003CRestockAnimation_003Ed__95))]
		private IEnumerator RestockAnimation(List<Gear> gears, float delay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CForceGearScale_003Ed__96))]
		private IEnumerator ForceGearScale()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CForceGearRefreshPos_003Ed__97))]
		private IEnumerator ForceGearRefreshPos()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CShowBuffEffect_003Ed__98))]
		private UniTask ShowBuffEffect()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CReceiveFreeRerollFromRecycle_003Ed__99))]
		private UniTask ReceiveFreeRerollFromRecycle()
		{
			return default;
		}

		public void AddFreeReroll(int amount)
		{
		}

		private void CTABuyButton(bool enable)
		{
		}

		public void AddGearToPool(GearData gearData)
		{
		}

		[IteratorStateMachine(typeof(_003CHintMergeableAllGears_003Ed__103))]
		private IEnumerator HintMergeableAllGears()
		{
			return null;
		}

		public void IncrementAdsRerollUsed()
		{
		}

		public void IncrementAdsSlotBuyUsed()
		{
		}

		public void LoadSaveData()
		{
		}
	}
}
