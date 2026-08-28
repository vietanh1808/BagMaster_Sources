using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using Game.Helpers;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class EventDungeonInfoLayout : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDoRefreshBuffLayout_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonInfoLayout _003C_003E4__this;

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
		private struct _003CEnterGameplay_003Ed__75 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonInfoLayout _003C_003E4__this;

			private EventDungeonViewState _003Clevel_003E5__2;

			private EventDungeonCampaign _003Ccurrent_003E5__3;

			private int _003CstartWave_003E5__4;

			private TaskAwaiter<LayoutType> _003C_003Eu__1;

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
		private struct _003CRenderBanner_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonInfoLayout _003C_003E4__this;

			public EventDungeonUnlockViewState asset;

			private Image _003C_003E7__wrap1;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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
		private struct _003CRenderFrame_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public EventDungeonInfoLayout _003C_003E4__this;

			public EventDungeonUnlockViewState asset;

			private Image _003C_003E7__wrap1;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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
		private static Action m_onClose;

		private List<EventDungeonViewState> levels;

		private EventDungeonProgressData currentProgress;

		[SerializeField]
		private Image imageBanner;

		[SerializeField]
		private Image imageFrame;

		[SerializeField]
		private TMP_Text textTitle;

		[SerializeField]
		private HorizontalLayoutGroup buffLayoutGroup;

		[SerializeField]
		private TMP_Text textBuffDescription;

		[SerializeField]
		private TMP_Text textDifficult;

		[SerializeField]
		private Button buttonPreviousDifficult;

		[SerializeField]
		private Button buttonNextDifficult;

		[SerializeField]
		private TMP_Text textTicket;

		[SerializeField]
		private Image imageTicket;

		[SerializeField]
		private Color colorEmptyTicket;

		[SerializeField]
		private EventDungeonInfoRewardsLayout rewardLayout;

		[SerializeField]
		private CooldownButton buttonClose;

		[SerializeField]
		private CooldownButton buttonSweep;

		[SerializeField]
		private Image imageSweepTicket;

		[SerializeField]
		private TMP_Text textSweepTicket;

		[SerializeField]
		private CooldownButton buttonSweepPrevious;

		[SerializeField]
		private Image imageSweepPreviousTicket;

		[SerializeField]
		private TMP_Text textSweepPreviousTicket;

		[SerializeField]
		private CooldownButton buttonChallenge;

		[SerializeField]
		private TMP_Text textChallengeBlocker;

		[SerializeField]
		private Image imageChallengeTicket;

		[SerializeField]
		private TMP_Text textChallengeTicket;

		[SerializeField]
		private CooldownButton buttonAdsBuyTicket;

		[SerializeField]
		private CooldownButton buttonBuyTicket;

		[SerializeField]
		private TMP_Text textButtonBuyCurrency;

		[SerializeField]
		private Image imageButtonBuyCurrency;

		[SerializeField]
		private MMAdditiveSceneLoadingManagerSettings _loadingSceneSettings;

		[SerializeField]
		private GameObject sweepPreviousFloorWhenReachMaxNotification;

		private int selectingLevel;

		private UINagivator uiNavInstance;

		private Color defaultTextBuyColor;

		public EventDungeonUnlockViewState ViewState { get; private set; }

		public Button ButtonChallenge => null;

		public static event Action onClose
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

		private void OnDestroy()
		{
		}

		public void Refresh()
		{
		}

		public void SetData(EventDungeonUnlockViewState viewState, List<EventDungeonViewState> levels, EventDungeonProgressData currentProgress, bool allowedChangeDifficult, int targetLevel = 0)
		{
		}

		private void RenderView()
		{
		}

		[AsyncStateMachine(typeof(_003CRenderBanner_003Ed__48))]
		private void RenderBanner(EventDungeonUnlockViewState asset)
		{
		}

		[AsyncStateMachine(typeof(_003CRenderFrame_003Ed__49))]
		private void RenderFrame(EventDungeonUnlockViewState asset)
		{
		}

		private EventDungeonViewState GetSelectingLevel()
		{
			return null;
		}

		private EventDungeonViewState GetPreviousLevel()
		{
			return null;
		}

		private void UpdateButtonChallengeState()
		{
		}

		private void UpdateButtonSweepState()
		{
		}

		private void UpdateButtonSweepPreviousState()
		{
		}

		private void UpdateButtonBuyTicketStates()
		{
		}

		private void UpdateButtonBuyAdsTicketState()
		{
		}

		private void UpdateButtonStates()
		{
		}

		private void UpdateLevelSelectionView()
		{
		}

		[AsyncStateMachine(typeof(_003CDoRefreshBuffLayout_003Ed__59))]
		private UniTaskVoid DoRefreshBuffLayout()
		{
			return default;
		}

		private bool GetQuickSweepActiveCondition()
		{
			return false;
		}

		private bool GetSweepPreviousActiveCondition()
		{
			return false;
		}

		private bool GetSweepCondition(EventDungeonViewState level)
		{
			return false;
		}

		private void UpdateDungeonRewardsView(EventDungeonViewState level)
		{
		}

		private void UpdateTicketCount(EventDungeonUnlockViewState state)
		{
		}

		private void OnNextDifficult()
		{
		}

		private void OnPreviousDifficult()
		{
		}

		private void OnCloseClicked()
		{
		}

		private void OnSweepClicked()
		{
		}

		private void OnSweepPreviousClicked()
		{
		}

		private void SweepLevel(EventDungeonViewState level)
		{
		}

		private bool CanPlayThisLevel(EventDungeonViewState level)
		{
			return false;
		}

		private void OnChallengeClicked()
		{
		}

		private void LoadingScreenFadeEnter()
		{
		}

		private void SendClickChallengeTrackingEvent()
		{
		}

		[AsyncStateMachine(typeof(_003CEnterGameplay_003Ed__75))]
		private UniTaskVoid EnterGameplay()
		{
			return default;
		}

		private void OnAdsBuyTicketClicked()
		{
		}

		private void OnUseAdsSkipTicket(ModalEventDungeonAdsOptions popup)
		{
		}

		private void OnWatchFreeAds(ModalEventDungeonAdsOptions popup)
		{
		}

		private bool HasEnoughBuyTicketCurrency()
		{
			return false;
		}

		private void OnBuyTicketClicked()
		{
		}

		private void DoShowRemoveCurrenyAnim()
		{
		}
	}
}
