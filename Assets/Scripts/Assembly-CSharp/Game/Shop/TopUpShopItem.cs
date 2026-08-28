using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Game.Shop
{
	[Obsolete("Unupdated, Use ValuePackShopItem")]
	public class TopUpShopItem : MonoBehaviour, IShopItem
	{
		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TextMeshProUGUI _valueText;

		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _priceText;

		[SerializeField]
		private Button _itemButton;

		[SerializeField]
		private CodelessIAPButton _codelessIAP;

		[SerializeField]
		private CurrencyView _tradePriceView;

		private ShopPackData _package;

		private PlayerInfo PInfo => null;

		public bool ReachedLimit => false;

		public UnityEvent OnClaimedEvent => null;

		public ShopPackData PackageData => null;

		public void Initialize(ShopPackData package)
		{
		}

		private void TradeReward()
		{
		}

		public void OnPurchasePending(Order order)
		{
		}

		public void OnPurchasesFetched(Order order)
		{
		}

		private void ProcessPurchase(Order order)
		{
		}

		public void OnPurchaseSuccessed(ConfirmedOrder confirmedOrder)
		{
		}

		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
		}

		public void OnPurchaseSuccess(Product product)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureDescription error)
		{
		}

		public void OnProductFetched(Product product)
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		private void Log(string msg)
		{
		}
	}
}
