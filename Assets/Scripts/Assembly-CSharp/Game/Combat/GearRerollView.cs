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
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class GearRerollView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDelayGlowFreeReroll_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public float delay;

			public GearRerollView _003C_003E4__this;

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
		private sealed class _003CDelayedSetButtonInteractable_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public GearRerollView _003C_003E4__this;

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
			public _003CDelayedSetButtonInteractable_003Ed__51(int _003C_003E1__state)
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
		private Button _rerollButton;

		[SerializeField]
		private Button _recycleNRerollButton;

		[SerializeField]
		private GameObject _freeRerollUI;

		[SerializeField]
		private GameObject _priceRerollUI;

		[SerializeField]
		private TextMeshProUGUI _priceRerollText;

		[SerializeField]
		private TextMeshProUGUI _freeRerollCountText;

		[SerializeField]
		private GameObject _adsIcon;

		[SerializeField]
		private Sprite _adsRerollButtonSprite;

		[SerializeField]
		private Transform _goldFloatingTextPosition;

		[Header("Feedbacks")]
		[SerializeField]
		private MMF_Player _notEnoughGoldFeedback;

		[SerializeField]
		private MMF_Player _swapNRevertClickFeedback;

		[SerializeField]
		private MMF_Player _rerollClickFeedback;

		[SerializeField]
		private MMF_Player _receiveFreeRerollRecycleFeedback;

		[Header("Animation")]
		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private string _swapRerollButtonTrigger;

		[SerializeField]
		private string _revertRerollButtonTrigger;

		[SerializeField]
		private Animator _glowAnimator;

		[SerializeField]
		private float _delayCheckGlowOnEnable;

		[SerializeField]
		private float _delayGlowWhenReceiveFromRecycle;

		[Header("Events")]
		public UnityEvent OnRerollEvent;

		public UnityEvent OnRerollByAdsEvent;

		public UnityEvent OnRerollAdsTicketEvent;

		private Sprite _rerollButtonInitialSprite;

		private UISound _rerollButtonSound;

		private int _freeReroll;

		private int _rerollPrice;

		private RecyleDropArea _recycleArea;

		private Color _initialPriceColor;

		private PlayerInfo PInfo => null;

		private OwnedResourceEntity Gold => null;

		private bool IsEnoughRerollPrice => false;

		private bool AdsRerollAvailable => false;

		private float GoldOffset => 0f;

		private bool HasRecycle => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void UpdateInfo(int freeReroll, int price)
		{
		}

		public void SetButtonVisible(bool visible)
		{
		}

		public void SetButtonInteractable()
		{
		}

		public void SetButtonNoninteractable()
		{
		}

		public void SetButtonNoninteractableWithDuration(float duration)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedSetButtonInteractable_003Ed__51))]
		private IEnumerator DelayedSetButtonInteractable(float delay)
		{
			return null;
		}

		private void UpdateRerollState()
		{
		}

		private void SetFreeReroll()
		{
		}

		private void SetNonFreeReroll()
		{
		}

		private void SetEnoughRerollGold()
		{
		}

		private void SetNotEnoughRerollGold()
		{
		}

		private bool GoldCheck()
		{
			return false;
		}

		private void OnRerollButtonClicked()
		{
		}

		private void OnRecycleNRerollButtonClicked()
		{
		}

		private void Reroll()
		{
		}

		private void InvokeReroll()
		{
		}

		private void InvokeRerollByAds()
		{
		}

		private void GlowFreeRerollFromRecycle()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayGlowFreeReroll_003Ed__64))]
		private UniTask DelayGlowFreeReroll(float delay)
		{
			return default;
		}

		private void GlowFreeReroll()
		{
		}

		private int GetGoldGapAdsThresold()
		{
			return 0;
		}
	}
}
