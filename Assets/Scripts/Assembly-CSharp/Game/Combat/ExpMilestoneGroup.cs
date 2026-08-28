using System.Collections;
using System.Collections.Generic;

namespace Game.Combat
{
	public class ExpMilestoneGroup : IReadOnlyList<ExpMilestoneData>, IEnumerable<ExpMilestoneData>, IEnumerable, IReadOnlyCollection<ExpMilestoneData>
	{
		public static readonly ExpMilestoneGroup Empty;

		public readonly int Id;

		private readonly ExpMilestoneData[] _levels;

		private readonly int[] _totalExpByLevels;

		public int Count => 0;

		public ExpMilestoneData this[int index] => default;

		private static int[] GetTotalExpByLevels(ExpMilestoneData[] levels)
		{
			return null;
		}

		public ExpMilestoneGroup(int id, IEnumerable<ExpMilestoneData> levels)
		{
		}

		public int GetTotalExp(int milestone)
		{
			return 0;
		}

		public IEnumerator<ExpMilestoneData> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
