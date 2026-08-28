using System.Collections.Generic;
using R3;

namespace Game.Shop
{
	public class ShopPackData
	{
		public bool IsActive;

		public int Id;

		public int GroupId;

		public string Name;

		public string Description;

		public string IconName;

		public string Banner;

		public ShopCategory Category;

		public int PurchaseMax;

		public int PurchaseMaxInDay;

		public List<ResourceRequireData> IngameCurrencyCost;

		public RewardPack RewardPack;

		public int GachaChestId;

		public RefreshType RefreshType;

		public string FakeMultipeValue;

		public int AdsPurchasePerDay;

		public int FreePurchasePerDay;

		public int UnlockAtChapter;

		public PackType PackType;

		public bool IsIap;

		public string IapProductId;

		public int DurationInDays;

		public RewardPack DailyBonus;

		public int[] SubscriptionIds;

		public Subject<ShopPackData> OnClaimed;

		public string NameLocalized => null;

		public string DescriptionLocalized => null;

		public string FakeMultipleValueLocalized => null;

		public int PurchaseCount => 0;

		public int SubscriptionId => 0;

		private PlayerInfo PInfo => null;

		private bool IsRealPurchase => false;

		public void ResetPurchaseCount()
		{
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public bool IsPurchasedMax()
		{
			return false;
		}

		public bool IsPurchasedMaxInDay()
		{
			return false;
		}

		public bool CanPurchasedToday()
		{
			return false;
		}

		public bool HasFreeClaimable()
		{
			return false;
		}

		public void Claim()
		{
		}

		public void ClaimNoReward()
		{
		}

		public void Subscribe()
		{
		}

		public int GetClaimedCountThisDay()
		{
			return 0;
		}

		public void CheckResetClaimCountNextDay()
		{
		}

		public string GetPlacement()
		{
			return null;
		}
	}
}
