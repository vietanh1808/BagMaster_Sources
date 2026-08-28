using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using I2.Loc;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.SevenDayQuest
{
	public class SevenDayLoginQuestButton : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitAndShowUnlockedPopupAsync_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SevenDayLoginQuestButton _003C_003E4__this;

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

		private static readonly List<SevenDayLoginQuestButton> _eventButtons;

		[Header("Active State")]
		[SerializeField]
		private Button _button;

		[SerializeField]
		private Localize _nameLocalize;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private MMF_Player _introReturnFeedback;

		[Header("Coming Soon State")]
		[SerializeField]
		private Button _comingSoonButton;

		[SerializeField]
		private Image _comingSoonIcon;

		[SerializeField]
		private TextMeshProUGUI _countDownText;

		[Tooltip("Last amount time in seconds")]
		[SerializeField]
		private float _lastAmountTime;

		private int _eventId;

		private string _popupPath;

		private SevenDayEventConfig _config;

		private EventDisplayState _state;

		private DateTime _startTime;

		private double _remainingSeconds;

		private float _nextRenderTime;

		private Color _normalTextColor;

		public int EventId => 0;

		public static SevenDayLoginQuestButton FindEvenButton(int eventId)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Init(SevenDayEventConfig config, bool isComingSoon = false, TimeSpan timeUntilStart = default(TimeSpan))
		{
		}

		private void SetComingSoon(bool isComingSoon, TimeSpan timeUntilStart)
		{
		}

		private void Update()
		{
		}

		private void UpdateComingSoonCountdown()
		{
		}

		private void ApplyState(EventDisplayState state)
		{
		}

		private void RenderCountdownText()
		{
		}

		private void OnExpired()
		{
		}

		private void CheckIsExpired()
		{
		}

		private void ShowPopup()
		{
		}

		private void ShowIntroIncomingPopup()
		{
		}

		private void ShowIntroUnlockedPopup()
		{
		}

		private void PushIntroPopup(bool isComingSoon)
		{
		}

		[AsyncStateMachine(typeof(_003CWaitAndShowUnlockedPopupAsync_003Ed__37))]
		private UniTaskVoid WaitAndShowUnlockedPopupAsync()
		{
			return default;
		}

		private bool IsAnyPopupOpenOrTransitioning(UINagivator nav)
		{
			return false;
		}

		public void PlayIntroReturnFeedback()
		{
		}
	}
}
