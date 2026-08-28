using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelRewardBundleData
	{
		public int Id;

		public string Icon;

		public string Name;

		public string Desc;

		public string Rarity;

		public string ClaimLogic;

		public string[] REWARD;

		public float[] WEIGHT;
	}
}
