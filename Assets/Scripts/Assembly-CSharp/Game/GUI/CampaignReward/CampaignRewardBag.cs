using I2.Loc;
using Spine.Unity;
using UnityEngine;

namespace Game.GUI.CampaignReward
{
	public class CampaignRewardBag : UiBehaviour
	{
		public enum BagType
		{
			Past = 0,
			Present = 1,
			Future = 2
		}

		private static readonly int StartParam;

		private static readonly int HasTentaclesParam;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private LocalizationParamsManager _waveTextParamManager;

		[field: SerializeField]
		public SkeletonGraphic SkeletonGraphic { get; private set; }

		private static string GetSkinName(CampaignDifficultyMode mode)
		{
			return null;
		}

		public void Init(CampaignDifficultyMode mode, int wave, in Color color, BagType bagType)
		{
		}
	}
}
