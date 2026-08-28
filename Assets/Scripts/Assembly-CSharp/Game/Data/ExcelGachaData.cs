using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelGachaData
	{
		public int Chest_ID;

		public int Chest_Type;

		public string Chest_Name;

		public string Chest_Description;

		public string Pity_Description_1;

		public int Pity_Attempt_1;

		public int Pity_Eqm_GroupID_1;

		public string Pity_Description_2;

		public int Pity_Attempt_2;

		public int Pity_Eqm_GroupID_2;

		public int Free_Purchase_Cooldown;

		public int Ads_Purchase_Per_Day;

		public string Key_Cost;

		public string Currency_Cost;

		public string Currency_Cost_2;

		public string Banner;

		public long StartTime;

		public long EndTime;

		public int Loop_Days;

		public int NoPityPoolAttempt_1;

		public int NoPityPoolAttempt_2;

		public string TrackingName;

		public string Gacha_Button_Icon;
	}
}
