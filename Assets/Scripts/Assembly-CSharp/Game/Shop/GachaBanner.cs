using Shop.Gacha.Views;
using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class GachaBanner : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[SerializeField]
		private TextMeshProUGUI[] _pityTexts;

		[SerializeField]
		private GachaChestCostDrawView _costDraw1;

		[SerializeField]
		private GachaChestCostDrawView _costDraw10;

		[SerializeField]
		private GachaChestCostDrawView _costDrawByKey;

		[SerializeField]
		private GachaChestCostDrawView _costDrawByKey2;

		[SerializeField]
		private GachaPreviewEquipmentsView _previewEquipments;

		private GachaData _gachaData;

		private GachaChestService _gachaChestService;

		private GachaChestCostService _gemCostService1;

		private GachaChestCostService _gemCostService10;

		private GachaChestKeyCostService _keyCostService;

		private GachaChestKeyCostService _keyCostService2;

		private bool _pityDirty;

		public GachaData GetGachaData()
		{
			return null;
		}

		public void UpdateInfo(GachaData gachaData)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGachaPityChanged(int gachaId)
		{
		}

		private void LateUpdate()
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
	}
}
