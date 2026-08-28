using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelEquipmentUpgradeData
	{
		public int ID;

		public int Level;

		public int[] CUR;

		public float[] STAT;
	}
}
