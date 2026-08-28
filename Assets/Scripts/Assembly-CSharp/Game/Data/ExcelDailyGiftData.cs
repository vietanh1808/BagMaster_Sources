using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelDailyGiftData
	{
		public int Id;

		public int GroupId;

		public int Order;

		public int UnlockAtChapter;

		public int AdsRequire;

		public int MaxPerDay;

		public string Rewards;
	}
}
