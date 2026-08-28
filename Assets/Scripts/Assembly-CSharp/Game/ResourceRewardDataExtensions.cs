using System;
using System.Collections.Generic;

namespace Game
{
	public static class ResourceRewardDataExtensions
	{
		public static void Reward(this IEnumerable<ResourceRewardData> rewards, string source, bool excludeCombatCurrencies = true, bool isIap = false, string context = "")
		{
		}

		[Obsolete]
		public static void Reward(this IEnumerable<ResourceRewardData> rewards, int excludeId)
		{
		}

		public static List<ResourceRewardData> ApplyMultiplier(this IEnumerable<ResourceRewardData> rewards, float multiplier = 1f)
		{
			return null;
		}

		public static RewardPack Merge(this IEnumerable<RewardPack> packs)
		{
			return null;
		}

		public static RewardPack ToRewardPack(this string rawData, int packId = 0)
		{
			return null;
		}

		public static int SortByRarity(ResourceRewardData x, ResourceRewardData y)
		{
			return 0;
		}

		public static void StackSameId(this List<ResourceRewardData> rewards)
		{
		}
	}
}
