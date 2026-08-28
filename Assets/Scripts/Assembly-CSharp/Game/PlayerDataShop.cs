using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerDataShop
	{
		public List<PlayerDataShopPack> ShopPackHistory;

		public List<PlayerDataGacha> GachaHistory;
	}
}
