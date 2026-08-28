using System;
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using Game.QuestSystem;
using Game.SevenDayQuest;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game
{
	public class SevenDayQuestUIItem : EnhancedScrollerCellView
	{
		public enum State
		{
			None = 0,
			Claimable = 1,
			Claimed = 2
		}

		[SerializeField]
		private RectTransform _panel;

		[SerializeField]
		private TextMeshProUGUI _informationText;

		[SerializeField]
		private TextMeshProUGUI _progressText;

		[SerializeField]
		private string _progressTextFormat;

		[SerializeField]
		private Image _progressContent;

		[SerializeField]
		private Color _progressContentInProgressColor;

		[SerializeField]
		private Color _progressContentCompletedColor;

		[SerializeField]
		private Color _progressContentClaimedColor;

		[SerializeField]
		private Button _claimButton;

		[SerializeField]
		private Button _claimedButton;

		[SerializeField]
		private Button _goToButton;

		[SerializeField]
		private GameObject _expiredMark;

		[SerializeField]
		private List<ResourceView> _rewardViews;

		[Header("Event")]
		public UnityEvent OnClaimableEvent;

		public UnityEvent OnClaimedEvent;

		[Header("Runtime")]
		[SerializeField]
		private State _state;

		[SerializeField]
		private bool _isExpired;

		private SevenDayQuestData _data;

		private QuestData _questData;

		private RewardPack _rewardPack;

		public Action OnClaimEventRuntime;

		private bool isEventMode;

		private QuestSystemManager QSM => null;

		private SevenDayQuestManager SDQM => null;

		public SevenDayQuestData Data => null;

		public RectTransform Panel => null;

		private void Start()
		{
		}

		private void OnClaimButtonClicked()
		{
		}

		public void UpdateInfo(SevenDayQuestData data)
		{
		}

		private void GoTo()
		{
		}

		public RewardPack GetRewardPack(SevenDayQuestData data)
		{
			return null;
		}

		public void UpdateProgress(int current, int target)
		{
		}

		public void ShowCompleteQuest()
		{
		}

		public bool IsClaimable()
		{
			return false;
		}

		public bool IsClaimed()
		{
			return false;
		}

		public void SetState(State state)
		{
		}

		public void SetExpired(bool expired)
		{
		}

		public void UpdateEventInfo(SevenDayQuestData data)
		{
		}

		public void SetEventState(State state)
		{
		}
	}
}
