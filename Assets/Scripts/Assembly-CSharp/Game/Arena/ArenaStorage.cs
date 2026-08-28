using System;
using System.Collections.Generic;

namespace Game.Arena
{
	public static class ArenaStorage
	{
		public static int TotalTicketCanPurchase
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static List<int> OpponentList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool HasJoinSeason
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static long LastTimeRefreshOpponentList
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static void Login(DateTime current, Action<int> onNewDay)
		{
		}

		public static void SetNewScore(int firstIndex, int secondIndex)
		{
		}

		public static bool UseNewScore(out int firstIndex, out int secondIndex)
		{
			firstIndex = default;
			secondIndex = default;
			return false;
		}

		public static void SetLeaderboard(ArenaLeaderboardData leaderboardData)
		{
		}

		public static ArenaLeaderboardData GetLeaderboard()
		{
			return default;
		}

		public static void SetCurrentPlayerData(ArenaCharacterData playerData)
		{
		}

		public static ArenaCharacterData GetCurrentPlayerData()
		{
			return default;
		}

		public static string GetCurrentPlayerUserName()
		{
			return null;
		}

		public static long GetLastVendorRefreshTime(ArenaSubTabType vendorType)
		{
			return 0L;
		}

		public static void SetLastVendorRefreshTime(ArenaSubTabType vendorType, long unixTime)
		{
		}

		public static void ClearVendorItemsPurchased(ArenaSubTabType vendorType)
		{
		}

		public static List<ArenaVendorPurchased> GetVendorItemsPurchased(ArenaSubTabType vendorType)
		{
			return null;
		}

		public static void PurchaseVendorItem(ArenaSubTabType vendorType, List<ArenaVendorPurchased> list, int bundleId, int quantity)
		{
		}

		public static int GetSeasonIndex()
		{
			return 0;
		}

		public static int IncreaseSeason()
		{
			return 0;
		}

		public static long GetSeasonDuration(DateTime dateTime)
		{
			return 0L;
		}

		public static void SetSeasonStartTime(long unixTime)
		{
		}

		public static void SetSeasonEndTime(long unixTime)
		{
		}

		public static long GetSeasonEndTime()
		{
			return 0L;
		}
	}
}
