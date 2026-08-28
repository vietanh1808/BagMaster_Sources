using System;
using Newtonsoft.Json;

namespace Game.Shop
{
	[Serializable]
	public class ShopRefreshTime
	{
		[JsonIgnore]
		public bool ShouldRefresh;

		[JsonIgnore]
		private IDisposable _upateDisposable;

		public RefreshType RefreshType { get; private set; }

		public DateTime LastRefreshTime { get; private set; }

		public ShopRefreshTime(RefreshType refreshType)
		{
		}

		~ShopRefreshTime()
		{
		}

		private void CheckAndRefresh()
		{
		}

		public void SaveLastRefreshTime()
		{
		}

		public TimeSpan GetRemainTimeUntilNextRefresh()
		{
			return default;
		}
	}
}
