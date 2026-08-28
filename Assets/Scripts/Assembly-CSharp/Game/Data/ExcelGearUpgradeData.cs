using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelGearUpgradeData
	{
		public int ID;

		public int Level;

		public int Card_ID;

		public int Card_Value;

		public int[] CUR;

		public float[] STAT;
	}
}
