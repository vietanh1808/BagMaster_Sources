using System;

namespace Game
{
	[Serializable]
	public class PlayerDataQuestProgress
	{
		public int QuestId;

		public int CurrentProgress;

		public long LatestCompletedTime;

		public int CompletedCount;
	}
}
