using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelEventUnlockData
	{
		public int ID;

		public string Event_Name;

		public string Event_Type;

		public int Unlock_Chapter_ID;

		public string Unlock_Description;

		public string Icon;

		public string Reward_Description;

		public string Reward_Icon;

		public int Progress_ID;
	}
}
