using System;

namespace Game.Combat
{
	public struct ExpMilestoneData : IComparable<ExpMilestoneData>, IEquatable<ExpMilestoneData>
	{
		public int RequiredExp;

		public int Level;

		public BuffPool BuffPool;

		public readonly int CompareTo(ExpMilestoneData other)
		{
			return 0;
		}

		public readonly bool Equals(ExpMilestoneData other)
		{
			return false;
		}

		public override readonly bool Equals(object obj)
		{
			return false;
		}

		public override readonly int GetHashCode()
		{
			return 0;
		}
	}
}
