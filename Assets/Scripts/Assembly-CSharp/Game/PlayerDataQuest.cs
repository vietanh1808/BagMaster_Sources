using System;
using System.Collections.Generic;

namespace Game
{
	[Serializable]
	public class PlayerDataQuest
	{
		public List<PlayerDataQuestProgress> Quests;

		public long LatestDailyQuestCheckinTime;
	}
}
