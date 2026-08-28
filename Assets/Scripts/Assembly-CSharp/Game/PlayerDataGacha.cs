using System;
using System.Collections.Generic;
using Game.Shop;

namespace Game
{
	[Serializable]
	public class PlayerDataGacha
	{
		public int Id;

		public int DrawCount;

		public int AdsDrawCount;

		public ShopRefreshTime AdsDrawRefreshTime;

		public long FreeDrawLatestTime;

		public List<int> PityCounts;
	}
}
