using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelChestData
	{
		public int ID;

		public string Asset;

		public int Common_rate;

		public int Uncommon_rate;

		public int Rare_rate;

		public float Lucky_rate;

		public int Ads_Common_rate;

		public int Ads_Uncommon_rate;

		public int Ads_Rare_rate;
	}
}
