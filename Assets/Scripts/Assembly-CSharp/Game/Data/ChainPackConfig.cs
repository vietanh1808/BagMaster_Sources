using System;

namespace Game.Data
{
	[Serializable]
	public struct ChainPackConfig
	{
		public RewardPack RewardPack;

		public int Order;

		public bool Is_Iap;

		public int Shop_ID;
	}
}
