using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class EnergyPurchasePopup : MonoBehaviour
	{
		[Header("Tab Left")]
		[SerializeField]
		private RewardPackUI _rewardPackUI1;

		[SerializeField]
		private TextMeshProUGUI _watchAdsChanceCountText;

		[SerializeField]
		private TextMeshProUGUI _watchAdsRewardCountText;

		[SerializeField]
		private string _watchAdsRewardCountFormat;

		[SerializeField]
		private Button _watchAdsButton;

		[SerializeField]
		private Button _notAvailableAdsButton;

		[SerializeField]
		private LocalizationParamsManager __watchAdsChanceCountFormatParam;

		[Header("Tab Right")]
		[SerializeField]
		private RewardPackUI _rewardPackUI2;

		[SerializeField]
		private CurrencyView[] _tabRightCostViews;

		[SerializeField]
		private TextMeshProUGUI _purchaseChanceCountText;

		[SerializeField]
		private TextMeshProUGUI _purchaseRewardCountText;

		[SerializeField]
		private string _purchaseRewardCountFormat;

		[SerializeField]
		private Button _purchaseButton;

		[SerializeField]
		private Button _notAvailablepurchaseButton;

		[SerializeField]
		private LocalizationParamsManager __purchaseChanceCountFormatParam;

		private string _notEnoughResourceStr;

		private string _limitPurchaseStr;

		private string _limitAdsStr;

		private PlayerInfo PInfo => null;

		public ResourceRequireData PurchaseCost => null;

		public RewardPack PurchaseReward => null;

		public RewardPack AdsReward => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdatePurchaseCost()
		{
		}

		public void WatchAdsReward()
		{
		}

		public void Purchase()
		{
		}
	}
}
