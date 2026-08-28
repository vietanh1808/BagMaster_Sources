using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelEventDungeonData
	{
		public int Dungeon_ID;

		public int Dungeon_Type;

		public int Unlock_Chapter_ID;

		public string Display_Name;

		public int Dungeon_Level;

		public int Dungeon_Level_ID;

		public int Reward_ID;

		public string Buff_Description;

		public string Bag_ID;

		public string InGameBackground;

		public string First_Loot_Reward;

		public string LocalizedDisplayName => null;

		public string LocalizedBuffDescription => null;
	}
}
