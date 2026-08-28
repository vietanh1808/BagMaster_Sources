using System;

namespace Game.Arena
{
	[Serializable]
	public struct ArenaUpScoreData
	{
		public int firstRank;

		public int secondRank;

		public bool changed;
	}
}
