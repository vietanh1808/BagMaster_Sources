using Game.Constant;

namespace Game
{
	public readonly struct CloudSaveConfig
	{
		public readonly bool IsEnabled;

		public readonly int UnlockCampaignId;

		public readonly Rarity MinimumSavableGachaRarity;

		public CloudSaveConfig(bool isEnabled, int unlockCampaignId, Rarity minimumSavableGachaRarity)
		{
			IsEnabled = false;
			UnlockCampaignId = 0;
			MinimumSavableGachaRarity = Rarity.Common;
		}
	}
}
