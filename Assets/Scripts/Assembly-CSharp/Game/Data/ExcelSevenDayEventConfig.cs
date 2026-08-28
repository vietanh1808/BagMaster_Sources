using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelSevenDayEventConfig
	{
		public int Event_ID;

		public string Name;

		public string Header;

		public string Description;

		public string Icon;

		public int Duration;

		public int Appear_Order;

		public int Chapter_Unlock;

		public int Login_Day_Unlock;

		public string Popup_Path;

		public string Intro_Path;

		public int Loop_Interval_In_Day;

		public int Max_Loop_Count;

		public int Day_From_First_Unlock;

		public int End_Mail_ID;

		public string TrackingScreen;

		public string TrackingScreenOffer;

		public string TrackingName;
	}
}
