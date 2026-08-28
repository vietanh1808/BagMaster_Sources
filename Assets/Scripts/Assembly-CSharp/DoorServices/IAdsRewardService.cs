using System;

namespace DoorServices
{
	public interface IAdsRewardService
	{
		bool HasAds();

		void Load();

		void ShowAds(Action onRewarded, Action<bool> onClosed = null);
	}
}
