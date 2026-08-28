using System;
using System.Collections.Generic;

namespace Game.Combat
{
	[Serializable]
	public class CombatSaveData
	{
		[Serializable]
		public class GearData
		{
			public int Id;

			public int Location;

			public IntArray[] Positions;

			public float LogValue;
		}

		[Serializable]
		public class PlayerSkillData
		{
			public int SkillId;

			public float RemainCooldown;

			public int CooldownCounter;

			public int CooldownAdsCounter;

			public int WaveActivateCounter;

			public int WholeMapActivateCounter;
		}

		[Serializable]
		public class BuffData
		{
			public int Wave;

			public int Id;
		}

		public int CampaignId;

		public int WaveReached;

		public int ReceivedRewardWaveReached;

		public int Gold;

		public float PlayerHp;

		public int RevivedCount;

		public int Exp;

		public List<PlayerSkillData> PlayerSkillDatas;

		public List<GearData> GearDatas;

		public int[] NewGearThisWave;

		public string BagLayoutName;

		public IntArray[] BagSlotUnlockeds;

		public int LastBuffSelectedWave;

		public List<BuffData> SelectedBuffIds;

		public int BuffRerollCount;

		public int BuffTakeAllCount;

		public int BuffTakeAllByAdsCount;

		public int RerollCount;

		public int FreeRerollCount;

		public int RerollPriceIndex;

		public int LastFirstSpawnGearWave;

		public int AdsGearRerollUsedCount;

		public int AdsSlotBuyUsedCount;

		public int RecycleLevel;

		public float RecycleValue;

		public int RecycleFreererollRemainCharges;

		public int BenchCharges;

		public List<ResourceRewardDataRef> Rewarded;

		public List<ResourceRewardDataRef> WaveRewards;
	}
}
