using System;
using System.Runtime.CompilerServices;
using Game;
using UnityEngine;

namespace BattlePass.Share
{
	public class EventCellRewardView : MonoBehaviour
	{
		[SerializeField]
		private ResourceView[] resources;

		[CompilerGenerated]
		private Action m_OnItemClicked;

		private bool canUpdateReward;

		public event Action OnItemClicked
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

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void ReturnToPool()
		{
		}

		public void Init(RewardPack pack, bool premiumPurchased, bool isUnlocked, bool isClaimed)
		{
		}
	}
}
