using System.Collections.Generic;

namespace Game.GearUpgrade
{
	public class GearMasteryData
	{
		public class LevelData
		{
			public int Level;

			public int MasteryRequire;

			public List<int> UnlockBuffIds;

			public RewardPack Reward;
		}

		public int Id;

		public List<LevelData> LevelDatas;

		public bool IsClaimable(float masteryPoint, int levelClaimed)
		{
			return false;
		}

		public List<LevelData> GetClaimables(float masterPoint, int levelClaimed)
		{
			return null;
		}
	}
}
