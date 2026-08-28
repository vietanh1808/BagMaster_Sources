using System;

namespace Game
{
	[Serializable]
	public class PlayerDataShopPack
	{
		public int Id;

		public int TotalClaimCount;

		public int ClaimCount;

		public long ClaimLatestTime;
	}
}
