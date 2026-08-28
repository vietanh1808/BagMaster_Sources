using UnityEngine;

namespace DoorServices
{
	public class SimpleSaver : Singleton<SimpleSaver>
	{
		[field: SerializeField]
		public int WatchInterCount { get; set; }

		[field: SerializeField]
		public int WatchRewardCount { get; set; }
	}
}
