using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public class RewardPackUI : MonoBehaviour
	{
		[Serializable]
		private class DefaultRewardItem
		{
			public int Id;

			public int Value;
		}

		[SerializeField]
		private CurrencyView _rewardItemTemplate;

		[SerializeField]
		private Transform _rewardItemParent;

		[SerializeField]
		private List<DefaultRewardItem> _defaultRewards;

		private List<GameObject> _spawnedItems;

		private RewardPack _rewardPack;

		public RewardPack RewardPack => null;

		private void Start()
		{
		}

		public void UpdateInfo(int rewardId)
		{
		}

		public void UpdateInfo(RewardPack rewardPack)
		{
		}
	}
}
