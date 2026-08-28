using System;

namespace Game
{
	[Serializable]
	public struct QuickAidConfig
	{
		public bool IsAdsAllow;

		public int ShopPackId;

		public SerializableResourceData RequiredResource;

		public QuickAidConfig(bool isAdsAllow, in SerializableResourceData requireResource, int shopPackId)
		{
			IsAdsAllow = false;
			ShopPackId = 0;
			RequiredResource = default;
		}
	}
}
