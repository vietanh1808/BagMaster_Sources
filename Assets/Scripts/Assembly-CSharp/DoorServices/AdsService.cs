using System;
using System.Runtime.CompilerServices;

namespace DoorServices
{
	public class AdsService
	{
		public const string PLACEMENT_RW_DEFAULT = "default";

		public const string PLACEMENT_RW_QUICK_MINE = "quick_mine";

		public const string PLACEMENT_RW_GAMEPLAY_REVIVE = "gameplay_revive";

		public const string PLACEMENT_RW_GAMEPLAY_BUFF_REROLL = "gameplay_buff_reroll";

		public const string PLACEMENT_RW_GAMEPLAY_BUFF_TAKEALL = "gameplay_buff_takeall";

		public const string PLACEMENT_RW_GAMEPLAY_RESULT_REWARD = "gameplay_result_reward";

		public const string PLACEMENT_RW_MORE_ENERGY = "more_energy";

		public const string PLACEMENT_RW_SHOP_GACHA_CHEST = "shop_gacha_chest";

		public const string PLACEMENT_RW_DUNGEON_TICKET = "dungeon_ticket";

		public const string PLACEMENT_INTER_DEFAULT = "default";

		public const string PLACEMENT_INTER_GAMEPLAY_RESULT = "gameplay_result";

		public const string PLACEMENT_INTER_GAMEPLAY_PAUSE = "gameplay_pause";

		public const string PLACEMENT_RW_GAMEPLAY_SLOT_BUY = "gameplay_slot_buy";

		public const string PLACEMENT_RW_GAMEPLAY_GEAR_REROLL = "gameplay_gear_reroll";

		public const string PLACEMENT_RW_GAMEPLAY_REFILL_BENCH = "gameplay_refill_bench";

		public const string PLACEMENT_RW_GAMEPLAY_REFILL_RECYCLE = "gameplay_refill_recycle";

		public const string PLACEMENT_INTER_TUT_DAILY_LOGIN = "tut_dailylogin";

		public const string PLACEMENT_INTER_BOSS_DEATH = "gameplay_boss_death";

		public const string PLACEMENT_RW_DAILYGIFT = "dailygift";

		public const string PLACEMENT_RW_CONTINUE_DEFEAT = "continue_after_defeat";

		public const string PLACEMENT_RW_ACTIVE_SKILL_CD = "active_skill_CD";

		public const string PLACEMENT_RW_BLACKMARKET_REFRESH = "black_market_refresh";

		[CompilerGenerated]
		private static Action m_OnBannerShown;

		[CompilerGenerated]
		private static Action m_OnBannerHidden;

		public static event Action OnBannerShown
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

		public static event Action OnBannerHidden
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

		public static void ShowRewardAds(Action rewardedCallback, Action<bool> closedCallback, string placement = "default")
		{
		}

		public static bool IsRewardAdsAvailable(string placement)
		{
			return false;
		}

		public static void ShowInterAds(Action closeCallback, string placement = "default")
		{
		}

		public static bool IsInterAdsAvailable(string placement)
		{
			return false;
		}

		public static int GetInterAdsStartLevel()
		{
			return 0;
		}

		public static int GetInterAdsAfterBossStartLevel()
		{
			return 0;
		}

		public static int GetBannerAdsStartLevel()
		{
			return 0;
		}

		public static void CheckRemoteConfigThenShowBanner()
		{
		}

		public static bool ShouldShowBanner()
		{
			return false;
		}

		public static void ShowBanner()
		{
		}

		public static void HideBanner()
		{
		}

		public static void OnSdkBannerDisplayStarted()
		{
		}
	}
}
