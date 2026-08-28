using System.Collections.Generic;
using Game.Combat;

namespace Game.Data
{
	public static class CampaignDatabaseExtensions
	{
		public static bool TryGetCampaign(this Dictionary<CampaignDifficultyMode, Dictionary<int, Campaign>> campaignMaps, int campaignId, out Campaign campaign)
		{
			campaign = null;
			return false;
		}

		public static bool TryGetUnlockCampaign(this Campaign campaign, out Campaign unlockCampaign)
		{
			unlockCampaign = null;
			return false;
		}

		public static bool TryGetCampaign(this LevelData levelData, out Campaign campaign)
		{
			campaign = null;
			return false;
		}

		private static Campaign FindCampaignByLevelId(LevelData levelData)
		{
			return null;
		}

		public static bool TryGetCampaign(this LevelData levelData, CampaignDifficultyMode mode, out Campaign result)
		{
			result = null;
			return false;
		}

		public static bool IsFinalCampaign(this Campaign campaign)
		{
			return false;
		}
	}
}
