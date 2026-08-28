using System;

namespace DoorServices
{
	public interface IAdsManager
	{
		void ShowInterstitialAds(Action<bool> onClosed);

		bool HasRewardAds();

		void ShowRewardAds(Action onRewarded, Action<bool> onClosed);
	}
}
