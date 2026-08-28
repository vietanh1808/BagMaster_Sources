using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelSevenDayQuestData
	{
		public int Event_ID;

		public int Campaign_ID;

		public int Quest_ID;

		public int Is_Chained;

		public string Description;

		public int Reward_Group_ID;

		public int Display_Order;

		public int Is_Limited_Time;

		public int Start_Time;

		public int End_Time;

		public int Day;
	}
}
