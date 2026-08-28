using System;
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using Game.Combat;
using TMPro;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearUIMasteryCheckPoint : EnhancedScrollerCellView
	{
		[SerializeField]
		private TextMeshProUGUI _requirePointText;

		[SerializeField]
		private GameObject _completed;

		[SerializeField]
		private GameObject _locked;

		[SerializeField]
		private ResourceView _rewardResourceView;

		[SerializeField]
		private SupportSkillSlot _rewardBuffView;

		public Action OnRefreshRequested;

		public void UpdateInfo(int point, bool completed, bool rewardLocked)
		{
		}

		public void SetBuffReward(List<int> rewardBuffIds)
		{
		}

		public void SetResourceReward(RewardPack reward)
		{
		}

		public void NoRewards()
		{
		}

		public override void RefreshCellView()
		{
		}
	}
}
