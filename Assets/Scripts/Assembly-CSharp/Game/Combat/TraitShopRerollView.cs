using System;
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
	public class TraitShopRerollView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPushGemOffer_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopRerollView _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CWaitForEndDelivery_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopRerollView _003C_003E4__this;

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
		private Button _rerollButton;

		[SerializeField]
		private GameObject _rerollAdsUi;

		[SerializeField]
		private TextMeshProUGUI _rerollAdsCountText;

		[SerializeField]
		private string _rerollAdsCountFormat;

		[SerializeField]
		private GameObject _rerollFreeUi;

		[SerializeField]
		private Button _takeAllButton;

		[SerializeField]
		private Button _takeAllNotEnoughtButton;

		[SerializeField]
		private Button buttonTakeAllPlainText;

		[SerializeField]
		private CurrencyView _takeAllPriceView;

		[SerializeField]
		private CurrencyView _takeAllNotEnoughPriceView;

		[SerializeField]
		private Button _takeAllByAdsButton;

		[SerializeField]
		private TextMeshProUGUI _takeAllAdsCountText;

		[SerializeField]
		private string _takeAllAdsFormat;

		[SerializeField]
		private float _buttonInteractableCooldown;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private MMF_Player _offerTakeAllFeedback;

		[SerializeField]
		private GameObject _gemBar;

		[Header("Events")]
		public UnityEvent OnReroll;

		public UnityEvent OnRerollAdsTicketEvent;

		public UnityEvent OnTakeAll;

		public UnityEvent OnTakeAllByAds;

		public UnityEvent OnTakeAllByAdsTicketEvent;

		public Func<bool> IsFinishAnimation;

		private float _interactableTime;

		private ResourceRequireData _takeAllCost;

		private bool forceHideButtons;

		private QuickAidConfig? _takeAllConfig;

		public ResourceRequireData TakeAllCost => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void SetButtonVisibility(bool reroll, bool takeAll, bool takeAllAds)
		{
		}

		public void SetRerollPrice(bool free, int adsCount, int totalAds)
		{
		}

		public void SetTakeAllPrice(ResourceRequireData cost)
		{
		}

		public void SetTakeAllPrice(in QuickAidConfig takeAllConfig)
		{
		}

		public void SetTakeAllAds(int adsCount)
		{
		}

		private void OnRerollClicked()
		{
		}

		private void Reroll()
		{
		}

		private void OnTakeAllClicked()
		{
		}

		[AsyncStateMachine(typeof(_003CPushGemOffer_003Ed__40))]
		private UniTask PushGemOffer()
		{
			return default;
		}

		private void CostTakeAll()
		{
		}

		private void DoTakeAll()
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForEndDelivery_003Ed__43))]
		private UniTask WaitForEndDelivery()
		{
			return default;
		}

		public void ActiveTakeAllPlainTextButton(bool value)
		{
		}

		public void ActiveButtons(bool value)
		{
		}

		public Button GetFakeTakeAllButton()
		{
			return null;
		}

		private void OnTakeAllByAdsClicked()
		{
		}

		private void SendTrackRerollOffer()
		{
		}

		private void SendTrackTakeAllOffer()
		{
		}

		private bool IsInteractable()
		{
			return false;
		}
	}
}
