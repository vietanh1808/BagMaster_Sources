using System.Collections.Generic;
using DG.Tweening;
using DoorServices;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Game
{
	public class NoAdsOfferPopup : MonoBehaviour, IIapOfferView
	{
		[SerializeField]
		private TextMeshProUGUI _priceText;

		[SerializeField]
		private ResourceView _rewardItemTemplate;

		[SerializeField]
		private Button _purchaseButton;

		[SerializeField]
		private string _productId;

		[SerializeField]
		private GameObject _block;

		[Header("Discount")]
		[SerializeField]
		private TextMeshProUGUI _discountPriceText;

		[SerializeField]
		private GameObject _discount1;

		[SerializeField]
		private GameObject _discount2;

		[SerializeField]
		private GameObject _discountDuration1;

		[SerializeField]
		private GameObject _discountDuration2;

		[Header("Returning animation")]
		[SerializeField]
		private MMF_Player _returnFeedback;

		[SerializeField]
		private Transform _adsIcon;

		[SerializeField]
		private float _returnDuration;

		[SerializeField]
		private Ease _returnEase;

		[SerializeField]
		private GameObject _endReturnVfx;

		[Header("Runtime")]
		[SerializeField]
		private int _offerType;

		public string IapProductId => null;

		public StoreEntryMethod StoreEntryMethod { get; private set; }

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ShowRewards(List<ResourceRewardData> rewardDatas)
		{
		}

		private void UpdateDiscountUi()
		{
		}

		private void UpdatePriceUi()
		{
		}

		private void ShowDiscountDuration(int type)
		{
		}

		public void SetIapInfo(string iapProductId, StoreEntryMethod storeEntryMethod = StoreEntryMethod.AutoOpen)
		{
		}

		public void OnPurchaseButtonClicked()
		{
		}

		private void OnPurchaseSuccess(Order confirmedOrder)
		{
		}

		private void Log(string msg)
		{
		}

		public void Close()
		{
		}

		public void ReturnNClose()
		{
		}
	}
}
