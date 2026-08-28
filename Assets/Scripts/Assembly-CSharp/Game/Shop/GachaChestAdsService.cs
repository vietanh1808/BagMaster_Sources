using System;

namespace Game.Shop
{
	public class GachaChestAdsService
	{
		private readonly PlayerInfo _playerInfo;

		private readonly GachaChestService _gachaService;

		private readonly int _id;

		private readonly int _maxPerDay;

		public string LogPlacement => null;

		public GachaChestAdsService(PlayerInfo playerInfo, GachaChestService gachaService, int id, int maxPerDay)
		{
		}

		public bool HasAdsDrawAvailable()
		{
			return false;
		}

		public int GetRemainingAdsDraws()
		{
			return 0;
		}

		public void Draw()
		{
		}

		private int GetAdsDrawCount()
		{
			return 0;
		}

		public TimeSpan GetRemainTimeUntilNextRefresh()
		{
			return default;
		}
	}
}
