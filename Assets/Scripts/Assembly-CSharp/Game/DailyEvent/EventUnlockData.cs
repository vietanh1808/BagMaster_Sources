using UnityEngine;

namespace Game.DailyEvent
{
	public class EventUnlockData
	{
		public int Id;

		public string EventName;

		public EventType Type;

		public int UnlockChapterId;

		public string UnlockDescription;

		public Sprite Banner;

		public string RewardDescription;

		public Sprite RewardIcon;

		public int ProgressId;

		private OwnedResourceEntity _progress;

		public OwnedResourceEntity Progress => null;
	}
}
