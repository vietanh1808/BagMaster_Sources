using System;
using System.Collections.Generic;
using Game.AFKRewardSystem;
using R3;
using UnityEngine;

namespace Game
{
	public class AFKRewardManager : Singleton<AFKRewardManager>
	{
		[Header("Configuration")]
		[SerializeField]
		private float _tickDurationInMinute;

		[SerializeField]
		private float _miniumClaimTimeInMinute;

		private PlayerInfo PInfo => null;

		public PatrolData CurrentPatrolData { get; private set; }

		public Subject<int> OnRewardChanged { get; private set; }

		protected override void OnAwake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Initialize()
		{
		}

		private void OnChapterProgressChanged(int value)
		{
		}

		public TimeSpan GetAFKTime()
		{
			return default;
		}

		public float GetGoldPerHour()
		{
			return 0f;
		}

		private int NewRewardCount()
		{
			return 0;
		}

		public void CalculateReward(int rewardCount)
		{
		}

		public void CalculateReward(int tickCount, Action<int, int> addRewardCallback)
		{
		}

		private void LoadCurrentPatrolData()
		{
		}

		public TimeSpan GetTimeToClaimReward()
		{
			return default;
		}

		public TimeSpan GetMaxAfkDuration()
		{
			return default;
		}

		private DateTime GetTimeNow()
		{
			return default;
		}

		public bool IsMaxDurationNow()
		{
			return false;
		}

		public bool ShouldClaimAFK()
		{
			return false;
		}

		public void ClaimReward()
		{
		}

		public void ClaimQuickAFKRewardByEnergy()
		{
		}

		public void ClaimQuickAFKRewardByAds()
		{
		}

		private void ClaimRewards(IReadOnlyCollection<ResourceRewardDataRef> rewardRefs, string placement)
		{
		}

		private void ClaimQuickAFKRewards()
		{
		}
	}
}
