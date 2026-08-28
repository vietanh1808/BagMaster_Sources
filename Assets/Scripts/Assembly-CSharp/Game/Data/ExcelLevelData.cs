using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelLevelData : IVariantConfig
	{
		public int ID;

		public int Wave_ID;

		public int Spawn_Group_ID;

		public string InitialGearsPool;

		public string InitialBuffPool;

		public float AdsRewardChance;

		public string RewardIds;

		public string DropBundleIds;

		public int[] CUR;

		public string Shop_ID;

		public int Chest_ID;

		public int[] Chest;

		public int MinSlotNumber;

		public bool Boss_Wave;

		public float RecycleValue;

		public int RecycleFreeRerollRewardNumber;

		public float RecommendCp;

		public int Milestone_reward;

		public bool IsFog;

		public string Enviroment_Skill_ID;

		public string Environment_Skill_Icon;

		public string Environment_Skill_Description;

		public string Hp_Reward_Milestone;

		public string Random_GoldDrop;

		public int Bench_Free_Times;

		public int Bench_Ad_Times;

		public int Recycle_Free_Times;

		public int Recycle_Ad_Times;

		public string InitGearsLayout;

		public float DelayOpenTraitShop;

		public string ActiveSkillPowerMod;

		public float GearWeightMod;

		public int ExpMilestoneBuffPoolID;

		public int Variant;

		int IVariantConfig.Variant => 0;
	}
}
