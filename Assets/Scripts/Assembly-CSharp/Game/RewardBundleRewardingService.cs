using System.Collections.Generic;
using Game.RewardBundle;

namespace Game
{
	public class RewardBundleRewardingService
	{
		public bool TryClaim(ItemDefine item, ReceiveRewardsCallBack callBack)
		{
			return false;
		}

		private void Reward(RewardBundleData bundleData, int amount, bool isUp, ReceiveRewardsCallBack callBack)
		{
		}

		private void RewardPlayerChoice(RewardBundleData bundleData, int amount, ReceiveRewardsCallBack callBack)
		{
		}

		private void RewardRandomUnique(RewardBundleData bundle, int amount, bool isUp, ReceiveRewardsCallBack callBack)
		{
		}

		private void RewardRandom(RewardBundleData bundleData, int amount, bool isUp, ReceiveRewardsCallBack callBack)
		{
		}

		private void OnRewarded(List<RewardBundleSubPack> rewardBundles, bool isUp, ReceiveRewardsCallBack callBack)
		{
		}
	}
}
