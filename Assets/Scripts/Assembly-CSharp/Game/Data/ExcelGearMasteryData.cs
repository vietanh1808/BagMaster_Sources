using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelGearMasteryData
	{
		public int Gear_Group_ID;

		public int Level;

		public int Mastery_Milestone;

		public int[] BUFF;

		public int[] CUR;
	}
}
