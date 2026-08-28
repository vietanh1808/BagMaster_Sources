using System.Collections.Generic;
using Game.Data;

namespace Game.Combat
{
	public class Campaign
	{
		public int Id;

		public int Index;

		public string IconPath;

		public string Name;

		public int LevelId;

		public int RewardId;

		public int ReducedRewardId;

		public float AdsRewardMultiplier;

		public string BackgroundPath;

		public List<ResourceRequireData> PlayResourceCost;

		public LevelType Level_Type;

		public int AdGearRerollUnlock;

		public int AdSlotAddUnlock;

		public int AdGearRerollLimit;

		public int AdSlotAddLimit;

		public string MonsterPreviewIds;

		public int ContinueFromDefeatLimit;

		public int ExpMilestoneGroupId;

		public CampaignDifficultyMode DifficultyMode;

		public int UnlockCampaignId;

		private LevelData[] _levelDatas;

		public string LocalizedName => null;

		public int LevelCount => 0;

		public LevelData[] LevelDatas => null;

		public void UpdateLevelDatas()
		{
		}
	}
}
