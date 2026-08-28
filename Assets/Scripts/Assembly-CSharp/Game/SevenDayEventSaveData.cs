using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class SevenDayEventSaveData
	{
		public int EventId;

		public long UnlockedTime;

		public int ProgressQuestClaimedLevel;

		public int ProgressBundleClaimedLevel;

		public int CurrentLoopIndex;

		public long CurrentLoopStartTime;

		public List<int> ClaimedBundleIdsInLoop;

		public bool LoopPopupPending;

		public bool ExpiredMailSent;

		public bool QuestAvailableEventFired;

		public int QuestAvailableTime;

		public List<SevenDayQuestDoneRecord> QuestDoneRecordsInLoop;

		public bool AreAllQuestCompleteEventFired;

		public List<SevenDayChestAvailableRecord> QuestChestAvailable;
	}
}
