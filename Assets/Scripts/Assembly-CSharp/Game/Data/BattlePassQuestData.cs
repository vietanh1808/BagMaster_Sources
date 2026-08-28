using System;

namespace Game.Data
{
	[Serializable]
	public struct BattlePassQuestData
	{
		public int Pass_ID;

		public int Quest_ID;

		public int Reward_ID;

		public string Description;

		public bool Is_Chained;

		public int Display_Order;
	}
}
