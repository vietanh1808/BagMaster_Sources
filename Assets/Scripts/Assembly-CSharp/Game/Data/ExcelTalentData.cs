using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelTalentData
	{
		public int ID;

		public int Order;

		public int RequireLevel;

		public int[] CUR;

		public float[] STAT;

		public int SkillId;

		public string Name;

		public string Description;

		public string Icon;

		public int Type;

		public string TrackingName;
	}
}
