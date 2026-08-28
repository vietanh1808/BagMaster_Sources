using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerDataDailyGift
	{
		public long CycleStartTime;

		public List<DailyGiftProgress> GiftIds;
	}
}
