namespace Game.Data
{
	public class DailyGiftData
	{
		public int Id;

		public int GroupId;

		public int Order;

		public int UnlockAtChapter;

		public int AdsRequire;

		public int MaxPerDay;

		public RewardPack Rewards;

		public bool IsUnlocked()
		{
			return false;
		}

		public bool IsFree()
		{
			return false;
		}
	}
}
