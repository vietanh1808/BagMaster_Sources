using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelExpMilestoneData : IEquatable<ExcelExpMilestoneData>
	{
		public int GroupID;

		public int Level;

		public int RequiredExp;

		public int BuffPoolID;

		public bool Equals(ExcelExpMilestoneData other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
