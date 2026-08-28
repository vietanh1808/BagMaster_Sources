using System;
using System.Collections.Generic;
using DoorServices;
using Game;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassPurchasePanel : MonoBehaviour, IIapOfferView
	{
		public static int ORDER_LAYER;

		[SerializeField]
		private ResourceView resourceViewPrefab;

		[SerializeField]
		private GridLayoutGroup gridLayout;

		[SerializeField]
		private MMF_Player player;

		[SerializeField]
		private Button close;

		[SerializeField]
		private Button close2;

		[Header("IAP")]
		[SerializeField]
		private TextMeshProUGUI textPremiumPrice;

		[SerializeField]
		private TextMeshProUGUI textLuxuryPrice;

		[SerializeField]
		private Button buyPremiumButton;

		[SerializeField]
		private Button buyLuxuryButton;

		[SerializeField]
		[Obsolete("Use default IAP loading screen")]
		private GameObject block;

		private List<ResourceRewardData> list;

		private List<ResourceView> views;

		private Action onHide;

		private Action onPurchase;

		private bool isLuxuryPack;

		private bool canHide;

		private string _productId;

		public string IapProductId => null;

		public StoreEntryMethod StoreEntryMethod => StoreEntryMethod.Others;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void Show(int[] rewardsId, Action purchaseCallback, Action hideCallback)
		{
		}

		private void OnDisable()
		{
		}

		private void CanHide()
		{
		}

		public void Hide()
		{
		}

		public void SetProductId(string id, bool isLuxuryPack)
		{
		}

		private void MakePurchase()
		{
		}

		private void OnPurchaseSuccess(Order confirmedOrder)
		{
		}

		private void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		private void Log(string msg)
		{
		}
	}
}
