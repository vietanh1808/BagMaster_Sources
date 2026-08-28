using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelCampaignData
	{
		public int ID;

		public int Index;

		public string Icon;

		public string Name;

		public int Level_ID;

		public int Reward_ID;

		public int Reduced_Reward_ID;

		public float Ads_Reward_Multiplier;

		public string InGameBackground;

		public string PlayResourceCost;

		public string Level_Type;

		public string StartGears;

		public int Ad_Gear_Reroll_Unlock;

		public int Ad_Slot_Add_Unlock;

		public int Ad_Gear_Reroll_Limit;

		public int Ad_Slot_Add_Limit;

		public string MonsterPreviewIds;

		public int Continue_From_Defeat_Limit;

		public string Mode;

		public int Unlock_Chapter_ID;

		public int ExpMilestoneGroupID;
	}
}
