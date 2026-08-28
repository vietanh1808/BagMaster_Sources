using System;

namespace Game.Data
{
	[Serializable]
	public struct BattlePassBundleData
	{
		public bool Is_Luxury;

		public int Pass_ID;

		public bool Unlock_Banner;

		public string Banner;

		public string Pass_Name;

		public string Description;

		public int Buy_Shop_ID;

		public int Luxury_Buy_Shop_ID;

		public string Extra_Reward_Description;

		public string Extra_Reward_Max_Description;

		public long Start_Time;

		public long End_Time;

		public int Chapter_Unlock;

		public int Duration;

		public string TrackingName;

		public int End_Mail_ID;
	}
}
