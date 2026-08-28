using Game.Combat;

namespace Game
{
	public static class CampaignExtensions
	{
		public static bool IsUnlocked(this Campaign campaign)
		{
			return false;
		}

		public static bool IsUnlockCampaignCompleted(this Campaign campaign)
		{
			return false;
		}

		public static bool IsMilestoneRewardClaimed(this LevelData levelData)
		{
			return false;
		}

		public static bool HasUnclaimedMilestoneReward(this Campaign campaign)
		{
			return false;
		}

		public static int GetWaveReached(this Campaign campaign)
		{
			return 0;
		}

		public static bool CanExpBeGained(this Campaign campaign)
		{
			return false;
		}
	}
}
