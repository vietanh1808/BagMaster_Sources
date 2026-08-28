using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelEventDungeonUnlockData
	{
		public int Dungeon_ID;

		public int Dungeon_Type;

		public string Display_Name;

		public int Unlock_Campaign_ID;

		public string Banner;

		public string FrameInfo;

		public int Ticket_ID;

		public int Daily_Free_Ticket;

		public int Rebuy_Ads;

		public int Rebuy_Currency;

		public string Rebuy_value;

		public string Reward_Description;

		public int Display_Order;

		public bool Can_Sweep;

		public string List_Item_Prefab;

		public string Category;

		public string Category_Name;

		public string LocalizedDisplayName => null;

		public string LocalizedCategoryName => null;
	}
}
