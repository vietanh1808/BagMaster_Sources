namespace Game.GUI.Chapter
{
	public class CampaignDifficultyButton : StandardGameButton
	{
		private static bool IsUnlockedAndHasNewCampaign(CampaignDifficultyMode campaignMode)
		{
			return false;
		}

		public void Init(CampaignDifficultyMode mode, in CampaignDifficultyModeSetting setting)
		{
		}

		private void SetNotification(CampaignDifficultyMode mode)
		{
		}
	}
}
