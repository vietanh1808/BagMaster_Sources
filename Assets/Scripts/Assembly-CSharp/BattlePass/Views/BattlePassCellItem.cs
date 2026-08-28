using System;
using BattlePass.Share;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Game.Data;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassCellItem : MonoBehaviour
	{
		[SerializeField]
		private Button buttonFreeClaim;

		[SerializeField]
		private Button buttonPremiumClaim;

		[SerializeField]
		private EventCellRewardView freeView;

		[SerializeField]
		private EventCellRewardView premiumView;

		[SerializeField]
		private EventStageView stageView;

		[SerializeField]
		private Image blackMask;

		[SerializeField]
		private Image line;

		protected Action<(int stage, int rewardId)> OnClaimedRewardState;

		private TweenerCore<float, float, FloatOptions> tween;

		private bool premiumPurchased;

		private bool isFreeClaimed;

		private bool isPremiumClaimed;

		public RectTransform RectTransform { get; private set; }

		protected bool CanClick { get; set; }

		protected bool StageUnlocked { get; private set; }

		protected BattlePassLevelData LevelData { get; private set; }

		protected virtual void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void ReturnToPool()
		{
		}

		private void PremiumClaim()
		{
		}

		private void FreeClaim()
		{
		}

		public void ResetCallback(Action<(int stage, int rerwardId)> refreshCallback)
		{
		}

		public virtual void UpdateData(BattlePassLevelData levelData, bool premiumPurchased, bool luxuryPurchased, bool stageUnlocked, bool isFreeClaimed, bool isPremiumClaimed, bool isLuxuryClaimed)
		{
		}

		public void FillBlackMask(float from, float to, float duration)
		{
		}
	}
}
