using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelBuffData
	{
		public int ID;

		public string Skill_ID;

		public string Asset;

		public string Name;

		public string Description;

		public int Buy_gold;

		public int Weight;

		public int Group_ID;

		public string Rarity;

		public string SelectedSfx;

		public int Display_Order;

		public string Display_On_Acquired;

		[Obsolete("Use Campaign_ID_Unlock")]
		public int Level_ID_Unlock;

		public int Campaign_ID_Unlock;

		public float DpsMod;

		public string BuffGearTags;

		public string SynergyText;

		public bool InCampaign;

		public bool InDungeon;
	}
}
