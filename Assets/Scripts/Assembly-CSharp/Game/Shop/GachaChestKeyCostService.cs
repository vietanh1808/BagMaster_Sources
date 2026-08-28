namespace Game.Shop
{
	public class GachaChestKeyCostService : IGachaCostService
	{
		private readonly PlayerInfo _playerInfo;

		private readonly GachaChestService _gachaService;

		private readonly int _resourceId;

		private readonly int _maxDrawCount;

		private readonly OwnedResourceEntity _ownedResource;

		public GachaChestKeyCostService(PlayerInfo playerInfo, GachaChestService gachaService, int resourceId, int maxDrawCount)
		{
		}

		public bool IsEnough()
		{
			return false;
		}

		public int GetRequiredAmount()
		{
			return 0;
		}

		public int GetOwnedAmount()
		{
			return 0;
		}

		public void Draw()
		{
		}
	}
}
