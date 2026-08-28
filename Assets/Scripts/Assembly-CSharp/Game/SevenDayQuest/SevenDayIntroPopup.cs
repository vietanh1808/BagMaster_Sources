using System;
using System.Collections.Generic;
using DG.Tweening;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.SevenDayQuest
{
	public class SevenDayIntroPopup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _titleText;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[SerializeField]
		private TextMeshProUGUI _countdownText;

		[SerializeField]
		private List<ResourceView> _rewardViews;

		[SerializeField]
		private Button _openEventButton;

		[Header("Return")]
		[SerializeField]
		private Transform _flyIcon;

		[SerializeField]
		private float _flyDuration;

		[SerializeField]
		private Ease _flyEase;

		[SerializeField]
		private MMF_Player _closeFeedback;

		[Header("Coming Soon State")]
		[SerializeField]
		private Button _notTimeButton;

		[SerializeField]
		private TextMeshProUGUI _incomingText;

		private SevenDayEventConfig _eventData;

		private DateTime _endTime;

		private DateTime _incomingEndTime;

		private EventDisplayState _state;

		private float _lastAmountTime;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void ApplyState(EventDisplayState state)
		{
		}

		public void SetCountDownInComingText(DateTime startTime, float lastAmountTime)
		{
		}

		private void RenderIncomingCountdown()
		{
		}

		public void SetEventId(SevenDayEventConfig data)
		{
		}

		public void Close()
		{
		}

		public void CloseWithFlyAnimation()
		{
		}

		private SevenDayLoginQuestButton FindTargetButton()
		{
			return null;
		}

		private void PopulateRewardList(int eventId)
		{
		}

		private void OpenEvent()
		{
		}
	}
}
