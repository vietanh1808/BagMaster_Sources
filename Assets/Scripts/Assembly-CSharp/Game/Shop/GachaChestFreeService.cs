using System;

namespace Game.Shop
{
	public class GachaChestFreeService
	{
		private readonly PlayerInfo _playerInfo;

		private readonly GachaChestService _gachaService;

		private readonly int _id;

		private readonly float _cooldownInHours;

		public GachaChestFreeService(PlayerInfo playerInfo, GachaChestService gachaService, int id, float cooldownInHours)
		{
		}

		public bool HasFreeDrawAvailable()
		{
			return false;
		}

		public TimeSpan GetNextFreeDrawTime()
		{
			return default;
		}

		public void Draw()
		{
		}

		private DateTime GetLastFreeDrawTime()
		{
			return default;
		}
	}
}
