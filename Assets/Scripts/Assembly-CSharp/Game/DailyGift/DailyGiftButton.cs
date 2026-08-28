using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.DailyGift
{
	public class DailyGiftButton : MonoBehaviour
	{
		[SerializeField]
		private Button _showPopupButton;

		[SerializeField]
		private TextMeshProUGUI _remainTimeText;

		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private UnityEvent<bool> _onNotificationEvent;

		private IDisposable _timer;

		private DailyGiftService _dailyGiftService;

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateTimer()
		{
		}

		private void Show()
		{
		}

		private void OnDailyGiftClaimed(int giftId, int claimCount)
		{
		}

		private void OnFeatureUnlocked(string feature)
		{
		}

		private void RefreshCta()
		{
		}

		private void SetNotification(bool value)
		{
		}
	}
}
