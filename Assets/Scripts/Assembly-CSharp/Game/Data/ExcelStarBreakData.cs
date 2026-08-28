using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelStarBreakData
	{
		public int ID;

		public string Name;

		public int Base_Cards;

		public float UpSize_Weight_1;

		public int UpSize_1;

		public float UpSize_Weight_2;

		public int UpSize_2;

		public float UpSize_Weight_3;

		public int UpSize_3;

		public float UpSize_Weight_4;

		public int UpSize_4;

		public int Base_Shards;

		public float Crack_Chances;

		public float Fail_Weight;

		public float SizeUpgrade_Weight;

		public float TierUpgrade_Weight;

		public int Currency_ID;

		public int NextTierID;
	}
}
