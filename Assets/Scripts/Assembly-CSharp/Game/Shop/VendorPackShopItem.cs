using System;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Shop
{
	public class VendorPackShopItem : ValuePackShopItem
	{
		[SerializeField]
		private MMF_Player openFeedback;

		[SerializeField]
		private GameObject maskLimitObject;

		public new Action<(ShopPackData pack, int quantity)> OnPurchaseSuccess;

		private int limit;

		public void PlayOpenFeedback()
		{
		}

		public override void SetLimit(int value, int count)
		{
		}

		protected override void UpdateLimit()
		{
		}

		public override void Initialize(ShopPackData package)
		{
		}

		protected override bool IsConsumeTradeRewardImmediately()
		{
			return false;
		}

		protected override void Claim(ShopPackData shopPackData, bool isIap)
		{
		}
	}
}
