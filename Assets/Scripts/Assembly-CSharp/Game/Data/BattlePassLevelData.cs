using System;

namespace Game.Data
{
	[Serializable]
	public struct BattlePassLevelData
	{
		public int Pass_ID;

		public int Pass_Level;

		public int BP_Count;

		public bool Is_Extra;

		public string Level_Price;

		public int Free_Reward_ID;

		public int Premium_Reward_ID;

		public int Luxury_Reward_ID;

		public int Extra_Reward_ID;

		public int CurrencyTypePurchaseLevel;

		public int CurrencyValuePurchaseLevel;

		public void CachePurchaseValue()
		{
		}
	}
}
