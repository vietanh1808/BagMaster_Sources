using UnityEngine;

namespace Game.Shop
{
	public class ValuePackShopItem : TimePackShopItem
	{
		[Header("Top Up Specific")]
		[SerializeField]
		private FlyToBarProfile _flyToBarFromTopUpItem;

		public override void Initialize(ShopPackData package)
		{
		}

		protected override void Claim(ShopPackData shopPackData, bool isIap)
		{
		}

		private void HandleTopUpRewards(ShopPackData shopPackData)
		{
		}

		protected override void UpdateLimit()
		{
		}

		public override void SetLimit(int value, int count)
		{
		}
	}
}
