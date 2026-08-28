using Game.ProgressPointSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Game.SevenDayQuest
{
	public class SevenDaysProgressItem : ProgressItem
	{
		[SerializeField]
		private Button _showRewardButton;

		public RewardBubbleView RewardBubbleView;

		protected override void Start()
		{
		}

		private void OnShowRewardButtonClicked()
		{
		}

		public void SetShowRewardClickable(bool interactable)
		{
		}
	}
}
