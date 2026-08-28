using System;

namespace Game.Data
{
	[Serializable]
	public struct VendorTabData
	{
		public int VendorID;

		public string VendorSubTab;

		public int VendorCurrencyShown;

		public int VendorItemGroupID;

		public int UnlockCampaignId;

		public int RefreshTime;

		public string Banner;

		public string VendorSubTabLocalizationKey;
	}
}
