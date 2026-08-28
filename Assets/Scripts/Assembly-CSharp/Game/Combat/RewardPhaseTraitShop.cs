using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Game.Constant;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class RewardPhaseTraitShop : MonoBehaviour
	{
		public class OpenParams
		{
			public List<CombatChestData> shopDatas;

			public List<int> initBuffs;

			public bool saveOnGetItem;

			public bool ignoreWaveLimit;

			[Obsolete]
			public CombatChestData shopData;
		}

		private struct StoredFlyItemData
		{
			public Sprite frame;

			public Sprite border;

			public Sprite icon;

			public GameObject obj;

			public Vector3 startPosition;
		}

		public class SelectedBuffData
		{
			public BuffData BuffData;

			public Color Color;
		}

		[CompilerGenerated]
		private sealed class _003CChainedOpen_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseTraitShop _003C_003E4__this;

			public List<int> priorityBuffIds;

			public List<CombatChestData> chestDatas;

			public int index;

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
			public _003CChainedOpen_003Ed__69(int _003C_003E1__state)
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
		private sealed class _003CChainedShowFlyObj_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseTraitShop _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CChainedShowFlyObj_003Ed__72(int _003C_003E1__state)
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
		private sealed class _003CHideButtons_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public RewardPhaseTraitShop _003C_003E4__this;

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
			public _003CHideButtons_003Ed__84(int _003C_003E1__state)
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
		private sealed class _003COpen_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OpenParams openParams;

			public RewardPhaseTraitShop _003C_003E4__this;

			private Image _003CbgImage_003E5__2;

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
			public _003COpen_003Ed__73(int _003C_003E1__state)
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
		private sealed class _003COpen_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseTraitShop _003C_003E4__this;

			public bool saveOnGetItem;

			public bool ignoreWaveLimit;

			public CombatChestData shopData;

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
			public _003COpen_003Ed__74(int _003C_003E1__state)
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
		private struct _003CStoreFlyItem_003Ed__100 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TraitItem item;

			public RewardPhaseTraitShop _003C_003E4__this;

			private GameObject _003Cgo_003E5__2;

			private GameObject _003CcontainerObj_003E5__3;

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
		private sealed class _003CUpdateButtons_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public bool useSkipAnimation;

			public RewardPhaseTraitShop _003C_003E4__this;

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
			public _003CUpdateButtons_003Ed__85(int _003C_003E1__state)
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
		private sealed class _003CWaitShowRerollButton_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool useSkipAnimation;

			public RewardPhaseTraitShop _003C_003E4__this;

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
			public _003CWaitShowRerollButton_003Ed__83(int _003C_003E1__state)
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
		private sealed class _003CWaitUntilTraitItemGet_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardPhaseTraitShop _003C_003E4__this;

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
			public _003CWaitUntilTraitItemGet_003Ed__70(int _003C_003E1__state)
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

		[SerializeField]
		private Button _bagReviewBtn;

		[SerializeField]
		private Button _buffReviewBtn;

		[SerializeField]
		private Sprite[] _titleSprites;

		[SerializeField]
		private Image _titleImage;

		[SerializeField]
		private TraitShopRerollView _rerollView;

		[SerializeField]
		private BuffSelectionCounterUI _buffCounterUi;

		[Header("Peek Bag")]
		[SerializeField]
		private CanvasGroup _peekCanvasGroup;

		[Header("Other ")]
		public List<TraitItem> Items;

		public MMF_Player CloseFeedback;

		public GameObject FireworkVfx;

		public float[] _itemAppearDelays;

		public int MaxRerollPerOpen;

		public CanvasGroup[] _hideWhenOpen;

		public AudioSource LoopAudioSource;

		public GameObject FlyBuffItemPrefab;

		[Header("Sound")]
		public AudioClip[] SoundByRarities;

		public AudioClip SoundSkip;

		public AudioClip SoundStoreFlyItem;

		private bool _initialized;

		private int _rerollCountThisOpen;

		private int _takeAllCountThisOpen;

		private CombatChestData _shopData;

		private bool _continue;

		private Dictionary<int, List<SelectedBuffData>> _selecteds;

		private Canvas _canvas;

		private bool saveOnGetItem;

		private TraitShopBuffSpawnService _buffSpawnService;

		[SerializeField]
		private GameObject mainContent;

		[SerializeField]
		private GameObject viewBagButtonHolder;

		[SerializeField]
		private TMP_Text textBuffCount;

		[SerializeField]
		private Transform flyObjectContent;

		[SerializeField]
		private List<StoredFlyItemData> flyBuffs;

		private bool useStoreFlyObj;

		private bool _hasBroadcastedExitEvent;

		private bool _wasItemGet;

		private bool _stopShowReroll;

		private Coroutine showRerollCoroutine;

		private bool shouldShowTextBuffCount;

		public TraitShopRerollView RerollView => null;

		private PlayerInfo PInfo => null;

		public IDictionary<int, List<SelectedBuffData>> Selecteds => null;

		public int LastClaimWave { get; private set; }

		public int RerollCount { get; private set; }

		public int TakeAllCount { get; private set; }

		public int TakeAllByAdsCount { get; private set; }

		public Unit Player => null;

		public Rarity CurrentRarity => Rarity.Common;

		private int TakeAllConfigIndex => 0;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize()
		{
		}

		public void AddToPool(BuffData buffData)
		{
		}

		public void SortBuffGroup()
		{
		}

		[IteratorStateMachine(typeof(_003CChainedOpen_003Ed__69))]
		private IEnumerator ChainedOpen(List<CombatChestData> chestDatas, int index = 0, List<int> priorityBuffIds = null)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitUntilTraitItemGet_003Ed__70))]
		private IEnumerator WaitUntilTraitItemGet()
		{
			return null;
		}

		private void OnGetTraitItem(TraitItem traitItem)
		{
		}

		[IteratorStateMachine(typeof(_003CChainedShowFlyObj_003Ed__72))]
		private IEnumerator ChainedShowFlyObj()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COpen_003Ed__73))]
		public IEnumerator Open(OpenParams openParams)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COpen_003Ed__74))]
		[Obsolete("use Open with [OpenParams] instead of")]
		public IEnumerator Open(CombatChestData shopData, bool ignoreWaveLimit = false, bool saveOnGetItem = true)
		{
			return null;
		}

		private void Reroll()
		{
		}

		public bool IsSkipBuffRollAnimation()
		{
			return false;
		}

		public bool IsFinishAnimation()
		{
			return false;
		}

		private void GetAllBuffs()
		{
		}

		private void GetAllBuffsByAds()
		{
		}

		private void InternalTakeAllBuffs(bool ads)
		{
		}

		public void StopShowRerollButton()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitShowRerollButton_003Ed__83))]
		private IEnumerator WaitShowRerollButton(bool useSkipAnimation = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHideButtons_003Ed__84))]
		private IEnumerator HideButtons(float delay = 0.12f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUpdateButtons_003Ed__85))]
		private IEnumerator UpdateButtons(float delay, bool useSkipAnimation = false)
		{
			return null;
		}

		private void DoRestock(List<Rarity> rarities, List<BuffData> priorityBuffDatas, int numberItems)
		{
		}

		private void DoRestock(List<Rarity> rarities, int numberItems)
		{
		}

		private void Restock(CombatChestData shopData)
		{
		}

		private void Restock(CombatChestData shopData, List<int> priorityBuffs)
		{
		}

		private void Restock()
		{
		}

		private void ShowTitleImage(Rarity rarity)
		{
		}

		private void DisplayBuffs(List<BuffData> buffDatas, bool useSkipAnimation)
		{
		}

		private void CreateBuffUIItem(BuffData buffData, int groupId, float delayAppear)
		{
		}

		private void PlayStartSound()
		{
		}

		private void OnGetItem(BuffData buffData, TraitItem item)
		{
		}

		[AsyncStateMachine(typeof(_003CStoreFlyItem_003Ed__100))]
		private void StoreFlyItem(TraitItem item)
		{
		}

		private void CreateFlyItem(TraitItem item)
		{
		}

		private void CreateFlyItem(Vector3 startPosition, Sprite frame, Sprite border, Sprite icon)
		{
		}

		private void OnBuffSelected(BuffData buffData, SimpleSkill skill, int wave)
		{
		}

		public void LoadBuffFromSave()
		{
		}

		public void LoadBuffFromSave(CombatSaveData saveData)
		{
		}

		public void ClearSelected()
		{
		}

		public void FadeOutUI()
		{
		}

		public void FadeInUI()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
