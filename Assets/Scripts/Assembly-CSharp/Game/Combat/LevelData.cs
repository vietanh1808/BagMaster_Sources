using System.Collections.Generic;

namespace Game.Combat
{
	public class LevelData
	{
		public int Id;

		public int WaveId;

		public int SpawnId;

		public List<int> InitialGearsPool;

		public List<int> InitialBuffPool;

		public RewardPack[] RewardPacks;

		public RewardPack Rewards;

		public RewardPack DropBundleRewards;

		public List<CombatChestData> ShopData;

		public ChestData ChestData;

		public RewardPack ChestRewards;

		public int MinSlotNumber;

		public float AdsRewardChance;

		public string ShopID;

		public bool BossWave;

		public RewardPack MilestoneRewards;

		public float RecommendCp;

		public bool HasFog;

		public int[] EnvironmentSkillIds;

		public string[] EnvironmentSkillIconNames;

		public string[] EnvironmentSkillDescriptions;

		public float[] HpRewardMilestone;

		public int[] RandomGoldDrop;

		public int RecycleFreeChargePerWave;

		public int RecycleChargeByAds;

		public int BenchFreeChargePerWave;

		public int BenchChargeByAds;

		public List<LevelStartGear> StartGears;

		public float DelayOpenTraitShop;

		public float ActiveSkillPowerMod;

		public float GearWeightMod;

		public int MaxCountMod;

		public int ExpMilestoneBuffPoolId;

		public bool HasMilestoneReward()
		{
			return false;
		}

		public int GetMilestoneRewardId()
		{
			return 0;
		}
	}
}
