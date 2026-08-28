namespace Game.RewardBundle
{
	public class RewardBundleSubPack : IHasWeight<RewardBundleSubPack>
	{
		public readonly RewardPack Pack;

		public float Weight { get; }

		public RewardBundleSubPack Value => null;

		public RewardBundleSubPack(RewardPack rewardPack, float weight)
		{
		}
	}
}
