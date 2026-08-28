using System;
using System.Collections.Generic;

namespace Game.Shop
{
	public class GachaData
	{
		public int ChestId;

		public ChestType Type;

		public string ChestName;

		public string ChestDescription;

		public List<ItemData> CommonPool;

		public List<PityData> Pities;

		public float FreePurchaseCooldown;

		public int AdsPurchasePerDay;

		public ResourceRequireData[] Costs;

		public string Banner;

		public DateTime StartTime;

		public DateTime EndTime;

		public int LoopInDay;

		public int NoPityPoolAttempt_1;

		public int NoPityPoolAttempt_2;

		public string TrackingName;

		public string GachaButtonIcon;

		public string LocalizedChestName => null;

		public string LocalizedChestDescription => null;

		public bool HasFree()
		{
			return false;
		}

		public bool HasKey()
		{
			return false;
		}

		public int GetDrawCount()
		{
			return 0;
		}

		public int GetNoPityPoolWindow(int tierIndex)
		{
			return 0;
		}

		public void IncreaseDrawCount()
		{
		}

		public bool InTime()
		{
			return false;
		}

		public bool TrueNotification()
		{
			return false;
		}

		public string GetPlacement()
		{
			return null;
		}
	}
}
