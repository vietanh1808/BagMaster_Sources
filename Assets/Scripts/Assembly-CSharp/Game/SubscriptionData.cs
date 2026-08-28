using System;

namespace Game
{
	[Serializable]
	public class SubscriptionData
	{
		public int Id;

		public long LatestSubscriptionTime;

		public long LatestDailyClaimTime;

		public double DurationInMinutes;
	}
}
