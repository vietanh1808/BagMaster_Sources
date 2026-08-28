using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelSevenDaysBundleProgressData
	{
		public int Event_ID;

		public int Level;

		public int Currency_ID;

		public int Quantity;

		public string Rewards;

		public bool IsShown;
	}
}
