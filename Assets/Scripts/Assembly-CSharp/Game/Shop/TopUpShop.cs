using UnityEngine;

namespace Game.Shop
{
	public class TopUpShop : ShopByCategory
	{
		[SerializeField]
		private GameObject _internetConnectionErrorPanel;

		protected override void Start()
		{
		}

		protected override void GenerateShopItems()
		{
		}

		private void CheckInternetConnection(bool isConnected)
		{
		}

		private void OnAnItemClaimed()
		{
		}
	}
}
