using System;
using System.Collections.Generic;
using Game.Arena;

namespace Game
{
	[Serializable]
	public class PlayerInfoArena
	{
		public long ArenaTicketRefreshTime;

		public long ChampionTicketRefreshTime;

		public List<ArenaVendorPurchased> ArenaTicketVendorPurchased;

		public List<ArenaVendorPurchased> ChampionTicketVendorPurchased;

		public ArenaUpScoreData ArenaUpScoreData;

		public ArenaCharacterData ArenaCharacterData;

		public ArenaLeaderboardData ArenaLeaderboardData;

		public int TotalTicketCanPurchase;

		public List<int> OpponentList;

		public bool HasJoinSeason;

		public long LastTimeRefreshOpponentList;

		public long LastLoginTime;

		public int SeasonIndex;

		public long SeasonEndTime;

		public long SeasonStartTime;
	}
}
