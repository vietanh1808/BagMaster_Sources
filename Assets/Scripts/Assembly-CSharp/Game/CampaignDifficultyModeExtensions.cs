using Game.Combat;
using TMPro;

namespace Game
{
	public static class CampaignDifficultyModeExtensions
	{
		public static int GetUnlockedProgress(this CampaignDifficultyMode mode)
		{
			return 0;
		}

		public static bool IsNewestCampaignPlayed(this CampaignDifficultyMode mode)
		{
			return false;
		}

		public static int GetProgress(this CampaignDifficultyMode mode)
		{
			return 0;
		}

		public static OwnedResourceEntity GetProgressEntity(this CampaignDifficultyMode mode)
		{
			return null;
		}

		public static bool IsUnlocked(this CampaignDifficultyMode campaignMode)
		{
			return false;
		}

		private static bool IsUnlockCampaignCompleted(this CampaignDifficultyMode campaignMode)
		{
			return false;
		}

		public static Campaign GetUnlockCampaign(this CampaignDifficultyMode campaignMode)
		{
			return null;
		}

		private static Campaign GetFirstCampaignUnlocker(this CampaignDifficultyMode campaignMode)
		{
			return null;
		}

		public static int GetUnlockCampaignId(this CampaignDifficultyMode campaignMode)
		{
			return 0;
		}

		public static string GetLocalizedName(this CampaignDifficultyMode mode)
		{
			return null;
		}

		public static VertexGradient GetChapterTextGradient(this in CampaignDifficultyModeSetting setting)
		{
			return default;
		}

		public static bool HasUnclaimedMilestoneReward(this CampaignDifficultyMode mode)
		{
			return false;
		}

		public static bool TryGetUnclaimedRewardInfo(this CampaignDifficultyMode mode, out LevelData level, out Campaign campaign)
		{
			level = null;
			campaign = null;
			return false;
		}

		public static int GetUnclaimedRewardIndex(this CampaignDifficultyMode mode)
		{
			return 0;
		}
	}
}
