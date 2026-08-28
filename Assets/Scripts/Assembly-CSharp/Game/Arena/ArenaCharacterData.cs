using System;

namespace Game.Arena
{
	[Serializable]
	public struct ArenaCharacterData
	{
		public int season;

		public int userId;

		public string userName;

		public int point;

		public int index;

		public RankType rank;

		public int totalWin;

		public int totalLose;

		public bool IsValid()
		{
			return false;
		}
	}
}
