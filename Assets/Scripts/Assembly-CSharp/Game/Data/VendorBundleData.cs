using System;

namespace Game.Data
{
	[Serializable]
	public struct VendorBundleData
	{
		public int BundleID;

		public int BundleGroupID;

		public int ShopID;

		public string UIPrefab;

		public int Limit;
	}
}
