using UnityEngine;

namespace Game.GUI.CampaignReward
{
	public class CampaignRewardUnlockToaster : MonoBehaviour
	{
		private const string UnlockChapterKey = "MAIN/Title_ChapterReward_UnlockChapter";

		[SerializeField]
		private CampaignDifficultyMode _mode;

		public void Toast()
		{
		}

		public void Toast(CampaignDifficultyMode mode)
		{
		}

		private static string GetMessage(CampaignDifficultyMode mode)
		{
			return null;
		}
	}
}
