using System;
using System.Collections.Generic;

namespace Game.Arena
{
	[Serializable]
	public struct ArenaLeaderboardData
	{
		public long lastUpdateUnixTime;

		public List<ArenaIndexData> leaderboard;
	}
}
