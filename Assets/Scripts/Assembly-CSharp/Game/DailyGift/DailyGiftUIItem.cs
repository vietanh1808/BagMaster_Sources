using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.DailyGift
{
	public class DailyGiftUIItem : MonoBehaviour
	{
		[Header("Rewards")]
		[SerializeField]
		private List<ResourceView> _rewardItems;

		[Header("State Objects")]
		[SerializeField]
		private GameObject _lockObject;

		[SerializeField]
		private GameObject _claimedObject;

		[SerializeField]
		private GameObject _inActiveObject;

		[SerializeField]
		private Image _progressBar;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[Header("Buttons")]
		[SerializeField]
		private Button _freeButton;

		[SerializeField]
		private Button _freeLockedButton;

		[SerializeField]
		private Button _adsButton;

		[SerializeField]
		private Button _adsLockedButton;

		[SerializeField]
		private TextMeshProUGUI _adsProgressText;

		[SerializeField]
		private TextMeshProUGUI _adsProgressTextOnLocked;

		[SerializeField]
		private TextMeshProUGUI _textProgress;

		[Header("Events")]
		public UnityEvent<DailyGiftUIItem> OnWatchAdsEvent;

		public UnityEvent OnUseTicketEvent;

		public UnityEvent OnWatchAdsSuccessfulEvent;

		public UnityEvent<DailyGiftUIItem> OnFreeClaimedEvent;

		[HideInInspector]
		public bool CallbackAdded;

		private float _interactableTime;

		public DailyGiftDisplayData DisplayData { get; private set; }

		private void Awake()
		{
		}

		public void UpdateInfo(DailyGiftDisplayData data)
		{
		}

		private void Refresh()
		{
		}

		private void UpdateRewardViews()
		{
		}

		private void ApplyState()
		{
		}

		private void SetTextAdsCount(TextMeshProUGUI text)
		{
		}

		private void UpdateProgressBar()
		{
		}

		private void OnFreeClicked()
		{
		}

		private void OnAdsClicked()
		{
		}

		private bool TryInteract()
		{
			return false;
		}

		public void InvokeWatchedAdsSuccess(bool useTicket)
		{
		}
	}
}
