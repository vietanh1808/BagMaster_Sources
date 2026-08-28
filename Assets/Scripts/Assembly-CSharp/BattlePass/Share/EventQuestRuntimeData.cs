using System;

namespace BattlePass.Share
{
	[Serializable]
	public class EventQuestRuntimeData
	{
		public int questId;

		public int beginProgress;

		public bool isInitialized;

		public int target;
	}
}
