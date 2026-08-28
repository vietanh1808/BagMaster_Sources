using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PendingRewardEntry
	{
		public string Id;

		public List<ResourceRewardDataRef> Items;

		public string Placement;

		public string Context;

		public bool IsIap;
	}
}
