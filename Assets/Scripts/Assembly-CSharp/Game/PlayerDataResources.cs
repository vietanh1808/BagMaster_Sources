using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerDataResources
	{
		public List<OwnedResourceEntity> OwnedResources;

		public List<PlayerDataCurrencyRefill> RefillDatas;
	}
}
