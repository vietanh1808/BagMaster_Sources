using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class QuickAFKRewardPanel : MonoBehaviour
	{
		[Header("General")]
		[SerializeField]
		private List<ResourceView> _rewardViews;

		[Header("Ads Reward")]
		[SerializeField]
		private TextMeshProUGUI _watchAdsChanceCountText;

		[SerializeField]
		private Button _watchAdsButton;

		[SerializeField]
		private Button _adsNotAvailableButton;

		[SerializeField]
		private GameObject _hasAdsChanceCTANotification;

		[Header("Purchase Reward")]
		[SerializeField]
		private CurrencyView[] _purchaseCostViews;

		[SerializeField]
		private TextMeshProUGUI _purchaseChanceCountText;

		[SerializeField]
		private Button _purchaseButton;

		[SerializeField]
		private Button _purchaseNotAvailableButton;

		[SerializeField]
		private GameObject _energyPurchasePopup;

		[SerializeField]
		private GameObject _hasEnergyChanceCTANotification;

		private PlayerInfo PInfo => null;

		private int RemainingWatchAdsCount => 0;

		private int RemainingPurchaseCount => 0;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnRemainWatchAdsCountChanged(int remainingCount)
		{
		}

		private void OnRemainPurchaseCountChanged(int remainingCount)
		{
		}

		private void PurchaseReward()
		{
		}

		private void WatchAdsReward()
		{
		}

		private void UpdateRewardList()
		{
		}
	}
}
