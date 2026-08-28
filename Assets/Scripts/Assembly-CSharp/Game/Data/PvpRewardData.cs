using System;

namespace Game.Data
{
	[Serializable]
	public struct PvpRewardData
	{
		public int RankID;

		public string RewardType;

		public int StartPlayer;

		public int EndPlayer;

		public int MailRewardID;

		public int[] Reward;

		public ResourceRewardData[] Rewards;

		public int Equal()
		{
			return 0;
		}

		public bool IsInRange(int index)
		{
			return false;
		}
	}
}
