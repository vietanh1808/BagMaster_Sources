using System;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class BlackMarketPackShopItem : ValuePackShopItem
	{
		[SerializeField]
		private MMF_Player openFeedback;

		[SerializeField]
		private GameObject maskLimitObject;

		[Header("Special Deal")]
		[SerializeField]
		private GameObject _specialDealObject;

		[SerializeField]
		private CurrencyView _originalPriceView;

		[SerializeField]
		private TextMeshProUGUI _specialDealOfferText;

		[Header("Most Deal")]
		[SerializeField]
		private Image _discountTagImage;

		[SerializeField]
		private GameObject _mostDealFx;

		[SerializeField]
		private BlackMarketCardFlip _cardFlip;

		public new Action<ShopPackData> OnPurchaseSuccess;

		private int limit;

		public void PlayOpenFeedback()
		{
		}

		public override void SetLimit(int value, int count)
		{
		}

		public void SetOriginalCurrency(int originalPrice)
		{
		}

		public override void Initialize(ShopPackData package)
		{
		}

		public void SetDiscountVisual(string spriteName)
		{
		}

		public void HideMostDealVFX()
		{
		}

		private bool IsSoldByGold()
		{
			return false;
		}

		public void SetMostDeal(bool isMostDeal)
		{
		}

		public void SetCardFaceDown()
		{
		}

		public void PlayCardFlip(float delay)
		{
		}

		public void ResetCardFlip()
		{
		}

		protected override bool IsConsumeTradeRewardImmediately()
		{
			return false;
		}

		protected override void Claim(ShopPackData shopPackData, bool isIap)
		{
		}

		private void PurchaseItem(ShopPackData shopPackData, ResourceRewardData cost)
		{
		}

		protected override void UpdateLimit()
		{
		}

		private int GetOwnedCount()
		{
			return 0;
		}
	}
}
