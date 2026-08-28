using Game.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace Game.SevenDayQuest
{
	public class SevenDayBundleUIItem : TimePackShopItem, IBundleItem
	{
		[SerializeField]
		private Transform _panel;

		[SerializeField]
		private GameObject _claimMark;

		[SerializeField]
		private GameObject _expiredMark;

		public Transform Panel => null;

		public SevenDayBundleData Data { get; private set; }

		UnityEvent IBundleItem.OnClaimedEvent => null;

		public override void Initialize(ShopPackData package)
		{
		}

		public bool IsPurchaseable()
		{
			return false;
		}

		public void UpdateInfo(SevenDayBundleData data, bool expired)
		{
		}

		protected override void RefreshAfterClaim()
		{
		}
	}
}
