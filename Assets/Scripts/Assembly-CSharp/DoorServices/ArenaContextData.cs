using System;
using System.Collections.Generic;

namespace DoorServices
{
	[Serializable]
	public class ArenaContextData
	{
		public string opponent_id;

		public int opponent_power;

		public int opponent_trophies;

		public int trophies_before;

		public int win_delta;

		public int lose_delta;

		public int rounds_won;

		public int rounds_lost;

		public int trophies_after;

		public int rank_before;

		public int rank_after;

		public static ArenaContextData BuildChallenge(string opponentId, int opponentPower, int opponentTrophies, int trophiesBefore, int winDelta, int loseDelta)
		{
			return null;
		}

		public void FillResult(int roundsWon, int roundsLost, int trophiesAfter, int rankBefore, int rankAfter)
		{
		}

		public Dictionary<string, object> ToDict()
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}
	}
}
