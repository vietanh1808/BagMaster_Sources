using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Game.Shop
{
	public class GachaChestService
	{
		[CompilerGenerated]
		private Action<RewardPack> m_OnGachaPerformedEvent;

		private readonly PlayerInfo _playerInfo;

		private readonly GachaChestPityService[] _gachaChestPityServices;

		private readonly GachaData _gachaData;

		public string Placement => null;

		public event Action<RewardPack> OnGachaPerformedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public GachaChestService(PlayerInfo playerInfo, GachaData gachaData)
		{
		}

		public int GetRemainPityAttempt(int pityIndex)
		{
			return 0;
		}

		public RewardPack Gacha(int drawCount)
		{
			return null;
		}

		private static bool ShouldSaveToCloud(IEnumerable<ResourceRewardData> rewards)
		{
			return false;
		}

		private ItemData GetReward()
		{
			return null;
		}

		private bool TryPityGacha(out ItemData reward)
		{
			reward = null;
			return false;
		}

		private List<ItemData> BuildRandomBranchPool()
		{
			return null;
		}

		private bool TryFixGacha(out ItemData reward)
		{
			reward = null;
			return false;
		}
	}
}
