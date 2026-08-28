using System.Collections.Generic;
using Game.Data;

namespace Game.RewardBundle
{
	public class RewardBundleData : ResourceEntityHasVisual
	{
		public RewardBundleClaimLogic ClaimLogic;

		public List<RewardBundleSubPack> SubPacks;

		public RewardBundleData(int id)
			: base(0)
		{
		}
	}
}
