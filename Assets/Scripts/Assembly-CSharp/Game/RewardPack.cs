using System;
using System.Collections.Generic;

namespace Game
{
	public class RewardPack
	{
		public readonly int Id;

		public readonly List<ResourceRewardData> Rewards;

		public float Chances;

		public int ReceivedNumber;

		public RewardPack(int id, List<ResourceRewardData> rewards)
		{
		}

		public RewardPack(int id, int[] rawData)
		{
		}

		public RewardPack Clone(float multiplier = 1f)
		{
			return null;
		}

		public RewardPack ApplyMultiplier(float multiplier = 1f)
		{
			return null;
		}

		[Obsolete]
		public List<ResourceRewardData> Reward()
		{
			return null;
		}

		public List<ResourceRewardData> Reward(string source, bool isIap = false)
		{
			return null;
		}

		public void Reward(string source, Action<List<ResourceRewardData>> onClaim, bool isIap = false)
		{
		}

		public List<ResourceRewardData> GetReward()
		{
			return null;
		}

		public RewardPack StackSameId()
		{
			return null;
		}
	}
}
