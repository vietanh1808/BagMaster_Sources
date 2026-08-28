namespace Game.Shop
{
	public class GachaChestPityService
	{
		private readonly PlayerInfo _playerInfo;

		private readonly GachaData _gachaData;

		private readonly PityData _pityData;

		public GachaChestPityService(PlayerInfo playerInfo, GachaData gachaData, PityData pityData)
		{
		}

		public bool IsPityAchieved()
		{
			return false;
		}

		public ItemData GetPityReward()
		{
			return null;
		}

		public void ResetPityCount()
		{
		}

		public void IncrementPityCount()
		{
		}

		public int GetRemainAttempt()
		{
			return 0;
		}

		public int GetCurrentCount()
		{
			return 0;
		}

		public bool InPool(ItemData item)
		{
			return false;
		}

		private int GetPityCount()
		{
			return 0;
		}
	}
}
