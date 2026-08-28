using Game.Combat;

namespace Game
{
	public static class CombatSaveDataExtensions
	{
		public static bool TryGetCampaign(this CombatSaveData saveData, out Campaign campaign)
		{
			campaign = null;
			return false;
		}

		public static string GetSaveInfoText(this CombatSaveData saveData)
		{
			return null;
		}

		public static string GetSaveInfoText(this CombatSaveData saveData, Campaign campaign)
		{
			return null;
		}

		public static void SetCampaignFromSave(this CombatSaveData saveData)
		{
		}

		public static void SetCampaignFromSave(this CombatSaveData saveData, Campaign campaign)
		{
		}
	}
}
