using Game;

namespace BattlePass.Share
{
	public static class BattlePassTracking
	{
		public const string TrackTypeFree = "free";

		public const string TrackTypePremium = "premium";

		public const string TrackTypeLuxury = "luxury";

		public const string TrackTypeAdvanced = "advanced";

		public const string TrackTypeExtra = "extra";

		private const string EventAvailable = "season_pass_available";

		private const string EventLevelUp = "season_pass_level_up";

		private const string EventRewardClaimed = "season_pass_reward_claimed";

		private const string EventPurchased = "season_pass_purchased";

		private const string EventFinished = "season_pass_finished";

		private const string KeyType = "type";

		private const string KeySpend = "spend";

		private const string KeyTrackType = "track_type";

		private const string KeyRewardType = "reward_type";

		private const string KeyAmount = "amount";

		public static void TrackBattlePassAvailable(string passName, int passIndex)
		{
		}

		public static void TrackBattlePassLevelUp(string passName, int passIndex, int levelReached, string type, int spend, string trackType)
		{
		}

		public static void TrackBattlePassRewardClaimed(string passName, int passIndex, int passLevel, int activePlaytime, string[] rewardTypes, int[] amounts, string trackType)
		{
		}

		public static void TrackBattlePassPurchased(string passName, int passIndex, int passLevel, string trackType)
		{
		}

		public static void TrackBattlePassFinished(string passName, int passIndex, int passLevel, string[] trackTypes)
		{
		}

		public static void TrackBattlePassRewardClaimed(string passName, int passIndex, int passLevel, int activePlaytime, RewardPack pack, string trackType)
		{
		}
	}
}
