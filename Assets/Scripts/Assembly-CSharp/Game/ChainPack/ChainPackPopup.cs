using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DoorServices;
using Game.Data;
using Game.GUI;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.ChainPack
{
	public class ChainPackPopup : UiBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			public UINagivator nav;

			internal bool _003CCloseAfterConfirm_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCloseAfterConfirm_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChainPackPopup _003C_003E4__this;

			private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

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
		private sealed class _003CInitItems_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChainPackPopup _003C_003E4__this;

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
			public _003CInitItems_003Ed__44(int _003C_003E1__state)
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
		private struct _003COnClaimReward_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChainPackPopup _003C_003E4__this;

			public ChainPackItem item;

			public int order;

			public RewardPack rewardPack;

			private int _003Clevel_003E5__2;

			private List<ResourceRewardData> _003Crewards_003E5__3;

			private bool _003ChasBundleReward_003E5__4;

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

		[SerializeField]
		private NodeItemView nodeItemPrefab;

		[SerializeField]
		private Transform nodeParent;

		[SerializeField]
		private ChainPackItem packItemPrefab;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private RectTransform content;

		[SerializeField]
		private TextMeshProUGUI textTitle;

		[SerializeField]
		private TextMeshProUGUI textRemainTimeSession;

		[SerializeField]
		private Button btnNext;

		[SerializeField]
		private Button btnPrevious;

		[SerializeField]
		private GameObject navigatorContainer;

		[SerializeField]
		private List<GameObject> packVisualList;

		[Header("Returning animation")]
		[SerializeField]
		private MMF_Player changeTabFeedback;

		[SerializeField]
		private MMF_Player returnFeedback;

		[SerializeField]
		private Transform container;

		[SerializeField]
		private float returnDuration;

		[SerializeField]
		private Ease returnEase;

		[SerializeField]
		private GameObject endReturnVfx;

		[Header("Reward received")]
		[SerializeField]
		private Transform rewardItemContainer;

		[SerializeField]
		private FlyToBarProfile flyToBarProfile;

		[SerializeField]
		private GameObject previousCTABtn;

		[SerializeField]
		private GameObject nextCTABtn;

		[SerializeField]
		private Color _lastChanceColor;

		[CompilerGenerated]
		private Action m_OnClosed;

		private List<NodeItemView> allNodes;

		private List<ChainPackItem> allItems;

		private List<ChainPackConfig> configs;

		private bool canHide;

		private int currentGroupId;

		private int currentTabIndex;

		private int totalNode;

		private Coroutine timeRemainCoroutine;

		private Coroutine deliveryCoroutine;

		private CanvasGroup canvasGroup;

		private bool _lastChance;

		private StoreEntryMethod _storeEntryMethod;

		public event Action OnClosed
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowDefault(int index, bool initItem = true, StoreEntryMethod storeEntryMethod = StoreEntryMethod.AutoOpen)
		{
		}

		public int ProceedToRewardTab()
		{
			return 0;
		}

		private void UpdateCtaButtonState()
		{
		}

		private bool TabHasReward(int tabIndex)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CInitItems_003Ed__44))]
		private IEnumerator InitItems()
		{
			return null;
		}

		private void RefreshTime(long second)
		{
		}

		public void Refresh(bool isInitializing = false)
		{
		}

		[AsyncStateMachine(typeof(_003COnClaimReward_003Ed__47))]
		private UniTaskVoid OnClaimReward(ChainPackItem item, int order, RewardPack rewardPack)
		{
			return default;
		}

		private float FlyReward(ChainPackItem item, List<ResourceRewardData> rewards)
		{
			return 0f;
		}

		private List<(int, int, Vector3)> GetRewardDeliveryData(ChainPackItem item, List<ResourceRewardData> rewards)
		{
			return null;
		}

		private void Next()
		{
		}

		private void Previous()
		{
		}

		private void JumpToIndex(int index, float duration)
		{
		}

		private ChainPackDirection ConvertDirection(int index)
		{
			return ChainPackDirection.Top;
		}

		public void ReturnNClose()
		{
		}

		[AsyncStateMachine(typeof(_003CCloseAfterConfirm_003Ed__55))]
		private UniTaskVoid CloseAfterConfirm()
		{
			return default;
		}

		private void CloseImmediately()
		{
		}

		private void SetInteractable(bool interactable)
		{
		}

		private static void ScrollToItemVertical(ScrollRect scrollRect, RectTransform item, float duration)
		{
		}
	}
}
