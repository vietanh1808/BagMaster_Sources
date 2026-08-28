using System.Collections.Generic;
using DoorServices;
using Game.GUI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Game.Shop
{
	public class TimePackShopItem : UiBehaviour, IShopItem, IIapOfferView
	{
		[SerializeField]
		protected Image _packImage;

		[SerializeField]
		protected TextMeshProUGUI _nameText;

		[SerializeField]
		protected TextMeshProUGUI _descriptionText;

		[SerializeField]
		private bool _showPurchaseCountInNameText;

		[SerializeField]
		private TextMeshProUGUI _fakeBonusValueText;

		[SerializeField]
		protected List<GameObject> _rewardItems;

		[SerializeField]
		private bool _disableWhenReachMax;

		[Header("Limit")]
		[SerializeField]
		protected TextMeshProUGUI _limitText;

		[SerializeField]
		protected string _limitTextFormat;

		[Header("Non-IAP")]
		[SerializeField]
		private bool shouldOpenConfirmPopup;

		[SerializeField]
		private Button _tradeButton;

		[SerializeField]
		protected CurrencyView _tradePriceView;

		[SerializeField]
		private Button _freeButton;

		[SerializeField]
		private Button _nonInteractionButton;

		[Header("IAP")]
		[SerializeField]
		protected Button _purchaseButton;

		[SerializeField]
		protected TextMeshProUGUI _priceText;

		[SerializeField]
		[Tooltip("Use When has discount")]
		protected TextMeshProUGUI _originalPriceText;

		[Header("Events")]
		public UnityEvent OnClaimedEvent;

		public ResourcesState ResourcesState;

		public ShopPackData PackageData { get; private set; }

		public bool ReachedLimit => false;

		public virtual bool ButtonInteractable => false;

		UnityEvent IShopItem.OnClaimedEvent => null;

		private PlayerInfo PInfo => null;

		public string IapProductId => null;

		public StoreEntryMethod StoreEntryMethod { get; set; }

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
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

		private void Log(string msg)
		{
		}

		public void OnPurchaseSuccess(Product product)
		{
		}

		public void OnProductFetched(Product product)
		{
		}

		protected virtual void UpdateImage()
		{
		}

		protected virtual void UpdateNameText()
		{
		}

		protected virtual void UpdateDescriptionText()
		{
		}

		protected virtual void UpdateLimit()
		{
		}

		public virtual void SetLimit(int value, int count)
		{
		}

		private void UpdatePurchaseButtonInteractable()
		{
		}

		protected virtual void UpdateFakePrice()
		{
		}

		protected virtual string UpdateIapPrice()
		{
			return null;
		}

		public void Refresh()
		{
		}

		public bool RandomInGroup()
		{
			return false;
		}

		public virtual void Initialize(ShopPackData package)
		{
		}

		protected override void OnUiFirstTimeVisible()
		{
		}

		protected virtual void UpdateRewards()
		{
		}

		protected virtual void UpdateButtons()
		{
		}

		protected virtual void UpdateIapButton()
		{
		}

		protected virtual TextMeshProUGUI GetOriginalPriceText()
		{
			return null;
		}

		private void FreeReward()
		{
		}

		private void TradeReward()
		{
		}

		protected virtual bool IsConsumeTradeRewardImmediately()
		{
			return false;
		}

		protected void MakePurchase()
		{
		}

		protected virtual void Claim(ShopPackData shopPackData, bool isIap)
		{
		}

		protected virtual void RefreshAfterClaim()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void SetNonInteractableAllButtons()
		{
		}

		public void SetOriginalPrice(string price)
		{
		}

		protected void TryTrackingIapImpression(ShopPackData newShopPackData)
		{
		}
	}
}
