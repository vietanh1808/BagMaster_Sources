using System;

namespace Game.EquipmentSystem
{
	[Serializable]
	public class UnlockInfo
	{
		public HowToUnlock How;

		public int NumberAdsRequire;

		public string IAPId;
	}
}
