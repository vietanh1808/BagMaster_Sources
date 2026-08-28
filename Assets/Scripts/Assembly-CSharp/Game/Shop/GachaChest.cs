using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class GachaChest : MonoBehaviour
	{
		[SerializeField]
		private int _chestId;

		[Header("UI Elements")]
		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[SerializeField]
		private TextMeshProUGUI[] _pityTexts;

		[Header("Draw Views")]
		[SerializeField]
		private GachaChestFreeDrawView _freeDrawView;

		[SerializeField]
		private GachaChestAdsDrawView _adsDrawView;

		[SerializeField]
		private GachaChestCostDrawView _keyCostDrawView;

		[SerializeField]
		private GachaChestCostDrawView _gemCostDrawView;

		[SerializeField]
		private GachaChestCostDrawView _gemCost10DrawView;

		[Header("Runtime")]
		[SerializeField]
		private bool _hasFreePurchase;

		[SerializeField]
		private bool _hasAdsPurchase;

		private GachaData _gachaData;

		private GachaChestService _gachaChestService;

		private GachaChestFreeService _freeService;

		private GachaChestAdsService _adsService;

		private GachaChestKeyCostService _keyCostService;

		private GachaChestCostService _gemCostService;

		private GachaChestCostService _gemCostX10Service;

		public const int MaxKeyCost = 10;

		public GachaData GetGachaData()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnGachaPerformed(RewardPack rewardPack)
		{
		}

		private void PushGachaRewardPopup(RewardPack rewardPack)
		{
		}

		private void UpdatePityText()
		{
		}

		private void UpdateState()
		{
		}

		private void SetState(bool isFree, bool isAds, bool hasKey)
		{
		}
	}
}
