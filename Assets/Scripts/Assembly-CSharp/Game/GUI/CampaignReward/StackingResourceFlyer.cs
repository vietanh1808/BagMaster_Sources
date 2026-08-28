using System.Collections.Generic;
using UnityEngine;

namespace Game.GUI.CampaignReward
{
	public class StackingResourceFlyer : MonoBehaviour
	{
		[SerializeField]
		private FlyToBarProfile _flyToBarProfile;

		private readonly List<ResourceRewardData> _rewards;

		public void Stack(RewardPack rewardPack)
		{
		}

		public void Stack(ResourceRewardData reward)
		{
		}

		public void TriggerResourceFlying(in Vector3 startPosition)
		{
		}
	}
}
