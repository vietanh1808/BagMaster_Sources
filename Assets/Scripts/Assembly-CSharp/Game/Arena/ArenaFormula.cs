using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Game.Arena
{
	public static class ArenaFormula
	{
		[CompilerGenerated]
		private static Action m_OnNewSeason;

		public const int PLAYER_USER_ID = 1;

		private const int UPDATE_BOT_POINT_AT_START_TIME_INTERVAL_IN_SECOND = 86400;

		private const int UPDATE_BOT_POINT_INTERVAL_IN_SECOND = 86400;

		private const int REFRESH_OPPONENT_LIST_INTERVAL_IN_SECOND = 1800;

		private const int DELTA_POINT_FIND_OPPONENT = 300;

		private const int MAX_OPPONENT = 5;

		private const int DEFAULT_POINT_AT_JOIN_SEASON = 1000;

		private const RankType DEFAULT_RANK_TYPE_AT_JOIN_SEASON = RankType.Bronze;

		private const int MAIL_DAILY_REWARD_KEY = 100000000;

		private const int MAIL_SEASON_REWARD_KEY = 50000000;

		private static bool hasCallJoinSeason;

		private static Dictionary<int, PlayerInfo> allBot;

		private static List<int> listOpponentsTemp;

		private static bool triggerLoadOpponentAtSession;

		public static int MAX_TICKET_BUY_IN_DAY => 0;

		public static DateTime Now => default;

		public static event Action OnNewSeason
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static int[] GetArenaTicketsStepPrice()
		{
			return null;
		}

		public static void UpdateLeaderboard()
		{
		}

		public static void UpdateArenaBattleResult(int opponentUserId, bool isPlayerWin)
		{
		}

		public static bool FindBotInfo(int userId, out PlayerInfo botInfo)
		{
			botInfo = null;
			return false;
		}

		public static string FindBotName(int userId)
		{
			return null;
		}

		public static bool FindCharacterInfo(int userId, out PlayerInfo characterInfo)
		{
			characterInfo = null;
			return false;
		}

		public static void TriggerStartBattleWith(int userId)
		{
		}

		public static void TriggerRefreshOpponentListByUser()
		{
		}

		public static long GetDurationCanRefreshOpponentList()
		{
			return 0L;
		}

		public static void RefreshTimeVendorShop(ArenaSubTabType subTabType)
		{
		}

		public static bool GetCharacterArenaPoint(int userId, out int arenaPoint)
		{
			arenaPoint = default;
			return false;
		}

		public static bool GetCharacterArenaName(int userId, out string arenaName)
		{
			arenaName = null;
			return false;
		}

		public static List<int> FindOpponents(bool forceRefresh)
		{
			return null;
		}

		public static int CalculatePower(PlayerInfo playerInfo)
		{
			return 0;
		}

		public static int CalculatePower(List<Stat> stats, bool includeGearValue = false)
		{
			return 0;
		}

		public static void JoinSeason()
		{
		}

		public static void TriggerSendSeasonRewards()
		{
		}

		public static void LoginAndSendDailyRewards()
		{
		}

		private static void UpdatePointWithInterval(DateTime now, bool beforeSendReward = false)
		{
		}

		private static void CreateBotInfoRuntime()
		{
		}

		public static long GetSeasonDuration()
		{
			return 0L;
		}

		public static long GetSeasonDurationIgnoreJoined()
		{
			return 0L;
		}

		private static void CreateSeason(DateTime now)
		{
		}

		private static void CreateBotData(DateTime now, DateTime startTime)
		{
		}

		private static void CreatePlayerData(int season)
		{
		}
	}
}
