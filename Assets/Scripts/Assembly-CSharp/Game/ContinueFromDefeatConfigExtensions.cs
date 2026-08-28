using Game.Combat;

namespace Game
{
	public static class ContinueFromDefeatConfigExtensions
	{
		private static ref readonly ContinueFromDefeatConfig Config
		{
			get
			{
				throw null;
			}
		}

		public static Campaign GetUnlockedCampaign(this in ContinueFromDefeatConfig config)
		{
			return null;
		}

		public static bool IsUnlocked(this in ContinueFromDefeatConfig config)
		{
			return false;
		}

		public static bool CanContinueFromDefeat(this Campaign campaign)
		{
			return false;
		}

		public static bool CanContinueFromDefeat(this in ContinueFromDefeatConfig config, Campaign campaign)
		{
			return false;
		}

		public static bool ShouldSaveDefeatData(this in ContinueFromDefeatConfig config)
		{
			return false;
		}

		public static bool ShouldSaveDefeatData(this in ContinueFromDefeatConfig config, Campaign campaign, int levelIndex)
		{
			return false;
		}
	}
}
