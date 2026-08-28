using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Game.Shop
{
	public class TimePackShop : ShopByCategory
	{
		[SerializeField]
		private TextMeshProUGUI _refreshTimeTextDaily;

		[SerializeField]
		private TextMeshProUGUI _refreshTimeTextWeekly;

		[SerializeField]
		private TextMeshProUGUI _refreshTimeTextMonthly;

		private Dictionary<RefreshType, List<TimePackShopItem>> _refreshTypeShopItems;

		private PlayerInfo PInfo => null;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void Refresh(RefreshType refreshType, ShopRefreshTime refreshTime)
		{
		}

		protected override void GenerateShopItems()
		{
		}
	}
}
