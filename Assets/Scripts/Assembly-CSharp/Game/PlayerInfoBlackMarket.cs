using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerInfoBlackMarket
	{
		public bool Unlocked;

		public long TriggerRefreshTimeBlackMarket;

		public List<LogPurchaseShopPackData> PackLogs;

		public int RefreshCount;

		public long RefreshCountResetUnix;
	}
}
