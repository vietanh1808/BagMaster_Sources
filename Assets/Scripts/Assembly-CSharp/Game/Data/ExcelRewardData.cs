using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelRewardData
	{
		public int ID;

		public string Chances;

		public string ReceivedNumber;

		public int[] Reward;

		public int Variant;
	}
}
