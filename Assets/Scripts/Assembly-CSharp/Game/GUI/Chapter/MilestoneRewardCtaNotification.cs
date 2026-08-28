using Game.Combat;
using I2.Loc;
using UnityEngine;

namespace Game.GUI.Chapter
{
	public class MilestoneRewardCtaNotification : MonoBehaviour
	{
		[SerializeField]
		private CampaignDifficultySelector _campaignSelector;

		[SerializeField]
		private GameObject _notification;

		[Header("Texts")]
		[SerializeField]
		private GameObject _claimable;

		[SerializeField]
		private GameObject _otherwise;

		[SerializeField]
		private LocalizationParamsManager _inProgressParamsManager;

		private static bool HasAnyUnclaimedReward => false;

		private void OnEnable()
		{
		}

		private void OnCampaignMilestoneRewardClaimed(CampaignDifficultyMode arg1, int arg2)
		{
		}

		private void OnSelectedModeChange(CampaignDifficultyMode arg0)
		{
		}

		private void UpdateUi()
		{
		}

		private void UpdateProgressText(Campaign campaign, LevelData level)
		{
		}

		private void OnDisable()
		{
		}
	}
}
