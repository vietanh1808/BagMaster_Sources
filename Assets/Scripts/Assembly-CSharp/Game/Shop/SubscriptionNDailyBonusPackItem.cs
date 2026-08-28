using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public abstract class SubscriptionNDailyBonusPackItem : MonoBehaviour
	{
		[SerializeField]
		protected SubscriptionPackItem _subscriptionItem;

		[Header("Daily Rewards")]
		[SerializeField]
		private Button _dailyClaimButton;

		[SerializeField]
		private Button _claimedButton;

		[SerializeField]
		private List<ResourceView> _dailyRewards;

		[SerializeField]
		private bool _hideClaimedButton;

		[SerializeField]
		private Color _normalRewardAmountTextColor;

		[SerializeField]
		private Color _greatThan1DayRewardAmountTextColor;

		private ShopPackData _subscriptionPackData;

		private int _dailyRewardDayPassed;

		private PlayerInfo PInfo => null;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnSubscribed(int id, TimeSpan newDuration)
		{
		}

		private void AssignEvents()
		{
		}

		protected virtual void LoadPackDatas()
		{
		}

		public abstract int GetPackId();

		public abstract string GetDailyRewardPlacement();

		private void GenerateDailyRewards()
		{
		}

		protected virtual void UpdateDailyClaimButtons()
		{
		}

		public void MarkDailyRewardsClaimed(bool isClaimed)
		{
		}

		private RewardPack GetDailyReward()
		{
			return null;
		}

		private void SetRewardAmountTextColor(Color color)
		{
		}
	}
}
