using Game.ProgressPointSystem;
using Game.QuestSystem;

namespace Game.SevenDayQuest
{
	public static class SevenDaysQuestTracking
	{
		private static bool TryGetTrackingName(IDataProvider provider, out string carnivalType)
		{
			carnivalType = null;
			return false;
		}

		private static void SendQuestAvailable(IDataProvider provider, SevenDayQuestData data)
		{
		}

		private static void SendQuestDone(IDataProvider provider, SevenDayQuestData data, QuestData questData)
		{
		}

		private static void SendQuestClaimed(IDataProvider provider, SevenDayQuestData data, QuestData questData)
		{
		}

		private static void SendQuestRedirect(IDataProvider provider, SevenDayQuestData data)
		{
		}

		private static void SendAllQuestsCompleted(IDataProvider provider)
		{
		}

		private static void SendQuestChestAvailable(IDataProvider provider, ProgressData data)
		{
		}

		private static void SendQuestChestClaimed(IDataProvider provider, ProgressData data)
		{
		}

		public static void TrackQuestAvailable(IDataProvider provider)
		{
		}

		public static bool TryTrackQuestDone(IDataProvider provider, SevenDayQuestData data, QuestData questData)
		{
			return false;
		}

		public static void TrackQuestClaimed(IDataProvider provider, SevenDayQuestData data, QuestData questData)
		{
		}

		public static void TrackAllQuestsCompleted(IDataProvider provider)
		{
		}

		public static void TrackQuestChestAvailable(IDataProvider provider, int previousPoint, int currentPoint)
		{
		}

		public static bool TrackQuestRedirect(IDataProvider provider, SevenDayQuestData data)
		{
			return false;
		}

		public static void TrackQuestChestClaimedRange(IDataProvider provider, int fromLevelExclusive, int toLevel)
		{
		}
	}
}
