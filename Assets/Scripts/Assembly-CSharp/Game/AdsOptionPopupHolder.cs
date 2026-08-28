using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game
{
	public class AdsOptionPopupHolder : AutoPositionPopup
	{
		[Header("Header")]
		[SerializeField]
		private TextMeshProUGUI _uiTextDefaultHeader;

		[SerializeField]
		private TextMeshProUGUI _uiTextHeader;

		[Header("Responesive")]
		[SerializeField]
		private RectTransform _optionContent;

		[Header("Ads Option")]
		[SerializeField]
		private Button _watchAdsButton;

		[SerializeField]
		private Button _spendTicketButton;

		[SerializeField]
		private Button _spendGemButton;

		[SerializeField]
		private Button _spendGemDeactivateButton;

		[Header("Spend Gem")]
		[SerializeField]
		private TextMeshProUGUI _uiTextSpendGem;

		[SerializeField]
		private TextMeshProUGUI _uiTextSpendGemDeactivate;

		[Header("Events")]
		public UnityEvent OnSpendTicketEvent;

		public UnityEvent OnWatchAdsEvent;

		public UnityEvent OnSpendGemEvent;

		public UnityEvent OnRewardedEvent;

		public UnityEvent OnClosedEvent;

		[Header("Placements")]
		public string AdsPlacement;

		public string ResourcePlacement;

		private int _requiredGem;

		public bool HasPauseGame;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void WatchAds()
		{
		}

		private void SpendTicket()
		{
		}

		private void SpendGem()
		{
		}

		private void DoDeactiveSpendGem()
		{
		}

		public void UpdateContentSize()
		{
		}

		public void UpdateOptionDisplayed(AdsOption option)
		{
		}

		public void SetSpendGemAmount(int value)
		{
		}

		public void UpdateHeader(string str)
		{
		}

		public void Close()
		{
		}

		public static void Show(Transform pivot, UnityAction onRewardCallback, UnityAction onSpendTicketCallback = null, UnityAction onClosedCallback = null, string adsPlacement = "", string resourcePlacement = "", AdsOption adsOption = (AdsOption)6, int requiredGem = 0, string title = "", bool hasPauseGame = false, Action<AdsOptionPopupHolder> OnShow = null)
		{
		}
	}
}
