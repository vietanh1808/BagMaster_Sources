using System.Collections.Generic;

namespace Game
{
	public readonly struct ContinueFromDefeatConfig
	{
		public readonly int UnlockCampaignId;

		public readonly int GemCost;

		public readonly bool CanContinueWithAds;

		public readonly bool CanContinueWithGem;

		public readonly bool CanContinueAfterQuitting;

		public readonly bool SaveAfterBossWave;

		public readonly int GlobalContinueLimit;

		private readonly SortedSet<int> _saveMilestones;

		public IReadOnlyCollection<int> SaveMilestones => null;

		public ContinueFromDefeatConfig(int gemCost, int unlockCampaignId, IEnumerable<int> saveMilestones, bool canContinueWithAds, bool canContinueWithGem, bool canContinueAfterQuitting, bool saveAfterBossWave, int globalContinueLimit)
		{
			UnlockCampaignId = 0;
			GemCost = 0;
			CanContinueWithAds = false;
			CanContinueWithGem = false;
			CanContinueAfterQuitting = false;
			SaveAfterBossWave = false;
			GlobalContinueLimit = 0;
			_saveMilestones = null;
		}

		public int GetHighestMilestone(int limit)
		{
			return 0;
		}
	}
}
