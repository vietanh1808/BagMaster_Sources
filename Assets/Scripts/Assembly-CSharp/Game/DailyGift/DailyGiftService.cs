using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.Data;

namespace Game.DailyGift
{
	public class DailyGiftService
	{
		[CompilerGenerated]
		private Action<DailyGiftData> m_OnClaimedEvent;

		[CompilerGenerated]
		private Action<DailyGiftData, bool> m_OnWatchAdsSuccessEvent;

		private List<DailyGiftData> _currentDailyGifts;

		private PlayerInfo PInfo => null;

		public event Action<DailyGiftData> OnClaimedEvent
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

		public event Action<DailyGiftData, bool> OnWatchAdsSuccessEvent
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

		public void UpdateNRefresh()
		{
		}

		public IReadOnlyCollection<DailyGiftDisplayData> GetDailyGiftDisplayDatas()
		{
			return null;
		}

		public DailyGiftDisplayData GetDailyGiftDisplayData(int id, bool locked)
		{
			return null;
		}

		private int GetTotalAdsProgress()
		{
			return 0;
		}

		private int GetCumulativeAdsRequire(int giftId)
		{
			return 0;
		}

		public void WatchAds(DailyGiftData giftData)
		{
		}

		private void IncreaseProgressNClaim(DailyGiftData giftData)
		{
		}

		private void IncreaseProgressForAllAds()
		{
		}

		public void Claim(DailyGiftData giftData)
		{
		}

		public TimeSpan GetRemainTime()
		{
			return default;
		}

		public bool AnyFreeClaimable()
		{
			return false;
		}

		private void LoadDailyGift()
		{
		}

		private void RefreshNewDailyGift()
		{
		}

		private Dictionary<int, List<DailyGiftData>> DivineDailyGiftByGroup()
		{
			return null;
		}

		private List<DailyGiftData> RandomList(Dictionary<int, List<DailyGiftData>> groups)
		{
			return null;
		}
	}
}
